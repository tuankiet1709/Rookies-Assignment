using AutoMapper;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Mvc;
using eCommerce.CustomerSite.ViewModel;
using eCommerce.CustomerSite.Models;
using eCommerce.CustomerSite.ViewModel.Product;
using eCommerce.Shared.Constants;
using eCommerce.Shared.Dto.Product;
using eCommerce.Shared.Enum;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace eCommerce.CustomerSite.Pages.Products
{
    public class IndexModel : MainLayoutViewModel
    {
        private readonly IProductService _productService;
        private readonly IBrandService _brandService;
        private readonly ICategoryService _categoryService;
        private readonly IConfiguration _config;
        private readonly IMapper _mapper;

        public IndexModel(
            IProductService productService,
            IBrandService brandService,
            ICategoryService categoryService,
            IConfiguration config,
            IMapper mapper)
        {
            _productService = productService;
            _brandService=brandService;
            _categoryService=categoryService;
            _config = config;
            _mapper = mapper;
        }
        public PagedResponseVM<ProductVm> Products { get; set; }
        [BindProperty]
        public int PageIndex{get;set;}
        public async Task OnGetAsync(string sortOrder,
            string currentFilter, string searchString, int? pageIndex,int? categoryId)
        {
            var productCriteriaDto = new ProductCriteriaDto() {
                Search = searchString,
                CategoryId= categoryId,
                Type=1,
                SortOrder = SortOrderEnum.Accsending,
                Page = pageIndex ?? 1,
                Limit = int.Parse(_config[ConfigurationConstants.PAGING_LIMIT])
            };
            PageIndex=pageIndex ?? 1;
            var pagedProducts = await _productService.GetProductAsync(productCriteriaDto);
            Products = _mapper.Map<PagedResponseVM<ProductVm>>(pagedProducts);
            
            Brands= await _brandService.GetBrandHome();
            Categories= await _categoryService.GetCategoryHome();
        }
    }
}
