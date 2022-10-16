using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Classes
{
    public class Suppliers : Audit
    {

        public virtual int ID { get; set; }
        public virtual string Supplier { get; set; }
        public virtual string Address { get; set; }
        public virtual string ContactPerson { get; set; }
        public virtual string ContactNbr { get; set; }
        public virtual string Email { get; set; }

    }
}
