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
using POS.Forms;
using POS.Helpers;

namespace POS.Panels
{
    public partial class PanelSearchSupplier : MetroForm
    {
        FormCreateInvoice createInvoice;

        SupplierHelper supplierHelper = new SupplierHelper();

        public PanelSearchSupplier(FormCreateInvoice form)
        {
            InitializeComponent();

            createInvoice = form;

        }


        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            supplierHelper.LoadSupplier(grdSupplierList, txtSearch.Text);

            if (grdSupplierList.Rows.Count > 0)
            {
                Init();
            }
        }

        private void PanelSearchSupplier_Load(object sender, EventArgs e)
        {
            supplierHelper.LoadSupplier(grdSupplierList, txtSearch.Text);

            Init();
        }

        private void grdSupplierList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectSupplier(e.RowIndex);
        }


        private void SelectSupplier(int rowIndex)
        {
            try
            {
                createInvoice.invoice.SupplierID = Convert.ToInt32(grdSupplierList.Rows[rowIndex].Cells[1].Value.ToString());
                createInvoice.invoice.Supplier = grdSupplierList.Rows[rowIndex].Cells[2].Value.ToString();
                createInvoice.invoice.ContactPerson = grdSupplierList.Rows[rowIndex].Cells[4].Value.ToString();

                createInvoice.InsertSupplier();
                this.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PanelSearchSupplier_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                Init();
            }
            else if (e.KeyCode == Keys.Enter && grdSupplierList.Rows.Count > 0 && grdSupplierList.ContainsFocus)
            {
                SelectSupplier(grdSupplierList.CurrentRow.Index);
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            else if (e.KeyCode == Keys.Down && txtSearch.ContainsFocus && grdSupplierList.Rows.Count > 0)
            {

                grdSupplierList.Select();
                grdSupplierList.Rows[0].Selected = true;
            }
        }

        private void grdSupplierList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var dataGridView = sender as DataGridView;
            if (dataGridView.Rows[e.RowIndex].Selected)
            {
                e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
                // edit: to change the background color:
                e.CellStyle.SelectionBackColor = Color.Coral;
            }
        }

        public void Init()
        {
            txtFocus();

            grdSupplierList.ClearSelection();

            grdSupplierList.CurrentCell = null;
        }

        public void txtFocus()
        {
            txtSearch.Select();
            txtSearch.Focus();
        }
    }
}
