
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using eCommerce.CustomerSite.ViewModel.Product;
using eCommerce.Shared.Dto.Product;

namespace eCommerce.CustomerSite.Pages.Products
{
    public class EditModel : PageModel
    {
        private readonly IProductService _productService;
        private readonly IConfiguration _config;
        private readonly IMapper _mapper;

        public EditModel(
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

        public async Task<IActionResult> OnPostAsync(int id)
        {
            if (!ModelState.IsValid || id < 0)
            {
                return NotFound();
            }

            var productDto =_mapper.Map<ProductDto>(Product);
            if (await _productService.UpdateProduct(productDto))
            {
                return RedirectToPage("./Index");
            }

            return Page();
        }
    }
}
