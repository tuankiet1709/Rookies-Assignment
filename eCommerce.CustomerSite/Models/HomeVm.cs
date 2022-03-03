
using eCommerce.CustomerSite.ViewModel.Product;
using eCommerce.CustomerSite.ViewModel.Category;
using eCommerce.Shared.Dto.Category;
using eCommerce.Shared.Dto.Product;

namespace eCommerce.CustomerSite.Models
{
    public class HomeVm:MainLayoutViewModel
    {
        public IEnumerable<ProductDto> Products { get; set; }
        public IEnumerable<ProductDto> FeaturedProducts { get; set; }
        public IEnumerable<ProductDto> LatestProducts { get; set; }
    }
}