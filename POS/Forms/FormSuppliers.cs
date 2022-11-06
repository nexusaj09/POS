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
    public partial class FormSuppliers : MetroForm
    {

        public User currUser = new User();
        public SupplierHelper supplierHelper = new SupplierHelper();

        public FormSuppliers(User currUser)
        {
            InitializeComponent();
            this.currUser = currUser;

        }

        private void FormSuppliers_Load(object sender, EventArgs e)
        {
            txtSearch.Select();
            txtSearch.Focus();

            supplierHelper.LoadSupplier(grdSupplierList, "");
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            using (FormCreateSupplier formCreate = new FormCreateSupplier(currUser, grdSupplierList, null))
            {
                formCreate.ShowDialog(this);
                formCreate.Dispose();
                txtSearch.Select();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

            supplierHelper.LoadSupplier(grdSupplierList, txtSearch.Text);
        }

        private void grdSupplierList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grdSupplierList.Columns[e.ColumnIndex].Name == "DELETE")
            {
                if (MessageBox.Show(this, "Are you sure to delete this supplier?", "Delete Supplier", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    supplierHelper.DeleteSupplier(Convert.ToInt32(grdSupplierList[1, e.RowIndex].Value.ToString()));
                    supplierHelper.LoadSupplier(grdSupplierList, "");
                    MessageBox.Show("Supplier Successfully Deleted", "Supplier Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (grdSupplierList.Columns[e.ColumnIndex].Name == "EDIT")
            {
                Suppliers supplier = new Suppliers();
                supplier.ID = Convert.ToInt32(grdSupplierList[1, e.RowIndex].Value.ToString());
                supplier.Supplier = grdSupplierList[2, e.RowIndex].Value.ToString();
                supplier.Address = grdSupplierList[3, e.RowIndex].Value.ToString();
                supplier.ContactPerson = grdSupplierList[4, e.RowIndex].Value.ToString();
                supplier.ContactNbr = grdSupplierList[5, e.RowIndex].Value.ToString();
                supplier.Email = grdSupplierList[6, e.RowIndex].Value.ToString();

                using (FormCreateSupplier createSupplier = new FormCreateSupplier(currUser, grdSupplierList, supplier))
                {
                    createSupplier.btnSave.Text = "UPDATE";
                    createSupplier.ShowDialog(this);
                    createSupplier.Dispose();
                    txtSearch.Select();
                }
            }
        }
    }
}
