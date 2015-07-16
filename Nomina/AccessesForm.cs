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
    public partial class AccessesForm : Form
    {
        public int userId;
        public AccessesForm()
        {
            InitializeComponent();
        }

        private void AccessesForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_payroll_unapecDataSet5.Roles' table. You can move, or remove it, as needed.
            this.rolesTableAdapter.Fill(this._payroll_unapecDataSet5.Roles);

        }

        public void selectRoles(List<Role> roles)
        {
            for(int i = 0; i < availableAccesses.Items.Count; ++i)
            {
                string name = availableAccesses.GetItemText(availableAccesses.Items[i]);
                availableAccesses.SetSelected(i, roles.Where(r => r.Name.Equals(name)).FirstOrDefault() != null);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var dbContext = new PayrollDbContext())
            {
                //LoginForm.user.Roles.Clear();
                dbContext.Database.ExecuteSqlCommand( "DELETE FROM UserRole WHERE UserRole_Role_id=" + userId);
                foreach (int i in availableAccesses.SelectedIndices)
                {
                    string name = availableAccesses.GetItemText(availableAccesses.Items[i]);
                    dbContext.Database.ExecuteSqlCommand("INSERT INTO UserRole VALUES( " + userId + ", " + dbContext.Roles.Where(r => r.Name.Equals(name)).FirstOrDefault().Id + " )");
                }

                MessageBox.Show("Permisos actualizados.");
            }
        }
    }
}
