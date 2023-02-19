using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Classes
{
    public class ProductSupplier
    {
        public virtual string RefNbr { get; set; }
        public virtual int SupplierID { get; set; }
        public virtual string SupplierName { get; set; }
        public virtual decimal Price { get; set; }
        public virtual DateTime TransactionDate { get; set;}
    }
}
