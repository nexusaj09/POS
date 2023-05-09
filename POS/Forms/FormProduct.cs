using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
    public partial class FormProduct : MetroForm
    {
        public User currUser = new User();
        public ProductHelper productHelper = new ProductHelper();
        public FormProduct(User user)
        {
            InitializeComponent();

            currUser = user;
        }

        private void FormProduct_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            using (FormCreateProduct formCreateProduct = new FormCreateProduct(this, null, currUser))
            {
                formCreateProduct.ShowDialog(this);
                formCreateProduct.Dispose();
                txtSearch.Select();
            }
        }


        public void Init()
        {
            txtSearch.Select();
            txtSearch.Focus();
            productHelper.LoadProducts(this, "");
            lblTotalProducts.Text = productHelper.CountProducts().ToString();
            lblStockOnHand.Text = productHelper.CountTotalProducts().ToString();
            lblUnderStock.Text = productHelper.CountTotalReStockQty().ToString();
            lblOutOfStock.Text = productHelper.CountTotalOutofStock().ToString();
            lblExpired.Text = productHelper.CountTotalExpiredStock().ToString();
            grdProductList.ClearSelection();
            grdProductList.CurrentCell = null;
        }


        private void grdProductList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grdProductList.Columns[e.ColumnIndex].Name == "DELETE")
            {
                DeleteProduct(e.RowIndex);
            }
            else if (grdProductList.Columns[e.ColumnIndex].Name == "EDIT")
            {
                Product updateProduct = new Product();
                updateProduct.ProductCode = grdProductList[1, e.RowIndex].Value.ToString();
                updateProduct.ProductBarcode = grdProductList[2, e.RowIndex].Value.ToString();
                updateProduct.Description = grdProductList[3, e.RowIndex].Value.ToString();
                updateProduct.Location = grdProductList[4, e.RowIndex].Value.ToString();
                updateProduct.BrandName = grdProductList[5, e.RowIndex].Value.ToString();
                updateProduct.GenericName = grdProductList[6, e.RowIndex].Value.ToString();
                updateProduct.Classification = grdProductList[7, e.RowIndex].Value.ToString();
                updateProduct.Formulation = grdProductList[8, e.RowIndex].Value.ToString();
                updateProduct.Category = grdProductList[9, e.RowIndex].Value.ToString();
                updateProduct.UOM = grdProductList[10, e.RowIndex].Value.ToString();
                updateProduct.Qty = Convert.ToInt32(grdProductList[11, e.RowIndex].Value.ToString());
                updateProduct.ReOrderQty = Convert.ToInt32(grdProductList[12, e.RowIndex].Value.ToString());
                updateProduct.SupplierPrice = Convert.ToDecimal(grdProductList[13, e.RowIndex].Value.ToString());
                updateProduct.SRP = Convert.ToDecimal(grdProductList[14, e.RowIndex].Value.ToString());
                updateProduct.FinalPrice = Convert.ToDecimal(grdProductList[15, e.RowIndex].Value.ToString());
                updateProduct.MarkUp = Convert.ToInt32(grdProductList[16, e.RowIndex].Value.ToString());
                updateProduct.LastModifiedByID = currUser.UserID;
                if (!string.IsNullOrEmpty(grdProductList[17, e.RowIndex].Value.ToString()))
                {
                    DateTime expDate = Convert.ToDateTime(grdProductList[17, e.RowIndex].Value.ToString());
                    var finalExpDate = expDate.ToShortDateString();
                    updateProduct.ExpirationDate = DateTime.ParseExact(finalExpDate, @"dd/MM/yyyy", CultureInfo.CreateSpecificCulture("en-GB"));
                }
                updateProduct.IsExpiring = Convert.ToBoolean(grdProductList[18, e.RowIndex].Value);
                FormCreateProduct form = new FormCreateProduct(this, updateProduct, currUser);
                form.btnSave.Text = "UPDATE";
                form.ShowDialog(this);
                form.Dispose();
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {

            using (PanelImportProduct panelImport = new PanelImportProduct(currUser))
            {
                panelImport.ShowDialog(this);
                panelImport.Dispose();
                txtSearch.Select();
            }
        }

        private void grdProductList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var dataGridView = sender as DataGridView;
            if (dataGridView.Rows[e.RowIndex].Selected)
            {
                e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
                //   edit: to change the background color:
                e.CellStyle.SelectionBackColor = Color.Coral;
            }
        }

        private void FormProduct_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                Init();

            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            else if (e.KeyCode == Keys.Down && txtSearch.ContainsFocus == true && grdProductList.Rows.Count > 0)
            {
                grdProductList.Select();
                grdProductList.Rows[0].Selected = true;

            }
            else if (e.KeyCode == Keys.Delete && grdProductList.Rows.Count > 0 && grdProductList.ContainsFocus)
            {
                DeleteProduct(grdProductList.CurrentCell.RowIndex);
            }
            else if (e.KeyCode == Keys.Enter && grdProductList.ContainsFocus)
            {
                if (grdProductList.CurrentCell == null) return;

                ViewInvoicePrices(grdProductList.CurrentCell.RowIndex);

                e.Handled = true;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            productHelper.LoadProducts(this, txtSearch.Text);

            if (grdProductList.Rows.Count > 0)
            {
                grdProductList.ClearSelection();
                grdProductList.CurrentCell = null;
            }
        }
        private void DeleteProduct(int row)
        {
            if (MessageBox.Show(this, "Are you sure to delete this product?", "Delete Product", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                productHelper.DeleteProduct(grdProductList[1, row].Value.ToString());
                Init();
                MessageBox.Show("Product Successfully Deleted", "Product Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void grdProductList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {


            if (e.RowIndex < 0) return;

            ViewInvoicePrices(e.RowIndex);

        }

        private void ViewInvoicePrices(int row)
        {
            string productCode = grdProductList[1, row].Value.ToString();
            using (PanelSupplierPrice form = new PanelSupplierPrice(productCode))
            {
                form.ShowDialog(this);
                form.Dispose();
                Init();
            }
        }
    }
}
