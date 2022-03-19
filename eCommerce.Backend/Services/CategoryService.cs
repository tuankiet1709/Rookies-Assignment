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
using eCommerce.Backend.Models;
using eCommerce.Shared.Enum;

namespace eCommerce.Backend.Services
{
    public class CategoryService:ICategoryService{
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;        
        public CategoryService(ApplicationDbContext context,
                IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<PagedResponseDto<CategoryDto>> GetCategoryAsync(CategoryCriteriaDto categoryCriteriaDto)
        {
            //query
            var query=_context.Categories.AsQueryable();

            //Filter(Search category by name)
            if (!string.IsNullOrEmpty(categoryCriteriaDto.Search))
            {
                query = query.Where(x => x.Name.Contains(categoryCriteriaDto.Search));
            }
            //Paging category
            var pagedCategories = await query
                                .AsNoTracking()
                                .PaginateAsync(categoryCriteriaDto);
            //mapping IEnumerable<Category> to IEnumerable<CategoryDto>
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
        public async Task<IEnumerable<CategoryDto>> GetCategoriesHome()
        {
            //query
            var query= await _context.Categories.Where(x=>x.Status==Status.Active).Take(100).ToListAsync();
            //mapping IEnumerable<Category> to IEnumerable<CategoryDto>
            var CategoryDto = _mapper.Map<IEnumerable<CategoryDto>>(query);
            return CategoryDto;
        }
        public async Task<IEnumerable<CategoryOptionDto>> GetCategoriesOption(string getParam)
        {
            //query
            var query= await _context.Categories.Where(x=>x.Status==Status.Active).Take(100).ToListAsync();
            
            //filter(get category child or parent)
            if(getParam=="child"){
                query= query.Where(x=>x.ParentId!=null).ToList();
            }
            else if(getParam=="parent"){
                query= query.Where(x=>x.ParentId==null).ToList();
            }
            //mapping IEnumerable<Category> to IEnumerable<CategoryOptionDto>
            var CategoryOptionDto = _mapper.Map<IEnumerable<CategoryOptionDto>>(query);
            return CategoryOptionDto;
        }
        public async Task<CategoryDto> GetCategoryByIdAsync(int id)
        {
            //query
            var category = await _context
                                .Categories
                                .Where(x=>x.Id == id)
                                .FirstOrDefaultAsync();
            //mapping Category to CategoryDto
            var categoryDto = _mapper.Map<CategoryDto>(category);

            return categoryDto;
        }
        public async Task<Category> PutCategory(int id, CategoryUpdateRequest categoryUpdateRequest)
        {
            //finding category by id
            var category = await _context.Categories.FindAsync(id);

            //update category
            category.Name = categoryUpdateRequest.Name;
            category.Description = categoryUpdateRequest.Description;
            category.UpdatedDate=categoryUpdateRequest.UpdatedDate;
            category.IsShowOnHome = categoryUpdateRequest.IsShowOnHome;
            category.ParentId = categoryUpdateRequest.ParentId;
            category.Status = categoryUpdateRequest.Status;
            category.UpdatedDate=DateTime.Now;
            
            //Update category to db
            _context.Categories.Update(category);
            await _context.SaveChangesAsync();

            return category;
        }
        public async Task<int> PostCategory(CategoryCreateRequest categoryCreateRequest)
        {
            //create new category
            var category = new Category
            {
                Name = categoryCreateRequest.Name,
                Description = categoryCreateRequest.Description,
                IsShowOnHome = categoryCreateRequest.IsShowOnHome,
                ParentId = categoryCreateRequest.ParentId,
            };
            //add category to db
            _context.Categories.Add(category);
            return await _context.SaveChangesAsync();
        }
        public async Task<int> DeleteCategory(int id)
        {
            //find category by id
            var category = await _context.Categories.FindAsync(id);
            //update category status
            category.Status = Status.InActive;
            //update category status to db
            _context.Categories.Update(category);
            return await _context.SaveChangesAsync();
        }
    }
}
    

    