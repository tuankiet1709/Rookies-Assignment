using AutoMapper;
using eCommerce.CustomerSite.ViewModel;
using eCommerce.CustomerSite.ViewModel.Category;
using eCommerce.Shared.Dto;
using eCommerce.Shared.Dto.Category;

namespace eCommerce.CustomerSite.Mapping
{
    public class CategoryAutoMapperProfile : Profile
    {
        public CategoryAutoMapperProfile()  
        {  
            CreateMap<CategoryDto, CategoryVm>().ReverseMap();
            CreateMap<BaseQueryCriteriaDto, BaseQueryCriteriaVM>().ReverseMap();  
            CreateMap<PagedResponseDto<CategoryDto>, PagedResponseVM<CategoryVm>>().ReverseMap();
        }  
    }
}
