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
namespace POS.Forms
{
    public partial class FormCreateDiscount : MetroForm
    {
        public FormCreateDiscount()
        {
            InitializeComponent();
        }

        private void FormCreateDiscount_Load(object sender, EventArgs e)
        {
            if (txtPercentage.Text == string.Empty)
                txtPercentage.Text = "0.00";
        }

        private void txtPercentage_Enter(object sender, EventArgs e)
        {
            if (txtPercentage.Text == "0.00")
            {
                txtPercentage.Text = null;
            }
        }
    }
}
