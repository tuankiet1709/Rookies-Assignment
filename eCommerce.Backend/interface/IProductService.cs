using System.Threading;
using System.Threading.Tasks;
using eCommerce.Shared;
using eCommerce.Shared.Dto;
using eCommerce.Shared.Dto.Product;
using eCommerce.Shared.ViewModel.Product;
using Microsoft.AspNetCore.Mvc;
public interface IProductService
{
    // Task<PagedResponseDto<ProductVm>> GetPaging(GetProductPagingRequest request);
    Task<int> Create(ProductCreateRequest request);
    Task<int> Update(ProductUpdateRequest request);
    Task<int> Delete(int productId);
    Task<bool> UpdatePrice (int productId,decimal price);
    Task<bool> UpdateStock (int productId, int quantity);
    Task IncreaseViewCount(int productId);
    Task<ActionResult<PagedResponseDto<ProductDto>>> GetProducts(ProductCriteriaDto productCriteriaDto1);

}