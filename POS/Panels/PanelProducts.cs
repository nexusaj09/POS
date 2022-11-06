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
    public partial class PanelProducts : MetroForm
    {
        ProductHelper productHelper = new ProductHelper();
        FormCreateInvoice formCreateInvoice;
        int index = 0;
        public PanelProducts(FormCreateInvoice form)
        {
            InitializeComponent();
            formCreateInvoice = form;
        }

        private void PanelProducts_Load(object sender, EventArgs e)
        {
            productHelper.LoadProductPanel(this, txtSearch.Text);
            txtSearch.Select();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            productHelper.LoadProductPanel(this, txtSearch.Text);
        }

        private void grdProductList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectProduct(e.RowIndex);
        }

        private void SelectProduct(int row)
        {
            bool isFound = false;


            if (formCreateInvoice.grdProductList.Rows.Count == 0)
            {
                formCreateInvoice.grdProductList.Rows.Add(index += 1, grdProductList[1,row].Value.ToString(),
                    grdProductList[3, row].Value.ToString(), "0.00", "0", "0.00");
            }
            else
            {
                for (int i = 1; i <= formCreateInvoice.grdProductList.Rows.Count; i++)
                {
                    //GridView.Rows[Index].Cells[ColumnName]               // GridView[ColumnIndex,Current Row Index] 
                    if (formCreateInvoice.grdProductList.Rows[i - 1].Cells["PRODUCTCODE"].Value.ToString() == grdProductList[1, row].Value.ToString())
                    {
                        isFound = true;
                        break;
                    }
                    else
                    {
                        isFound = false;
                    }
                }

                if (isFound)
                {
                    MessageBox.Show("Item is already in the list", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    index = Convert.ToInt32(formCreateInvoice.grdProductList.Rows.Count);
                    formCreateInvoice.grdProductList.Rows.Add(index += 1, grdProductList[1, row].Value.ToString(),
                grdProductList[3, row].Value.ToString(), "0.00", "0", "0.00");
                }
            }


        }

        private void PanelProducts_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                SelectProduct(grdProductList.CurrentCell.RowIndex);
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Down)
            {
                if (txtSearch.ContainsFocus == true)
                {
                    grdProductList.Select();
                }
            }
            else if (e.KeyCode == Keys.F1)
            {
                txtSearch.Select();
            }
        }
    }
}
