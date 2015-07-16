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
        public static User user;

        public LoginForm()
        {
            InitializeComponent();
            accesses = new List<string>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LogUser();
        }

        /// <summary>
        /// method for log in user
        /// </summary>
        private void LogUser()
        {
            using (var dbContext = new PayrollDbContext())
            {
                user = dbContext.Users.Where(u => u.name.Equals(userName.Text) && u.password.Equals(userPassword.Text)).FirstOrDefault();
                if (user == null)
                {
                    MessageBox.Show("Por favor verifique los datos ingresados.");
                }
                else
                {
                    user.Roles.ToList().ForEach(r => accesses.Add(r.Name.ToUpper()));
                    if (accesses.Contains("ADMIN"))
                    {
                        new AdminForm().Show();
                    }
                    else
                    {
                        new Home().Show();
                    }
                    Hide();
                }
            }
        }

        public static Boolean hasAccess(String section)
        {
            return accesses.Contains(section);
        }

        private void LoginForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.Enter:
                    LogUser();
                    break;
            }
        }

    }
}
