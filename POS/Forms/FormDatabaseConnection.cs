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
using POS.Helpers;

namespace POS.Forms
{
    public partial class FormDatabaseConnection : MetroForm
    {

        DatabaseConnection dbcon = new DatabaseConnection();

        public FormDatabaseConnection()
        {
            InitializeComponent();
        }

        private void FormDatabaseConnection_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnCheckConnection_Click(object sender, EventArgs e)
        {
            dbcon.user = txtUsername.Text;
            dbcon.password = txtPassword.Text;
            dbcon.dataSource = txtServerName.Text;
            dbcon.initialCatalog = txtDatabaseName.Text;
            if (dbcon.SaveConnectionStringRegistry() == true)
            {
                MessageBox.Show("Connection Successful", "Success", MessageBoxButtons.OK,MessageBoxIcon.Information);
                txtDatabaseName.Text = null;
                txtPassword.Text = null;
                txtServerName.Text = null;
                txtUsername.Text = null;
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Connection Error","Unsuccessful", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
