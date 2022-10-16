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
    public partial class FormCreateUser : MetroForm
    {
        public User currUser = new User();
        public UserHelper userHelper = new UserHelper();
        public DataGridView grdUsers = new DataGridView();
        public User newUser = new User();
        public FormCreateUser(User currentUser, DataGridView grdUsers)
        {
            InitializeComponent();
            this.currUser = currentUser;
            this.grdUsers = grdUsers;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
            this.Dispose();
        }

        private void Clear()
        {
            txtUsername.Text = null;
            txtConfirmPassword.Text = null;
            txtPassword.Text = null;
            txtFullname.Text = null;
            cmbRole.Text = null;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnSave.Text == "SAVE")
                {
                    if (txtConfirmPassword.Text != txtPassword.Text)
                    {
                        MessageBox.Show(this, "Password doesn't match!",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else
                    {
                        if (MessageBox.Show(this, "Save User?",
                                "Create User", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {

                            newUser.Fullname = txtFullname.Text;
                            newUser.Username = txtUsername.Text;
                            newUser.Password = txtPassword.Text;
                            newUser.Role = cmbRole.Text;
                            newUser.CreatedDateTime = DateTime.Now;
                            newUser.LastModifiedDateTime = DateTime.Now;
                            newUser.IsActive = chkIsActive.Checked;
                            newUser.CreatedByID = currUser.UserID;
                            newUser.LastModifiedByID = currUser.UserID;
                            userHelper.CreateUser(newUser);
                            MessageBox.Show(this, "New User Successfully Created!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Clear();
                            userHelper.LoadUsers(grdUsers, "");
                            this.Close();
                            this.Dispose();
                        }

                    }
                }
                else if (btnSave.Text == "UPDATE")
                {
                    if (MessageBox.Show(this, "Are you sure to update this user?", "Updating User", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if ((txtConfirmPassword.Text != txtPassword.Text) && txtPassword.Enabled == true) 
                        {
                            MessageBox.Show(this, "Password doesn't match!",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        else
                        {
                            newUser.Fullname = txtFullname.Text;
                            newUser.Username = txtUsername.Text;
                            newUser.Password = txtPassword.Text;
                            newUser.Role = cmbRole.Text;
                            newUser.LastModifiedDateTime = DateTime.Now;
                            newUser.IsActive = chkIsActive.Checked;
                            newUser.LastModifiedByID = currUser.UserID;
                            userHelper.UpdateUser(newUser);
                            MessageBox.Show(this, "User successfully updated!", "Updated Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Clear();
                            userHelper.LoadUsers(grdUsers, "");
                            this.Close();
                            this.Dispose();
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void FormCreateUser_Load(object sender, EventArgs e)
        {
            if (newUser.Username != null)
            {
                txtFullname.Text = newUser.Fullname.ToString();
                txtPassword.Text = newUser.Password.ToString();
                txtUsername.Text = newUser.Username.ToString();
                cmbRole.Text = newUser.Role.ToString();
                chkIsActive.Checked = newUser.IsActive;

            }
            lblChangePass.Enabled = btnSave.Text == "SAVE" ? false : true;
            txtPassword.Enabled = btnSave.Text == "SAVE" ? true : false;
            txtConfirmPassword.Enabled = btnSave.Text == "SAVE" ? true : false;
        }

        private void lblChangePass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            txtPassword.Select();
            txtPassword.Focus();
            txtPassword.Enabled = true;
            txtConfirmPassword.Enabled = true;
        }
    }

}