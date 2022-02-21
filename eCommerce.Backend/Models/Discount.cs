using eCommerce.Shared.Enum;

namespace eCommerce.Backend.Models
{
    public class Discount
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public int LimitedOrderPrice { get; set; }
        public bool ApplyAll { get; set; }
        public int DiscountPercent { get; set; }
        public decimal DiscountAmount { get; set; }
        public int? ProductId { get; set; }
        public int? ProductCategoryId { get; set; }
        public Status Status { get; set; }
        public Category Category { get; set; }
        public Product Product { get; set; }


    }
}