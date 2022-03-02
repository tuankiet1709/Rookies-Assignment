
using eCommerce.CustomerSite.ViewModel.Product;
using eCommerce.CustomerSite.ViewModel.Category;
using eCommerce.Shared.Dto.Category;
using eCommerce.Shared.Dto.Brand;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace eCommerce.CustomerSite.Models
{
    public class MainLayoutViewModel : PageModel
    {
        public IEnumerable<CategoryDto> Categories { get; set; }
        public IEnumerable<BrandDto> Brands { get; set; }

    }
}