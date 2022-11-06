using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Classes
{
    public class Invoice: Audit
    {

        public virtual int ID { get; set; }
        public virtual string RefNbr { get; set; }
        public virtual int SupplierID { get; set; }
        public virtual string Supplier { get; set; }
        public virtual string ContactPerson { get; set; }
        public virtual decimal TotalAmt { get; set; }
        public virtual int TotalQty { get; set; }


    }
}
