using Microsoft.AspNetCore.Http.Features;
namespace eCommerce.Shared.ViewModel.Category
{
    public class ProductCreateRequest
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string SeoAlias { get; set; }
        public decimal OriginalPrice { get; set; }
        public decimal Price { get; set; }
        public decimal DecreasedPrice { get; set; }
        public int Stock { get; set; }
        public bool? IsFeatured { get; set; }
        public int BrandId {get;set;}
    }
}