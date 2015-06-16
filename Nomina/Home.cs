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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void puestosForm_Click(object sender, EventArgs e)
        {
            new PositionForm().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new DepartmentForm().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new IncomeTypeForm().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new DeductionTypeForm().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new PayrollForm().Show();
        }
    }
}
