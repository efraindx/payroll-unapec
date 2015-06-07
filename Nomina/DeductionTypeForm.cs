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
    public partial class DeductionTypeForm : Form
    {
        public DeductionTypeForm()
        {
            InitializeComponent();
        }

        private void transactionTypesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.transactionTypesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._payroll_unapecDataSet1);

        }

        private void DeductionTypeForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_payroll_unapecDataSet1.TransactionTypes' table. You can move, or remove it, as needed.
            this.transactionTypesTableAdapter.Fill(this._payroll_unapecDataSet1.TransactionTypes);

        }
    }
}
