
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using eCommerce.CustomerSite.Models;
using eCommerce.CustomerSite.ViewModel.Product;
using eCommerce.Shared.Dto.Product;

namespace eCommerce.CustomerSite.Pages.Products
{
    public class DetailModel : MainLayoutViewModel
    {
        private readonly IProductService _productService;
        private readonly IConfiguration _config;
        private readonly IMapper _mapper;

        public DetailModel(
            IProductService productService,
            IConfiguration config,
            IMapper mapper)
        {
            _productService = productService;
            _config = config;
            _mapper = mapper;
        }

        [BindProperty]
        public ProductVm Product  { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productDto = await _productService.GetProductByIdAsync(id.Value);

            if (productDto == null)
            {
                return NotFound();
            }
            Product = _mapper.Map<ProductVm>(productDto);
            return Page();
        }
    }
}
