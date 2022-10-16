using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Classes
{
    public class Discount: Audit
    {

        public virtual int ID { get; set; }
        public virtual string Description { get; set; }
        public virtual string DiscountPercentage { get; set; }


    }
}
