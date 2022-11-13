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
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            using (FormCreateUser createUser = new FormCreateUser(currUser, grdUserList))
            {
                createUser.ShowDialog(this);
                createUser.Dispose();
                Init();
            }             
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            userHelper.LoadUsers(grdUserList, txtSearch.Text);
            if (grdUserList.Rows.Count > 0)
            {
                Init();
            }

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
                    createUser.ShowDialog(this);
                    createUser.Dispose();
                    Init();
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

        private void FormUsers_Load(object sender, EventArgs e)
        {
            userHelper.LoadUsers(grdUserList, txtSearch.Text);

            Init();
        }

        public void txtFocus()
        {
            txtSearch.Select();
            txtSearch.Focus();
        }

        public void Init()
        {
            txtFocus();

            grdUserList.ClearSelection();

            grdUserList.CurrentCell = null;
        }

        private void grdUserList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var dataGridView = sender as DataGridView;
            if (dataGridView.Rows[e.RowIndex].Selected)
            {
                e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
                // edit: to change the background color:
                e.CellStyle.SelectionBackColor = Color.Coral;
            }
        }

        private void FormUsers_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                Init();

            }
            else if (e.KeyCode == Keys.Down && txtSearch.ContainsFocus && grdUserList.Rows.Count > 0)
            {

                grdUserList.Select();
                grdUserList.Rows[0].Selected = true;

            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
