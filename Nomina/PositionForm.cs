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
    public partial class PositionForm : Form
    {
        public PositionForm()
        {
            InitializeComponent();
        }

        private void PositionForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_payroll_unapecDataSet.Positions' table. You can move, or remove it, as needed.
            updateTableAdapter();
        }

        private void updateTableAdapter()
        {
            this.positionsTableAdapter.Fill(this._payroll_unapecDataSet.Positions);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void savePosition_Click(object sender, EventArgs e)
        {
            if(validateForm())
            {
                using(var  dbContext = new PayrollDbContext())
                {
                    Position position = new Position();
                    position.Name = positionName.Text;
                    position.RiskLevel = positionRisk.Text;
                    position.MinSalary = double.Parse(positionMinSalary.Text);
                    position.MaxSalary = double.Parse(positionMaxSalary.Text);

                    dbContext.Positions.Add(position);
                    dbContext.SaveChanges();
                    updateTableAdapter();
                }
            }
        }

        private bool validateForm()
        {
            return validateName() && validateRisk() && validateRisk();
        }

        private bool validateName()
        {
            bool isValid = ! string.IsNullOrWhiteSpace(positionName.Text);
            if(!isValid)
            {
                MessageBox.Show("Por favor valide nombre introducido.");
            }

            return isValid;
        }

        //TODO: El riesgo seran constantes, texto libre o que??
        private bool validateRisk()
        {
            bool isValid = !string.IsNullOrWhiteSpace(positionRisk.Text);
            if(!isValid)
            {
                MessageBox.Show("Por favor valide el riesgo introducido.");
            }

            return isValid;
        }

        private bool validateSalaries()
        {
            double minSalary, maxSalary = 0;
            bool isValid = false;

            if(double.TryParse( positionMinSalary.Text, out minSalary ) 
                && double.TryParse(positionMaxSalary.Text, out maxSalary))
            {
                isValid = minSalary <= maxSalary;
                if(!isValid)
                {
                    MessageBox.Show("El salario minimo no puede ser mayor que el salario maximo.");
                }
            }
            else
            {
                MessageBox.Show("Por favor valide los salarios introducidos.");
            }

            return isValid;
        }
    }
}
