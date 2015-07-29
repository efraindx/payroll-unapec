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
    public partial class IncomeTypeForm : StandardForm
    {
        public IncomeTypeForm()
        {
            InitializeComponent();
        }

        public override void UpdateTableAdapter()
        {
            this.transactionTypesTableAdapter.Fill(this._payroll_unapecDataSet1.TransactionTypes);
        }

        public override void ResetInputValues()
        {
            txtIncomeName.Text = "";
            cmbIncomeStatus.SelectedIndex = -1;
            cmbSalaryDependent.SelectedIndex = -1;
        }

        public bool ValidateName()
        {
            bool isValid = !string.IsNullOrWhiteSpace(txtIncomeName.Text);
            if (!isValid)
            {
                MessageBox.Show("Debe insertar el nombre del ingreso.");
            }

            return isValid;
        }

        public bool ValidateStatus()
        {
            bool isValid = cmbIncomeStatus.SelectedIndex > -1;
            if (!isValid)
            {
                MessageBox.Show("Debe seleccionar un estatus.");
            }

            return isValid;
        }

        public bool ValidateSalaryDependent()
        {
            bool isValid = cmbSalaryDependent.SelectedIndex > -1;
            if (!isValid)
            {
                MessageBox.Show("Debe seleccionar si el ingreso depende del salaario.");
            }

            return isValid;
        }

        public override bool ValidateForm()
        {
            return ValidateName() && ValidateStatus() && ValidateSalaryDependent();
        }

        public override void SaveNewItem()
        {
            using (var dbContext = new PayrollDbContext())
            {
                TransactionType transactionType = new TransactionType();
                transactionType.Name = txtIncomeName.Text;
                transactionType.SalaryDependent = cmbSalaryDependent.SelectedItem.ToString();
                transactionType.Status = cmbIncomeStatus.SelectedItem.ToString();
                transactionType.isIncome = true;

                dbContext.TransactionTypes.Add(transactionType);
                dbContext.SaveChanges();
            }
        }

        public override void DeleteItem(int itemID)
        {
            using (var dbContext = new PayrollDbContext())
            {
                var selectedIncomeType = dbContext.TransactionTypes.Where(t => t.Id == itemID).FirstOrDefault();
                if (selectedIncomeType != null)
                {
                    dbContext.TransactionTypes.Remove(selectedIncomeType);
                    dbContext.SaveChanges();
                }
            }
        }

        public override void UpdateItem(int itemID, int rowIndex, int columnIndex, string newValue)
        {
            using (var dbContext = new PayrollDbContext())
            {
                var incomeTypeToUpdate = dbContext.TransactionTypes.Where(t => t.Id == itemID).FirstOrDefault();
                if (incomeTypeToUpdate != null)
                {
                    switch (columnIndex)
                    { 
                        case 1:
                            incomeTypeToUpdate.Name = newValue;
                            dbContext.SaveChanges();
                            break;

                        case 2:
                            incomeTypeToUpdate.SalaryDependent = newValue;
                            dbContext.SaveChanges();
                            break;

                        case 3:
                            incomeTypeToUpdate.Status = newValue;
                            dbContext.SaveChanges();
                            break;
                    }
                }
            }
        }

        public override DataGridView GetDataGrid()
        {
            return transactionTypesDataGridView;
        }
    }
}
