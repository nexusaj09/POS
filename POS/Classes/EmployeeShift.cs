using System;

namespace POS.Classes
{
    public class EmployeeShift : Audit
    {
        public int ID { get; set; }

        public int EmployeeID { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime? EndTime { get; set; }

        public decimal TotalCashSalesShift { get; set; }
        
        public decimal TotalGcashSalesShift { get; set; }
    }
}
