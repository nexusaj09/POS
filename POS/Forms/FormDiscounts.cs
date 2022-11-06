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
    public partial class FormDiscounts : MetroForm
    {
        public User currUser = new User();
        private DiscountHelper discountHelper = new DiscountHelper();

        public FormDiscounts(User currUser)
        {
            InitializeComponent();

            this.currUser = currUser;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

            using (FormCreateDiscount createDiscount = new FormCreateDiscount(currUser, grdDiscountList, null))
            {
                createDiscount.ShowDialog(this);
                createDiscount.Dispose();
                txtSearch.Select();
            }
        }

        private void FormDiscounts_Load(object sender, EventArgs e)
        {
            discountHelper.LoadDiscount(grdDiscountList, txtSearch.Text);
            txtSearch.Select();
            txtSearch.Focus();

        }

        private void grdDiscountList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grdDiscountList.Columns[e.ColumnIndex].Name == "DELETE")
            {
                if (MessageBox.Show(this, "Are you sure to delete this discount?", "Delete Discount", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    discountHelper.DeleteDiscount(Convert.ToInt32(grdDiscountList[1, e.RowIndex].Value.ToString()));
                    discountHelper.LoadDiscount(grdDiscountList, "");
                    MessageBox.Show("Discount Successfully Deleted", "Discount Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (grdDiscountList.Columns[e.ColumnIndex].Name == "EDIT")
            {
                Discount updateDiscount = new Discount();
                updateDiscount.ID = Convert.ToInt32(grdDiscountList[1, e.RowIndex].Value.ToString());
                updateDiscount.Description = grdDiscountList[2, e.RowIndex].Value.ToString();
                updateDiscount.DiscountPercentage = grdDiscountList[3, e.RowIndex].Value.ToString();

                using (FormCreateDiscount createDiscount = new FormCreateDiscount(currUser, grdDiscountList, updateDiscount))
                {
                    createDiscount.btnSave.Text = "UPDATE";
                    createDiscount.ShowDialog(this);
                    createDiscount.Dispose();
                    txtSearch.Select();
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            discountHelper.LoadDiscount(grdDiscountList, txtSearch.Text);
        }
    }
}
