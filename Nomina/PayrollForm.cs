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
    public partial class PayrollForm : StandardForm
    {
        public PayrollForm()
        {
            InitializeComponent();
        }

        public override void UpdateTableAdapter()
        {
            this.payrollsTableAdapter.Fill(this._payroll_unapecDataSet2.Payrolls);
        }

        public override void SaveNewItem(object sender, EventArgs e)
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

        private void payrollsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int column = e.ColumnIndex;
            int row = e.RowIndex;
            
            if(3 == column)
            {
                string payrollName = payrollsDataGridView.Rows[row].Cells[1].Value.ToString();
                string payrollPeriocity = payrollsDataGridView.Rows[row].Cells[2].Value.ToString();
                TransactionForm transactionForm = new TransactionForm();
                transactionForm.payrollName.Text = "Nómina " + payrollName;
                transactionForm.Text = "Nómina " + payrollName;
                transactionForm.payrollPeriocity.Text = "Periocidad " + payrollPeriocity;
                transactionForm.AddAutomaticTransactions();
                transactionForm.Show();
            }
        }

        public override void ResetInputValues()
        {
            payrollName.Text = "";
            payrollPeriocity.SelectedIndex = -1;
        }

        public bool ValidateName()
        {
            bool isValid = !string.IsNullOrWhiteSpace(payrollName.Text);
            if (!isValid)
            {
                MessageBox.Show("Debe insertar un nombre.");
            }

            return isValid;
        }

        public bool ValidatePeriodicity()
        {
            bool isValid = payrollPeriocity.SelectedIndex > -1;
            if (!isValid)
            {
                MessageBox.Show("Debe seleccionar un periodo para la nómina.");
            }

            return isValid;
        }

        public override bool ValidateForm()
        {
            return ValidateName() && ValidatePeriodicity();
        }
    }
}
