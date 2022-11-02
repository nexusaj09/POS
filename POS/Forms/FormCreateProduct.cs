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
using MessagingToolkit.Barcode;
using POS.Helpers;
using POS.Classes;

namespace POS.Forms
{
    public partial class FormCreateProduct : MetroForm
    {
        public ProductHelper productHelper = new ProductHelper();
        public User currUser = new User();
        FormProduct form = null;
        public Product updateProduct = new Product();

        public FormCreateProduct(FormProduct formProduct, Product product)
        {
            InitializeComponent();

            form = formProduct;
            updateProduct = product;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void txtBarcode_TextChanged(object sender, EventArgs e)
        {


            BarcodeEncoder barcode = new BarcodeEncoder();
            barcode.IncludeLabel = true;

            barcode.CustomLabel = txtBarcode.Text;
            barcode.Height = 80;
            barcode.Width = pictureBox1.Width;
            if (txtBarcode.Text != null && txtBarcode.Text != String.Empty)
            {
                pictureBox1.Image = new Bitmap(barcode.Encode(BarcodeFormat.Code39, txtBarcode.Text));
            }
            else
            {
                pictureBox1.Image = null;

            }
        }

        private void FormCreateProduct_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void txtMarkUp_TextChanged(object sender, EventArgs e)
        {
            decimal price = 0;

            if (txtMarkUp.Text != "" && txtSupplierPrice.Text != "")
            {
                price = Convert.ToDecimal(txtSupplierPrice.Text) * (Convert.ToDecimal(txtMarkUp.Text) / 100);
                txtSRP.Text = Decimal.Round(Convert.ToDecimal(txtSupplierPrice.Text) + price).ToString();
            }
            else
            {
                txtSRP.Text = txtSupplierPrice.Text;
            }

        }

        private void txtSupplierPrice_Leave(object sender, EventArgs e)
        {
            if (txtSupplierPrice.Text != "" && txtMarkUp.Text == "")
            {
                txtSRP.Text = txtSupplierPrice.Text;
            }
        }

        private void txtBarcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtReOrderQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtInitialQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtSupplierPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.';
        }

        private void txtSupplierPrice_TextChanged(object sender, EventArgs e)
        {

            decimal price = 0;

            if (txtMarkUp.Text != "" && txtSupplierPrice.Text != "")
            {
                price = Convert.ToDecimal(txtSupplierPrice.Text) * (Convert.ToDecimal(txtMarkUp.Text) / 100);
                txtSRP.Text = Decimal.Round(Convert.ToDecimal(txtSupplierPrice.Text) + price).ToString();
            }
            else
            {
                txtSRP.Text = txtSupplierPrice.Text;
            }

        }

        private void txtMarkUp_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtFinalPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.';
        }

        private void txtBrandName_TextChanged(object sender, EventArgs e)
        {
            ConcatDescr();
        }

        private void txtGeneric_TextChanged(object sender, EventArgs e)
        {
            ConcatDescr();
        }

        private void txtClass_TextChanged(object sender, EventArgs e)
        {

            ConcatDescr();
        }

        private void txtFormulation_TextChanged(object sender, EventArgs e)
        {
            ConcatDescr();
        }

        private void txtUOM_TextChanged(object sender, EventArgs e)
        {
            ConcatDescr();
        }

        private void ConcatDescr()
        {
            txtDescription.Text = txtBrandName.Text + " " + txtGeneric.Text + " "
                + txtClass.Text + " " + txtFormulation.Text + " " + txtUOM.Text;
        }

        private void btnSaveBarcode_Click(object sender, EventArgs e)
        {
            SaveFileDialog sD = new SaveFileDialog();
            Image img;
            sD.Filter = "PNG File|*.png";
            sD.FileName = txtProductCode.Text;
            if (!string.IsNullOrEmpty(txtBarcode.Text))
            {
                if (sD.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        img = pictureBox1.Image;
                        img.Save(sD.FileName, System.Drawing.Imaging.ImageFormat.Png);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("No Barcode Entered", "Empty Barcode", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtProductCode.Select();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                if (btnSave.Text == "SAVE")
                {
                    if (MessageBox.Show(this, "Add this Product?", "Add Product", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        Product newProduct = new Product();
                        newProduct.ProductBarcode = txtBarcode.Text;
                        newProduct.ProductCode = txtProductCode.Text;
                        newProduct.Description = txtDescription.Text;
                        newProduct.BrandName = txtBrandName.Text;
                        newProduct.GenericName = txtGeneric.Text;
                        newProduct.Classification = txtClass.Text;
                        newProduct.Formulation = txtFormulation.Text;
                        newProduct.Category = cmbCategory.Text;
                        newProduct.UOM = txtUOM.Text;
                        newProduct.ReOrderQty = txtReOrderQty.Text != string.Empty ? Convert.ToInt32(txtReOrderQty.Text) :0 ;
                        newProduct.Qty = txtInitialQty.Text != string.Empty ? Convert.ToInt32(txtInitialQty.Text) : 0;
                        newProduct.SupplierPrice = txtSupplierPrice.Text != string.Empty ? Convert.ToDecimal(txtSupplierPrice.Text) : 0;
                        newProduct.FinalPrice = txtFinalPrice.Text != string.Empty ? Convert.ToDecimal(txtFinalPrice.Text) : 0;
                        newProduct.SRP = txtSRP.Text != string.Empty ? Convert.ToDecimal(txtSRP.Text) : 0;
                        newProduct.MarkUp = txtMarkUp.Text != string.Empty ? Convert.ToInt32(txtMarkUp.Text) : 0;
                        newProduct.CreatedByID = form.currUser.UserID;
                        newProduct.CreatedDateTime = DateTime.Now;
                        newProduct.LastModifiedByID = form.currUser.UserID;
                        newProduct.LastModifiedDateTime = DateTime.Now;

                        productHelper.CreateProduct(newProduct);

                        MessageBox.Show(this, "New Product Added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Clear();

                        form.Init();
                    }
                }
                else if (btnSave.Text == "UPDATE")
                {
                    if (MessageBox.Show(this, "Are you sure to update this product?", "Updating product", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        
                        updateProduct.ProductBarcode = txtBarcode.Text;
                        updateProduct.ProductCode = txtProductCode.Text;
                        updateProduct.Description = txtDescription.Text;
                        updateProduct.BrandName = txtBrandName.Text;
                        updateProduct.GenericName = txtGeneric.Text;
                        updateProduct.Classification = txtClass.Text;
                        updateProduct.Formulation = txtFormulation.Text;
                        updateProduct.Category = cmbCategory.Text;
                        updateProduct.UOM = txtUOM.Text;
                        updateProduct.ReOrderQty = txtReOrderQty.Text != string.Empty ? Convert.ToInt32(txtReOrderQty.Text) : 0;
                        updateProduct.Qty = txtInitialQty.Text != string.Empty ? Convert.ToInt32(txtInitialQty.Text) : 0;
                        updateProduct.SupplierPrice = txtSupplierPrice.Text != string.Empty ? Convert.ToDecimal(txtSupplierPrice.Text) : 0;
                        updateProduct.FinalPrice = txtFinalPrice.Text != string.Empty ? Convert.ToDecimal(txtFinalPrice.Text) : 0;
                        updateProduct.SRP = txtSRP.Text != string.Empty ? Convert.ToDecimal(txtSRP.Text) : 0;
                        updateProduct.MarkUp = txtMarkUp.Text != string.Empty ? Convert.ToInt32(txtMarkUp.Text) : 0;
                        updateProduct.LastModifiedDateTime = DateTime.Now;

                        productHelper.UpdateProduct(updateProduct);

                        MessageBox.Show(this, "Product successfully updated!", "Updated Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        form.Init();
                        this.Close();
                        this.Dispose();

                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            }

        private void Clear()
        {
            txtProductCode.Clear();
            txtBarcode.Clear();
            txtDescription.Clear();
            txtBrandName.Clear();
            txtGeneric.Clear();
            txtClass.Clear();
            txtFormulation.Clear();
            cmbCategory.Text = null;
            txtUOM.Clear();
            txtReOrderQty.Clear();
            txtInitialQty.Clear();
            txtSupplierPrice.Clear();
            txtFinalPrice.Clear();
            txtSRP.Clear();
            txtMarkUp.Clear();
            txtProductCode.Select();
        }

        private void Init()
        {
            productHelper.LoadCategories(cmbCategory);
            cmbCategory.Text = null;
            txtInitialQty.Enabled = btnSave.Text == "SAVE" ? true : false;
            txtProductCode.Enabled = btnSave.Text == "SAVE" ? true : false;

            if (updateProduct != null)
            {
                txtProductCode.Text = updateProduct.ProductCode;
                txtBarcode.Text = updateProduct.ProductBarcode;
                txtDescription.Text = updateProduct.Description;
                txtBrandName.Text = updateProduct.BrandName;
                txtGeneric.Text = updateProduct.GenericName;
                txtClass.Text = updateProduct.Classification;
                txtFormulation.Text = updateProduct.Formulation;
                cmbCategory.Text = updateProduct.Category;
                txtUOM.Text = updateProduct.UOM;
                txtReOrderQty.Text = updateProduct.ReOrderQty.ToString();
                txtInitialQty.Text = updateProduct.Qty.ToString();
                txtSupplierPrice.Text = updateProduct.SupplierPrice.ToString();
                txtFinalPrice.Text = updateProduct.FinalPrice.ToString();
                txtSRP.Text = updateProduct.SRP.ToString();
                txtMarkUp.Text = updateProduct.MarkUp.ToString();
            }

        }
    }
}
