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


        private void Init()
        {
            supplierHelper.LoadSupplier(grdSupplierList,null);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            supplierHelper.LoadSupplier(grdSupplierList, txtSearch.Text);
        }

        private void PanelSearchSupplier_Load(object sender, EventArgs e)
        {
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
    }
}
