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

        public TransactionForm()
        {
            InitializeComponent();
        }

        public void AddAutomaticTransactions()
        {
            using (var dbContext = new PayrollDbContext())
            {
                payroll = dbContext.Payrolls.Where(p => p.Id == payrollId).FirstOrDefault();
                dbContext.Employees.Where(e => e.Payroll_Id == payrollId).ToList().ForEach(e => {
                    AddTransaction(e.Name, "ISR", ISRCalculator.getISR(e.Salary));
                    AddTransaction(e.Name, "AFP", AFPCalculator.getAFP(e.Salary));
                    AddTransaction(e.Name, "SFS", SFSCalculator.getSFS(e.Salary));
                });
            }

            if(payroll.Periocity == "Semanal")
            {
                cmbQuincena.Hide();
                cmbSemana.Show();
            }

            if (payroll.Periocity == "Quincenal")
            {
                cmbQuincena.Show();
                cmbSemana.Hide();
            }

            if (payroll.Periocity == "Mensual")
            {
                cmbQuincena.Hide();
                cmbSemana.Hide();
            }
        }

        private void AddTransaction(string a, string b, double c)
        {
            int row = transactionsDataGridView.Rows.Add();
            transactionsDataGridView.Rows[row].Cells[0].Value = a;
            transactionsDataGridView.Rows[row].Cells[1].Value = b;
            transactionsDataGridView.Rows[row].Cells[2].Value = "Deducción";
            transactionsDataGridView.Rows[row].Cells[3].Value = c;
            transactionsDataGridView.Rows[row].Cells[4].Value = "Pendiente";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddTransaction( "Empleado de Prueba", transactionDetail.Text, Double.Parse(transactionAmmount.Text) );
        }

        private void TransactionForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_payroll_unapecDataSet.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this._payroll_unapecDataSet.Employees);

        }
    }
}
