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

namespace eCommerce.Backend.Controllers;

[ApiController]
[Route("api/[controller]")]
public class RatingsController : ControllerBase
{
    private readonly ApplicationDbContext _context;
    private readonly IMapper _mapper;
    public RatingsController(
            ApplicationDbContext context,
            IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }
    // [HttpGet("{id}")]
    // // [Authorize(Policy = SecurityConstants.ADMIN_ROLE_POLICY)]
    // [AllowAnonymous]
    // public async Task<ActionResult<RatingVm>> GetProductRatings(int id)
    // {
    //     var brand = await _context
    //                         .Rates
    //                         .Where(x=>x.RateId == id&&x.IsApproved==true)
    //                         .FirstOrDefaultAsync();

    //     if (brand == null)
    //     {
    //         return NotFound();
    //     }

    //     var brandVm = _mapper.Map<RatingVm>(brand);

    //     return brandVm;
    // }
    [HttpGet("{productId}")]
        // [Authorize(Policy = SecurityConstants.ADMIN_ROLE_POLICY)]
    [AllowAnonymous]
    public async Task<IEnumerable<RatingDto>> GetProductRating(int productId)
    {
        var productRating = await _context.Ratings.Where(x=>x.ProductId == productId).ToListAsync();

        var ratingDto = _mapper.Map<IEnumerable<RatingDto>>(productRating);

        return ratingDto;
    }
    [HttpPost]
    // [Authorize(Policy = SecurityConstants.ADMIN_ROLE_POLICY)]
    [AllowAnonymous]
    public async Task<ActionResult> PostRating([FromForm] RatingCreateRequest ratingCreateRequest)
    {
        // var productRating = _mapper.Map<Rating>(ratingCreateRequest);
        var productRating=new Rating{
            RatePoint=ratingCreateRequest.RatePoint,
            Comment=ratingCreateRequest.Comment,
            ProductId=ratingCreateRequest.ProductId,
            ReviewerName=ratingCreateRequest.ReviewerName,
            IsApproved=true,
            RateDate=DateTime.Now
        };

        _context.Ratings.Add(productRating);
        await _context.SaveChangesAsync();

        return Ok(productRating);
    }
}

