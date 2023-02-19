using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using POS.Classes;
using POS.Helpers;

namespace POS.Panels
{
    public partial class PanelViewCart : MetroForm
    {
        TransactionHelper tranHelper = new TransactionHelper();

        public PanelViewCart()
        {
            InitializeComponent();
        }

        private void PanelViewCart_Load(object sender, EventArgs e)
        {
            Init();
        }


        protected void Init()
        {
            List<Transaction> holdTransaction = new List<Transaction>();

            grdHoldTransactions.Rows.Clear();

            int count = 1;

            holdTransaction = tranHelper.LoadHoldItems();

            foreach (Transaction transaction in holdTransaction)
            {
                if (transaction == null) return;

                grdHoldTransactions.Rows.Add(count, transaction.TransactionNbr.ToString(), transaction.TotalAmt) ;

                count++;
                

            }

        }

        private void PanelViewCart_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
