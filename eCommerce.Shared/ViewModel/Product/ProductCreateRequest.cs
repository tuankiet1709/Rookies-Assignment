using Microsoft.AspNetCore.Http;
namespace eCommerce.Shared.ViewModel.Product
{
    public class ProductCreateRequest
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Details { get; set; }
        public decimal OriginalPrice { get; set; }
        public decimal Price { get; set; }
        public bool? IsFeatured { get; set; }
        public int BrandId {get;set;}
        public int CategoryId{get;set;}
        public IFormFile ImageFile{get;set;}
    }
}