using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Classes
{
    public class Audit
    {
        public virtual int? CreatedByID { get; set; }
        public virtual DateTime? CreatedDateTime { get; set; }
        public virtual int? LastModifiedByID { get; set; }
        public virtual DateTime? LastModifiedDateTime { get; set; }
    }
}
