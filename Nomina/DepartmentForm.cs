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
    public partial class DepartmentForm : StandardForm
    {
        public DepartmentForm()
        {
            InitializeComponent();
        }

        public override void UpdateTableAdapter()
        {
            this.departmentsTableAdapter.Fill(this._payroll_unapecDataSet.Departments);
        }

        public override void ResetInputValues()
        {
            departmentName.Text = "";
            departmentLocation.Text = "";
        }

        public override void SaveNewItem()
        {
            using (var dbContext = new PayrollDbContext())
            {
                Department department = new Department();
                department.Name = departmentName.Text;
                department.Location = departmentLocation.Text;

                dbContext.Departments.Add(department);
                dbContext.SaveChanges();
            }
        }

        public override bool ValidateForm()
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

        public override void DeleteItem(int itemID)
        {
            using (var dbContext = new PayrollDbContext())
            {
                //delete selected departament
                var currentDepartment = dbContext.Departments.Where(d => d.Id == itemID).FirstOrDefault();
                if (currentDepartment != null)
                {
                    dbContext.Departments.Remove(currentDepartment);
                    dbContext.SaveChanges();
                }
            }
        }

        public override void UpdateItem(int itemID, int rowIndex, int columnIndex, string newValue)
        {
            using (var dbContext = new PayrollDbContext())
            {
                var departmentToUpdate = dbContext.Departments.Where(d => d.Id == itemID).FirstOrDefault();
                if (departmentToUpdate != null)
                {
                    //update attributes of department
                    switch (columnIndex)
                    {
                        case 1:
                            departmentToUpdate.Name = newValue;
                            dbContext.SaveChanges();
                            break;

                        case 2:
                            departmentToUpdate.Location = newValue;
                            dbContext.SaveChanges();
                            break;
                    }
                }
            }
        }

        public override DataGridView GetDataGrid()
        {
            return departmentsDataGrid;
        }
    }
}
