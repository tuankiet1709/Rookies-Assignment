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
using eCommerce.Backend.Services;

namespace eCommerce.Backend.Controllers;
[ApiController]
[Route("api/[controller]")]
public class CustomersController : ControllerBase
{
    private readonly ICustomerService _customerService;
    public CustomersController(
            ICustomerService customerService)
    {
        _customerService= customerService;
    }
    //https://localhost:44342/api/customers
    [HttpGet()]
    [AllowAnonymous]
    public async Task<IActionResult> GetCustomerAsync([FromQuery] CustomerCriteriaDto customerCriteriaDto)
    {
        var data = await _customerService.GetCustomerAsync(customerCriteriaDto);
        return Ok(data);
    }
    //https://localhost:44342/api/customers/{id}
    [HttpGet("{id}")]
        // [Authorize(Policy = SecurityConstants.ADMIN_ROLE_POLICY)]
    [AllowAnonymous]
    public async Task<ActionResult<CustomerDto>> GetCustomerByIdAsync(string id)
    {
        var customer = await _customerService.GetCustomerByIdAsync(id);

        if (customer == null)
        {
            return NotFound();
        }
        else {
            return customer;
        }
    }
}

