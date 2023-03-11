using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Classes
{
    public class EmployeeShift : Audit
    {
        public string ShiftID { get; set; }

        public int EmployeeID { get; set; }

        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public decimal TotalCashSalesShift { get; set; }
        public decimal TotalGcashSalesShift { get; set; }
    }
}
