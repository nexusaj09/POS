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
    }
}
