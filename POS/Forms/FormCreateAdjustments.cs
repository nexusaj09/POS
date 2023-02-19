using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BarcodeLib;
using MetroFramework.Forms;
using POS.Classes;
using POS.Helpers;

namespace POS.Forms
{
    public partial class FormCreateAdjustments : MetroForm
    {
        public StockAdjustmentHelper adjustmentHelper = new StockAdjustmentHelper();
        public StockAdjustment stockAdjustment = new StockAdjustment();
        public FormStockAdjustments formStockAdjustments;
        public FormCreateAdjustments(FormStockAdjustments formStock, StockAdjustment adjustment)
        {
            InitializeComponent();

            formStockAdjustments = formStock;

            stockAdjustment = adjustment;
        }

        private void FormCreateAdjustments_Load(object sender, EventArgs e)
        {
      
            txtUser.Text = formStockAdjustments.currUser.Fullname;

            Init();
        }

        private void cmbActions_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            adjustmentHelper.LoadProduct(grdProductList, txtSearch.Text);
            grdProductList.CurrentCell = null;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmClose();
        }

        public void frmClose()
        {
            this.Close();
        }

        private void FormCreateAdjustments_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                Init();
            }
            else if (e.KeyCode == Keys.Down && grdProductList.Rows.Count > 0 && txtSearch.ContainsFocus)
            {
                grdProductList.Select();
            }

        }

        public void Init()
        {
            adjustmentHelper.LoadProduct(grdProductList, "");

            if (stockAdjustment != null)
            {
                btnSave.Visible = false;

                grdProductList.CurrentCell = null;
                grdProductList.ClearSelection();
                CreateBarcode(stockAdjustment.Barcode);

                EnableFields(false);

                txtAdjustmentNbr.Text = stockAdjustment.AdjustmentNbr;
                txtDescription.Text = stockAdjustment.Description;
                txtProductCode.Text = stockAdjustment.ProductCode;
                txtQtyAdjust.Text = stockAdjustment.QtyAdjusted.ToString();
                txtQtyOnHand.Text = stockAdjustment.QtyOnHand.ToString();
                txtUser.Text = stockAdjustment.User;
                cmbActions.Text = stockAdjustment.Actions;
                txtReasons.Text = stockAdjustment.Reason;
                txtUser.Text = stockAdjustment.User;
                label1.Select();

            }
            else
            {
                txtSearch.Select();

                grdProductList.CurrentCell = null;
                grdProductList.ClearSelection();

                txtAdjustmentNbr.Text = adjustmentHelper.GetRefNbr();
            }
        }

        private void EnableFields(bool action)
        {

            txtQtyAdjust.Enabled = action;
            txtQtyOnHand.Enabled = action;

            cmbActions.Enabled = action;
            txtReasons.Enabled = action;
            txtSearch.Enabled = action;
            grdProductList.Enabled = action;
        }

        private void grdProductList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && grdProductList.Rows.Count > 0)
            {
                SelectProduct(grdProductList.CurrentCell.RowIndex);
                e.Handled = true;
            }
        }

        private void SelectProduct(int row)
        {
            txtProductCode.Text = grdProductList[1, row].Value.ToString();
            txtDescription.Text = grdProductList[3, row].Value.ToString();
            txtQtyOnHand.Text = grdProductList[4, row].Value.ToString();

            CreateBarcode(grdProductList[2, row].Value.ToString());

            txtQtyAdjust.Select();
        }

        private void CreateBarcode(string sbarcode)
        {
            Barcode barcode = new Barcode();
            barcode.IncludeLabel = true;

            barcode.Height = (int)(imgBarcode.Height * 0.8);
            barcode.Width = (int)(imgBarcode.Width * 0.8);
            if (!string.IsNullOrEmpty(sbarcode))
            {
                imgBarcode.Image = new Bitmap(barcode.Encode(TYPE.CODE39, sbarcode));
            }
            else
            {
                imgBarcode.Image = null;

            }
        }

        private void grdProductList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectProduct(e.RowIndex);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtProductCode.Text))
            {
                if (cmbActions.SelectedIndex == 1 && Convert.ToInt32(txtQtyOnHand.Text) < Convert.ToInt32(txtQtyAdjust.Text))
                {
                    MessageBox.Show(this, "Qty Adjusted is greater than the Qty on hand", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtQtyAdjust.Select();
                }
                else if (string.IsNullOrEmpty(cmbActions.Text))
                {
                    MessageBox.Show(this, "Please select an Action!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmbActions.Select();
                }
                else if (string.IsNullOrEmpty(txtQtyAdjust.Text))
                {
                    MessageBox.Show(this, "Please enter Adjustment Qty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtQtyAdjust.Select();
                }
                else if (string.IsNullOrEmpty(txtReasons.Text))
                {
                    MessageBox.Show(this, "Please enter Reason(s)!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtReasons.Select();
                }
                else
                {
                    ProcessAdjustment();

                    Clear();

                    Init();



                    formStockAdjustments.Init();
                }
            }
            else
            {
                MessageBox.Show(this, "Please select a product!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Clear()
        {
            txtSearch.Clear();
            txtDescription.Clear();
            txtProductCode.Clear();
            txtQtyAdjust.Clear();
            txtQtyOnHand.Clear();
            txtReasons.Clear();
            cmbActions.SelectedIndex = -1;
            imgBarcode.Image = null;
            stockAdjustment = null;
        }

        private void ProcessAdjustment()
        {
            bool isSuccessful = false;
            stockAdjustment = new StockAdjustment();

            if (MessageBox.Show(this, "Do want to continue this adjustment?", "Adjustments", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                stockAdjustment.AdjustmentNbr = txtAdjustmentNbr.Text;
                stockAdjustment.ProductCode = txtProductCode.Text;
                stockAdjustment.PrevQty = Convert.ToInt32(txtQtyOnHand.Text);
                stockAdjustment.QtyAdjusted = Convert.ToInt32(txtQtyAdjust.Text);
                stockAdjustment.QtyOnHand = cmbActions.SelectedIndex == 0 ? stockAdjustment.PrevQty + stockAdjustment.QtyAdjusted : stockAdjustment.PrevQty - stockAdjustment.QtyAdjusted;
                stockAdjustment.Actions = cmbActions.Text;
                stockAdjustment.Reason = txtReasons.Text;
                stockAdjustment.CreatedByID = formStockAdjustments.currUser.UserID;
                stockAdjustment.CreatedDateTime = DateTime.Now;
                stockAdjustment.LastModifiedByID = formStockAdjustments.currUser.UserID;
                stockAdjustment.LastModifiedDateTime = DateTime.Now;

                isSuccessful = adjustmentHelper.InsertAdjustment(stockAdjustment);

                if (isSuccessful)
                {
                    adjustmentHelper.AdjustProduct(stockAdjustment.QtyAdjusted, stockAdjustment.ProductCode, cmbActions.SelectedIndex);
                    MessageBox.Show(this, "Product adjustment successful", "Product Adjusted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }
    }
}
