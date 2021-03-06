using AutoMapper;
using System.Linq.Dynamic.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using eCommerce.Shared.Dto;
using eCommerce.Shared.Dto.Category;
using eCommerce.Backend.Data;
using eCommerce.Backend.Extension;
using Microsoft.AspNetCore.Authorization;
using eCommerce.Shared.ViewModel.Category;

namespace eCommerce.Backend.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CategoriesController : ControllerBase
{
    private readonly ApplicationDbContext _context;
    private readonly IMapper _mapper;
    public CategoriesController(ApplicationDbContext context,
            IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }
    [HttpGet()]
    [AllowAnonymous]
    public async Task<ActionResult<PagedResponseDto<CategoryDto>>> GetCategories([FromQuery] CategoryCriteriaDto categoryCriteriaDto)
    {
        //query
        var query=_context.Categories.AsQueryable();
        //Filter
        if (!string.IsNullOrEmpty(categoryCriteriaDto.Search))
        {
            query = query.Where(x => x.Name.Contains(categoryCriteriaDto.Search));
        }

        var pagedCategories = await query
                            .AsNoTracking()
                            .PaginateAsync(categoryCriteriaDto);

        var CategoryDto = _mapper.Map<IEnumerable<CategoryDto>>(pagedCategories.Items);
        return new PagedResponseDto<CategoryDto>
        {
            CurrentPage = pagedCategories.CurrentPage,
            TotalPages = pagedCategories.TotalPages,
            TotalItems = pagedCategories.TotalItems,
            Search = categoryCriteriaDto.Search,
            SortColumn = categoryCriteriaDto.SortColumn,
            SortOrder = categoryCriteriaDto.SortOrder,
            Limit = categoryCriteriaDto.Limit,
            Items = CategoryDto
        };
    }
    [HttpGet("Home")]
    [AllowAnonymous]
    public async Task<IEnumerable<CategoryDto>> GetCategoriesHome([FromQuery] CategoryCriteriaDto categoryCriteriaDto)
    {
        //query
        var query= await _context.Categories.ToListAsync();


        var CategoryDto = _mapper.Map<IEnumerable<CategoryDto>>(query);
        return CategoryDto;
    }
    [HttpGet("{id}")]
        // [Authorize(Policy = SecurityConstants.ADMIN_ROLE_POLICY)]
    [AllowAnonymous]
    public async Task<ActionResult<CategoryVm>> GetCategory(int id)
    {
        var Category = await _context
                            .Categories
                            .Where(x=>x.Id == id)
                            .FirstOrDefaultAsync();

        if (Category == null)
        {
            return NotFound();
        }

        var CategoryVm = new CategoryVm
        {
            Id = Category.Id,
            Name = Category.Name,
            // ImagePath = _fileStorageService.GetFileUrl(brand.ImageName)
        };

        return CategoryVm;
    }
}

