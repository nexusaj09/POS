using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Classes
{
    public class User: Audit
    {
        public virtual int UserID { get; set; }
        public virtual string Username { get; set; }
        public virtual string Fullname { get; set; }
        public virtual string Password { get; set; }
        public virtual string Role { get; set; }
        public virtual bool IsActive { get; set; }
    }
}
