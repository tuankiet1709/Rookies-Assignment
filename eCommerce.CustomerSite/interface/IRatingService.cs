using System.Threading;
using System.Threading.Tasks;
using eCommerce.Shared;
using eCommerce.Shared.Dto;
using eCommerce.Shared.Dto.Rating;
using eCommerce.CustomerSite.ViewModel.Rating;
public interface IRatingService
{
    // Task<RatingDto> GetRatingByIdAsync(int id);
    Task<IEnumerable<RatingDto>> GetProductRating(int productId);
    Task<bool> CreateProductRating(RatingDto Rating);


}