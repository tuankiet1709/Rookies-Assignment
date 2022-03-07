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
using eCommerce.Backend.Models;
using eCommerce.Shared.ViewModel.ProductImage;
using eCommerce.Backend.Services;

namespace eCommerce.Backend.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductsController : ControllerBase
{
    private readonly ApplicationDbContext _context;
    private readonly IFileStorageService _fileStorageService;
    private readonly IMapper _mapper;
    public ProductsController(
            ApplicationDbContext context,
            IFileStorageService fileStorageService,
            IMapper mapper)
    {
        _context = context;
        _fileStorageService=fileStorageService;
        _mapper = mapper;
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
    public async Task<ActionResult<ProductDto>> GetProduct(int id)
    {
        var product = await _context.Products.Where(x=>x.Id == id).FirstOrDefaultAsync();

        if (product == null)
        {
            return NotFound();
        }

        var productDto = _mapper.Map<ProductDto>(product);

        return productDto;
    }
    [HttpGet("Home")]
    [AllowAnonymous]
    public async Task<ActionResult<List<ProductDto>>> GetProductsHome([FromQuery] ProductVm ProductVm)
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
    [HttpPost("ProductImage")]
    [AllowAnonymous]
    public async Task<int> AddImage(int productId, ProductImageCreateRequest request)
    {
        var productImage = new ProductImage()
        {
            Caption = request.Caption,
            DateCreated = DateTime.Now,
            IsDefault = request.IsDefault,
            ProductId = productId,
            SortOrder = request.SortOrder
        };

        if (request.ImageFile != null)
        {
            productImage.ImagePath = await _fileStorageService.SaveFileAsync(request.ImageFile);
            productImage.FileSize = request.ImageFile.Length;
        }
        _context.ProductImages.Add(productImage);
        await _context.SaveChangesAsync();
        return productImage.Id;
    }
}

