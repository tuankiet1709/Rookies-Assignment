using Microsoft.AspNetCore.Http.Features;
namespace eCommerce.Shared.ViewModel.Product
{
    public class ProductCreateRequest
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Details { get; set; }
        public string SeoTitle { get; set; }
        public string SeoDescription { get; set; }
        public string SeoAlias { get; set; }
        public decimal OriginalPrice { get; set; }
        public decimal Price { get; set; }
        public decimal DecreasedPrice { get; set; }
        public int Stock { get; set; }
        public bool? IsFeatured { get; set; }
        public int BrandId {get;set;}
    }
}