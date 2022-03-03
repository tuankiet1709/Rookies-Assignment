using System.Threading;
using System.Threading.Tasks;
using eCommerce.Shared;
using eCommerce.Shared.Dto;
using eCommerce.Shared.Dto.Brand;

public interface IBrandService
{
    Task<PagedResponseDto<BrandDto>> GetBrandAsync(BrandCriteriaDto brandCriteriaDto);
    Task<IEnumerable<BrandDto>> GetBrandHome();
    Task<BrandDto> GetBrandByIdAsync(int id);
    Task<bool> UpdateBrand(BrandDto brand);

}