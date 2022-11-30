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
    public partial class FormInvoice : MetroForm
    {
        public User currUser = new User();
        public InvoiceHelper invoiceHelper = new InvoiceHelper();
        public FormInvoice(User user)
        {
            InitializeComponent();

            currUser = user;

        }



        public void txtFocus()
        {
            txtSearch.Select();
            txtSearch.Focus();
        }

        private void FormInvoice_Load(object sender, EventArgs e)
        {
            invoiceHelper.LoadInvoices(this, "");

            Init();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            using (FormCreateInvoice formCreateInvoice = new FormCreateInvoice(this))
            {
                formCreateInvoice.invoice = null;
                formCreateInvoice.ShowDialog(this);
                formCreateInvoice.Dispose();
                txtSearch.Select();
            }
        }

        private void grdProductList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var dataGridView = sender as DataGridView;
            if (dataGridView.Rows[e.RowIndex].Selected)
            {
                e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
                // edit: to change the background color:
                e.CellStyle.SelectionBackColor = Color.Coral;
            }
        }

        private void FormInvoice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                Init();

            }
            else if (e.KeyCode == Keys.Down && txtSearch.ContainsFocus && grdInvoiceList.Rows.Count > 0)
            {

                grdInvoiceList.Select();
                grdInvoiceList.Rows[0].Selected = true;

            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            else if (e.KeyCode == Keys.Enter && grdInvoiceList.ContainsFocus)
            {
                SelectInvoice(grdInvoiceList.CurrentCell.RowIndex);
                e.Handled = true;
            }
        }

        public void Init()
        {
            txtFocus();

            grdInvoiceList.ClearSelection();

            grdInvoiceList.CurrentCell = null;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            invoiceHelper.LoadInvoices(this, txtSearch.Text);

            if (grdInvoiceList.Rows.Count > 0)
            {
                Init();
            }
        }

        private void grdInvoiceList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grdInvoiceList.Columns[e.ColumnIndex].Name == "VIEW")
            {
                SelectInvoice(e.RowIndex);
            }
        }

        private void SelectInvoice(int row)
        {
            using (FormCreateInvoice formCreateInvoice = new FormCreateInvoice(this))
            {
                formCreateInvoice.invoice.RefNbr = grdInvoiceList[1, row].Value.ToString();
                formCreateInvoice.invoice.Supplier = grdInvoiceList[2, row].Value.ToString();
                formCreateInvoice.invoice.ContactPerson = grdInvoiceList[3, row].Value.ToString();
                formCreateInvoice.invoice.CreatedBy = grdInvoiceList[4, row].Value.ToString();
                formCreateInvoice.invoice.TransactionDate = Convert.ToDateTime(grdInvoiceList[5, row].Value.ToString());
                formCreateInvoice.invoice.TotalQty = Convert.ToInt32(grdInvoiceList[6, row].Value.ToString());
                formCreateInvoice.invoice.TotalAmt = Convert.ToDecimal(grdInvoiceList[7, row].Value.ToString());
                formCreateInvoice.ShowDialog(this);
                formCreateInvoice.Dispose();

                Init();

            }
        }
    }
}
