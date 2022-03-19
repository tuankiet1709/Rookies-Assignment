using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;
using eCommerce.Shared;
using eCommerce.Shared.Constants;
using eCommerce.Shared.Dto;
using eCommerce.Shared.Dto.Category;
using eCommerce.Shared.ViewModel.Category;

public class CategoryService : ICategoryService
{
    private readonly IHttpClientFactory _clientFactory;

    public CategoryService(IHttpClientFactory clientFactory)
    {
        _clientFactory = clientFactory;
    }

    public async Task<PagedResponseDto<CategoryDto>> GetCategoryAsync(CategoryCriteriaDto CategoryCriteriaDto)
    {
        var client = _clientFactory.CreateClient(ServiceConstants.BACK_END_NAMED_CLIENT);
        var getCategoriesEndpoint = string.IsNullOrEmpty(CategoryCriteriaDto.Search) ? 
                                    EndpointConstants.GET_CATEGORIES :
                                    $"{EndpointConstants.GET_CATEGORIES}?Search={CategoryCriteriaDto.Search}";
        
        var response = await client.GetAsync(getCategoriesEndpoint);
        response.EnsureSuccessStatusCode();
        var pagedCategories = await response.Content.ReadAsAsync<PagedResponseDto<CategoryDto>>();
        return pagedCategories;
    }

    public async Task<CategoryDto> GetCategoryByIdAsync(int id)
    {
        var client = _clientFactory.CreateClient(ServiceConstants.BACK_END_NAMED_CLIENT);
        var response = await client.GetAsync($"{EndpointConstants.GET_CATEGORIES}\\{id}");
        response.EnsureSuccessStatusCode();
        var Category = await response.Content.ReadAsAsync<CategoryDto>();
        return Category;
    }
    public async Task<IEnumerable<CategoryDto>> GetCategoryHome()
    {
        var client = _clientFactory.CreateClient(ServiceConstants.BACK_END_NAMED_CLIENT);
        var response = await client.GetAsync($"{EndpointConstants.GET_CATEGORIES}\\Home");
        response.EnsureSuccessStatusCode();
        var categories = await response.Content.ReadAsAsync<IEnumerable<CategoryDto>>();
        return categories;
    }
}