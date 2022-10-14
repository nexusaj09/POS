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
    public partial class FormDatabaseConnection : MetroForm
    {
        public FormDatabaseConnection()
        {
            InitializeComponent();
        }

        private void FormDatabaseConnection_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
