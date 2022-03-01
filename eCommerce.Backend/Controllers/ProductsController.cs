using AutoMapper;
using System.Linq.Dynamic.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using eCommerce.Shared.Dto;
using eCommerce.Shared.Dto.Product;
using eCommerce.Backend.Data;
using eCommerce.Backend.Extension;
using Microsoft.AspNetCore.Authorization;
using eCommerce.Shared.ViewModel.Product;

namespace eCommerce.Backend.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductsController : ControllerBase
{
    private readonly IProductService _ProductService;
    private readonly ApplicationDbContext _context;
    private readonly IMapper _mapper;
    public ProductsController(IProductService productService,
            ApplicationDbContext context,
            IMapper mapper)
    {
        _ProductService = productService;
        _context = context;
        _mapper = mapper;
    }
    [HttpGet("paging")]
    [AllowAnonymous]
    public async Task<IActionResult> GetProducts1([FromQuery] ProductCriteriaDto request)
    {
        var product = await _ProductService.GetProducts(request);
        if (product == null)
            return BadRequest("Cannot find product");
        return Ok(product);
    }
    [HttpGet()]
    [AllowAnonymous]
    public async Task<ActionResult<PagedResponseDto<ProductDto>>> GetProducts([FromQuery] ProductCriteriaDto productCriteriaDto)
    {
        //query
        var query =_context.Products 
                            .Include(p=>p.ProductCategories)
                            .Distinct();
        //Filter
        if (!string.IsNullOrEmpty(productCriteriaDto.Search))
        {
            query = query.Where(x => x.Name.Contains(productCriteriaDto.Search));
        }

        if (productCriteriaDto.CategoryId != null && productCriteriaDto.CategoryId != 0)
        {
            query=query.Where(x => x.ProductCategories.Any(pc => pc.ProductId == productCriteriaDto.CategoryId));
        }

        var pagedProducts = await query
                            .AsNoTracking()
                            .PaginateAsync(productCriteriaDto);

        var ProductDto = _mapper.Map<IEnumerable<ProductDto>>(pagedProducts.Items);
        return new PagedResponseDto<ProductDto>
        {
            CurrentPage = pagedProducts.CurrentPage,
            TotalPages = pagedProducts.TotalPages,
            TotalItems = pagedProducts.TotalItems,
            Search = productCriteriaDto.Search,
            SortColumn = productCriteriaDto.SortColumn,
            SortOrder = productCriteriaDto.SortOrder,
            Limit = productCriteriaDto.Limit,
            Items = ProductDto
        };
    }
    [HttpGet("{id}")]
        // [Authorize(Policy = SecurityConstants.ADMIN_ROLE_POLICY)]
    [AllowAnonymous]
    public async Task<ActionResult<ProductVm>> GetProduct(int id)
    {
        var product = await _context
                            .Products
                            .Where(x=>x.Id == id)
                            .FirstOrDefaultAsync();

        if (product == null)
        {
            return NotFound();
        }

        var productVm = new ProductVm
        {
            Id = product.Id,
            Name = product.Name,
            // ImagePath = _fileStorageService.GetFileUrl(brand.ImageName)
        };

        return productVm;
    }
    [HttpGet("Home")]
    [AllowAnonymous]
    public async Task<List<ProductDto>> GetProductsHome([FromQuery] ProductVm ProductVm)
    {
        //query
        var query= await _context.Products.ToListAsync();

        var productDto = _mapper.Map<List<ProductDto>>(query);
        return productDto;
    }
    [HttpGet("FeaturedProduct")]
    [AllowAnonymous]
    public async Task<List<ProductDto>> GetFeaturedProducts([FromQuery] ProductVm ProductVm)
    {
        //query
        var query= await _context.Products.Where(x=>x.IsFeatured==true).Take(10).ToListAsync();

        var productDto = _mapper.Map<List<ProductDto>>(query);
        return productDto;
    }
    [HttpGet("LastestProduct")]
    [AllowAnonymous]
    public async Task<List<ProductDto>> GetLastestProduct([FromQuery] ProductVm ProductVm)
    {
        //query
        var query= await _context.Products.OrderByDescending(x=>x.DateCreated).Take(10).ToListAsync();

        var productDto = _mapper.Map<List<ProductDto>>(query);
        return productDto;
    }
}

