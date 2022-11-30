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
                Init();
            }
        }

        private void FormDiscounts_Load(object sender, EventArgs e)
        {
            discountHelper.LoadDiscount(grdDiscountList, txtSearch.Text);
            Init();

        }

        private void grdDiscountList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grdDiscountList.Columns[e.ColumnIndex].Name == "DELETE")
            {
                DeleteDiscount(e.RowIndex);
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
                    Init();
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            discountHelper.LoadDiscount(grdDiscountList, txtSearch.Text);

            if (grdDiscountList.Rows.Count > 0)
            {
                Init();
            }
        }


        private void grdDiscountList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            var dataGridView = sender as DataGridView;
            if (dataGridView.Rows[e.RowIndex].Selected)
            {
                e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
                // edit: to change the background color:
                e.CellStyle.SelectionBackColor = Color.Coral;
            }
        }

        private void FormDiscounts_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            else if (e.KeyCode == Keys.F1)
            {
                Init();
            }
            else if (e.KeyCode == Keys.Down && txtSearch.ContainsFocus && grdDiscountList.Rows.Count > 0)
            {
                grdDiscountList.Select();
                grdDiscountList.Rows[0].Selected = true;
            }
            else if (e.KeyCode == Keys.Delete && grdDiscountList.ContainsFocus && grdDiscountList.Rows.Count > 0)
            {
                DeleteDiscount(grdDiscountList.CurrentCell.RowIndex);
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

            grdDiscountList.ClearSelection();

            grdDiscountList.CurrentCell = null;
        }

        private void DeleteDiscount(int row)
        {

            if (MessageBox.Show(this, "Are you sure to delete this discount?", "Delete Discount", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                discountHelper.DeleteDiscount(Convert.ToInt32(grdDiscountList[1,row].Value.ToString()));
                discountHelper.LoadDiscount(grdDiscountList, "");
                MessageBox.Show("Discount Successfully Deleted", "Discount Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
