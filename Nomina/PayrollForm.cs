﻿using System;
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
    public partial class PayrollForm : Form
    {
        public PayrollForm()
        {
            InitializeComponent();
        }

        private void payrollsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.payrollsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._payroll_unapecDataSet2);

        }

        private void PayrollForm_Load(object sender, EventArgs e)
        {
            UpdateTableAdapter();

        }

        private void UpdateTableAdapter()
        {
            this.payrollsTableAdapter.Fill(this._payroll_unapecDataSet2.Payrolls);
        }

        private void SaveNewItem(object sender, EventArgs e)
        {
            using (var dbContext = new PayrollDbContext())
            {
                Payroll payroll = new Payroll();
                payroll.Name = payrollName.Text;
                payroll.Periocity = payrollPeriocity.Text;
                

                dbContext.Payrolls.Add(payroll);
                dbContext.SaveChanges();
                this.UpdateTableAdapter();
            }
        }
    }
}
