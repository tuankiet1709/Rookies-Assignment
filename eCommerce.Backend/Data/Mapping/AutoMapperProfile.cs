using AutoMapper;
using eCommerce.Backend.Helpers;
using eCommerce.Backend.Models;
using eCommerce.Shared.Dto.Brand;
using eCommerce.Shared.Dto.Product;
using eCommerce.Shared.Dto.Category;
using eCommerce.Shared.Dto.Rating;
using eCommerce.Shared.ViewModel.Rating;

namespace RookieShop.Backend.Data.Mapping
{
    public class AutoMapperProfile : Profile  
    {
        public AutoMapperProfile()  
        {  
            CreateMap<Brand, BrandDto>()
                .ForMember(src => src.ImagePath,
                           opts => opts
                                    .MapFrom(src => ImageHelper
                                                        .GetFileUrl(src.Image)
                                            ));  
            CreateMap<Product, ProductDto>();  
            CreateMap<Category, CategoryDto>();  
            CreateMap<Rating, RatingDto>();  
            CreateMap<RatingCreateRequest,Rating>();
        }  
    }
}