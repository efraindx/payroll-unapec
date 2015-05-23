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
    }
}
