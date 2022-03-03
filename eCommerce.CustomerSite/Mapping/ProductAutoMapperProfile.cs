using AutoMapper;
using eCommerce.CustomerSite.ViewModel;
using eCommerce.CustomerSite.ViewModel.Product;
using eCommerce.Shared.Dto;
using eCommerce.Shared.Dto.Product;

namespace eCommerce.CustomerSite.Mapping
{
    public class ProductAutoMapperProfile : Profile
    {
        public ProductAutoMapperProfile()  
        {  
            CreateMap<ProductDto, ProductVm>().ReverseMap();
            CreateMap<BaseQueryCriteriaDto, BaseQueryCriteriaVM>().ReverseMap();  
            CreateMap<PagedResponseDto<ProductDto>, PagedResponseVM<ProductVm>>().ReverseMap();
        }  
    }
}
