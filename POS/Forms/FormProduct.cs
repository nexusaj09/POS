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
            FormCreateProduct formCreateProduct = new FormCreateProduct(this,null);
            formCreateProduct.ShowDialog();
            txtSearch.Select();
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
            grdProductList.ClearSelection();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            productHelper.LoadProducts(this, txtSearch.Text);
        }

        private void grdProductList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grdProductList.Columns[e.ColumnIndex].Name == "DELETE")
            {
                if (MessageBox.Show(this, "Are you sure to delete this product?", "Delete Product", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    productHelper.DeleteProdut(Convert.ToInt32(grdProductList[1, e.RowIndex].Value.ToString()));
                    Init();
                    MessageBox.Show("Product Successfully Deleted", "Product Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (grdProductList.Columns[e.ColumnIndex].Name == "EDIT")
            {
                Product updateProduct = new Product();
                updateProduct.ID = Convert.ToInt32(grdProductList[1, e.RowIndex].Value.ToString());
                updateProduct.ProductCode = grdProductList[2, e.RowIndex].Value.ToString();
                updateProduct.ProductBarcode = grdProductList[3, e.RowIndex].Value.ToString();
                updateProduct.Description = grdProductList[4, e.RowIndex].Value.ToString();
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

                FormCreateProduct form = new FormCreateProduct(this, updateProduct);
                form.btnSave.Text = "UPDATE";
                form.ShowDialog();
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            PanelImportProduct panelImport = new PanelImportProduct(currUser);
            panelImport.Show();
        }
    }
}
