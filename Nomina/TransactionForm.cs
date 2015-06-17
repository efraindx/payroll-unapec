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
        public TransactionForm()
        {
            InitializeComponent();
        }

        public void AddAutomaticTransactions()
        {
            AddTransaction("Rubén Jiménez", "ISR", ISRCalculator.getISR(90000));
            AddTransaction("Rubén Jiménez", "AFP", AFPCalculator.getAFP(90000));
            AddTransaction("Rubén Jiménez", "SFS", SFSCalculator.getSFS(90000));
            AddTransaction("Rubén Jiménez", "Comida", 350);

            AddTransaction("Joel Cuevas", "ISR", ISRCalculator.getISR(65000));
            AddTransaction("Joel Cuevas", "AFP", AFPCalculator.getAFP(65000));
            AddTransaction("Joel Cuevas", "SFS", SFSCalculator.getSFS(65000));
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
