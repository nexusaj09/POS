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

namespace POS.Forms
{
    public partial class FormInit : MetroForm
    {
        public FormInit()
        {
            InitializeComponent();
        }

        private void FormInit_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            FormDatabaseConnection frmDatabaseConn = new FormDatabaseConnection();
            frmDatabaseConn.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            FormMainMenu formMainMenu = new FormMainMenu();
            formMainMenu.Show();
            this.Hide();

        }
    }
}
