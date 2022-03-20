using System.Threading;
using System.Threading.Tasks;
using eCommerce.Shared;
using eCommerce.Shared.Dto;
using eCommerce.Shared.Dto.Customer;
using eCommerce.Shared.ViewModel;
using eCommerce.Backend.Models;
public interface ICustomerService
{
    Task<PagedResponseDto<CustomerDto>> GetCustomerAsync(CustomerCriteriaDto categoryCriteriaDto);
    Task<CustomerDto> GetCustomerByIdAsync(string id);

}