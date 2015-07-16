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
    public partial class UsersForm : Form
    {
        public UsersForm()
        {
            InitializeComponent();
        }

        private void UsersForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_payroll_unapecDataSet4.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this._payroll_unapecDataSet4.Users);
            // TODO: This line of code loads data into the '_payroll_unapecDataSet4.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this._payroll_unapecDataSet4.Users);

        }

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._payroll_unapecDataSet4);

        }

        private void usersDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            AccessesForm form = new AccessesForm();
            form.Show();
            using (var dbContext = new PayrollDbContext())
            {
                int userId = int.Parse(usersDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
                form.userId = userId;
                var selectedUser = dbContext.Users.Find(userId);

                if (selectedUser != null)
                {
                    form.selectRoles(dbContext.Users.Find(userId).Roles.ToList());
                }
                else
                {
                    form.selectRoles(dbContext.Roles.ToList());
                }
            }
        }
    }
}
