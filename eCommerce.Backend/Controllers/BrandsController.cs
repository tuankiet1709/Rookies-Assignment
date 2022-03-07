using AutoMapper;
using System.Linq.Dynamic.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using eCommerce.Shared.Dto;
using eCommerce.Shared.Dto.Brand;
using eCommerce.Backend.Data;
using eCommerce.Backend.Extension;
using Microsoft.AspNetCore.Authorization;
using eCommerce.Shared.ViewModel.Brand;
using eCommerce.Backend.Services;

namespace eCommerce.Backend.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BrandsController : ControllerBase
{
    private readonly ApplicationDbContext _context;
    private readonly IMapper _mapper;
    private readonly IFileStorageService _fileStorageService;
    public BrandsController(ApplicationDbContext context,
            IFileStorageService fileStorageService,
            IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
        _fileStorageService=fileStorageService;
    }
    [HttpGet()]
    [AllowAnonymous]
    public async Task<ActionResult<PagedResponseDto<BrandDto>>> GetBrands([FromQuery] BrandCriteriaDto brandCriteriaDto)
    {
        //query
        var query=_context.Brands.AsQueryable();
        //Filter
        if (!string.IsNullOrEmpty(brandCriteriaDto.Search))
        {
            query = query.Where(x => x.Name.Contains(brandCriteriaDto.Search));
        }

        var pagedBrands = await query
                            .AsNoTracking()
                            .PaginateAsync(brandCriteriaDto);

        var BrandDto = _mapper.Map<IEnumerable<BrandDto>>(pagedBrands.Items);
        return new PagedResponseDto<BrandDto>
        {
            CurrentPage = pagedBrands.CurrentPage,
            TotalPages = pagedBrands.TotalPages,
            TotalItems = pagedBrands.TotalItems,
            Search = brandCriteriaDto.Search,
            SortColumn = brandCriteriaDto.SortColumn,
            SortOrder = brandCriteriaDto.SortOrder,
            Limit = brandCriteriaDto.Limit,
            Items = BrandDto
        };
    }
    [HttpGet("Home")]
    [AllowAnonymous]
    public async Task<IEnumerable<BrandDto>> GetBrandsHome([FromQuery] BrandCriteriaDto brandCriteriaDto)
    {
        //query
        var query=_context.Brands.AsQueryable();

        var pagedBrands = await query
                            .AsNoTracking()
                            .PaginateAsync(brandCriteriaDto);

        var BrandDto = _mapper.Map<IEnumerable<BrandDto>>(pagedBrands.Items);
        return BrandDto;
    }
    [HttpGet("{id}")]
        // [Authorize(Policy = SecurityConstants.ADMIN_ROLE_POLICY)]
    [AllowAnonymous]
    public async Task<ActionResult<BrandVm>> GetBrand(int id)
    {
        var Brand = await _context
                            .Brands
                            .Where(x=>x.Id == id)
                            .FirstOrDefaultAsync();

        if (Brand == null)
        {
            return NotFound();
        }

        var BrandVm = new BrandVm
        {
            Id = Brand.Id,
            Name = Brand.Name,
            // ImagePath = _fileStorageService.GetFileUrl(brand.ImageName)
        };

        return BrandVm;
    }
}

