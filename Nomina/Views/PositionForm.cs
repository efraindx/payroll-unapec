using Nomina.Persistence;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Nomina.Views
{
    public partial class PositionForm : StandardForm
    {
        public PositionForm()
        {
            InitializeComponent();
        }

        public override void UpdateTableAdapter()
        {
            this.positionsTableAdapter.Fill(this._payroll_unapecDataSet.Positions);
        }

        public override void SaveNewItem()
        {
            using (var dbContext = new PayrollDbContext())
            {
                Position position = new Position();
                position.Name = positionName.Text;
                position.RiskLevel = cmbRiesgo.SelectedItem.ToString();
                position.MinSalary = double.Parse(positionMinSalary.Text);
                position.MaxSalary = double.Parse(positionMaxSalary.Text);

                dbContext.Positions.Add(position);
                dbContext.SaveChanges();
            }
        }

        public override void ResetInputValues()
        {
            positionName.Text = "";
            positionMinSalary.Text = "";
            positionMaxSalary.Text = "";
            cmbRiesgo.SelectedIndex = -1;
        }

        public override bool ValidateForm()
        {
            return ValidateName() && ValidateRisk() && ValidateSalaries();
        }

        private bool ValidateName()
        {
            bool isValid = !string.IsNullOrWhiteSpace(positionName.Text);
            if (!isValid)
            {
                MessageBox.Show("Por favor valide nombre introducido.");
            }

            return isValid;
        }

        private bool ValidateRisk()
        {
            int selectedIndex = cmbRiesgo.SelectedIndex;
            bool isValid = selectedIndex >= 0;

            if (!isValid)
            {
                MessageBox.Show("Por favor seleccione un riesgo.");
            }

            return isValid;
        }

        private bool ValidateSalaries()
        {
            double minSalary, maxSalary = 0;
            bool isValid = false;

            if (double.TryParse(positionMinSalary.Text, out minSalary)
                && double.TryParse(positionMaxSalary.Text, out maxSalary))
            {
                isValid = minSalary <= maxSalary;
                if (!isValid)
                {
                    MessageBox.Show("El salario mínimo no puede ser mayor que el salario máximo.");
                }
            }
            else
            {
                MessageBox.Show("Por favor valide los salarios introducidos. No se permiten letras ni signos.");
            }

            return isValid;
        }

        public override void DeleteItem(int itemID)
        {
            using (var dbContext = new PayrollDbContext())
            {
                //delete selected positions
                var currentPosition = dbContext.Positions.Where(p => p.Id == itemID).FirstOrDefault();
                if (currentPosition != null)
                {
                    dbContext.Positions.Remove(currentPosition);
                    dbContext.SaveChanges();
                }
            }
        }

        public override void UpdateItem(int itemID, int rowIndex, int columnIndex, string newValue)
        {
            using (var dbContext = new PayrollDbContext())
            {
                var positionToUpdate = dbContext.Positions.Where(p => p.Id == itemID).FirstOrDefault();
                if (positionToUpdate != null)
                {
                    //update attributes of position
                    switch (columnIndex)
                    {
                        case 1:
                            positionToUpdate.Name = newValue;
                            dbContext.SaveChanges();
                            break;

                        case 2:
                            positionToUpdate.RiskLevel = newValue;
                            dbContext.SaveChanges();
                            break;

                        case 3:
                            int newMinSalaxy;
                            if (int.TryParse(newValue, out newMinSalaxy))
                            {
                                positionToUpdate.MinSalary = newMinSalaxy;
                                dbContext.SaveChanges();
                            }
                            break;

                        case 4:
                            int newMaxSalary;
                            if (int.TryParse(newValue, out newMaxSalary))
                            {
                                positionToUpdate.MaxSalary = newMaxSalary;
                                dbContext.SaveChanges();
                            }
                            break;
                    }
                }
            }
        }

        public override DataGridView GetDataGrid()
        {
            return positionsDataGrid;
        }
    }
}
