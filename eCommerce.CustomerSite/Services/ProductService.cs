using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;
using eCommerce.Shared;
using eCommerce.Shared.Constants;
using eCommerce.Shared.Dto;
using eCommerce.Shared.Dto.Product;
using eCommerce.Shared.ViewModel.Product;

public class ProductService : IProductService
{
    private readonly IHttpClientFactory _clientFactory;

    public ProductService(IHttpClientFactory clientFactory)
    {
        _clientFactory = clientFactory;
    }

    public async Task<PagedResponseDto<ProductDto>> GetProductAsync(ProductCriteriaDto ProductCriteriaDto)
    {
        var client = _clientFactory.CreateClient(ServiceConstants.BACK_END_NAMED_CLIENT);
        var getProductsEndpoint = "";
                                    
        if(!string.IsNullOrEmpty(ProductCriteriaDto.Search)){
            getProductsEndpoint=$"{EndpointConstants.GET_PRODUCTS}?Search={ProductCriteriaDto.Search}";
        }
        else if(ProductCriteriaDto.CategoryId!=null){
            getProductsEndpoint=$"{EndpointConstants.GET_PRODUCTS}?CategoryId={ProductCriteriaDto.CategoryId}";
        }
        else if(!string.IsNullOrEmpty(ProductCriteriaDto.Search)&&ProductCriteriaDto.CategoryId!=null){
            getProductsEndpoint=$"{EndpointConstants.GET_PRODUCTS}?Search={ProductCriteriaDto.Search}&CategoryId={ProductCriteriaDto.CategoryId}";
        }
        else{
            getProductsEndpoint=EndpointConstants.GET_PRODUCTS;
        }
        
        var response = await client.GetAsync(getProductsEndpoint);
        response.EnsureSuccessStatusCode();
        var pagedProducts = await response.Content.ReadAsAsync<PagedResponseDto<ProductDto>>();
        return pagedProducts;
    }

    public async Task<ProductDto> GetProductByIdAsync(int id)
    {
        var client = _clientFactory.CreateClient(ServiceConstants.BACK_END_NAMED_CLIENT);
        var response = await client.GetAsync($"{EndpointConstants.GET_PRODUCTS}\\{id}");
        response.EnsureSuccessStatusCode();
        var Product = await response.Content.ReadAsAsync<ProductDto>();
        return Product;
    }

    public async Task<IEnumerable<ProductDto>> GetFeaturedProducts()
    {
        var client = _clientFactory.CreateClient(ServiceConstants.BACK_END_NAMED_CLIENT);
        var response = await client.GetAsync($"{EndpointConstants.GET_PRODUCTS}\\FeaturedProduct");
        response.EnsureSuccessStatusCode();
        var product = await response.Content.ReadAsAsync<IEnumerable<ProductDto>>();
        return product;
    }public async Task<IEnumerable<ProductDto>> GetLastestProducts()
    {
        var client = _clientFactory.CreateClient(ServiceConstants.BACK_END_NAMED_CLIENT);
        var response = await client.GetAsync($"{EndpointConstants.GET_PRODUCTS}\\LastestProduct");
        response.EnsureSuccessStatusCode();
        var product = await response.Content.ReadAsAsync<IEnumerable<ProductDto>>();
        return product;
    }
}