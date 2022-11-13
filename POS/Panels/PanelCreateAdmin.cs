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

namespace POS.Panels
{
    public partial class PanelCreateAdmin : MetroForm
    {
        public UserHelper userHelper = new UserHelper();

        public PanelCreateAdmin()
        {
            InitializeComponent();
        }

        private void PanelCreateAdmin_Load(object sender, EventArgs e)
        {
            cmbRole.Text = "System Administrator";
            chkIsActive.Checked = true;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
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
                        User newUser = new User();

                        newUser.Fullname = txtFullname.Text;
                        newUser.Username = txtUsername.Text;
                        newUser.Password = txtPassword.Text;
                        newUser.Role = cmbRole.Text;
                        newUser.CreatedDateTime = DateTime.Now;
                        newUser.LastModifiedDateTime = DateTime.Now;
                        newUser.IsActive = true;
                        newUser.CreatedByID = 1;
                        newUser.LastModifiedByID = 1;
                        userHelper.CreateUser(newUser);
                        MessageBox.Show(this, "System Administrator Successfully Created!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
