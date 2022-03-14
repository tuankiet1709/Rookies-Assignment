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
using eCommerce.Backend.Services;
using eCommerce.Backend.Models;
using eCommerce.Shared.Enum;

namespace eCommerce.Backend.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CategoriesController : ControllerBase
{
    private readonly ApplicationDbContext _context;
    private readonly IMapper _mapper;        
    private readonly IFileStorageService _fileStorageService;

    public CategoriesController(ApplicationDbContext context,
            IFileStorageService fileStorageService,
            IMapper mapper)
    {
        _context = context;
        _fileStorageService=fileStorageService;
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
    public async Task<IEnumerable<CategoryDto>> GetCategoriesHome()
    {
        //query
        var query= await _context.Categories.Where(x=>x.Status==Status.Active).Take(100).ToListAsync();

        var CategoryDto = _mapper.Map<IEnumerable<CategoryDto>>(query);
        return CategoryDto;
    }
    [HttpGet("Option")]
    [AllowAnonymous]
    public async Task<IEnumerable<CategoryOptionDto>> GetCategoriesOption(string getParam)
    {
        //query
        var query= await _context.Categories.Where(x=>x.Status==Status.Active).Take(100).ToListAsync();
        
        //filter
        if(getParam=="child"){
            query= query.Where(x=>x.ParentId!=null).ToList();
        }
        else if(getParam=="parent"){
            query= query.Where(x=>x.ParentId==null).ToList();
        }

        var CategoryOptionDto = _mapper.Map<IEnumerable<CategoryOptionDto>>(query);
        return CategoryOptionDto;
    }
    [HttpGet("HomeOption")]
    [AllowAnonymous]
    public async Task<IEnumerable<CategoryOptionDto>> GetCategoriesProductOption()
    {
        //query
        var query= await _context.Categories.Where(x=>x.Status==Status.Active&&x.ParentId!=null).Take(100).ToListAsync();

        var CategoryOptionDto = _mapper.Map<IEnumerable<CategoryOptionDto>>(query);
        return CategoryOptionDto;
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
            // ImagePath = _fileStorageService.GetFileUrl(category.ImageName)
        };

        return CategoryVm;
    }
    [HttpPut("{id}")]
    [AllowAnonymous]
    //[Authorize(Policy = SecurityConstants.ADMIN_ROLE_POLICY)]
    public async Task<ActionResult> PutCategory([FromRoute] int id, [FromForm] CategoryUpdateRequest categoryUpdateRequest)
    {
        var category = await _context.Categories.FindAsync(id);

        if (category == null)
        {
            return NotFound();
        }
        else {
            category.Name = categoryUpdateRequest.Name;
            category.Description = categoryUpdateRequest.Description;
            category.UpdatedDate=categoryUpdateRequest.UpdatedDate;
            category.IsShowOnHome = categoryUpdateRequest.IsShowOnHome;
            category.ParentId = categoryUpdateRequest.ParentId;
            category.Status = categoryUpdateRequest.Status;
            category.UpdatedDate=DateTime.Now;
        }
        
        _context.Categories.Update(category);
        await _context.SaveChangesAsync();

        return Ok(category);
    }

    [HttpPost]
    //[Authorize(Policy = SecurityConstants.ADMIN_ROLE_POLICY)]
    public async Task<ActionResult<CategoryVm>> PostCategory([FromForm] CategoryCreateRequest categoryCreateRequest)
    {
        var category = new Category
        {
            Name = categoryCreateRequest.Name,
            Description = categoryCreateRequest.Description,
            IsShowOnHome = categoryCreateRequest.IsShowOnHome,
            ParentId = categoryCreateRequest.ParentId,
        };

        _context.Categories.Add(category);
        await _context.SaveChangesAsync();

        return CreatedAtAction("GetCategory", new { id = category.Id }, new CategoryVm { Id = category.Id, Name = category.Name });
    }

    [HttpDelete("{id}")]
    [AllowAnonymous]
    //[Authorize(Policy = SecurityConstants.ADMIN_ROLE_POLICY)]
    public async Task<IActionResult> DeleteCategory(int id)
    {
        var category = await _context.Categories.FindAsync(id);

        if (category == null)
        {
            return NotFound();
        }

        category.Status = Status.InActive;
        _context.Categories.Update(category);
        await _context.SaveChangesAsync();

        return Ok(true);
    }
}

