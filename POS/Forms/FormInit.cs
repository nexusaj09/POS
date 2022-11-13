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
using POS.Panels;
namespace POS.Forms
{
    public partial class FormInit : MetroForm
    {
        public User currentUser = new User();
        public UserHelper userHelper = new UserHelper();
        public bool isEstablished = false;
        public FormInit()
        {
            InitializeComponent();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                currentUser = new User();
                currentUser.Username = txtUsername.Text;
                currentUser.Password = txtPassword.Text;

                currentUser = userHelper.UserLogin(currentUser);

                if (currentUser != null)
                {
                    if (currentUser.IsActive)
                    {
                        this.Hide();
                        MessageBox.Show(this, "Welcome " + currentUser.Fullname.ToString(), "Access Granted!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (currentUser.Role == "System Administrator")
                        {
                            FormMainMenu mainMenu = new FormMainMenu(currentUser);
                            mainMenu.Show();
                        }
                        userHelper.CreateLoginLog(currentUser.UserID);
                        //else if (login.Role == "Cashier")
                        //{
                        //    if (!helperPetty.IsPettyCashEntered())
                        //    {
                        //        pettyCash.CreatedByID = login.ID;
                        //        pettyCash.CreatedDateTime = DateTime.Now;
                        //        panelPettyCash panelPettyCash = new panelPettyCash(pettyCash);
                        //        panelPettyCash.ShowDialog();
                        //    }
                        //    frmTransaction transaction = new frmTransaction(login);
                        //    transaction.Show();
                        //}
                    }
                    else
                        MessageBox.Show(this, "User is inactive. ", "Inactive User!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    MessageBox.Show(this, "User Doesn't Exisit", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsername.Focus();
                    txtUsername.Select();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtPassword.Text == string.Empty)
                {
                    txtPassword.Focus();
                }
                else
                {
                    btnLogin.PerformClick();
                }
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }

        private void FormInit_Load(object sender, EventArgs e)
        {
            this.BringToFront();
            this.Activate();

            isEstablished = userHelper.DisplayConnSetup();

            if (isEstablished == true)
            {

                InitialSetup();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FormDatabaseConnection frmDatabaseConn = new FormDatabaseConnection(this);
            frmDatabaseConn.ShowDialog(this);

            txtUsername.Select();

            if (isEstablished == true)
            {
                InitialSetup();
            }
        }

        public void InitialSetup()
        {
            if (userHelper.UserCount() == 0)
            {
                PanelCreateAdmin createAdmin = new PanelCreateAdmin();
                createAdmin.ShowDialog();
            }
        }

    }
}
