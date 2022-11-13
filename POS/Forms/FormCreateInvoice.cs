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
    public partial class FormCreateInvoice : MetroForm
    {
        public Invoice invoice = new Invoice();
        FormInvoice formInvoice;
        InvoiceHelper invoiceHelper = new InvoiceHelper();

        public FormCreateInvoice(FormInvoice formInvoice)
        {
            InitializeComponent();
            this.formInvoice = formInvoice;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearchSupplier_Click(object sender, EventArgs e)
        {
            using (PanelSearchSupplier searchSupplier = new PanelSearchSupplier(this))
            {
                searchSupplier.ShowDialog(this);
                searchSupplier.Dispose();
            }
            txtRefNbr.Select();
        }

        public void InsertSupplier()
        {
            txtSupplier.Text = invoice.Supplier.ToString();
            txtContactPerson.Text = invoice.ContactPerson.ToString();
        }

        public void Init()
        {
            txtCreatedBy.Text = formInvoice.currUser.Fullname.ToString();

            if (btnSave.Text == "SAVE")
            {
                txtRefNbr.Text = invoiceHelper.GetRefNbr();
            }

            grdInvoiceList.Rows.Clear();

            invoice = new Invoice();

            txtContactPerson.Clear();
            txtSupplier.Clear();
            dtTranDate.Value = DateTime.Now;
            lblTotalInvoice.Text = "0.00";
            lblTotalQTY.Text = "0";
            lblTotalQTY.Select();
        }

        private void FormCreateInvoice_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void btnSearchProduct_Click(object sender, EventArgs e)
        {
            using (PanelProducts panelProducts = new PanelProducts(this))
            {
                panelProducts.ShowDialog(this);
                panelProducts.Dispose();
            }

            grdInvoiceList.Select();


        }

        private void grdProductList_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                grdInvoiceList.Rows[e.RowIndex].Cells["SUPPLIERPRICE"].Value = string.Format("{0:#,##0.00}", double.Parse(grdInvoiceList.Rows[e.RowIndex].Cells["SUPPLIERPRICE"].Value.ToString()));
            }

            ComputeTotalPerItem();

        }

        private void ComputeTotalPerItem()
        {
            decimal totalAmt = 0M;
            int totalQty = 0;

            foreach (DataGridViewRow r in grdInvoiceList.Rows)
            {
                grdInvoiceList.Rows[r.Index].Cells["TOTALINVOICE"].Value =
                Convert.ToDecimal(grdInvoiceList.Rows[r.Index].Cells["SUPPLIERPRICE"].Value.ToString()) * Convert.ToInt32(grdInvoiceList.Rows[r.Index].Cells["Qty"].Value);
                grdInvoiceList.Rows[r.Index].Cells["TOTALINVOICE"].Value = string.Format("{0:#,##0.00}", double.Parse(grdInvoiceList.Rows[r.Index].Cells["TOTALINVOICE"].Value.ToString()));
                totalAmt += Convert.ToDecimal(grdInvoiceList.Rows[r.Index].Cells["TOTALINVOICE"].Value);

                totalQty += Convert.ToInt32(grdInvoiceList.Rows[r.Index].Cells["QTY"].Value);

            }
            lblTotalInvoice.Text = string.Format("{0:#,##0.00}", double.Parse(totalAmt.ToString()));
            lblTotalQTY.Text = totalQty.ToString();
        }

        private void grdProductList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grdInvoiceList.Columns[e.ColumnIndex].Name == "DELETE")
            {
                DeleteRow(e.RowIndex);
            }
        }

        private void grdProductList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (grdInvoiceList.ContainsFocus == true && grdInvoiceList.Rows.Count > 0)
                {
                    DeleteRow(grdInvoiceList.CurrentRow.Index);
                }

            }


        }

        private void DeleteRow(int currentIndex)
        {
            if (MessageBox.Show("Remove Selected Row?", "Remove", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                grdInvoiceList.Rows.RemoveAt(currentIndex);
                for (int i = 0; i < grdInvoiceList.Rows.Count; i++)
                {
                    grdInvoiceList.Rows[i].Cells["Count"].Value = i + 1;
                }
                ComputeTotalPerItem();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                if (btnSave.Text == "SAVE")
                {
                    if (invoice.SupplierID == null)
                    {
                        MessageBox.Show("No Supplier Selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (grdInvoiceList.Rows.Count == 0)
                    {
                        MessageBox.Show("No Products Selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (MessageBox.Show(this, "Add this Invoice?", "Invoicing", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {


                            // categoryHelper.LoadCategories(currView, "");

                            invoice.RefNbr = txtRefNbr.Text;
                            invoice.TotalAmt = Convert.ToDecimal(lblTotalInvoice.Text);
                            invoice.TotalQty = Convert.ToInt32(lblTotalQTY.Text);
                            invoice.TransactionDate = dtTranDate.Value;
                            invoice.CreatedByID = formInvoice.currUser.UserID;
                            invoice.CreatedDateTime = DateTime.Now;
                            invoice.LastModifiedByID = formInvoice.currUser.UserID;
                            invoice.LastModifiedDateTime = DateTime.Now;
                            invoiceHelper.CreateInvoice(invoice);

                            foreach (var row in grdInvoiceList.Rows)
                            {

                            }


                            MessageBox.Show(this, "Invoice Successfully Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            Init();
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void grdInvoiceList_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (grdInvoiceList.CurrentCell.ColumnIndex == 3)
            {
                e.Control.KeyPress += new KeyPressEventHandler(grdInvoiceList_KeyPress);
            }
        }

        private void grdInvoiceList_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}


