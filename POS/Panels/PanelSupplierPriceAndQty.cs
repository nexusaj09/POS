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
using POS.Forms;

namespace POS.Panels
{
    public partial class PanelSupplierPriceAndQty : MetroForm
    {
       public InvoiceDetail invoice = null;

        public PanelSupplierPriceAndQty(InvoiceDetail invoiceDetail)
        {
            InitializeComponent();
            invoice = invoiceDetail;
        }

        private void txtSupplierPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txtSupplierPrice_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSupplierPrice.Text))
            {
                txtSupplierPrice.Text = string.Format("{0:#,##0.00}", double.Parse(txtSupplierPrice.Text));
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            invoice.SupplierPrice = string.IsNullOrEmpty(txtSupplierPrice.Text) ? 0 : Convert.ToDecimal(txtSupplierPrice.Text);
            invoice.Qty = string.IsNullOrEmpty(txtQty.Text) ? 0 : Convert.ToInt32(txtQty.Text.Replace(",",""));
            this.Close();
        }

        private void txtQty_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtQty.Text))
            {
                txtQty.Text = string.Format("{0:#,###}", int.Parse(txtQty.Text));
            }
        }
    }
}
