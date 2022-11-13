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

            Init();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            productHelper.LoadProductPanel(this, txtSearch.Text);

            if (grdProductList.Rows.Count > 0)
            {
                Init();
            }
        }

        private void grdProductList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectProduct(e.RowIndex);
        }

        private void SelectProduct(int row)
        {
            bool isFound = false;


            if (formCreateInvoice.grdInvoiceList.Rows.Count == 0)
            {
                formCreateInvoice.grdInvoiceList.Rows.Add(index += 1,"", grdProductList[1,row].Value.ToString(),
                    grdProductList[3, row].Value.ToString(), "0.00", "0", "0.00");

                MessageBox.Show("Product Added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                for (int i = 1; i <= formCreateInvoice.grdInvoiceList.Rows.Count; i++)
                {
                    //GridView.Rows[Index].Cells[ColumnName]               // GridView[ColumnIndex,Current Row Index] 
                    if (formCreateInvoice.grdInvoiceList.Rows[i - 1].Cells["PRODUCTCODE"].Value.ToString() == grdProductList[1, row].Value.ToString())
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
                    MessageBox.Show("Product is already in the list", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    index = Convert.ToInt32(formCreateInvoice.grdInvoiceList.Rows.Count);
                    formCreateInvoice.grdInvoiceList.Rows.Add(index += 1,"", grdProductList[1, row].Value.ToString(),
                grdProductList[3, row].Value.ToString(), "0.00", "0", "0.00");

                    MessageBox.Show("Product Added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
            else if (e.KeyCode == Keys.Down && txtSearch.ContainsFocus && grdProductList.Rows.Count > 0)
            {

                grdProductList.Select();
                grdProductList.Rows[0].Selected = true;

            }
            else if (e.KeyCode == Keys.F1)
            {
                Init();
            }
        }

        private void grdProductList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var dataGridView = sender as DataGridView;
            if (dataGridView.Rows[e.RowIndex].Selected)
            {
                e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
                // edit: to change the background color:
                e.CellStyle.SelectionBackColor = Color.Coral;
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

            grdProductList.ClearSelection();

            grdProductList.CurrentCell = null;
        }
    }
}
