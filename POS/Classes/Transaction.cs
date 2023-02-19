using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Classes
{
    public class Transaction : Audit
    {
        public virtual string TransactionNbr { get; set; }
        public virtual int NbrOfItems { get; set; }
        public virtual decimal TotalDueAmt { get; set; }
        public virtual decimal TotalAmt { get; set; }
        public virtual decimal ChangeAmt { get; set; }
        public virtual decimal TenderedAmt { get; set; }
        public virtual decimal DiscountAmt { get; set; }
        public virtual decimal VatAmt { get; set; }
        public virtual decimal VatExemptAmt { get; set; }
        public virtual string MachineName { get; set; }
        public virtual string Status { get; set; }

    }
}
