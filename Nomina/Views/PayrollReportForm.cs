using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Nomina.Persistence;

namespace Nomina.Views
{
    public partial class PayrollReportForm : Form
    {
        public PayrollReportForm()
        {
            InitializeComponent();
        }

        private void PayrollReportForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'all.DataTable1' table. You can move, or remove it, as needed.
            this.DataTable1TableAdapter.FillAll(this.all.DataTableReport);
            buildComboboxEmployees();
            buildComboboxPayrolls();
            this.payrollsTableAdapter1.Fill(this._payroll_unapecDataSet6.Payrolls);
            this.employeesTableAdapter.Fill(this.all.Employees);
            cmbTransactionType.SelectedIndex = 0;
            this.DataTable1TableAdapter.FillAll(this.all.DataTableReport);
            this.reportViewer1.RefreshReport();
        }

        private void cmbTransactionType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbTransactionType.SelectedIndex)
            {
                case 0:

                    if (cmbEmployee.SelectedIndex != 0)
                    {
                        int empId = int.Parse(cmbEmployee.SelectedValue.ToString());
                        if (cmbNomina.SelectedIndex != 0)
                        {
                            int payrollId = int.Parse(cmbNomina.SelectedValue.ToString());
                            this.DataTable1TableAdapter.FillByEmpIDAndPayrollIDWithAllTransactionTypes(this.all.DataTableReport, empId, payrollId);
                        }
                        else
                        {
                            this.DataTable1TableAdapter.FillByEmpIDWithAllTransactionTypesAndPayrolls(this.all.DataTableReport, empId);
                        }
                    }
                    else
                    {
                        if (cmbNomina.SelectedIndex != 0)
                        {
                            int payrollId = int.Parse(cmbNomina.SelectedValue.ToString());
                            this.DataTable1TableAdapter.FillByPayrollIDWithAllEmployeeAndTransactionTypes(this.all.DataTableReport, payrollId);
                        }
                        else
                        {
                            this.DataTable1TableAdapter.FillAll(this.all.DataTableReport);
                        }
                    }

                    break;

                case 1:

                    if (cmbEmployee.SelectedIndex != 0)
                    {
                        int empId = int.Parse(cmbEmployee.SelectedValue.ToString());
                        if (cmbNomina.SelectedIndex != 0)
                        {
                            int payrollId = int.Parse(cmbNomina.SelectedValue.ToString());
                            this.DataTable1TableAdapter.FillByEmpIdAndTransactionTypeAndPayrollId(this.all.DataTableReport, empId, true, payrollId);
                        }
                        else
                        {
                            this.DataTable1TableAdapter.FillByEmpIdAndTransactionTypeWithAllPayrolls(this.all.DataTableReport, true, empId);
                        }
                    }
                    else
                    {
                        if (cmbNomina.SelectedIndex != 0)
                        {
                            int payrollId = int.Parse(cmbNomina.SelectedValue.ToString());
                            this.DataTable1TableAdapter.FillByTransactionTypeAndPayrollIdWithAllEmployees(this.all.DataTableReport, true, payrollId);
                        }
                        else
                        {
                            this.DataTable1TableAdapter.FillByTransactionTypeWithAllEmployeesAndPayrolls(this.all.DataTableReport, true);
                        }
                    }

                    break;

                case 2:

                    if (cmbEmployee.SelectedIndex != 0)
                    {
                        int empId = int.Parse(cmbEmployee.SelectedValue.ToString());
                        if (cmbNomina.SelectedIndex != 0)
                        {
                            int payrollId = int.Parse(cmbNomina.SelectedValue.ToString());
                            this.DataTable1TableAdapter.FillByEmpIdAndTransactionTypeAndPayrollId(this.all.DataTableReport, empId, false, payrollId);
                        }
                        else
                        {
                            this.DataTable1TableAdapter.FillByEmpIdAndTransactionTypeWithAllPayrolls(this.all.DataTableReport, false, empId);
                        }
                    }
                    else
                    {
                        if (cmbNomina.SelectedIndex != 0)
                        {
                            int payrollId = int.Parse(cmbNomina.SelectedValue.ToString());
                            this.DataTable1TableAdapter.FillByTransactionTypeAndPayrollIdWithAllEmployees(this.all.DataTableReport, false, payrollId);
                        }
                        else
                        {
                            this.DataTable1TableAdapter.FillByTransactionTypeWithAllEmployeesAndPayrolls(this.all.DataTableReport, false);
                        }
                    }

                    break;
            }
            this.reportViewer1.RefreshReport();
        }

        private void cmbEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEmployee.SelectedIndex != 0)
            {
                int empId = int.Parse(cmbEmployee.SelectedValue.ToString());

                switch (cmbTransactionType.SelectedIndex)
                {
                    case 0:

                        if (cmbNomina.SelectedIndex != 0)
                        {
                            int payrollId = int.Parse(cmbNomina.SelectedValue.ToString());
                            this.DataTable1TableAdapter.FillByEmpIDAndPayrollIDWithAllTransactionTypes(this.all.DataTableReport, empId, payrollId);
                        }
                        else
                        {
                            this.DataTable1TableAdapter.FillByEmpIDWithAllTransactionTypesAndPayrolls(this.all.DataTableReport, empId);
                        }
                        break;

                    case 1:

                        if (cmbNomina.SelectedIndex != 0)
                        {
                            int payrollId = int.Parse(cmbNomina.SelectedValue.ToString());
                            this.DataTable1TableAdapter.FillByEmpIdAndTransactionTypeAndPayrollId(this.all.DataTableReport, empId, true, payrollId);
                        }
                        else
                        {
                            this.DataTable1TableAdapter.FillByEmpIdAndTransactionTypeWithAllPayrolls(this.all.DataTableReport, true, empId);
                        }
                        break;

                    case 2:

                        if (cmbNomina.SelectedIndex != 0)
                        {
                            int payrollId = int.Parse(cmbNomina.SelectedValue.ToString());
                            this.DataTable1TableAdapter.FillByEmpIdAndTransactionTypeAndPayrollId(this.all.DataTableReport, empId, false, payrollId);
                        }
                        else
                        {
                            this.DataTable1TableAdapter.FillByEmpIdAndTransactionTypeWithAllPayrolls(this.all.DataTableReport, false, empId);
                        }
                        break;
                }
            }
            else
            {
                switch (cmbTransactionType.SelectedIndex)
                {
                    case 0:

                        if (cmbNomina.SelectedIndex != 0)
                        {
                            int payrollId = int.Parse(cmbNomina.SelectedValue.ToString());
                            this.DataTable1TableAdapter.FillByPayrollIDWithAllEmployeeAndTransactionTypes(this.all.DataTableReport, payrollId);
                        }
                        else
                        {
                            this.DataTable1TableAdapter.FillAll(this.all.DataTableReport);
                        }
                        break;

                    case 1:

                        if (cmbNomina.SelectedIndex != 0)
                        {
                            int payrollId = int.Parse(cmbNomina.SelectedValue.ToString());
                            this.DataTable1TableAdapter.FillByTransactionTypeAndPayrollIdWithAllEmployees(this.all.DataTableReport, true, payrollId);
                        }
                        else
                        {
                            this.DataTable1TableAdapter.FillByTransactionTypeWithAllEmployeesAndPayrolls(this.all.DataTableReport, true);
                        }
                        break;

                    case 2:

                        if (cmbNomina.SelectedIndex != 0)
                        {
                            int payrollId = int.Parse(cmbNomina.SelectedValue.ToString());
                            this.DataTable1TableAdapter.FillByTransactionTypeAndPayrollIdWithAllEmployees(this.all.DataTableReport, false, payrollId);
                        }
                        else
                        {
                            this.DataTable1TableAdapter.FillByTransactionTypeWithAllEmployeesAndPayrolls(this.all.DataTableReport, false);
                        }
                        break;
                }
            }
            this.reportViewer1.RefreshReport();
        }

        private void buildComboboxPayrolls()
        {
            using (var dbContext = new PayrollDbContext())
            {
                List<Payroll> payrolls = dbContext.Payrolls.ToList();
                Payroll all = new Payroll();
                all.Name = "TODOS";
                all.Id = 0;
                payrolls.Insert(0, all);
                cmbNomina.DataSource = new BindingSource(payrolls, null);
                cmbNomina.DisplayMember = "Name";
                cmbNomina.ValueMember = "Id";
            }

        }

        private void buildComboboxEmployees()
        {
            using (var dbContext = new PayrollDbContext())
            {
                int[] employeesIdsInTransactions = dbContext.Transactions.Select(t => t.Employee_Id).ToArray();

                var q = from employee in dbContext.Employees
                        where employeesIdsInTransactions.Contains(employee.Id)
                        select employee;

                List<Employee> employees = q.ToList<Employee>();
                Employee all = new Employee();
                all.Name = "TODOS";
                all.Id = 0;
                employees.Insert(0, all);
                cmbEmployee.DataSource = new BindingSource(employees, null);
                cmbEmployee.DisplayMember = "Name";
                cmbEmployee.ValueMember = "Id";
            }

        }

        private void cmbNomina_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNomina.SelectedIndex != 0)
            {
                int payrollId = int.Parse(cmbNomina.SelectedValue.ToString());

                switch (cmbTransactionType.SelectedIndex)
                {
                    case 0:

                        if (cmbEmployee.SelectedIndex != 0)
                        {
                            int employeeId = int.Parse(cmbEmployee.SelectedValue.ToString());
                            this.DataTable1TableAdapter.FillByEmpIDAndPayrollIDWithAllTransactionTypes(this.all.DataTableReport, employeeId, payrollId);
                        }
                        else
                        {
                            this.DataTable1TableAdapter.FillByPayrollIDWithAllEmployeeAndTransactionTypes(this.all.DataTableReport, payrollId);
                        }
                        break;

                    case 1:

                        if (cmbEmployee.SelectedIndex != 0)
                        {
                            int employeeId = int.Parse(cmbEmployee.SelectedValue.ToString());
                            this.DataTable1TableAdapter.FillByEmpIdAndTransactionTypeAndPayrollId(this.all.DataTableReport, employeeId, true, payrollId);
                        }
                        else
                        {
                            this.DataTable1TableAdapter.FillByTransactionTypeAndPayrollIdWithAllEmployees(this.all.DataTableReport, true, payrollId);
                        }
                        break;

                    case 2:

                        if (cmbEmployee.SelectedIndex != 0)
                        {
                            int employeeId = int.Parse(cmbEmployee.SelectedValue.ToString());
                            this.DataTable1TableAdapter.FillByEmpIdAndTransactionTypeAndPayrollId(this.all.DataTableReport, employeeId, true, payrollId);
                        }
                        else
                        {
                            this.DataTable1TableAdapter.FillByTransactionTypeAndPayrollIdWithAllEmployees(this.all.DataTableReport, true, payrollId);
                        }
                        break;
                }
            }
            else
            {
                switch (cmbTransactionType.SelectedIndex)
                {
                    case 0:

                        if (cmbEmployee.SelectedIndex != 0)
                        {
                            int employeeId = int.Parse(cmbEmployee.SelectedValue.ToString());
                            this.DataTable1TableAdapter.FillByEmpIDWithAllTransactionTypesAndPayrolls(this.all.DataTableReport, employeeId);
                        }
                        else
                        {
                            this.DataTable1TableAdapter.FillAll(this.all.DataTableReport);
                        }
                        break;

                    case 1:

                        if (cmbEmployee.SelectedIndex != 0)
                        {
                            int employeeId = int.Parse(cmbEmployee.SelectedValue.ToString());
                            this.DataTable1TableAdapter.FillByEmpIdAndTransactionTypeWithAllPayrolls(this.all.DataTableReport, true, employeeId);
                        }
                        else
                        {
                            this.DataTable1TableAdapter.FillByTransactionTypeWithAllEmployeesAndPayrolls(this.all.DataTableReport, true);
                        }
                        break;

                    case 2:

                        if (cmbEmployee.SelectedIndex != 0)
                        {
                            int employeeId = int.Parse(cmbEmployee.SelectedValue.ToString());
                            this.DataTable1TableAdapter.FillByEmpIdAndTransactionTypeWithAllPayrolls(this.all.DataTableReport, false, employeeId);
                        }
                        else
                        {
                            this.DataTable1TableAdapter.FillByTransactionTypeWithAllEmployeesAndPayrolls(this.all.DataTableReport, false);
                        }
                        break;
                }
            }
            this.reportViewer1.RefreshReport();
        }
    }
}