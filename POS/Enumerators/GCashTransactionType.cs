using System.ComponentModel;

namespace POS.Enumerators
{
    public enum GCashTransactionType
    {
        [Description("Cash In")]
        CashIn = 1,
        [Description("Cash Out")]
        CashOut = 2
    }
}
