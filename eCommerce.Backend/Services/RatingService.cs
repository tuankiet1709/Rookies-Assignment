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
using eCommerce.Shared.Enum;

namespace eCommerce.Backend.Services
{
    public class RatingService:IRatingService{
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        public RatingService(
                ApplicationDbContext context,
                IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        //Get top 20 product Rating by product id
        public async Task<IEnumerable<RatingDto>> GetProductRating(int productId)
        {
            //Get rating by product id
            var productRating = await _context.Ratings.Where(x=>x.ProductId == productId).Take(20).ToListAsync();
            //Mapping IEnumberable<RatingDto> to IEnumberable<RatingDto>
            var ratingDto = _mapper.Map<IEnumerable<RatingDto>>(productRating);

            return ratingDto;
        }
        //create new rating
        public async Task<int> PostRating(RatingCreateRequest ratingCreateRequest)
        {
            //create a new product rating
            var productRating=new Rating{
                RatePoint=ratingCreateRequest.RatePoint,
                Comment=ratingCreateRequest.Comment,
                ProductId=ratingCreateRequest.ProductId,
                ReviewerName=ratingCreateRequest.ReviewerName,
                IsApproved=true,
                RateDate=DateTime.Now
            };
            //Add product rating to db
            _context.Ratings.Add(productRating);
            return await _context.SaveChangesAsync();
        }
    }
}
    

    