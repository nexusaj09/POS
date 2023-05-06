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
    public partial class FormCreateDiscount : MetroForm
    {

        public User currUser = new User();
        private DiscountHelper discountHelper = new DiscountHelper();
        private DataGridView grdDiscount = new DataGridView();
        private Discount discount = new Discount();

        public FormCreateDiscount(User currUser, DataGridView dataGrid, Discount discount)
        {
            InitializeComponent();

            this.currUser = currUser;
            this.grdDiscount = dataGrid;
            this.discount = discount;
        }

        private void FormCreateDiscount_Load(object sender, EventArgs e)
        {

            if (discount != null)
            {
                txtDescr.Text = discount.Description;
                txtPercentage.Text = discount.DiscountPercentage.ToString();
            }
            else
            {
                if (txtPercentage.Text == string.Empty)
                {
                    txtPercentage.Text = "0.00";
                }
            }
        }

        private void txtPercentage_Enter(object sender, EventArgs e)
        {
            if (txtPercentage.Text == "0.00")
            {
                txtPercentage.Text = null;
            }
        }

        private void txtPercentage_Leave(object sender, EventArgs e)
        {
            if (txtPercentage.Text != null && txtPercentage.Text != string.Empty)
            {
                txtPercentage.Text = string.Format("{0:#,##0.00}", double.Parse(txtPercentage.Text));
            }
            else
            {
                txtPercentage.Text = "0.00";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnSave.Text == "SAVE")
                {

                    if (MessageBox.Show(this, "Add this Discount?", "Add Discount", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes && (txtDescr.Text != null && txtDescr.Text != string.Empty))
                    {
                        if (discountHelper.IsExisting(txtDescr.Text) == false)
                        {

                            Discount newDiscount = new Discount();

                            newDiscount.Description = txtDescr.Text;
                            newDiscount.DiscountPercentage = string.IsNullOrEmpty(txtPercentage.Text) ? 0 : decimal.Parse(txtPercentage.Text);
                            newDiscount.CreatedByID = currUser.UserID;
                            newDiscount.CreatedDateTime = DateTime.Now;
                            newDiscount.LastModifiedByID = currUser.UserID;
                            newDiscount.LastModifiedDateTime = DateTime.Now;

                            discountHelper.CreateDiscount(newDiscount);

                            MessageBox.Show(this, "New Discount Added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            discountHelper.LoadDiscount(grdDiscount, "");

                            txtDescr.Text = string.Empty;
                            txtPercentage.Text = string.Empty;
                        }
                        else
                            MessageBox.Show("Discount Already Exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtDescr.Select();

                    }
                    else if (txtDescr.Text == null || txtDescr.Text == string.Empty)
                    {
                        MessageBox.Show(this, "Please enter a description!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtDescr.Select();
                    }
                }
                else if (btnSave.Text == "UPDATE")
                {

                    if (MessageBox.Show(this, "Are you sure to update this discount?", "Updating discount", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        discount.Description = txtDescr.Text;
                        discount.DiscountPercentage = string.IsNullOrEmpty(txtPercentage.Text) ? 0 : decimal.Parse(txtPercentage.Text);
                        discount.LastModifiedByID = currUser.UserID;
                        discount.LastModifiedDateTime = DateTime.Now;

                        discountHelper.UpdateDiscount(discount);
                        MessageBox.Show(this, "Discount successfully updated!", "Updated Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        discountHelper.LoadDiscount(grdDiscount, "");
                        this.Close();

                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                txtDescr.Select();
                txtDescr.Focus();
            }
        }

        private void txtPercentage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
