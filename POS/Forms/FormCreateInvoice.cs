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
using POS.Panels;

namespace POS.Forms
{
    public partial class FormCreateInvoice : MetroForm
    {
        public Invoice invoice = new Invoice();
        FormInvoice formInvoice;

        public FormCreateInvoice(FormInvoice formInvoice)
        {
            InitializeComponent();
            this.formInvoice = formInvoice;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearchSupplier_Click(object sender, EventArgs e)
        {
            using (PanelSearchSupplier searchSupplier = new PanelSearchSupplier(this))
            {
                searchSupplier.ShowDialog(this);
                searchSupplier.Dispose();
            }
            txtRefNbr.Select();
        }

        public void InsertSupplier()
        {
            txtSupplier.Text = invoice.Supplier.ToString();
            txtContactPerson.Text = invoice.ContactPerson.ToString();


        }

        public void Init()
        {
            txtCreatedBy.Text = formInvoice.currUser.Fullname.ToString();
        }

        private void FormCreateInvoice_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void btnSearchProduct_Click(object sender, EventArgs e)
        {
            using (PanelProducts panelProducts = new PanelProducts(this))
            {
                panelProducts.ShowDialog(this);
                panelProducts.Dispose();
            }

            grdProductList.Select();


        }

        private void grdProductList_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                grdProductList.Rows[e.RowIndex].Cells["SUPPLIERPRICE"].Value = string.Format("{0:#,##0.00}", double.Parse(grdProductList.Rows[e.RowIndex].Cells["SUPPLIERPRICE"].Value.ToString()));
            }

            ComputeTotalPerItem();

        }

        private void ComputeTotalPerItem()
        {
            decimal totalAmt = 0M;
            int totalQty = 0;

            foreach (DataGridViewRow r in grdProductList.Rows)
            {
                grdProductList.Rows[r.Index].Cells["TOTALINVOICE"].Value =
                Convert.ToDecimal(grdProductList.Rows[r.Index].Cells["SUPPLIERPRICE"].Value.ToString()) * Convert.ToInt32(grdProductList.Rows[r.Index].Cells["Qty"].Value);
                grdProductList.Rows[r.Index].Cells["TOTALINVOICE"].Value = string.Format("{0:#,##0.00}", double.Parse(grdProductList.Rows[r.Index].Cells["TOTALINVOICE"].Value.ToString()));
                totalAmt += Convert.ToDecimal(grdProductList.Rows[r.Index].Cells["TOTALINVOICE"].Value);

                totalQty += Convert.ToInt32(grdProductList.Rows[r.Index].Cells["QTY"].Value);

            }
            lblTotalInvoice.Text = string.Format("{0:#,##0.00}", double.Parse(totalAmt.ToString()));
            lblTotalQTY.Text = totalQty.ToString();
        }

        private void grdProductList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grdProductList.Columns[e.ColumnIndex].Name == "DELETE")
            {
                DeleteRow(e.RowIndex);
            }
        }

        private void grdProductList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (grdProductList.ContainsFocus == true && grdProductList.Rows.Count > 0)
                {
                    DeleteRow(grdProductList.CurrentRow.Index);
                }

            }

        }

        private void DeleteRow(int currentIndex)
        {
            if (MessageBox.Show("Remove Selected Row?", "Remove", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                grdProductList.Rows.RemoveAt(currentIndex);
                for (int i = 0; i < grdProductList.Rows.Count; i++)
                {
                    grdProductList.Rows[i].Cells["Count"].Value = i + 1;
                }
                ComputeTotalPerItem();
            }
        }
    }
}

