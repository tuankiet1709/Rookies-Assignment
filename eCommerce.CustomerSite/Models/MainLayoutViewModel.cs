
using eCommerce.CustomerSite.ViewModel.Product;
using eCommerce.CustomerSite.ViewModel.Category;
using eCommerce.Shared.Dto.Category;
using eCommerce.Shared.Dto.Brand;

namespace eCommerce.CustomerSite.Models
{
    public class MainLayoutViewModel
    {
        public IEnumerable<CategoryDto> Categories { get; set; }
        public IEnumerable<BrandDto> Brands { get; set; }

    }
}