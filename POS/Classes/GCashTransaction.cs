namespace POS.Classes
{
    public class GCashTransaction: Audit
    {
        public int ID { get; set; }
        public string TransactionNbr { get; set; }
        public decimal Amt { get; set; }
        public decimal TransactionFee { get; set; }
        public string RefNbr { get; set; }
        public decimal TotalAmt { get; set; }
        public decimal ChangeAmt { get; set; }
        public decimal TenderedAmt { get; set; }
        public int TransactionType { get; set; }
        public int ShiftID { get; set; }
        public bool IsNegative { get; set; }
    }
}
