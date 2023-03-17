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
using MetroFramework;
using POS.Classes;

namespace POS.Panels
{
    public partial class PanelPettyCash : MetroForm
    {
        User currUser = new User();

        public PanelPettyCash(User user)
        {
            this.currUser = user;
            InitializeComponent();

        }

        private void PanelPettyCash_Load(object sender, EventArgs e)
        {

        }

        private void txtPettyCash_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.';

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtGCashPettyCash_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.';

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtPettyCash_Enter(object sender, EventArgs e)
        {
            if (txtPettyCash.Text.Equals("0.00"))
            {
                txtPettyCash.Text = null;
            }
        }

        private void txtGCashPettyCash_Enter(object sender, EventArgs e)
        {
            if (txtGCashPettyCash.Text.Equals("0.00"))
            {
                txtGCashPettyCash.Text = null;
            }
        }

        private void txtPettyCash_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPettyCash.Text))
            {
                txtPettyCash.Text = string.Format("{0:#,##0.00}", double.Parse(txtPettyCash.Text));
            }
            else
            {
                txtPettyCash.Text = "0.00";
            }
        }

        private void txtGCashPettyCash_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtGCashPettyCash.Text))
            {
                txtGCashPettyCash.Text = string.Format("{0:#,##0.00}", double.Parse(txtGCashPettyCash.Text));
            }
            else
            {
                txtGCashPettyCash.Text = "0.00";
            }

        }
    }
}
