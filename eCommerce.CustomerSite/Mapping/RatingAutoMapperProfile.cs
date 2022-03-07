using AutoMapper;
using eCommerce.CustomerSite.ViewModel;
using eCommerce.CustomerSite.ViewModel.Rating;
using eCommerce.Shared.Dto;
using eCommerce.Shared.Dto.Rating;

namespace eCommerce.CustomerSite.Mapping
{
    public class RatingAutoMapperProfile : Profile
    {
        public RatingAutoMapperProfile()  
        {  
            CreateMap<RatingDto, RatingVm>().ReverseMap();
            CreateMap<BaseQueryCriteriaDto, BaseQueryCriteriaVM>().ReverseMap();  
            CreateMap<PagedResponseDto<RatingDto>, PagedResponseVM<RatingVm>>().ReverseMap();
        }  
    }
}
