using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Classes
{
    public class Product : Audit
    {
        public virtual int ID { get; set; }
        public virtual string ProductCode { get; set; }
        public virtual string ProductBarcode { get; set; }
        public virtual string Description { get; set; }

        public virtual string BrandName { get; set; }
        public virtual string GenericName { get; set; }
        public virtual string Classification { get; set; }
        public virtual string Formulation { get; set; }
        public virtual string Category { get; set; }
        public virtual string UOM { get; set; }
        public virtual int ReOrderQty { get; set; }
        public virtual int Qty { get; set; }

        public virtual decimal SupplierPrice { get; set; }
        public virtual decimal FinalPrice { get; set; }
        public virtual decimal SRP { get; set; }
        public virtual int MarkUp { get; set; }






    }
}
