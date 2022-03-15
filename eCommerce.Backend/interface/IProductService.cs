using System.Threading;
using System.Threading.Tasks;
using eCommerce.Shared;
using eCommerce.Shared.Dto;
using eCommerce.Shared.Dto.Product;
using eCommerce.Shared.ViewModel.Product;

public interface IProductService
{
    Task<PagedResponseDto<ProductDto>> GetProductAsync(ProductCriteriaDto productCriteriaDto);
    Task<ProductDto> GetProductByIdAsync(int id);
    Task<List<ProductDto>> GetLastestProduct();
    Task<List<ProductDto>> GetFeaturedProducts();
    Task<int> PostProduct(ProductCreateRequest productCreateRequest);
    Task<int> PutProduct(int id, ProductUpdateRequest productUpdateRequest);
    Task<int> DeleteProduct(int id);
}