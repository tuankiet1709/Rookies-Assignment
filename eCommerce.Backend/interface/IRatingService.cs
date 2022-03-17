using System.Threading;
using System.Threading.Tasks;
using eCommerce.Shared;
using eCommerce.Shared.Dto;
using eCommerce.Shared.Dto.Rating;
using eCommerce.Shared.ViewModel.Rating;
public interface IRatingService
{
    Task<IEnumerable<RatingDto>> GetProductRating(int productId);
    Task<int> PostRating(RatingCreateRequest ratingCreateRequest);


}