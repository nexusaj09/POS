﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using POS.Helpers;
using POS.Classes;
using System.Drawing;
using BarcodeLib;
using POS.Models;
using POS.Repositories;

namespace POS.Forms
{
    public partial class FormCreateProduct : MetroForm
    {
        public ProductHelper productHelper = new ProductHelper();
        public User currUser = new User();
        FormProduct form = null;
        public Product updateProduct = new Product();
        bool isBarcodeExisting = false;
        bool isProductCodeExisting = false;
        bool isSkip = false;
        bool fromInvoice = false;

        public FormCreateProduct(FormProduct formProduct, Product product, User user)
        {
            InitializeComponent();

            form = formProduct;
            updateProduct = product;
            currUser = user;
        }

        public FormCreateProduct(User user, bool inv)
        {
            InitializeComponent();

            currUser = user;
            fromInvoice = inv;
        }

        private async void FormCreateProduct_Load(object sender, EventArgs e)
        {
            await Init();
        }

        private void FormCreateProduct_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (txtProductCode.Text != String.Empty && isSkip == false)
            {
                if (MessageBox.Show("Are you sure to leave this form?", "Leaving", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    e.Cancel = false;
                }
                else
                {
                    e.Cancel = true;
                    txtProductCode.Select();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBarcode_TextChanged(object sender, EventArgs e)
        {
            Barcode barcode = new Barcode();
            barcode.IncludeLabel = true;

            barcode.Height = (int)(pictureBox1.Height * 0.8);
            barcode.Width = (int)(pictureBox1.Width * 0.8);
            if (txtBarcode.Text != null && txtBarcode.Text != String.Empty)
            {
                pictureBox1.Image = new Bitmap(barcode.Encode(TYPE.CODE39, txtBarcode.Text));
            }
            else
            {
                pictureBox1.Image = null;

            }
        }

        private void txtMarkUp_TextChanged(object sender, EventArgs e)
        {
            decimal price = 0;

            if (txtMarkUp.Text != "" && txtSupplierPrice.Text != "")
            {
                price = Convert.ToDecimal(txtSupplierPrice.Text) * (Convert.ToDecimal(txtMarkUp.Text) / 100);
                txtSRP.Text = Decimal.Ceiling(Convert.ToDecimal(txtSupplierPrice.Text) + price).ToString();
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
                txtSRP.Text = Decimal.Ceiling(Convert.ToDecimal(txtSupplierPrice.Text) + price).ToString();
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
                txtBarcode.Select();
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnSave.Text == "SAVE")
                {
                    if (MessageBox.Show(this, "Add this Product?", "Add Product", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        if (!string.IsNullOrEmpty(txtProductCode.Text))
                        {
                            var newProduct = GenerateNewProduct();
                            var productDiscounts = productDiscountBindingSource.DataSource as IList<ProductDiscount>;

                            productHelper.CreateProduct(newProduct);
                            var prodDiscountRepo = new ProductDiscountRepository();
                            await prodDiscountRepo.BulkSaveProductDiscoutAsync(productDiscounts);

                            MessageBox.Show(this, "New Product Added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            Clear();
                            if (fromInvoice == false)
                            {
                                form.Init();
                            }
                        }
                        else
                        {
                            MessageBox.Show("No Product Code Entered", "Empty Product Code", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtProductCode.Select();
                        }                   
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
                        updateProduct.LastModifiedByID = currUser.UserID;
                        updateProduct.ExpirationDate = dtExpirationDate.Value;
                        updateProduct.IsExpiring = chckWithExpiry.Checked;
                        updateProduct.Location = txtLocation.Text;
                        productHelper.UpdateProduct(updateProduct);

                        MessageBox.Show(this, "Product successfully updated!", "Updated Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        form.Init();

                        isSkip = true;

                        this.Close();
                    }
                }
            }
            catch (Exception ex)
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
            txtProductCode.Focus();
            isBarcodeExisting = false;
            isProductCodeExisting = false;
            dtExpirationDate.Value = DateTime.Now;
            chckWithExpiry.Checked = false;
            txtLocation.Clear();

            cmbDiscounts.SelectedIndex = -1;
            productDiscountBindingSource.Clear();
        }

        private async Task Init()
        {
            productHelper.LoadCategories(cmbCategory);
            cmbCategory.Text = null;
            txtInitialQty.Enabled = btnSave.Text == "SAVE" ? true : false;
            txtProductCode.Enabled = btnSave.Text == "SAVE" ? true : false;
            dtExpirationDate.Enabled = false;

            // Get list of available discounts
            await GetAvailableDiscountsAsync();

            if (updateProduct != null && updateProduct.ProductCode != null && btnSave.Visible == true)
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

                dtExpirationDate.Value = dtExpirationDate.Value == null  ? updateProduct.ExpirationDate: DateTime.Now;
                txtLocation.Text = updateProduct.Location.ToString();
                chckWithExpiry.Checked = updateProduct.IsExpiring;
                dtExpirationDate.Enabled = updateProduct.IsExpiring;

                await InitProductDiscountsAsync();
            }
        }

        protected async Task InitProductDiscountsAsync()
        {
            var productDiscounts = await productHelper.GetProductDiscountsAsync(txtProductCode.Text);
            if (productDiscounts.Any())
            {
                productDiscountBindingSource.DataSource = productDiscounts;
                grdProductDiscount.ClearSelection();
            }
        }

        protected async Task GetAvailableDiscountsAsync()
        {
            var discountHelper = new DiscountHelper();
            var dpDiscounts = await discountHelper.GetDiscountsAsync();
            cmbDiscounts.DataSource = dpDiscounts;
            cmbDiscounts.DisplayMember = "DisplayName";
            cmbDiscounts.ValueMember = "ID";
            cmbDiscounts.SelectedIndex = -1;
        }

        private void txtProductCode_Leave(object sender, EventArgs e)
        {
            try
            {
                isProductCodeExisting = productHelper.IsExisting(txtProductCode.Text);

                if (isProductCodeExisting && btnSave.Text == "SAVE")
                {
                    MessageBox.Show("Product Code Already Exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnSave.Enabled = false;
                    txtProductCode.Focus();
                }
                else if (isBarcodeExisting && btnSave.Text == "SAVE")
                {
                    btnSave.Enabled = false;
                }
                else
                {
                    btnSave.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtBarcode_Leave(object sender, EventArgs e)
        {
            try
            {
                isBarcodeExisting = productHelper.IsExistingBarcode(txtBarcode.Text);

                if (txtBarcode.Text != "" && isBarcodeExisting && btnSave.Text == "SAVE")
                {
                    MessageBox.Show("Barcode Already Exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtBarcode.Focus();
                    btnSave.Enabled = false;
                }
                else if (isProductCodeExisting && btnSave.Text == "SAVE")
                {
                    btnSave.Enabled = false;
                }
                else
                {
                    btnSave.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void chckWithExpiry_CheckedChanged(object sender, EventArgs e)
        {
            dtExpirationDate.Enabled = chckWithExpiry.Checked == true ? true : false;
        }

        private void grdProductDiscount_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var dataGridView = sender as DataGridView;
            if (dataGridView.Rows[e.RowIndex].Selected)
            {
                e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
                //   edit: to change the background color:
                e.CellStyle.SelectionBackColor = Color.Coral;
            }
        }

        private async void btnAddDiscount_Click(object sender, EventArgs e)
        {
            if (cmbDiscounts.SelectedValue == null)
            {
                MessageBox.Show("Please select a discount to apply for this product.", "Select a discount...", MessageBoxButtons.OK);
                return;
            }

            var discounts = cmbDiscounts.DataSource as List<Discount>;
            var selectedDiscount = discounts[cmbDiscounts.SelectedIndex];
            
            var productDiscount = GenerateProductDiscount(selectedDiscount);

            if (updateProduct != null)
            {
                // if product is being updated and want to add a discount,
                // add it directly to db table
                var prodDiscountRepo = new ProductDiscountRepository();
                await prodDiscountRepo.SaveProductDiscountAsync(productDiscount);

                await InitProductDiscountsAsync();
            }
            else
            {
                var productDiscounts = GetProductDiscountDataSource();
                productDiscounts.Add(productDiscount);

                productDiscountBindingSource.DataSource = productDiscounts.ToList();
                grdProductDiscount.ClearSelection();
            }
            
            cmbDiscounts.SelectedIndex = -1;
            cmbDiscounts.Focus();
        }

        private async void grdProductDiscount_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grdProductDiscount.Columns[e.ColumnIndex].Name == "RemoveAction")
            {
                var productDiscounts = productDiscountBindingSource.DataSource as IList<ProductDiscount>;
                var productDiscount = productDiscounts[e.RowIndex];

                if (updateProduct != null)
                {
                    var prodDiscountRepo = new ProductDiscountRepository();
                    await prodDiscountRepo.RemoveProductDiscountAsync(productDiscount.Id);
                }

                productDiscountBindingSource.Remove(productDiscount);
                grdProductDiscount.ClearSelection();
            }
        }

        private Product GenerateNewProduct()
        {
            var product = new Product
            {
                ProductBarcode = txtBarcode.Text,
                ProductCode = txtProductCode.Text,
                Description = txtDescription.Text,
                BrandName = txtBrandName.Text,
                GenericName = txtGeneric.Text,
                Classification = txtClass.Text,
                Formulation = txtFormulation.Text,
                Category = cmbCategory.Text,
                UOM = txtUOM.Text,
                ReOrderQty = txtReOrderQty.Text != string.Empty ? Convert.ToInt32(txtReOrderQty.Text) : 0,
                Qty = txtInitialQty.Text != string.Empty ? Convert.ToInt32(txtInitialQty.Text) : 0,
                SupplierPrice = txtSupplierPrice.Text != string.Empty ? Convert.ToDecimal(txtSupplierPrice.Text) : 0,
                FinalPrice = txtFinalPrice.Text != string.Empty ? Convert.ToDecimal(txtFinalPrice.Text) : 0,
                SRP = txtSRP.Text != string.Empty ? Convert.ToDecimal(txtSRP.Text) : 0,
                MarkUp = txtMarkUp.Text != string.Empty ? Convert.ToInt32(txtMarkUp.Text) : 0,
                ExpirationDate = dtExpirationDate.Value,
                IsExpiring = chckWithExpiry.Checked,
                Location = txtLocation.Text,
                CreatedByID = fromInvoice == false ? form.currUser.UserID : currUser.UserID,
                CreatedDateTime = DateTime.Now,
                LastModifiedByID = fromInvoice == false ? form.currUser.UserID : currUser.UserID,
                LastModifiedDateTime = DateTime.Now
            };

            return product;
        }

        private ProductDiscount GenerateProductDiscount(Discount discount)
        {
            var productDiscount = new ProductDiscount
            {
                ProductCode = txtProductCode.Text,
                DiscountID = discount.ID,
                DiscountDescription = discount.Description,
                DiscountPercentage = discount.DiscountPercentage,
                RemoveAction = "Remove",
                CreatedByID = currUser.UserID
            };

            return productDiscount;
        }

        private IList<ProductDiscount> GetProductDiscountDataSource()
        {
            var productDiscounts = productDiscountBindingSource.DataSource as IList<ProductDiscount>;
            if (productDiscounts is null || !productDiscounts.Any())
                productDiscounts = new List<ProductDiscount>();

            return productDiscounts;
        }
    }
}