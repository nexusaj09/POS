using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using POS.Classes;
using POS.Helpers;

namespace POS.Forms
{
    public partial class FormUsers : MetroForm
    {

        public User currUser = new User();
        private UserHelper userHelper = new UserHelper();
        public FormUsers(User currentUser)
        {
            InitializeComponent();
            this.currUser = currentUser;
            userHelper.LoadUsers(grdUserList, txtSearch.Text);
            txtSearch.Select();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            using (FormCreateUser createUser = new FormCreateUser(currUser, grdUserList))
            {
                createUser.ShowDialog();
                createUser.Dispose();
                this.BringToFront();
                txtSearch.Select();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            userHelper.LoadUsers(grdUserList, txtSearch.Text);
        }

        private void grdUserList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grdUserList.Columns[e.ColumnIndex].Name == "EDIT")
            {
                using (FormCreateUser createUser = new FormCreateUser(currUser, grdUserList))
                {
                    createUser.newUser.UserID = Convert.ToInt32(grdUserList[1, e.RowIndex].Value.ToString());
                    createUser.newUser.Fullname = grdUserList[4, e.RowIndex].Value.ToString();
                    createUser.newUser.Username = grdUserList[2, e.RowIndex].Value.ToString();
                    createUser.newUser.Role = grdUserList[5, e.RowIndex].Value.ToString();
                    createUser.newUser.IsActive = Convert.ToBoolean(grdUserList[6, e.RowIndex].Value);
                    createUser.newUser.Password = grdUserList[3, e.RowIndex].Value.ToString();
                    createUser.btnSave.Text = "UPDATE";
                    createUser.txtUsername.Select();
                    createUser.ShowDialog();

                    createUser.Dispose();
                    this.BringToFront();
                    txtSearch.Select();
                }
            }
            else if (grdUserList.Columns[e.ColumnIndex].Name == "DELETE")
            {
                if (MessageBox.Show(this, "Are you sure to delete this user?", "Delete User", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    userHelper.DeleteUser(Convert.ToInt32(grdUserList[1, e.RowIndex].Value.ToString()));
                    userHelper.LoadUsers(grdUserList, txtSearch.Text);
                    MessageBox.Show("User Successfully Deleted", "User Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
