namespace eCommerce.Backend.Models
{
    public class ProductCategory
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public Product Products { get; set; }
        public Category Categories { get; set; }
        
    }
}