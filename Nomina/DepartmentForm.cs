using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nomina
{
    public partial class DepartmentForm : Form
    {
        public DepartmentForm()
        {
            InitializeComponent();
        }

        private void DepartmentForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_payroll_unapecDataSet.Departments' table. You can move, or remove it, as needed.
            updateTableAdapter();

        }

        private void updateTableAdapter()
        {
            this.departmentsTableAdapter.Fill(this._payroll_unapecDataSet.Departments);
        }

        private  void resetInputs()
        {
            departmentName.Text = "";
            departmentLocation.Text = "";
        }

        private void saveDepartment_Click(object sender, EventArgs e)
        {
            if (validateForm())
            {
                using(var dbContext = new PayrollDbContext())
                {
                    Department department = new Department();
                    department.Name = departmentName.Text;
                    department.Location = departmentLocation.Text;

                    dbContext.Departments.Add(department);
                    dbContext.SaveChanges();
                    updateTableAdapter();
                }
            }
        }

        private bool validateForm()
        {
            return validateName() && validateLocation();
        }

        private bool validateName()
        {
            bool  isValid =  !string.IsNullOrWhiteSpace(departmentName.Text);
            if (!isValid)
            {
                MessageBox.Show("Por favor verifique el nombre introducido.");
            }

            return isValid;
        }

        private bool validateLocation()
        {
            bool isValid = !string.IsNullOrWhiteSpace(departmentLocation.Text);
            if (!isValid)
            {
                MessageBox.Show("Por favor verifique la ubicación introducida.");
            }

            return isValid;
        }

        private void cancelDepartmentForm_Click(object sender, EventArgs e)
        {
            //validate if any row has been selected
            if (departmentsDataGrid.SelectedRows.Count > 0)
            {
                int departmentId = 0;
                foreach (DataGridViewRow selectedRow in departmentsDataGrid.SelectedRows)
                {
                    //confirm for delete position
                    var confirmResult = MessageBox.Show("Está seguro que desea eliminar el/los departamentos seleccionados?", "Confirmar Eliminación", MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        //try to parse the column ID value to int
                        if (int.TryParse(selectedRow.Cells[0].Value.ToString(), out departmentId))
                        {
                            using (var dbContext = new PayrollDbContext())
                            {
                                //delete selected positions
                                var currentDepartment = dbContext.Departments.Where(d => d.Id == departmentId).FirstOrDefault();
                                if (currentDepartment != null)
                                {
                                    dbContext.Departments.Remove(currentDepartment);
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

                MessageBox.Show("Los departamentos seleccionados fueron eliminados.");
                updateTableAdapter();
            }
            else
            {
                MessageBox.Show("Debe seleccionar al menos una fila a eliminar.");
            }
        }

        private void departmentsDataGrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //validate that current row is valid
            if (e.RowIndex > -1)
            {
                int departmentId;
                //get id of position and try to parse it
                if (int.TryParse(departmentsDataGrid.Rows[e.RowIndex].Cells[0].Value.ToString(), out departmentId))
                {
                    using (var dbContext = new PayrollDbContext())
                    {
                        var departmentToUpdate = dbContext.Departments.Where(d => d.Id == departmentId).FirstOrDefault();
                        if (departmentToUpdate != null)
                        {
                            //update attributes of position
                            switch (e.ColumnIndex)
                            {
                                case 1:
                                    string newName = departmentsDataGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
                                    departmentToUpdate.Name = newName;
                                    dbContext.SaveChanges();
                                    break;

                                case 2:
                                    string newLocation = departmentsDataGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
                                    departmentToUpdate.Location = newLocation;
                                    dbContext.SaveChanges();
                                    break;

                                
                            }
                        }
                    }
                }

                MessageBox.Show("Departamento actualizado satisfactoriamente.");
            }
        }
    }
}
