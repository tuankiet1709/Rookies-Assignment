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
using eCommerce.Shared.ViewModel.Product;
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
        var query =_context.Products.AsQueryable();
        //Filter
        if (!string.IsNullOrEmpty(productCriteriaDto.Search))
        {
            query = query.Where(x => x.Name.Contains(productCriteriaDto.Search));
        }

        if (productCriteriaDto.CategoryId != null && productCriteriaDto.CategoryId != 0)
        {
            query=query.Where(x => x.CategoryId==productCriteriaDto.CategoryId);
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
        var query= await _context.Products.OrderByDescending(x=>x.CreatedDate).Take(10).ToListAsync();

        var productDto = _mapper.Map<List<ProductDto>>(query);
        return productDto;
    }
    [HttpPost]
    //[Authorize(Policy = SecurityConstants.ADMIN_ROLE_POLICY)]
    public async Task<ActionResult<ProductVm>> PostProduct([FromForm]ProductCreateRequest productCreateRequest)
    {
        var product = new Product
        {
            Name=productCreateRequest.Name,
            Description=productCreateRequest.Description,
            Details=productCreateRequest.Details,
            Images=string.Empty,
            OriginalPrice=productCreateRequest.OriginalPrice,
            Price=productCreateRequest.Price,
            IsFeatured=productCreateRequest.IsFeatured,
            BrandId=productCreateRequest.BrandId,
            CategoryId=productCreateRequest.CategoryId,
        };

        if (productCreateRequest.ImageFile != null)
        {
            product.Images = await _fileStorageService.SaveFileAsync(productCreateRequest.ImageFile);
        }

        _context.Products.Add(product);
        await _context.SaveChangesAsync();

        return CreatedAtAction("GetProduct", new { id = product.Id }, new ProductVm { Id = product.Id, Name = product.Name });
    }
    [HttpPut("{id}")]
    [AllowAnonymous]
    //[Authorize(Policy = SecurityConstants.ADMIN_ROLE_POLICY)]
    public async Task<ActionResult> PutProduct([FromRoute] int id, [FromForm] ProductUpdateRequest productUpdateRequest)
    {
        var product = await _context.Products.FindAsync(id);

        if (product == null)
        {
            return NotFound();
        }
        else {
            product.Name=productUpdateRequest.Name;
            product.Description=productUpdateRequest.Description;
            product.Details=productUpdateRequest.Details;
            product.UpdatedDate=DateTime.Now;
            product.OriginalPrice=productUpdateRequest.OriginalPrice;
            product.Price=productUpdateRequest.Price;
            product.IsFeatured=productUpdateRequest.IsFeatured;
            product.BrandId=productUpdateRequest.BrandId;
            product.CategoryId=productUpdateRequest.CategoryId;
        }

        if (productUpdateRequest.ImageFile != null)
        {
            product.Images = await _fileStorageService.SaveFileAsync(productUpdateRequest.ImageFile);
        }
        
        _context.Products.Update(product);
        await _context.SaveChangesAsync();

        return Ok(product);
    }
    [HttpDelete("{id}")]
    [AllowAnonymous]
    //[Authorize(Policy = SecurityConstants.ADMIN_ROLE_POLICY)]
    public async Task<IActionResult> DeleteProduct(int id)
    {
        var product = await _context.Products.FindAsync(id);
        if (product == null)
        {
            return NotFound();
        }

        //_context.Brands.Remove(brand);
        product.isDeleted = true;
        _context.Products.Update(product);
        await _context.SaveChangesAsync();

        return Ok(true);
    }
}

