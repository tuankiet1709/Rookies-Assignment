using AutoMapper;
using System.Linq.Dynamic.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using eCommerce.Shared.Dto;
using eCommerce.Shared.Dto.Customer;
using eCommerce.Backend.Data;
using eCommerce.Backend.Extension;
using Microsoft.AspNetCore.Authorization;
using eCommerce.Shared.ViewModel.Customer;
using eCommerce.Backend.Models;
using eCommerce.Shared.Enum;

namespace eCommerce.Backend.Services
{
    public class CustomerService:ICustomerService{
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        private readonly IFileStorageService _fileStorageService;
        public CustomerService(ApplicationDbContext context,
                IFileStorageService fileStorageService,
                IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
            _fileStorageService=fileStorageService;
        }
        [HttpGet()]
        [AllowAnonymous]
        public async Task<PagedResponseDto<CustomerDto>> GetCustomerAsync(CustomerCriteriaDto customerCriteriaDto)
        {
            //query
            var query= (from u in _context.Users
                        join ur in _context.UserRoles on u.Id equals ur.UserId
                        join r in _context.Roles on ur.RoleId equals r.Id
                        where r.Name=="User"
                        select u)
                        .AsQueryable();
                        
            //Filter
            if (!string.IsNullOrEmpty(customerCriteriaDto.Search))
            {
                query = query.Where(x => x.FirstName.Contains(customerCriteriaDto.Search)||
                                        x.LastName.Contains(customerCriteriaDto.Search)||
                                        x.UserName.Contains(customerCriteriaDto.Search));
            }
            
            var pagedCustomers = await query
                                .AsNoTracking()
                                .PaginateAsync(customerCriteriaDto);

            var CustomerDto = _mapper.Map<List<CustomerDto>>(pagedCustomers.Items);
            return new PagedResponseDto<CustomerDto>
            {
                CurrentPage = pagedCustomers.CurrentPage,
                TotalPages = pagedCustomers.TotalPages,
                TotalItems = pagedCustomers.TotalItems,
                Search = customerCriteriaDto.Search,
                SortColumn = customerCriteriaDto.SortColumn,
                SortOrder = customerCriteriaDto.SortOrder,
                Limit = customerCriteriaDto.Limit,
                Items = CustomerDto
            };
        }
        [HttpGet("{id}")]
            // [Authorize(Policy = SecurityConstants.ADMIN_ROLE_POLICY)]
        [AllowAnonymous]
        public async Task<CustomerDto> GetCustomerByIdAsync(string id)
        {
            var brand = await _context
                                .Users
                                .Where(x=>x.Id == id)
                                .FirstOrDefaultAsync();

            var CustomerDto = _mapper.Map<CustomerDto>(brand);


            return CustomerDto;
        }
    }
}
    

    