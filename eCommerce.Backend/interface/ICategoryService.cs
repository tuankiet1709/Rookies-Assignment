using System.Threading;
using System.Threading.Tasks;
using eCommerce.Shared;
using eCommerce.Shared.Dto;
using eCommerce.Shared.Dto.Category;
using eCommerce.Shared.ViewModel.Category;
using eCommerce.Backend.Models;
public interface ICategoryService
{
    Task<PagedResponseDto<CategoryDto>> GetCategoryAsync(CategoryCriteriaDto categoryCriteriaDto);
    Task<IEnumerable<CategoryDto>> GetCategoriesHome();
    Task<IEnumerable<CategoryOptionDto>> GetCategoriesOption(string getParam);
    Task<CategoryDto> GetCategoryByIdAsync(int id);
    Task<Category> PutCategory( int id, CategoryUpdateRequest categoryUpdateRequest);
    Task<int> PostCategory(CategoryCreateRequest categoryCreateRequest);
    Task<int> DeleteCategory(int id);

}