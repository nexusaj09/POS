using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Classes
{
    public class TransactionDetail : Audit
    {

        public virtual string TransactionNbr { get; set; }
        public virtual string ProductCode { get; set; }
        public virtual string Descr { get; set; }
        public virtual string UOM { get; set; }
        public virtual decimal Price { get; set; }
        public virtual int Qty { get; set; }
        public virtual decimal LessAmt { get; set; }
        public virtual decimal RowTotalAmt { get; set; }
        public virtual string Status { get; set; }


    }
}
