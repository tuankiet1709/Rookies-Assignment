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
    private readonly ApplicationDbContext _context;
    private readonly IMapper _mapper;
    private readonly IFileStorageService _fileStorageService;
    public RatingsController(
            ApplicationDbContext context,
            IFileStorageService fileStorageService,
            IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
        _fileStorageService=fileStorageService;
    }
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

