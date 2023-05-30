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
using POS.Helpers;

namespace POS.Panels
{
    public partial class PanelProducts : MetroForm
    {
        ProductHelper productHelper = new ProductHelper();
        TransactionHelper transactionHelper = new TransactionHelper();
        FormCreateInvoice formCreateInvoice;
        FormTransaction formTransaction;
        bool isFromTransaction;
        int index = 0;        
        public PanelProducts(FormCreateInvoice form)
        {
            InitializeComponent();

            formCreateInvoice = form;

            this.grdProductList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        }

        public PanelProducts(FormTransaction fromTran, bool isTran)
        {
            InitializeComponent();

            formTransaction = fromTran;

            isFromTransaction = isTran;

            this.grdProductList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        }

        private void PanelProducts_Load(object sender, EventArgs e)
        {
            productHelper.LoadProductPanel(this, txtSearch.Text);

            Init();

            this.grdProductList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            productHelper.LoadProductPanel(this, txtSearch.Text);

            if (grdProductList.Rows.Count > 0)
            {
                Init();
            }
        }

        private void grdProductList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!isFromTransaction)
            {
                SelectProduct(e.RowIndex);
            }
            else
            {
                if (e.RowIndex < 0) return;
                SelectProductToTran(e.RowIndex);
            }
        }

        private void SelectProduct(int row)
        {
            bool isFound = false;

            if (formCreateInvoice.grdInvoiceList.Rows.Count == 0)
            {
                AddProduct(row);
            }
            else
            {
                for (int i = 1; i <= formCreateInvoice.grdInvoiceList.Rows.Count; i++)
                {
                    //GridView.Rows[Index].Cells[ColumnName]               // GridView[ColumnIndex,Current Row Index] 
                    if (formCreateInvoice.grdInvoiceList.Rows[i - 1].Cells["PRODUCTCODE"].Value.ToString() == grdProductList[1, row].Value.ToString())
                    {
                        isFound = true;
                        break;
                    }
                    else
                    {
                        isFound = false;
                    }
                }

                if (isFound)
                {
                    MessageBox.Show("Product is already in the list", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    AddProduct(row);

                }
            }
        }

        public void AddProduct(int row)
        {
            index = Convert.ToInt32(formCreateInvoice.grdInvoiceList.Rows.Count);

            InvoiceDetail detail = new InvoiceDetail();

            detail.ProductCode = grdProductList[1, row].Value.ToString();
            detail.Descr = grdProductList[3, row].Value.ToString();

            using (PanelSupplierPriceAndQty panelSupplierPriceAndQty = new PanelSupplierPriceAndQty(detail))
            {
                panelSupplierPriceAndQty.ShowDialog();

                detail = panelSupplierPriceAndQty.invoice;

                panelSupplierPriceAndQty.Dispose();
            }

            detail.TotalPerItem = detail?.SupplierPrice != null && detail?.Qty != null ? detail.SupplierPrice * detail.Qty : 0;

            if (detail.Qty != 0 || detail.SupplierPrice != 0)
            {
                formCreateInvoice.grdInvoiceList.Rows.Add(index += 1, "", detail.ProductCode,
                      detail.Descr, detail.SupplierPrice, detail.Qty, detail.TotalPerItem);

                //    MessageBox.Show("Product Added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                formCreateInvoice.ComputeTotalPerItem();
            }            
        }

        private async void SelectProductToTran(int row)
        {

            string barcode = grdProductList[2, row].Value.ToString();

            Product product = new Product();

            product = transactionHelper.InsertProductToGrid(barcode);

            if (product == null) return;

            formTransaction.AddProduct(product);

            // Add the product discounts here
            await formTransaction.AddProductDiscountsAsync(product.ProductCode);
        }

        private void PanelProducts_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                if (!isFromTransaction)
                {
                    SelectProduct(grdProductList.CurrentCell.RowIndex);
                }
                else
                {
                    SelectProductToTran(grdProductList.CurrentCell.RowIndex);
                }
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Down && txtSearch.ContainsFocus && grdProductList.Rows.Count > 0)
            {

                grdProductList.Select();
                grdProductList.Rows[0].Selected = true;

            }
            else if (e.KeyCode == Keys.F1)
            {
                Init();
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

        public void txtFocus()
        {
            txtSearch.Select();
            txtSearch.Focus();
        }

        public void Init()
        {
            txtFocus();

            grdProductList.ClearSelection();

            grdProductList.CurrentCell = null;
        }

    }
}
