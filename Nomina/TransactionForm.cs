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
        private Dictionary<String, TransactionCalculator> calculators;
        private ComboBox currentPeriocity;
        private double salaryDivider;

        public TransactionForm()
        {
            InitializeComponent();
            calculators = new Dictionary<string, TransactionCalculator>();
            calculators.Add("ISR", new ISRCalculator());
            calculators.Add("AFP", new AFPCalculator());
            calculators.Add("SFS", new SFSCalculator());
            salaryDivider = 1.0;
        }

        public void AddAutomaticTransactions()
        {
            using (var dbContext = new PayrollDbContext())
            {
                if(dbContext.TransactionTypes.Count() > 0)
                {
                    payroll = dbContext.Payrolls.Where(p => p.Id == payrollId).FirstOrDefault();

                    if (payroll.Periocity == "Semanal")
                    {
                        salaryDivider = 4.33;
                        cmbQuincena.Hide();
                        cmbSemana.Show();
                        currentPeriocity = cmbSemana;
                        cmbSemana.SelectedIndex = 0;
                    }

                    if (payroll.Periocity == "Quincenal")
                    {
                        salaryDivider = 2;
                        cmbQuincena.Show();
                        cmbSemana.Hide();
                        currentPeriocity = cmbQuincena;
                        cmbQuincena.SelectedIndex = 0;
                    }

                    if (payroll.Periocity == "Mensual")
                    {
                        salaryDivider = 1;
                        cmbQuincena.Hide();
                        currentPeriocity = null;
                        cmbSemana.Hide();
                    }

                    
                    transactionEmployee.Items.Clear();
                    employees = dbContext.Employees.Where(e => e.Payroll_Id == payrollId).ToList();
                    TransactionType salaryTransaction = dbContext.TransactionTypes.Where(t => t.Name.Equals("Salario")).FirstOrDefault();
                    if (salaryTransaction != null)
                    {
                        salaryTransaction.Name = "Salario " + payroll.Periocity;
                        salaryTransaction.isIncome = true;

                        employees.ForEach(e =>
                        {
                            List<TransactionType> automaticDeductions = dbContext.TransactionTypes.Where(t => t.isIncome == false && t.SalaryDependent.Equals("Si") && t.Status.Equals("Activo")).ToList();
                            AddTransaction(e, salaryTransaction, e.Salary / salaryDivider);
                            automaticDeductions.ForEach(ad =>
                            {
                                if (calculators.ContainsKey(ad.Name))
                                {
                                    AddTransaction(e, ad, calculators[ad.Name].calculate(e.Salary) / salaryDivider);
                                }
                            });
                        });
                        if (employees.Count() > 0)
                        {
                            Employee all = new Employee();
                            all.Name = "TODOS";
                            all.Id = -1;
                            employees.Insert(0, all);
                            transactionEmployee.DataSource = new BindingSource(employees, null);
                            transactionEmployee.DisplayMember = "Name";
                            transactionEmployee.ValueMember = "Id";
                            Show();
                        }
                        else
                        {
                            MessageBox.Show("No existen empleados registrados en esta nómina.");
                            Dispose();
                        }

                        cmbMonths.SelectedIndex = System.DateTime.Now.Month - 1;

                        transactionYear.Items.Add(System.DateTime.Now.Year - 1);
                        transactionYear.Items.Add(System.DateTime.Now.Year);
                        transactionYear.Items.Add(System.DateTime.Now.Year + 1);
                        transactionYear.SelectedIndex = 1;
                    } else
                    {
                        MessageBox.Show("Debe exister un Tipo de Ingreso llamado 'Salario', por favor agreguelo antes de continuar.");
                        Dispose();
                    }
                } else {
                    MessageBox.Show("No existen deducciones ni ingresos registrados, por favor agregar algunos antes de continuar.");
                    Dispose();
                }
            }
        }

        private void AddTransaction(Employee employee, TransactionType transactionType, double amount)
        {
            if (amount > 0)
            {
                int row = transactionsDataGridView.Rows.Add();
                transactionsDataGridView.Rows[row].Cells[0].Value = employee.Name;
                transactionsDataGridView.Rows[row].Cells[0].Tag = employee.Id;
                transactionsDataGridView.Rows[row].Cells[1].Value = transactionType.Name;
                transactionsDataGridView.Rows[row].Cells[1].Tag = transactionType.Id;
                transactionsDataGridView.Rows[row].Cells[2].Value = transactionType.isIncome ? "Ingreso" : "Deddución";
                transactionsDataGridView.Rows[row].Cells[3].Value = amount.ToString("C");
                transactionsDataGridView.Rows[row].Cells[4].Value = "Pendiente";
            }
        }

        private void button1_Click(object sender, EventArgs ea)
        {
            using (var dbContext = new PayrollDbContext())
            {
                TransactionType type = dbContext.TransactionTypes.Where(t => t.Id == (int)transactionDetail.SelectedValue).FirstOrDefault();
                string typeDescription = type.isIncome ? "Ingreso" : "Deducción";
                TransactionCalculator calculator = calculators.ContainsKey(type.Name) ? calculators[type.Name] : null;
                if(calculator == null && String.IsNullOrWhiteSpace(transactionAmmount.Text))
                {
                    MessageBox.Show("Debe indicar el monto para las transacciones que no dependen del salario.");
                } else
                {
                    Employee employee = dbContext.Employees.Where(e => e.Id == (int)transactionEmployee.SelectedValue).FirstOrDefault();

                    if ((int)transactionEmployee.SelectedValue > 0)
                    {
                        AddTransaction(employee, type, calculator == null ? Double.Parse(transactionAmmount.Text) : calculator.calculate(employee.Salary) / salaryDivider);
                    }
                    else if ((int)transactionEmployee.SelectedValue == -1)
                    {
                        employees.ForEach(e => {
                            if (e.Id > 0)
                            {
                                AddTransaction(e, type, calculator == null ? Double.Parse(transactionAmmount.Text) : calculator.calculate(e.Salary) / salaryDivider);
                            }
                        });
                    }
                } 
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            int rows = transactionsDataGridView.Rows.Count;
            string group = string.Format("{0} {1} {2}", currentPeriocity != null ? currentPeriocity.Text : "", cmbMonths.Text, transactionYear.Text);

            using (var dbContext = new PayrollDbContext())
            {
                if (rows > 0)
                {
                    dbContext.Database.ExecuteSqlCommand(string.Format("DELETE FROM Transactions WHERE [Group] = '{0}'", group));
                    for (int i = 0; i < rows; ++i)
                    {
                        Transaction t = new Transaction();
                        t.Employee_Id = (int)transactionsDataGridView.Rows[i].Cells[0].Tag;
                        t.TransactionType_Id = (int)transactionsDataGridView.Rows[i].Cells[1].Tag;
                        t.Date = System.DateTime.Now;
                        t.Group = group;
                        t.Amount = double.Parse(transactionsDataGridView.Rows[i].Cells[3].Value.ToString(), System.Globalization.NumberStyles.Currency);
                        t.Status = transactionsDataGridView.Rows[i].Cells[4].Value.ToString();
                        dbContext.Transactions.Add(t);
                        dbContext.SaveChanges();
                    }

                    MessageBox.Show(string.Format("Se ha generado la nómina {0}", group));
                }
                else
                {
                    MessageBox.Show(string.Format("No existen registros para la nómina {0}", group));
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
