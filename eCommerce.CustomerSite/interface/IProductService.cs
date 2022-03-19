using System.Threading;
using System.Threading.Tasks;
using eCommerce.Shared;
using eCommerce.Shared.Dto;
using eCommerce.Shared.Dto.Product;

public interface IProductService
{
    Task<PagedResponseDto<ProductDto>> GetProductAsync(ProductCriteriaDto productCriteriaDto);
    Task<ProductDto> GetProductByIdAsync(int id);
    Task<IEnumerable<ProductDto>> GetLastestProducts();
    Task<IEnumerable<ProductDto>> GetFeaturedProducts();


}