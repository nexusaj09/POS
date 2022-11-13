using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Classes
{
    public class InvoiceDetail: Audit
    {
        public virtual string Id { get; set; }
        public virtual string RefNbr { get; set; }
        public virtual string ProductCode { get; set;}

        public virtual decimal SupplierPrice { get; set; }
        public virtual int Qty { get; set; }
        public virtual decimal TotalPerItem { get; set; }

        public virtual string Status { get; set; }


    }
}
