using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Classes
{
    public class GCashTransaction: Audit
    {
        public virtual int ShiftID { get; set; }
        public virtual string TransactionNbr { get; set; }
        public virtual decimal Amt { get; set; }
        public virtual decimal TransactionFee { get; set; }
        public virtual string RefNbr { get; set; }
        public virtual decimal TotalAmt { get; set; }
        public virtual decimal ChangeAmt { get; set; }
        public virtual decimal TenderedAmt { get; set; }
        public virtual string Type { get; set; }

    }
}
