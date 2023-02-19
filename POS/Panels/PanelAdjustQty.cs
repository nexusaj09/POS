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

namespace POS.Panels
{


    public partial class PanelAdjustQty : MetroForm
    {


        private int _adjustedQty;
        public int AdjustedQty
        {
            get { return this._adjustedQty; }
            set { this._adjustedQty = value; }
        }

        public PanelAdjustQty(FormTransaction form)
        {
            InitializeComponent();
        }

        private void txtAdjustQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void PanelAdjustQty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                AdjustedQty = Convert.ToInt32(txtAdjustQty.Text);
                this.Close();
            }
        }
    }
}
