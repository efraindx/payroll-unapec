using Nomina.Views;
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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void puestosForm_Click(object sender, EventArgs e)
        {
            if(LoginForm.hasAccess("POSITION")) {
                new PositionForm().Show();
            } else {
                MessageBox.Show("No tiene acceso a esta sección, por favor contacte a un administrador.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (LoginForm.hasAccess("DEPARTMENT"))
            {
                new DepartmentForm().Show();
            }
            else
            {
                MessageBox.Show("No tiene acceso a esta sección, por favor contacte a un administrador.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (LoginForm.hasAccess("INCOME"))
            {
                new IncomeTypeForm().Show();
            }
            else
            {
                MessageBox.Show("No tiene acceso a esta sección, por favor contacte a un administrador.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (LoginForm.hasAccess("DEDUCTION"))
            {
                new DeductionTypeForm().Show();
            }
            else
            {
                MessageBox.Show("No tiene acceso a esta sección, por favor contacte a un administrador.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (LoginForm.hasAccess("PAYROLL"))
            {
                new PayrollForm().Show();
            }
            else
            {
                MessageBox.Show("No tiene acceso a esta sección, por favor contacte a un administrador.");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (LoginForm.hasAccess("EMPLOYEE"))
            {
                new EmployeeeForm().Show();
            }
            else
            {
                MessageBox.Show("No tiene acceso a esta sección, por favor contacte a un administrador.");
            }
        }

        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
