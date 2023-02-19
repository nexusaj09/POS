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
using POS.Forms;
using POS.Helpers;

namespace POS.Panels
{
    public partial class PanelSupplierPrice : MetroForm
    {
        public InvoiceHelper invoiceHelper = new InvoiceHelper();
        public string _productCode;
        public PanelSupplierPrice(string productCode)
        {
            InitializeComponent();

            _productCode = productCode;
        }

        private void PanelSupplierPrice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            else if (e.KeyCode == Keys.Down && txtSearch.ContainsFocus && grdSupplierList.Rows.Count > 0)
            {
                grdSupplierList.Select();
                grdSupplierList.Rows[0].Selected = true;
            }
            else if (e.KeyCode == Keys.F1)
            {
                Init();
            }
            else if (e.KeyCode == Keys.Enter && grdSupplierList.ContainsFocus)
            {
                if (grdSupplierList.CurrentCell == null) return;

                ViewSupplier(grdSupplierList.CurrentCell.RowIndex);
                e.Handled = true;
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

            grdSupplierList.ClearSelection();

            grdSupplierList.CurrentCell = null;
        }

        private void PanelSupplierPrice_Load(object sender, EventArgs e)
        {
            invoiceHelper.LoadProductSupplierInvoice(this, _productCode, "");

            Init();
        }

        private void grdSupplierList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var dataGridView = sender as DataGridView;
            if (dataGridView.Rows[e.RowIndex].Selected)
            {
                e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
                //   edit: to change the background color:
                e.CellStyle.SelectionBackColor = Color.Coral;
                e.CellStyle.SelectionForeColor = Color.White;
            }
        }

        private void grdSupplierList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            ViewSupplier(e.RowIndex);
        }

        private void ViewSupplier(int row)
        {
            if (grdSupplierList.Rows.Count > 0)
            {

                int rowID = Convert.ToInt32(grdSupplierList[2, row].Value);

                Suppliers supplier = new Suppliers();

                supplier = invoiceHelper.LoadSupplierDetails(rowID);

                if (supplier == null) return;

                using (FormCreateSupplier form = new FormCreateSupplier(supplier, false))
                {
                    form.ShowDialog();
                    form.Dispose();
                    txtFocus();
                }
            }
        }
    }
}
