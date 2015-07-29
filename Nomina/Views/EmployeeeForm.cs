using Nomina.Persistence;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nomina.Views
{
    public partial class EmployeeeForm : StandardForm
    {
        public EmployeeeForm()
        {
            InitializeComponent();
        }

        public override void UpdateTableAdapter()
        {
            this.payrollsTableAdapter.Fill(this.all.Payrolls);
            this.departmentsTableAdapter.Fill(this.all.Departments);
            this.positionsTableAdapter.Fill(this.all.Positions);
            this.employeesTableAdapter.Fill(this.all.Employees);
        }

        public override void ResetInputValues()
        {
            employeeCedula.Text = "";
            employeeName.Text = "";
            employeeSalary.Text = "";
            employeeDepartment.SelectedIndex = -1;
            employeePosition.SelectedIndex = -1;
            employeePayroll.SelectedIndex = -1;
        }

        public override void SaveNewItem()
        {
            using (var dbContext = new PayrollDbContext())
            {
                Employee employee = new Employee();
                employee.Cedula = employeeCedula.Text;
                employee.Name = employeeName.Text;
                employee.Salary = double.Parse(employeeSalary.Text);
                employee.Position_Id = (int)employeePosition.SelectedValue;
                employee.Department_Id = (int)employeeDepartment.SelectedValue;
                employee.Payroll_Id = (int)employeePayroll.SelectedValue;
                dbContext.Employees.Add(employee);
                dbContext.SaveChanges();
            }
        }

        public override void DeleteItem(int itemID)
        {
            using (var dbContext = new PayrollDbContext())
            {
                var selectedEmployee = dbContext.Employees.Where(e => e.Id == itemID).FirstOrDefault();
                if (selectedEmployee != null)
                {
                    dbContext.Employees.Remove(selectedEmployee);
                    dbContext.SaveChanges();
                }
            }
        }

        public override void UpdateItem(int itemID, int rowIndex, int columnIndex, string newValue)
        {
            using (var dbContext = new PayrollDbContext())
            {
                var employeeToUpdate = dbContext.Employees.Where(e => e.Id == itemID).FirstOrDefault();
                if (employeeToUpdate != null)
                {
                    switch (columnIndex)
                    {
                        case 1:
                            if (CedulaIsValid(newValue))
                            {
                                employeeToUpdate.Cedula = newValue;
                                dbContext.SaveChanges();
                            }
                            break;

                        case 2:
                            employeeToUpdate.Name = newValue;
                            dbContext.SaveChanges();
                            break;

                        case 3:
                            employeeToUpdate.Department_Id = int.Parse(newValue);
                            dbContext.SaveChanges();
                            break;

                        case 4:
                            
                            employeeToUpdate.Position_Id = int.Parse(newValue);
                            dbContext.SaveChanges();
                            break;

                        case 5:
                            employeeToUpdate.Salary = double.Parse(newValue);
                            dbContext.SaveChanges();
                            break;

                        case 6:
                            employeeToUpdate.Payroll_Id = int.Parse(newValue);
                            dbContext.SaveChanges();
                            break;
                    }
                }
            }
        }

        public override DataGridView GetDataGrid()
        {
            return employeesDataGridView;
        }

        public override bool ValidateForm()
        {
            string cedula = employeeCedula.Text;
            return CedulaIsValid(cedula) && NameIsValid() && SalaryIsValid();
        }

        public bool CedulaIsValid(string cedula)
        {
            if (!ValidateCedula(cedula))
            {
                MessageBox.Show("La cédula no es válida, por favor verifique.");
                return false;
            }
            return true;
        }

        public bool NameIsValid()
        {
            bool isValid = !string.IsNullOrEmpty(employeeName.Text);
            if (!isValid)
            {
                MessageBox.Show("El nombre introducido no es válido, por favor verifique.");
                return false;
            }
            return true;
        }

        public bool SalaryIsValid()
        {
            bool isValid = !string.IsNullOrEmpty(employeeSalary.Text);
            if (!isValid)
            {
                MessageBox.Show("El salario introducido no es válido, por favor verifique.");
                return false;
            }
            return true;
        }

        public bool ValidateCedula(string ced)
        {
            if (string.IsNullOrEmpty(ced))
            {
                return false;
            }

            string c = ced.Replace("-", "");
            string Cedula = c.Substring(0, c.Length - 1);
            string Verificador = c.Substring(c.Length - 1, 1);
            decimal suma = 0;

            int mod, dig, res;
            res = 0;

            if ((ced.Length < 13) || (ced.Length > 13))
            {
                return false;
            }
            for (int i = 0; i < Cedula.Length; i++)
            {
                mod = 0;
                if ((i % 2) == 0) mod = 1;
                else mod = 2;
                if (int.TryParse(Cedula.Substring(i, 1), out dig))
                {
                    res = dig * mod;
                }
                else
                {
                    return false;
                }
                if (res > 9)
                {
                    res = Convert.ToInt32(res.ToString().Substring(0, 1)) +
                    Convert.ToInt32(res.ToString().Substring(1, 1));
                }
                suma += res;

            }
            decimal el_numero = (10 - (suma % 10)) % 10;
            if ((el_numero.ToString() == Verificador) && (Cedula.Substring(0, 3) != "000"))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private void EmployeeeForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'all.Payrolls' table. You can move, or remove it, as needed.
            this.payrollsTableAdapter.Fill(this.all.Payrolls);
            // TODO: This line of code loads data into the 'all.Departments' table. You can move, or remove it, as needed.
            this.departmentsTableAdapter.Fill(this.all.Departments);
            // TODO: This line of code loads data into the 'all.Positions' table. You can move, or remove it, as needed.
            this.positionsTableAdapter.Fill(this.all.Positions);
            // TODO: This line of code loads data into the 'all.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.all.Employees);
        }
    }
}
