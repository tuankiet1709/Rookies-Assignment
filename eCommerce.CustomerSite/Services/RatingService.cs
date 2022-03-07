using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;
using eCommerce.Shared;
using eCommerce.Shared.Constants;
using eCommerce.Shared.Dto;
using eCommerce.Shared.Dto.Rating;
using eCommerce.Shared.ViewModel.Rating;

public class RatingService : IRatingService
{
    private readonly IHttpClientFactory _clientFactory;

    public RatingService(IHttpClientFactory clientFactory)
    {
        _clientFactory = clientFactory;
    }

    public async Task<IEnumerable<RatingDto>> GetProductRating(int ProductId)
    {
        var client = _clientFactory.CreateClient(ServiceConstants.BACK_END_NAMED_CLIENT);
        var response = await client.GetAsync($"{EndpointConstants.GET_RATINGS}\\{ProductId}");
        response.EnsureSuccessStatusCode();
        var Rating = await response.Content.ReadAsAsync<IEnumerable<RatingDto>>();
        return Rating;
    }

    public async Task<bool> CreateProductRating(RatingDto Rating)
    {
        //var json = JsonConvert.SerializeObject(RatingCreateRequest);
        //var data = new StringContent(json, Encoding.UTF8, "application/json");
        var content = new MultipartFormDataContent();
        content.Add(new StringContent(Rating.Comment), "Comment");
        content.Add(new StringContent(Rating.RatePoint.ToString()), "RatePoint");
        content.Add(new StringContent(Rating.ProductId.ToString()), "ProductId");
        content.Add(new StringContent(Rating.ReviewerName), "ReviewerName");

        var client = _clientFactory.CreateClient(ServiceConstants.BACK_END_NAMED_CLIENT);
        var res = await client.PostAsync(
                            $"{EndpointConstants.POST_RATINGS}",
                            content);

        res.EnsureSuccessStatusCode();

        return await Task.FromResult(true);
    }
}