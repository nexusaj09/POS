namespace POS.Classes
{
    public class TopupTransaction : Audit
    {
        public int ID { get; set; }
        public string ReferenceNumber { get; set; }
        public decimal Amount { get; set; }
        public int TopupType { get; set; }
        public int ShiftID { get; set; }
    }
}
