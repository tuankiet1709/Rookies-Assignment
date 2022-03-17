using AutoMapper;
using System.Linq.Dynamic.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using eCommerce.Shared.Dto;
using eCommerce.Shared.Dto.Category;
using eCommerce.Backend.Extension;
using Microsoft.AspNetCore.Authorization;
using eCommerce.Shared.ViewModel.Category;
using eCommerce.Backend.Models;
using eCommerce.Shared.Enum;


namespace eCommerce.Backend.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CategoriesController : ControllerBase
{
    private readonly ICategoryService _categoryService;
    public CategoriesController(ICategoryService categoryService)
    {
        _categoryService = categoryService;
    }
    //https://localhost:44341/api/Categories
    [HttpGet()]
    [AllowAnonymous]
    public async Task<ActionResult<PagedResponseDto<CategoryDto>>> GetCategoryAsync([FromQuery] CategoryCriteriaDto categoryCriteriaDto)
    {
        var data= await _categoryService.GetCategoryAsync(categoryCriteriaDto);

        return Ok(data);
        
    }
    //https://localhost:44341/api/Categories/Home
    [HttpGet("Home")]
    [AllowAnonymous]
    public async Task<ActionResult<IEnumerable<CategoryDto>>> GetCategoriesHome()
    {
        var data= await _categoryService.GetCategoriesHome();
        if(data==null){
            return NotFound();
        }
        else{
            return Ok(data);
        }
    }
    //https://localhost:44341/api/Categories/Option
    [HttpGet("Option")]
    [AllowAnonymous]
    public async Task<ActionResult<IEnumerable<CategoryOptionDto>>> GetCategoriesOption(string getParam)
    {
        var data= await _categoryService.GetCategoriesOption(getParam);
        if(data==null){
            return NotFound();
        }
        else{
            return Ok(data);
        }
    }
    //https://localhost:44341/api/Categories/{id}
    [HttpGet("{id}")]
        // [Authorize(Policy = SecurityConstants.ADMIN_ROLE_POLICY)]
    [AllowAnonymous]
    public async Task<ActionResult<CategoryDto>> GetCategoryByIdAsync(int id)
    {
        var category= await _categoryService.GetCategoryByIdAsync(id);
        if(category==null){
            return NotFound();
        }
        else{
            return Ok(category);
        }
    }
    //https://localhost:44341/api/Categories/{id}
    [HttpPut("{id}")]
    [AllowAnonymous]
    //[Authorize(Policy = SecurityConstants.ADMIN_ROLE_POLICY)]
    public async Task<ActionResult<Category>> PutCategory(int id, [FromForm]CategoryUpdateRequest categoryUpdateRequest)
    {
        var checkCategory= await _categoryService.GetCategoryByIdAsync(id);
        if(checkCategory==null){
            return NotFound($"Category with id={id} is not found");
        }
        else{
            return await _categoryService.PutCategory(id, categoryUpdateRequest);
        }
    }   
    //https://localhost:44341/api/Categories
    [HttpPost]
    //[Authorize(Policy = SecurityConstants.ADMIN_ROLE_POLICY)]
    public async Task<ActionResult<int>> PostCategory([FromForm] CategoryCreateRequest categoryCreateRequest)
    {
        if (categoryCreateRequest == null)
        {
            return BadRequest();
        }
        else{
            var createCategory = await _categoryService.PostCategory(categoryCreateRequest);
            return Ok(createCategory);
        }
    }
    //https://localhost:44341/api/Categories/{id}
    [HttpDelete("{id}")]
    [AllowAnonymous]
    //[Authorize(Policy = SecurityConstants.ADMIN_ROLE_POLICY)]
    public async Task<ActionResult<int>> DeleteCategory(int id)
    {
        var checkCategory= await _categoryService.GetCategoryByIdAsync(id);
        if(checkCategory==null){
            return NotFound($"Category with id={id} is not found");
        }
        else{
            return await _categoryService.DeleteCategory(id);
        }

    }
}

