using POS.Classes;
using System;

namespace POS.Entities
{
    public class GCashCashOut : Audit
    {
        public Guid Uid { get; set; }
        public string ReferenceNumber { get; set; }
        public decimal Amount { get; set; }
        public decimal Fee { get; set; }
        public bool IsFeePaySeparately { get; set; }
        public bool IsAmountIncludesFee { get; set; }
        public bool IsFeeDeductedOnCashOutAmount { get; set; }
        public int ShiftID { get; set; }
    }
}
