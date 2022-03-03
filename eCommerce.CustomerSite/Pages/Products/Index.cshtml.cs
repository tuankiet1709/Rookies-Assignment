using AutoMapper;
using Microsoft.AspNetCore.Mvc.RazorPages;
using eCommerce.CustomerSite.ViewModel;
using eCommerce.CustomerSite.Models;
using eCommerce.CustomerSite.ViewModel.Product;
using eCommerce.Shared.Constants;
using eCommerce.Shared.Dto.Product;
using eCommerce.Shared.Enum;

namespace eCommerce.CustomerSite.Pages.Products
{
    public class IndexModel : MainLayoutViewModel
    {
        private readonly IProductService _productService;
        private readonly IConfiguration _config;
        private readonly IMapper _mapper;

        public IndexModel(
            IProductService productService,
            IConfiguration config,
            IMapper mapper)
        {
            _productService = productService;
            _config = config;
            _mapper = mapper;
        }
        public PagedResponseVM<ProductVm> Products { get; set; }
        public int PageIndex { get; set; }        
        public async Task OnGetAsync(string sortOrder,
            string currentFilter, string searchString, int? pageIndex)
        {
            var productCriteriaDto = new ProductCriteriaDto() {
                Search = searchString,
                SortOrder = SortOrderEnum.Accsending,
                Page = pageIndex ?? 1,
                Limit = int.Parse(_config[ConfigurationConstants.PAGING_LIMIT])
            };
            var pagedProducts = await _productService.GetProductAsync(productCriteriaDto);
            Products = _mapper.Map<PagedResponseVM<ProductVm>>(pagedProducts);
        }
    }
}
