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
    public partial class FormStockAdjustments : MetroForm
    {
        public User currUser = new User();
        public StockAdjustment stockAdjustment;
        public StockAdjustmentHelper stockAdjustmentHelper = new StockAdjustmentHelper();
        public FormStockAdjustments(User user)
        {
            InitializeComponent();

            currUser = user;  
        }

        private void FormStockAdjustments_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            using (FormCreateAdjustments formAdjust = new FormCreateAdjustments(this,stockAdjustment))
            {
                formAdjust.ShowDialog(this);
                formAdjust.Dispose();
                txtSearch.Select();

            }
        }

        private void grdAdjustment_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var dataGridView = sender as DataGridView;
            if (dataGridView.Rows[e.RowIndex].Selected)
            {
                e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
                // edit: to change the background color:
                e.CellStyle.SelectionBackColor = Color.Coral;
                e.CellStyle.SelectionForeColor = Color.White;
            }
        }

        private void SelectAdjustment(int row)
        {
            stockAdjustment = new StockAdjustment();
            stockAdjustment.AdjustmentNbr = grdAdjustment[2, row].Value.ToString();
            stockAdjustment.ProductCode = grdAdjustment[3, row].Value.ToString();
            stockAdjustment.Barcode = grdAdjustment[4, row].Value.ToString();
            stockAdjustment.Description = grdAdjustment[5, row].Value.ToString();
            stockAdjustment.QtyOnHand = Convert.ToInt32(grdAdjustment[6, row].Value.ToString());
            stockAdjustment.QtyAdjusted = Convert.ToInt32(grdAdjustment[7, row].Value.ToString());
            stockAdjustment.Actions = grdAdjustment[9, row].Value.ToString();
            stockAdjustment.Reason = grdAdjustment[10, row].Value.ToString();
            stockAdjustment.User = grdAdjustment[11, row].Value.ToString();

            using (FormCreateAdjustments formAdjust = new FormCreateAdjustments(this, stockAdjustment))
            {
                formAdjust.ShowDialog(this);
                formAdjust.Dispose();
                Init();
            }
        }

        private void FormStockAdjustments_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down && txtSearch.ContainsFocus && grdAdjustment.Rows.Count > 0)
            {
                grdAdjustment.Select();
                grdAdjustment.Rows[0].Selected = true;

            }
            else if(e.KeyCode == Keys.F1)
            {
                Init();
            }
            else if (e.KeyCode == Keys.Enter && grdAdjustment.ContainsFocus && grdAdjustment.Rows.Count > 0)
            {
                SelectAdjustment(grdAdjustment.CurrentCell.RowIndex);
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }

        }

        public void Init()
        {
            txtFocus();

            stockAdjustmentHelper.LoadStockAdjustment(grdAdjustment, "");

            grdAdjustment.ClearSelection();

            grdAdjustment.CurrentCell = null;
        }

        public void txtFocus()
        {
            txtSearch.Select();
            txtSearch.Focus();
        }

        private void grdAdjustment_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grdAdjustment.Rows.Count > 0)
            {
                SelectAdjustment(e.RowIndex);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            stockAdjustmentHelper.LoadStockAdjustment(grdAdjustment, txtSearch.Text);
        }
    }
}
