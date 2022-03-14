namespace eCommerce.Backend.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Details { get; set; }
        public string Images{get;set;}
        public decimal OriginalPrice { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public int ViewCount { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool? IsFeatured { get; set; }
        public bool isDeleted{get;set;}
        public int BrandId {get;set;}
        public int CategoryId{get;set;}
        public List<Cart> Carts { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
        public List<Rating> ProductRatings { get; set; }
        public Brand Brand {get;set;}
        public Category Category {get;set;}

    }
}