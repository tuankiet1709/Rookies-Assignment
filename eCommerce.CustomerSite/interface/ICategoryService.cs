using System.Threading;
using System.Threading.Tasks;
using eCommerce.Shared;
using eCommerce.Shared.Dto;
using eCommerce.Shared.Dto.Category;

public interface ICategoryService
{
    Task<PagedResponseDto<CategoryDto>> GetCategoryAsync(CategoryCriteriaDto categoryCriteriaDto);
    Task<CategoryDto> GetCategoryByIdAsync(int id);
    Task<IEnumerable<CategoryDto>> GetCategoryHome();

}