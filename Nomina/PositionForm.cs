using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Nomina
{
    public partial class PositionForm : Form
    {
        public PositionForm()
        {
            InitializeComponent();
        }

        private void PositionForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_payroll_unapecDataSet.Positions' table. You can move, or remove it, as needed.
            updateTableAdapter();
        }

        private void updateTableAdapter()
        {
            this.positionsTableAdapter.Fill(this._payroll_unapecDataSet.Positions);
        }

        private void savePosition_Click(object sender, EventArgs e)
        {
            if (validateForm())
            {
                using (var dbContext = new PayrollDbContext())
                {
                    Position position = new Position();
                    position.Name = positionName.Text;
                    position.RiskLevel = cmbRiesgo.SelectedItem.ToString();
                    position.MinSalary = double.Parse(positionMinSalary.Text);
                    position.MaxSalary = double.Parse(positionMaxSalary.Text);

                    dbContext.Positions.Add(position);
                    dbContext.SaveChanges();
                    updateTableAdapter();
                    setDefaultValuesToInputs();
                }
            }
        }

        //Set default values to inputs on save item
        private void setDefaultValuesToInputs()
        {
            positionName.Text = "";
            positionMinSalary.Text = "";
            positionMaxSalary.Text = "";
            cmbRiesgo.SelectedIndex = -1;
        }

        private bool validateForm()
        {
            return validateName() && validateRisk() && validateSalaries();
        }

        private bool validateName()
        {
            bool isValid = !string.IsNullOrWhiteSpace(positionName.Text);
            if (!isValid)
            {
                MessageBox.Show("Por favor valide nombre introducido.");
            }

            return isValid;
        }

        private bool validateRisk()
        {
            int selectedIndex = cmbRiesgo.SelectedIndex;
            bool isValid = selectedIndex > 0;

            if (!isValid)
            {
                MessageBox.Show("Por favor seleccione un riesgo.");
            }

            return isValid;
        }

        private bool validateSalaries()
        {
            double minSalary, maxSalary = 0;
            bool isValid = false;

            if (double.TryParse(positionMinSalary.Text, out minSalary)
                && double.TryParse(positionMaxSalary.Text, out maxSalary))
            {
                isValid = minSalary <= maxSalary;
                if (!isValid)
                {
                    MessageBox.Show("El salario mínimo no puede ser mayor que el salario máximo.");
                }
            }
            else
            {
                MessageBox.Show("Por favor valide los salarios introducidos. No se permiten letras ni signos.");
            }

            return isValid;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //validate if any row has been selected
            if (positionsDataGrid.SelectedRows.Count > 0)
            {
                int positionID = 0;
                foreach (DataGridViewRow selectedRow in positionsDataGrid.SelectedRows)
                {
                    //confirm for delete position
                    var confirmResult = MessageBox.Show("Está seguro que desea eliminar el/los puestos seleccionados?", "Confirmar Eliminación", MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        //try to parse the column ID value to int
                        if (int.TryParse(selectedRow.Cells[0].Value.ToString(), out positionID))
                        {
                            using (var dbContext = new PayrollDbContext())
                            {
                                //delete selected positions
                                var currentPosition = dbContext.Positions.Where(p => p.Id == positionID).FirstOrDefault();
                                if (currentPosition != null)
                                {
                                    dbContext.Positions.Remove(currentPosition);
                                    dbContext.SaveChanges();
                                }
                            }
                        }
                    }
                    else
                    {
                        //exit if no confirm for delete position
                        return;
                    }
                }

                MessageBox.Show("Los puestos seleccionados fueron eliminados.");
                updateTableAdapter();
            }
            else
            {
                MessageBox.Show("Debe seleccionar al menos una fila a eliminar.");
            }
        }

        private void positionsDataGrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //validate that current row is valid
            if (e.RowIndex > -1)
            {
                int positionID;
                //get id of position and try to parse it
                if (int.TryParse(positionsDataGrid.Rows[e.RowIndex].Cells[0].Value.ToString(), out positionID))
                {
                    using (var dbContext = new PayrollDbContext())
                    {
                        var positionToUpdate = dbContext.Positions.Where(p => p.Id == positionID).FirstOrDefault();
                        if (positionToUpdate != null)
                        {
                            //update attributes of position
                            switch (e.ColumnIndex)
                            {
                                case 1:
                                    string newName = positionsDataGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
                                    positionToUpdate.Name = newName;
                                    dbContext.SaveChanges();
                                    break;

                                case 2:
                                    string newRiskLevel = positionsDataGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
                                    positionToUpdate.RiskLevel = newRiskLevel;
                                    dbContext.SaveChanges();
                                    break;

                                case 3:
                                    int newMinSalaxy;
                                    if (int.TryParse(positionsDataGrid.Rows[e.RowIndex].Cells[3].Value.ToString(), out newMinSalaxy))
                                    {
                                        positionToUpdate.MinSalary = newMinSalaxy;
                                        dbContext.SaveChanges();
                                    }
                                    break;

                                case 4:
                                    int newMaxSalary;
                                    if (int.TryParse(positionsDataGrid.Rows[e.RowIndex].Cells[4].Value.ToString(), out newMaxSalary))
                                    {
                                        positionToUpdate.MaxSalary = newMaxSalary;
                                        dbContext.SaveChanges();
                                    }
                                    break;
                            }
                        }
                    }
                }
                
                MessageBox.Show("Puesto actualizado satisfactoriamente.");
            }
        }

        //Message to show when validations error
        private void positionsDataGrid_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Inserte valores válidos, los salarios deben ser números.");
        }
    }
}
