using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using POS.Classes;
using POS.Helpers;
using POS.Panels;
using POS.Properties;

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
            Application.Exit();
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

                            promptWarning();


                            FormMainMenu mainMenu = new FormMainMenu(currentUser);
                            mainMenu.Show();
                        }
               
                        else if (currentUser.Role == "Cashier")
                        {
                          
                            FormTransaction transaction = new FormTransaction(currentUser);
                            transaction.Show();
                        }

                        userHelper.CreateLoginLog(currentUser.UserID);
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
            else
            {
                FormDatabaseConnection formDatabaseConnection = new FormDatabaseConnection(this);
                formDatabaseConnection.ShowDialog();
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

        public void promptWarning()
        {
            var t = new Timer();
            t.Interval = 10000;

            ProductHelper helper = new ProductHelper();

            int lowQty = helper.CountTotalReStockQty();
            int outOfStock = helper.CountTotalOutofStock();
            int expired = helper.CountTotalExpiredStock();


            if (lowQty > 0 || expired > 0 || outOfStock > 0)
            {
                notifyIcon1.Icon = Resources.pos_terminal;
                notifyIcon1.Text = "POS NOTIFICATION";
                notifyIcon1.Visible = true;
                notifyIcon1.BalloonTipTitle = "POS NOTIFICATION";
                notifyIcon1.BalloonTipText = string.Format("LOW QUANTITY: {0}\nOUT OF STOCK: {1}\nEXPIRED PRODUCTS {2}", lowQty.ToString(), outOfStock.ToString(), expired.ToString());
                notifyIcon1.ShowBalloonTip(100);

                t.Tick += (s, a) =>
                {
                    notifyIcon1.Dispose();
                    t.Stop();
                };

                t.Start();
            }

        }
    }
}
