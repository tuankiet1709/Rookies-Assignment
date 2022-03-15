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
using eCommerce.Backend.Models;
using eCommerce.Backend.Services;

namespace eCommerce.Backend.Controllers;
[ApiController]
[Route("api/[controller]")]
public class ProductsController : ControllerBase
{
    private readonly IProductService _productService;
    public ProductsController(
            IProductService productService)
    {
        _productService= productService;
    }
    //https://localhost:44341/api/products
    [HttpGet()]
    [AllowAnonymous]
    public async Task<ActionResult<PagedResponseDto<ProductDto>>> GetProductAsync([FromQuery] ProductCriteriaDto productCriteriaDto)
    {
        var data = await _productService.GetProductAsync(productCriteriaDto);
        return Ok(data);
    }
    //https://localhost:44341/api/products/featuredproduct
    [HttpGet("FeaturedProduct")]
    [AllowAnonymous]
    public async Task<ActionResult<List<ProductDto>>> GetFeaturedProducts()
    {
        var data= await _productService.GetFeaturedProducts();
        return Ok(data);
    }
    //https://localhost:44341/api/products/latestproduct
    [HttpGet("LastestProduct")]
    [AllowAnonymous]
    public async Task<ActionResult<List<ProductDto>>> GetLastestProduct()
    {
        var data = await _productService.GetLastestProduct();
        return Ok(data);
    }
    //https://localhost:44341/api/products/{id}
    [HttpGet("{id}")]
        // [Authorize(Policy = SecurityConstants.ADMIN_ROLE_POLICY)]
    [AllowAnonymous]
    public async Task<ActionResult<ProductDto>> GetProductByIdAsync(int id)
    {
        var product = await _productService.GetProductByIdAsync(id);

        if (product == null)
        {
            return NotFound();
        }
        else {
            return product;
        }
    }
    //https://localhost:44341/api/products/
    [HttpPost]
    //[Authorize(Policy = SecurityConstants.ADMIN_ROLE_POLICY)]
    public async Task<ActionResult<ProductDto>> PostProduct([FromForm]ProductCreateRequest productCreateRequest)
    {
        if (productCreateRequest == null)
        {
            return BadRequest();
        }
        else{
            var createProduct = await _productService.PostProduct(productCreateRequest);
            return CreatedAtAction("GetProductByIdAsync", new { id = createProduct }, new ProductDto { Id = createProduct, Name = productCreateRequest.Name });
        }
    }
    //https://localhost:44341/api/products/{id}
    [HttpPut("{id}")]
    [AllowAnonymous]
    //[Authorize(Policy = SecurityConstants.ADMIN_ROLE_POLICY)]
    public async Task<ActionResult> PutProduct([FromRoute] int id, [FromForm] ProductUpdateRequest productUpdateRequest)
    {
        var productCriteriaDto=new ProductCriteriaDto();
        var checkProduct= await _productService.GetProductByIdAsync(id);
        if(checkProduct==null){
            return NotFound($"Product with id={id} is not found");
        }
        else{
            return NoContent();
        }
    }
    //https://localhost:44341/api/products/{id}
    [HttpDelete("{id}")]
    [AllowAnonymous]
    //[Authorize(Policy = SecurityConstants.ADMIN_ROLE_POLICY)]
    public async Task<ActionResult> DeleteProduct(int id)
    {
        var checkProduct= await _productService.GetProductByIdAsync(id);
        if(checkProduct==null){
            return NotFound($"Product with id={id} is not found");
        }
        else{
            return NoContent();
        }
    }
}

