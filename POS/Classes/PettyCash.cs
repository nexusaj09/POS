using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Classes
{
    public class PettyCash: Audit
    {   
        public string ShiftID { get; set; }
        public decimal PettyCashAmt { get; set; }
        public decimal GCashPettyCashAmt { get; set; }


    }
}
