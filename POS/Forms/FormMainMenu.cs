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
    public partial class FormMainMenu : Form
    {
        public User currUser = new User();
        private UserHelper userHelper = new UserHelper();
        public FormMainMenu(User currentUser)
        {
            InitializeComponent();
            this.currUser = currentUser;
            lblRole.Text = currentUser.Role;
            lblUser.Text = currentUser.Fullname;
        }

        private void FormMainMenu_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormUsers formUsers = new FormUsers(currUser);
            formUsers.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to Logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                userHelper.CreateLogoutLog(currUser.UserID);
                MessageBox.Show("Logout Successfully", "Logged Out", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();

            }
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            FormCategories formCategories = new FormCategories(currUser);
            formCategories.Show();
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            FormSuppliers suppliers = new FormSuppliers(currUser);
            suppliers.Show();
        }

        private void btnDiscounts_Click(object sender, EventArgs e)
        {
            FormDiscounts discounts = new FormDiscounts();
            discounts.Show();
        }
    }
}
