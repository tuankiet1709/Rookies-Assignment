using AutoMapper;
using System.Linq.Dynamic.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using eCommerce.Shared.Dto;
using eCommerce.Shared.Dto.Product;
using eCommerce.Backend.Data;
using eCommerce.Backend.Extension;
using Microsoft.AspNetCore.Authorization;
using eCommerce.Shared.ViewModel.Product;

namespace eCommerce.Backend.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductController : ControllerBase
{
    private readonly IProductService _ProductService;
    public ProductController(IProductService productService)
    {
        _ProductService = productService;
    }
    [HttpGet]
    public async Task<IActionResult> GetProducts([FromQuery] ProductCriteriaDto request)
    {
            var product = await _ProductService.GetProducts(request);
        if (product == null)
            return BadRequest("Cannot find product");
        return Ok(product);
    }
}

