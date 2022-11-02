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
    public partial class FormCategories : MetroForm
    {
        public User currUser = new User();
        private CategoryHelper cateroryHelper = new CategoryHelper();

        public FormCategories(User currUser)
        {
            InitializeComponent();
            this.currUser = currUser;
        }

        private void FormCategories_Load(object sender, EventArgs e)
        {
            txtSearch.Select();
            txtSearch.Focus();

            cateroryHelper.LoadCategories(grdCategoryList,"");

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            FormCreateCategory createCategory = new FormCreateCategory(currUser, grdCategoryList,null);
            createCategory.ShowDialog();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            cateroryHelper.LoadCategories(grdCategoryList, txtSearch.Text);
        }

        private void grdCategoryList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grdCategoryList.Columns[e.ColumnIndex].Name == "DELETE")
            {
                if (MessageBox.Show(this, "Are you sure to delete this category?", "Delete Category", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cateroryHelper.DeleteCategory(Convert.ToInt32(grdCategoryList[1, e.RowIndex].Value.ToString()));
                    cateroryHelper.LoadCategories(grdCategoryList,"");
                    MessageBox.Show("Category Successfully Deleted", "Category Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
           else if (grdCategoryList.Columns[e.ColumnIndex].Name == "EDIT")
            {
                Categories categories = new Categories();
                categories.ID = Convert.ToInt32(grdCategoryList[1, e.RowIndex].Value.ToString());
                categories.Category = grdCategoryList[2, e.RowIndex].Value.ToString();

                FormCreateCategory createCategory = new FormCreateCategory(currUser, grdCategoryList, categories);
                createCategory.btnSave.Text = "UPDATE";
                createCategory.ShowDialog();
            }
        }
    }
}
