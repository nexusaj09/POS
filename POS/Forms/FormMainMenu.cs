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
using POS.Properties;

namespace POS.Forms
{
    public partial class FormMainMenu : Form
    {
        public User currUser = new User();
        private UserHelper userHelper = new UserHelper();
        int count = 0;
        public FormMainMenu(User currentUser)
        {
            InitializeComponent();
            this.currUser = currentUser;
            lblRole.Text = currentUser.Role;
            lblUser.Text = currentUser.Fullname;
        }

        private void FormMainMenu_Load(object sender, EventArgs e)
        {
            Init();
            timer1.Enabled = true;
            promptWarning();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool isOpen = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "FormUsers")
                {
                    isOpen = true;
                    f.BringToFront();
                    break;
                }
            }

            if (isOpen == false)
            {
                FormUsers formUsers = new FormUsers(currUser);
                formUsers.Show(this);

            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to Logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                userHelper.CreateLogoutLog(currUser.UserID);
                MessageBox.Show("Logout Successfully", "Logged Out", MessageBoxButtons.OK, MessageBoxIcon.Information);

                List<Form> openForms = new List<Form>();

                foreach (Form f in Application.OpenForms)
                    openForms.Add(f);

                foreach (Form f in openForms)
                {
                    if (f.Name != "FormInit")
                        f.Close();
                }

                FormInit login = new FormInit();
                login.Show();


            }
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {

            bool isOpen = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "FormCategories")
                {
                    isOpen = true;
                    f.BringToFront();
                    break;
                }
            }

            if (isOpen == false)
            {
                FormCategories formCategories = new FormCategories(currUser);
                formCategories.Show(this);

            }

        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {

            bool isOpen = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "FormSuppliers")
                {
                    isOpen = true;
                    f.BringToFront();
                    break;
                }
            }

            if (isOpen == false)
            {
                FormSuppliers suppliers = new FormSuppliers(currUser);
                suppliers.Show(this);

            }

        }

        private void btnDiscounts_Click(object sender, EventArgs e)
        {

            bool isOpen = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Discount List")
                {
                    isOpen = true;
                    f.BringToFront();
                    break;
                }
            }

            if (isOpen == false)
            {
                FormDiscounts discounts = new FormDiscounts(currUser);
                discounts.Show(this);
            }
        }

        private void btnNotes_Click(object sender, EventArgs e)
        {

            bool isOpen = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "FormNotes")
                {
                    isOpen = true;
                    f.BringToFront();
                    break;
                }
            }

            if (isOpen == false)
            {
                FormNotes notes = new FormNotes(currUser);
                notes.Show(this);

            }


        }

        private void btnUserRoles_Click(object sender, EventArgs e)
        {
            bool isOpen = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "User Roles")
                {
                    isOpen = true;
                    f.BringToFront();
                    break;
                }
            }

            if (isOpen == false)
            {
                FormUserRoles formUserRoles = new FormUserRoles();
                formUserRoles.Show(this);

            }

            //FormUserRoles myForm = new FormUserRoles();
            //myForm.TopLevel = false;
            //myForm.AutoScroll = true;
            //myForm.Dock = DockStyle.Fill;
            //this.pnlShow.Controls.Add(myForm);
            //myForm.Show();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            bool isOpen = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "FormProduct")
                {
                    isOpen = true;
                    f.BringToFront();
                    break;
                }
            }

            if (isOpen == false)
            {
                FormProduct formProduct = new FormProduct(currUser);
                formProduct.Show();
            }

        }

        private void btnDashboard_MouseHover(object sender, EventArgs e)
        {
            btnDashboard.ForeColor = Color.White;
        }

        private void btnDashboard_MouseLeave(object sender, EventArgs e)
        {
            btnDashboard.ForeColor = Color.Black;
        }

        private void btnDashboard_MouseEnter(object sender, EventArgs e)
        {
            btnDashboard.ForeColor = Color.White;
        }


        private void Init()
        {
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnStockInvoice_Click(object sender, EventArgs e)
        {
            bool isOpen = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "FormInvoice")
                {
                    isOpen = true;
                    f.BringToFront();
                    break;
                }
            }

            if (isOpen == false)
            {
                FormInvoice formInvoice = new FormInvoice(currUser);
                formInvoice.Show(this);
            }
        }

        private void btnStockAdjustments_Click(object sender, EventArgs e)
        {

            bool isOpen = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "FormStockAdjustments")
                {
                    isOpen = true;
                    f.BringToFront();
                    break;
                }
            }

            if (isOpen == false)
            {
                FormStockAdjustments form = new FormStockAdjustments(currUser);
                form.Show(this);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {



            //count += 1000;

            //if (count == 3000)
            //{
            //    promptWarning();
            //    count = 0;
            //}

        }



        public void promptWarning()
        {
            var t = new Timer();
            t.Interval = 1000;

            ProductHelper helper = new ProductHelper();

            int lowQty = helper.CountTotalReStockQty();
            int outOfStock = helper.CountTotalOutofStock();
            int expired = helper.CountTotalExpiredStock();


            if (lowQty > 0 || expired > 0 || outOfStock > 0)
            {

            }

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            promptWarning();
        }

        private void btnTransaction_Click(object sender, EventArgs e)
        {
            try
            {
                bool isOpen = false;

                foreach (Form f in Application.OpenForms)
                {
                    if (f.Name == "FormTransaction")
                    {
                        isOpen = true;
                        f.BringToFront();
                        break;
                    }
                }

                if (isOpen == false)
                {
                    FormTransaction form = new FormTransaction(currUser);
                    form.Show();

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
