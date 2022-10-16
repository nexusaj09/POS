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
    public partial class FormDiscounts : MetroForm
    {
        public FormDiscounts()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            FormCreateDiscount createDiscount = new FormCreateDiscount();
            createDiscount.Show();
        }
    }
}
