using AutoMapper;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using eCommerce.CustomerSite.Models;
namespace eCommerce.CustomerSite.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IMapper _mapper;
    private readonly IProductService _productService;
    private readonly ICategoryService _categoryService;
    private readonly IBrandService _brandService;
    public MainLayoutViewModel Layout { get; set; }

    public HomeController(ILogger<HomeController> logger,
    IMapper mapper,
    IProductService productService,
    ICategoryService categoryService,
    IBrandService brandService)
    {
        _logger = logger;
        _mapper=mapper;
        _productService=productService;
        _categoryService=categoryService;
        _brandService=brandService;
    }
    public async Task<IActionResult> Index()
    {
        HomeVm homeVm=new HomeVm();
        homeVm.Categories=await _categoryService.GetCategoryHome();
        homeVm.Brands=await _brandService.GetBrandHome();        
        homeVm.LatestProducts=await _productService.GetLastestProducts();
        homeVm.FeaturedProducts=await _productService.GetFeaturedProducts();

        return View(homeVm);
    }
    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

