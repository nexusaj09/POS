namespace POS.Models.Product
{
    public class EligibleProductDiscount
    {
        public bool IsSelected { get; set; }
        public string ProductCode { get; set; }
        public string Description { get; set; }
        public decimal Qty { get; set; }
        public decimal UnitAmount { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal LineAmount { get; set; }
    }
}
