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
    public partial class DeductionTypeForm : StandardForm
    {
        public DeductionTypeForm()
        {
            InitializeComponent();
        }

        public override void UpdateTableAdapter()
        {
            this.transactionTypesTableAdapter.Fill(this._payroll_unapecDataSet1.TransactionTypes);
        }

        public override void ResetInputValues()
        {
            txtDeductionName.Text = "";
            cmbDeductionStatus.SelectedIndex = -1;
            cmbDeductionSalaryDependent.SelectedIndex = -1;
        }

        public override bool ValidateForm()
        {
            return ValidateName() && ValidateStatus() && ValidateSalaryDependent();
        }

        public bool ValidateName()
        {
            bool isValid = !string.IsNullOrWhiteSpace(txtDeductionName.Text);

            if (!isValid)
            {
                MessageBox.Show("Por favor revise el nombre introducido.");
            }

            return isValid;
        }

        public bool ValidateStatus()
        {
            bool isValid = cmbDeductionStatus.SelectedIndex > -1;
            if (!isValid)
            {
                MessageBox.Show("Por favor seleccione un estatus.");
            }

            return isValid;
        }

        public bool ValidateSalaryDependent()
        {
            bool isValid = cmbDeductionSalaryDependent.SelectedIndex > -1;
            if (!isValid)
            {
                MessageBox.Show("Por favor seleccione si la deducción depende del salario.");
            }

            return isValid;
        }

        public override void SaveNewItem()
        {
            using (var dbContext = new PayrollDbContext())
            {
                TransactionType transactionType = new TransactionType();
                transactionType.Name = txtDeductionName.Text;
                transactionType.SalaryDependent = cmbDeductionSalaryDependent.SelectedItem.ToString();
                transactionType.Status = cmbDeductionStatus.SelectedItem.ToString();

                dbContext.TransactionTypes.Add(transactionType);
                dbContext.SaveChanges();
            }
        }

        public override void DeleteItem(int itemID)
        {
            using (var dbContext = new PayrollDbContext())
            {
                var selectedDeductionType = dbContext.TransactionTypes.Where(t => t.Id == itemID).FirstOrDefault();
                if (selectedDeductionType != null)
                {
                    dbContext.TransactionTypes.Remove(selectedDeductionType);
                    dbContext.SaveChanges();
                }
            }
        }

        public override void UpdateItem(int itemID, int rowIndex, int columnIndex, string newValue)
        {
            using (var dbContext = new PayrollDbContext())
            {
                var deductionToUpdate = dbContext.TransactionTypes.Where(t => t.Id == itemID).FirstOrDefault();
                if (deductionToUpdate != null)
                {
                    switch (columnIndex)
                    { 
                        case 1:
                            deductionToUpdate.Name = newValue;
                            dbContext.SaveChanges();
                            break;

                        case 2:
                            deductionToUpdate.Status = newValue;
                            dbContext.SaveChanges();
                            break;

                        case 3:
                            deductionToUpdate.SalaryDependent = newValue;
                            dbContext.SaveChanges();
                            break;
                    }
                }
            }
        }

        public override DataGridView GetDataGrid()
        {
            return deductionTypeDataGrid;
        }
    }
}
