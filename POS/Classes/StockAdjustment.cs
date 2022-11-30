using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Classes
{
    public class StockAdjustment : Audit
    {

        public virtual string AdjustmentNbr { get; set; }
        public virtual string ProductCode { get; set; }
        public virtual string Barcode { get; set; }
        public virtual string Description { get; set; }
        public virtual int PrevQty { get; set; }
        public virtual int QtyOnHand { get; set; }
        public virtual int QtyAdjusted { get; set; }
        public virtual string Actions { get; set; }
        public virtual string Reason { get; set; }
        public virtual string User { get; set; }
    }
}
