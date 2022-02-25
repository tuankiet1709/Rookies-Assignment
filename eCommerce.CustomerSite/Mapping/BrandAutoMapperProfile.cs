using AutoMapper;
using eCommerce.CustomerSite.ViewModel;
using eCommerce.CustomerSite.ViewModel.Brand;
using eCommerce.Shared.Dto;
using eCommerce.Shared.Dto.Brand;

namespace eCommerce.CustomerSite.Mapping
{
    public class BrandAutoMapperProfile : Profile
    {
        public BrandAutoMapperProfile()  
        {  
            CreateMap<BrandDto, BrandVm>().ReverseMap();
            CreateMap<BaseQueryCriteriaDto, BaseQueryCriteriaVM>().ReverseMap();  
            CreateMap<PagedResponseDto<BrandDto>, PagedResponseVM<BrandVm>>().ReverseMap();
        }  
    }
}
