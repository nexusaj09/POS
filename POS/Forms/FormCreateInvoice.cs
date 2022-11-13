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

            if (invoice == null)
            {
                txtRefNbr.Text = invoiceHelper.GetRefNbr();
                txtCreatedBy.Text = formInvoice.currUser.Fullname.ToString();


                grdInvoiceList.Rows.Clear();

                invoice = new Invoice();

                txtContactPerson.Clear();
                txtSupplier.Clear();
                dtTranDate.Value = DateTime.Now;
                lblTotalInvoice.Text = "0.00";
                lblTotalQTY.Text = "0";
                lblTotalQTY.Select();
            }
            else
            {
                txtRefNbr.Text = invoice.RefNbr.ToString();
                txtContactPerson.Text = invoice.ContactPerson.ToString();
                txtCreatedBy.Text = invoice.CreatedBy.ToString();
                txtSupplier.Text = invoice.Supplier.ToString();
                dtTranDate.Value = invoice.TransactionDate;

                lblTotalInvoice.Text = invoice.TotalAmt.ToString();
                lblTotalQTY.Text = invoice.TotalQty.ToString();

                dtTranDate.Enabled = false;
                txtContactPerson.Enabled = false;
                btnSave.Visible = false;
                btnSearchProduct.Enabled = false;
                btnSearchSupplier.Enabled = false;
                lblTotalInvoice.Select();

                grdInvoiceList.Enabled = false;

                invoiceHelper.LoadInvoiceDetail(this, invoice.RefNbr.ToString());

                grdInvoiceList.ClearSelection();

                grdInvoiceList.CurrentCell = null;

                grdInvoiceList.Columns[7].Visible = false;

            }
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
            if (e.ColumnIndex == 4)
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
            bool isSuccess = false;

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

                            foreach (DataGridViewRow row in grdInvoiceList.Rows)
                            {
                                InvoiceDetail detail = new InvoiceDetail();
                                detail.RefNbr = txtRefNbr.Text;
                                detail.ProductCode = grdInvoiceList.Rows[row.Index].Cells[2].Value.ToString();
                                detail.SupplierPrice = Convert.ToDecimal(grdInvoiceList.Rows[row.Index].Cells[4].Value.ToString());
                                detail.Qty = Convert.ToInt32(grdInvoiceList.Rows[row.Index].Cells[5].Value.ToString());
                                detail.TotalPerItem = Convert.ToDecimal(grdInvoiceList.Rows[row.Index].Cells[6].Value.ToString());
                                detail.CreatedByID = formInvoice.currUser.UserID;
                                detail.CreatedDateTime = DateTime.Now;
                                detail.LastModifiedByID = formInvoice.currUser.UserID;
                                detail.LastModifiedDateTime = DateTime.Now;

                                isSuccess = invoiceHelper.CreateInvoiceDetail(detail);

                                if (isSuccess)
                                {
                                    invoiceHelper.UpdateProduct(detail);
                                }
                            }


                            MessageBox.Show(this, "Invoice Successfully Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            invoice = null;

                            Init();

                            invoiceHelper.LoadInvoices(formInvoice, "");

                            formInvoice.Init();
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


