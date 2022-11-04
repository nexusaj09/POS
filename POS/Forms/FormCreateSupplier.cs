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
    public partial class FormCreateSupplier : MetroForm
    {

        public User currUser = new User();
        public SupplierHelper supplierHelper = new SupplierHelper();
        public DataGridView dataGrid = new DataGridView();
        public Suppliers updateSupplier = new Suppliers();
        public FormCreateSupplier(User currUser, DataGridView gridView, Suppliers suppliers)
        {
            InitializeComponent();

            this.currUser = currUser;
            this.dataGrid = gridView;
            this.updateSupplier = suppliers;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                if (btnSave.Text == "SAVE")
                {
                    if (MessageBox.Show(this, "Add this supplier?", "Add Supplier", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes && txtSupplierName.Text != String.Empty)
                    {
                        if (supplierHelper.IsExisting(txtSupplierName.Text) == false)
                        {
                            Suppliers newSupplier = new Suppliers();

                            newSupplier.Supplier = txtSupplierName.Text;
                            newSupplier.Address = txtAddress.Text;
                            newSupplier.ContactPerson = txtContactPerson.Text;
                            newSupplier.ContactNbr = txtContactNbr.Text;
                            newSupplier.Email = txtEmail.Text;
                            newSupplier.CreatedByID = currUser.UserID;
                            newSupplier.CreatedDateTime = DateTime.Now;
                            newSupplier.LastModifiedByID = currUser.UserID;
                            newSupplier.LastModifiedDateTime = DateTime.Now;

                            supplierHelper.CreateSupplier(newSupplier);

                            MessageBox.Show(this, "New Supplier Added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            supplierHelper.LoadSupplier(dataGrid, "");

                            Clear();
                        }
                        else
                            MessageBox.Show("Supplier Already Exists!", "Existing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtSupplierName.Select();
                    }
                    else if (txtSupplierName.Text == string.Empty)
                    {
                        MessageBox.Show("Supplier Name shoudn't be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtSupplierName.Select();
                    }
                }
                else if (btnSave.Text == "UPDATE")
                {
                    if (MessageBox.Show(this, "Are you sure to update this supplier?", "Updating supplier", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        updateSupplier.Supplier = txtSupplierName.Text;
                        updateSupplier.Address = txtAddress.Text;
                        updateSupplier.ContactPerson = txtContactPerson.Text;
                        updateSupplier.ContactNbr = txtContactNbr.Text;
                        updateSupplier.Email = txtEmail.Text;
                        updateSupplier.LastModifiedByID = currUser.UserID;
                        updateSupplier.LastModifiedDateTime = DateTime.Now;

                        supplierHelper.UpdateSupplier(updateSupplier);
                        MessageBox.Show(this, "Supplier successfully updated!", "Updated Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        supplierHelper.LoadSupplier(dataGrid, "");
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
            txtAddress.Text = null;
            txtContactNbr.Text = null;
            txtContactPerson.Text = null;
            txtEmail.Text = null;
            txtSupplierName.Text = null;
            txtSupplierName.Select();

        }

        private void FormCreateSupplier_Load(object sender, EventArgs e)
        {
            if (updateSupplier != null)
            {
                txtSupplierName.Text = updateSupplier.Supplier;
                txtAddress.Text = updateSupplier.Address;
                txtContactPerson.Text = updateSupplier.ContactPerson;
                txtContactNbr.Text = updateSupplier.ContactNbr;
                txtEmail.Text = updateSupplier.Email;
                txtSupplierName.Select();
            }
        }

        private void txtContactPerson_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ';
        }

        private void txtContactNbr_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '+' && e.KeyChar != '-';
        }
    }
}
