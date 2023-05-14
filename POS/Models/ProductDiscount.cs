using POS.Classes;

namespace POS.Models
{
    public class ProductDiscount : Audit
    {
        public int Id { get; set; }
        public string ProductCode { get; set; }
        public int DiscountID { get; set; }
        public string DiscountDescription { get; set; }
        public decimal DiscountPercentage { get; set; }
        public string RemoveAction { get; set; }
    }
}
