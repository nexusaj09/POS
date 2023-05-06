namespace POS.Classes
{
    public class Discount: Audit
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public decimal DiscountPercentage { get; set; }
        
        public string DisplayName { get; set; }
    }
}
