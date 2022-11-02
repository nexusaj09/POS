using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Classes
{
    public class Categories: Audit
    {

        public virtual int ID { get; set; }
        public virtual string Category { get; set; }

    }
}
