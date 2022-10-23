using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Classes
{
    public class Notes : Audit
    {
        public virtual int ID { get; set; }
        public virtual string Title { get; set; }
        public virtual string Description { get; set; }


    }
}
