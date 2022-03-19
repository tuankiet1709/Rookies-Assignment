using AutoMapper;
using eCommerce.Backend.Helpers;
using eCommerce.Backend.Models;
using eCommerce.Shared.Dto.Brand;
using eCommerce.Shared.Dto.Product;
using eCommerce.Shared.Dto.Category;
using eCommerce.Shared.Dto.Rating;
using eCommerce.Shared.ViewModel.Rating;

namespace eCommerce.Backend.Data.Mapping
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
            CreateMap<Brand, BrandOptionDto>();  
            CreateMap<Product, ProductDto>()
                .ForMember(src => src.Images,
                           opts => opts
                                    .MapFrom(src => ImageHelper
                                                        .GetFileUrl(src.Images)
                                                    ));  
            CreateMap<Category, CategoryDto>();  
            CreateMap<Category, CategoryOptionDto>();  
            CreateMap<Rating, RatingDto>();  
            CreateMap<RatingCreateRequest,Rating>();
        }  
    }
}