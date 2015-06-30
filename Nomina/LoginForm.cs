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
    public partial class LoginForm : Form
    {
        public static List<String> accesses;

        public LoginForm()
        {
            InitializeComponent();
            accesses = new List<string>();
            accesses.Add("PAYROLL");
            accesses.Add("EMPLOYEE");
            accesses.Add("POSITION");
            accesses.Add("DEPARTMENT");
            accesses.Add("DEDUCTION");
            accesses.Add("INCOME");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Home().Show();
            Hide();
        }

        public static Boolean hasAccess(String section)
        {
            return accesses.Contains(section);
        }
    }
}
