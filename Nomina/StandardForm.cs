using System;
using System.Windows.Forms;

namespace Nomina
{
    public abstract partial class StandardForm : Form
    {
        public void StandardForm_Load(object sender, EventArgs e)
        {
            UpdateTableAdapter();
        }

        public abstract void UpdateTableAdapter();

        public abstract void ResetInputValues();

        public abstract bool ValidateForm();

        public abstract void SaveNewItem();

        public abstract void DeleteItem(int itemID);

        public abstract void UpdateItem(int itemID, int rowIndex, int columnIndex, string newValue);

        public abstract DataGridView GetDataGrid();

        public void SaveButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                SaveNewItem();
                UpdateTableAdapter();
                ResetInputValues();
            }
        }

        public void DeleteButton_Click(object sender, EventArgs e)
        {
            //validate if any row has been selected
            if (GetDataGrid().SelectedRows.Count > 0)
            {
                int itemID = 0;
                foreach (DataGridViewRow selectedRow in GetDataGrid().SelectedRows)
                {
                    //confirm for delete item
                    var confirmResult = MessageBox.Show("Está seguro que desea eliminar el/los elementos seleccionados?", "Confirmar Eliminación", MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        //try to parse the column ID value to int
                        if (int.TryParse(selectedRow.Cells[0].Value.ToString(), out itemID))
                        {
                            DeleteItem(itemID);
                        }
                    }
                    else
                    {
                        //exit if no confirm for delete item
                        return;
                    }
                }

                MessageBox.Show("Los elementos seleccionados fueron eliminados.");
                UpdateTableAdapter();
            }
            else
            {
                MessageBox.Show("Debe seleccionar al menos una fila a eliminar.");
            }
        }

        public void DataGrid_CellParsing(object sender, DataGridViewCellParsingEventArgs e)
        {
            //validate that current row is valid
            if (e.RowIndex > -1 && !String.IsNullOrWhiteSpace(e.Value.ToString()))
            {
                int itemID;
                //get id of position and try to parse it
                if (int.TryParse(GetDataGrid().Rows[e.RowIndex].Cells[0].Value.ToString(), out itemID))
                {
                    UpdateItem(itemID, e.RowIndex, e.ColumnIndex, e.Value.ToString());
                }

                MessageBox.Show("Elemento actualizado satisfactoriamente.");
            }
        }

        //Message to show when validations error
        public void DataGrid_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Inserte valores válidos, los valores introducidos son incorrectos.");
        }
    }
}
