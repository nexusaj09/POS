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
        FormInit formInit  = new FormInit();
        public FormDatabaseConnection(FormInit form)
        {
            InitializeComponent();
            formInit = form;
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
            if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtServerName.Text) || string.IsNullOrEmpty(txtPassword.Text) || string.IsNullOrEmpty(txtDatabaseName.Text))
            {
                MessageBox.Show("Fill up all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                dbcon.user = txtUsername.Text;
                dbcon.password = txtPassword.Text;
                dbcon.dataSource = txtServerName.Text;
                dbcon.initialCatalog = txtDatabaseName.Text;

                if (dbcon.SaveConnectionStringRegistry() == true)
                {
                    MessageBox.Show("Connection Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Clear();

                    formInit.isEstablished = true;

                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Connection Error", "Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    formInit.isEstablished = false;

                    Clear();
                }
            }

        }
        private void Clear()
        {
            txtDatabaseName.Clear();
            txtPassword.Clear();
            txtServerName.Clear();
            txtUsername.Clear();
        }
    }
}
