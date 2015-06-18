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
    public partial class EmployeeeForm : Form
    {
        public EmployeeeForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void EmployeeeForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_payroll_unapecDataSet2.Payrolls' table. You can move, or remove it, as needed.
            this.payrollsTableAdapter.Fill(this._payroll_unapecDataSet2.Payrolls);
            // TODO: This line of code loads data into the '_payroll_unapecDataSet.Positions' table. You can move, or remove it, as needed.
            this.positionsTableAdapter.Fill(this._payroll_unapecDataSet.Positions);
            // TODO: This line of code loads data into the '_payroll_unapecDataSet.Departments' table. You can move, or remove it, as needed.
            this.departmentsTableAdapter.Fill(this._payroll_unapecDataSet.Departments);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var dbContext = new PayrollDbContext())
            {
                Employee employee = new Employee();
                employee.Cedula = employeeCedula.Text;
                employee.Name = employeeName.Text;
                //employee.Position_Id = employeePosition.Text;
                //employee.Department_Id = employeeDepartment.Text;
                employee.Payroll_Id = int.Parse(employeePayroll.Text);
                employee.Salary = Double.Parse(employeeSalary.Text);

                dbContext.Employees.Add(employee);
                dbContext.SaveChanges();

                // TODO: This line of code loads data into the '_payroll_unapecDataSet2.Payrolls' table. You can move, or remove it, as needed.
                this.payrollsTableAdapter.Fill(this._payroll_unapecDataSet2.Payrolls);
                // TODO: This line of code loads data into the '_payroll_unapecDataSet.Positions' table. You can move, or remove it, as needed.
                this.positionsTableAdapter.Fill(this._payroll_unapecDataSet.Positions);
                // TODO: This line of code loads data into the '_payroll_unapecDataSet.Departments' table. You can move, or remove it, as needed.
                this.departmentsTableAdapter.Fill(this._payroll_unapecDataSet.Departments);
            }


        }
    }
}
