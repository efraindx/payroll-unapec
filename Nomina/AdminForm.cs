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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new UsersForm().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new RolesForm().Show();
        }

        private void AdminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dispose();
            Application.Exit();
        }
    }
}
