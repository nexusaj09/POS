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

namespace POS.Forms
{
    public partial class FormInvoice : MetroForm
    {
        public User currUser = new User();
        public FormInvoice(User user)
        {
            InitializeComponent();

            currUser = user;

        }



        public void Init()
        {
            txtSearch.Select();
            txtSearch.Focus();
        }

        private void FormInvoice_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            using (FormCreateInvoice formCreateInvoice = new FormCreateInvoice(this))
            {
                formCreateInvoice.ShowDialog(this);
                formCreateInvoice.Dispose();
                txtSearch.Select();
            }
        }
    }
}
