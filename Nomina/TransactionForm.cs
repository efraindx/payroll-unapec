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
    public partial class TransactionForm : Form
    {
        public int payrollId;
        private Payroll payroll;
        private List<Employee> employees;

        public TransactionForm()
        {
            InitializeComponent();
        }

        public void AddAutomaticTransactions()
        {
            using (var dbContext = new PayrollDbContext())
            {
                payroll = dbContext.Payrolls.Where(p => p.Id == payrollId).FirstOrDefault();
                transactionEmployee.Items.Clear();
                employees = dbContext.Employees.Where(e => e.Payroll_Id == payrollId).ToList();
                employees.ForEach(e => {
                    AddTransaction(e, dbContext.TransactionTypes.Where(t => t.Name.Equals("ISR")).FirstOrDefault(),ISRCalculator.getISR(e.Salary));
                    AddTransaction(e, dbContext.TransactionTypes.Where(t => t.Name.Equals("AFP")).FirstOrDefault(), AFPCalculator.getAFP(e.Salary));
                    AddTransaction(e, dbContext.TransactionTypes.Where(t => t.Name.Equals("SFS")).FirstOrDefault(), SFSCalculator.getSFS(e.Salary));
                });
                if(employees.Count() > 0)
                {
                    Employee all = new Employee();
                    all.Name = "TODOS";
                    all.Id = -1;
                    employees.Insert(0, all);
                    transactionEmployee.DataSource = new BindingSource(employees, null);
                    transactionEmployee.DisplayMember = "Name";
                    transactionEmployee.ValueMember = "Id";
                }
            }


            cmbMonths.SelectedIndex = System.DateTime.Now.Month-1;

            if(payroll.Periocity == "Semanal")
            {
                cmbQuincena.Hide();
                cmbSemana.Show();
                cmbSemana.SelectedIndex = 0;
            }

            if (payroll.Periocity == "Quincenal")
            {
                cmbQuincena.Show();
                cmbSemana.Hide();
                cmbQuincena.SelectedIndex = 0;
            }

            if (payroll.Periocity == "Mensual")
            {
                cmbQuincena.Hide();
                cmbSemana.Hide();
            }
        }

        private void AddTransaction(Employee employee, TransactionType transactionType, double amount)
        {
            int row = transactionsDataGridView.Rows.Add();
            transactionsDataGridView.Rows[row].Cells[0].Value = employee.Name;
            transactionsDataGridView.Rows[row].Cells[0].Tag = employee.Id;
            transactionsDataGridView.Rows[row].Cells[1].Value = transactionType.Name;
            transactionsDataGridView.Rows[row].Cells[1].Tag = transactionType.Id;
            transactionsDataGridView.Rows[row].Cells[2].Value = transactionType.isIncome ? "Ingreso" : "Deddución";
            transactionsDataGridView.Rows[row].Cells[3].Value = amount;
            transactionsDataGridView.Rows[row].Cells[4].Value = "Pendiente";
        }

        private void button1_Click(object sender, EventArgs ea)
        {
            using (var dbContext = new PayrollDbContext())
            {
                TransactionType type = dbContext.TransactionTypes.Where(t => t.Id == (int)transactionDetail.SelectedValue).FirstOrDefault();
                string typeDescription = type.isIncome ? "Ingreso" : "Deducción";
                double amount = Double.Parse(transactionAmmount.Text);
                Employee employee = dbContext.Employees.Where(e => e.Id == (int)transactionEmployee.SelectedValue).FirstOrDefault();

                if ((int)transactionEmployee.SelectedValue > 0)
                {
                    AddTransaction(employee, type, amount);
                } else if((int)transactionEmployee.SelectedValue == -1)
                {
                    employees.ForEach(e => {
                        if(e.Id > 0)
                        {
                            AddTransaction(e, type, amount);
                        }
                    });
                }
                
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            int rows = transactionsDataGridView.Rows.Count;
            using (var dbContext = new PayrollDbContext())
            {
                for (int i = 0; i < rows; ++i)
                {
                    Transaction t = new Transaction();
                    t.Employee_Id = (int)transactionsDataGridView.Rows[i].Cells[0].Tag;
                    t.TransactionType_Id = (int)transactionsDataGridView.Rows[i].Cells[1].Tag;
                    t.Date = System.DateTime.Now;
                    t.Amount = double.Parse(transactionsDataGridView.Rows[i].Cells[3].Value.ToString());
                    t.Status = transactionsDataGridView.Rows[i].Cells[4].Value.ToString();
                    dbContext.Transactions.Add(t);
                    dbContext.SaveChanges();
                }
            }  
        }

        private void TransactionForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_payroll_unapecDataSet3.TransactionTypes' table. You can move, or remove it, as needed.
            this.transactionTypesTableAdapter1.Fill(this._payroll_unapecDataSet3.TransactionTypes);
            // TODO: This line of code loads data into the '_payroll_unapecDataSet1.TransactionTypes' table. You can move, or remove it, as needed.
            this.transactionTypesTableAdapter.Fill(this._payroll_unapecDataSet1.TransactionTypes);
            // TODO: This line of code loads data into the '_payroll_unapecDataSet.Employees' table. You can move, or remove it, as needed.
            //this.employeesTableAdapter.Fill(this._payroll_unapecDataSet.Employees);

        }
    }
}
