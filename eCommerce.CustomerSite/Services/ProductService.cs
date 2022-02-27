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
        var getProductsEndpoint = string.IsNullOrEmpty(ProductCriteriaDto.Search) ? 
                                    EndpointConstants.GET_PRODUCTS :
                                    $"{EndpointConstants.GET_PRODUCTS}?Search={ProductCriteriaDto.Search}";
        
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

    public async Task<bool> UpdateProduct(ProductDto Product)
    {
        var ProductCreateRequest = new ProductCreateRequest
        {
             Name = Product.Name
        };

        //var json = JsonConvert.SerializeObject(ProductCreateRequest);
        //var data = new StringContent(json, Encoding.UTF8, "application/json");
        var content = new MultipartFormDataContent();
        content.Add(new StringContent(Product.Name), "Name");

        var client = _clientFactory.CreateClient(ServiceConstants.BACK_END_NAMED_CLIENT);
        var res = await client.PutAsync(
                            $"{EndpointConstants.GET_PRODUCTS}\\{Product.Id}",
                            content);

        res.EnsureSuccessStatusCode();

        return await Task.FromResult(true);
    }
}