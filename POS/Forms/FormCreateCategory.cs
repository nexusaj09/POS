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
    public partial class FormCreateCategory : MetroForm
    {
        public User currUser = new User();
        public CategoryHelper categoryHelper = new CategoryHelper();
        public DataGridView currView = new DataGridView();
        public Categories updateCategory = new Categories();
        public FormCreateCategory(User currUser, DataGridView view, Categories categories)
        {
            InitializeComponent();
            this.currUser = currUser;
            this.currView = view;
            this.updateCategory = categories;
        }




        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void FormCreateCategory_Load(object sender, EventArgs e)
        {
            txtCategory.Select();
            txtCategory.Focus();
            if (updateCategory != null)
            {
                txtCategory.Text = updateCategory.Category.ToString();
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnSave.Text == "SAVE")
                {
                    if (MessageBox.Show(this, "Add this category?", "Add Category", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        Categories newCategory = new Categories();

                        newCategory.Category = txtCategory.Text;
                        newCategory.CreatedByID = currUser.UserID;
                        newCategory.CreatedDateTime = DateTime.Now;
                        newCategory.LastModifiedByID = currUser.UserID;
                        newCategory.LastModifiedDateTime = DateTime.Now;

                        categoryHelper.CreateCategory(newCategory);

                        MessageBox.Show(this, "New Category Added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        categoryHelper.LoadCategories(currView, "");

                        txtCategory.Clear();
                        txtCategory.Select();
                    }
                }
                else if (btnSave.Text == "UPDATE")
                {
                    if (MessageBox.Show(this, "Are you sure to update this category?", "Updating category", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        updateCategory.Category = txtCategory.Text;
                        updateCategory.LastModifiedByID = currUser.UserID;
                        updateCategory.LastModifiedDateTime = DateTime.Now;
      
                        categoryHelper.UpdateCategory(updateCategory);
                        MessageBox.Show(this, "Category successfully updated!", "Updated Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtCategory.Text = null;
                        categoryHelper.LoadCategories(currView, "");
                        this.Close();
                        this.Dispose();

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
