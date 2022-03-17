using AutoMapper;
using System.Linq.Dynamic.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using eCommerce.Shared.Dto;
using eCommerce.Shared.Dto.Rating;
using eCommerce.Backend.Data;
using eCommerce.Backend.Extension;
using Microsoft.AspNetCore.Authorization;
using eCommerce.Shared.ViewModel.Rating;
using eCommerce.Backend.Models;
using eCommerce.Backend.Services;

namespace eCommerce.Backend.Controllers;

[ApiController]
[Route("api/[controller]")]
public class RatingsController : ControllerBase
{
    private readonly IRatingService _ratingService;
    public RatingsController(IRatingService ratingService)
    {
        _ratingService=ratingService;
    }
    //https://localhost:44341/api/rating/{productId}
    [HttpGet("{productId}")]
        // [Authorize(Policy = SecurityConstants.ADMIN_ROLE_POLICY)]
    [AllowAnonymous]
    public async Task<ActionResult<IEnumerable<RatingDto>>> GetProductRating(int productId)
    {
        var ratings= await _ratingService.GetProductRating(productId);

        if(ratings==null){
            return NotFound($"There are not any rating for product id: {productId}");
        }
        else{
            return Ok(ratings);
        }
    }
    //https://localhost:44341/api/rating
    [HttpPost]
    // [Authorize(Policy = SecurityConstants.ADMIN_ROLE_POLICY)]
    [AllowAnonymous]
    public async Task<ActionResult> PostRating([FromForm] RatingCreateRequest ratingCreateRequest)
    {
        var result= await _ratingService.PostRating(ratingCreateRequest);
        return Ok(result);
    }
}

