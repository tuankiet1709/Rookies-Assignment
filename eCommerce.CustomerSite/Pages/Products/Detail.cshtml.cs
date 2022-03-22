using AutoMapper;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Mvc;
using eCommerce.CustomerSite.Models;
using eCommerce.CustomerSite.ViewModel.Product;
using eCommerce.Shared.Dto.Rating;
using eCommerce.CustomerSite.ViewModel.Rating;

namespace eCommerce.CustomerSite.Pages.Products
{
    public class DetailModel : MainLayoutViewModel
    {
        private readonly IProductService _productService;
        private readonly IRatingService _ratingService;
        private readonly IBrandService _brandService;
        private readonly IConfiguration _config;
        private readonly IMapper _mapper;
        public DetailModel(
            IProductService productService,
            IRatingService ratingService,
            IBrandService brandService,
            IConfiguration config,
            IMapper mapper)
        {
            _productService = productService;
            _ratingService=ratingService;
            _brandService=brandService;
            _config = config;
            _mapper = mapper;
        }

        [BindProperty]
        public ProductVm Product  { get; set; }
        [BindProperty]
        public RatingVm ProductRating  { get; set; }
        [BindProperty]
        public int point{get;set;}
        [BindProperty]
        public IEnumerable<RatingVm> ProductRatings  { get; set; }
        public async Task<IActionResult> OnGetAsync(int id)
        {
            int sumPoint=0;
            int countRate=0;
            var productDto = await _productService.GetProductByIdAsync(id);

            if (productDto == null)
            {
                return NotFound();
            }
            var productRatings= await _ratingService.GetProductRating(id);
            ProductRatings=_mapper.Map<IEnumerable<RatingVm>>(productRatings);
            foreach(var i in productRatings){
                sumPoint+=i.RatePoint;
                countRate++;
            }
            if(countRate==0) countRate=1;
            point=sumPoint/countRate;
            Product = _mapper.Map<ProductVm>(productDto);
            Brands= await _brandService.GetBrandHome();
            return Page();
        }
        public async Task<IActionResult> OnPostAsync() 
        {
            ModelState.Clear();
            if (!TryValidateModel(ProductRating))
            {
                return Page();
            }

            ProductRating.RateDate=DateTime.Now;
            ProductRating.IsApproved=true;
            var ratingDto =_mapper.Map<RatingDto>(ProductRating);
            if (await _ratingService.CreateProductRating(ratingDto))
            {
                return RedirectToPage("./Detail",new {id=ProductRating.ProductId});
            }
            return Page();
        }
        public PartialViewResult OnGetProductRatingModal()
        {
            // this handler returns _ContactModalPartial
            return new PartialViewResult
            {
                ViewName = "ProductRatingModal",
                ViewData = new ViewDataDictionary<RatingVm>(ViewData, new RatingVm { })
            };
        }
        public async Task<PartialViewResult> OnPostProductRatingModal(RatingVm ratingVm)
        {
            ViewData["IsValid"]="False";
            ModelState.Clear();
            if (TryValidateModel(ProductRating))
            {
                ProductRating=ratingVm;
                ProductRating.RateDate=DateTime.Now;
                ProductRating.IsApproved=true;
                var ratingDto =_mapper.Map<RatingDto>(ProductRating);
                await _ratingService.CreateProductRating(ratingDto);
                ViewData["IsValid"]="True";
            }
            return new PartialViewResult
            {
                ViewName = "ProductRatingModal",
                ViewData = new ViewDataDictionary<RatingVm>(ViewData, ratingVm)
            };
        }
    }
}
