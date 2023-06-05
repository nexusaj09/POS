using MetroFramework.Forms;
using POS.Models.Product;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace POS.Forms
{
    public partial class PanelProductDiscountSelection : MetroForm
    {
        private readonly decimal _discountPercentage;
        private readonly IEnumerable<EligibleProductDiscount> _eligibleProductDiscounts;

        public PanelProductDiscountSelection(decimal discountPercentage, IEnumerable<EligibleProductDiscount> eligibleProductDiscounts)
        {
            InitializeComponent();

            _discountPercentage = discountPercentage;
            _eligibleProductDiscounts = eligibleProductDiscounts;

            Text = $"Select a product to apply {_discountPercentage:##}% discount";
        }

        private void PanelProductDiscountSelection_Load(object sender, EventArgs e)
        {
            productDiscountSelectionBindingSource.DataSource = _eligibleProductDiscounts.ToList();
        }

        private void PanelProductDiscountSelection_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    btnCancel.PerformClick();
                    break;
                case Keys.F12:
                    btnApply.PerformClick();
                    break;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void grdProductDiscountSelection_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var dataGridView = sender as DataGridView;
            if (dataGridView.Rows[e.RowIndex].Selected)
            {
                // edit: to change the background color:
                e.CellStyle.SelectionBackColor = Color.Coral;
                e.CellStyle.SelectionForeColor = Color.White;
            }
        }
    }
}
