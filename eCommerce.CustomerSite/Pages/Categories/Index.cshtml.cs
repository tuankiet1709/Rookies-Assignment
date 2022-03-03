
using AutoMapper;
using Microsoft.AspNetCore.Mvc.RazorPages;
using eCommerce.CustomerSite.ViewModel;
using eCommerce.CustomerSite.ViewModel.Category;
using eCommerce.Shared.Constants;
using eCommerce.Shared.Dto.Category;
using eCommerce.Shared.Enum;

namespace eCommerce.CustomerSite.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly ICategoryService _categoryservice;
        private readonly IConfiguration _config;
        private readonly IMapper _mapper;

        public IndexModel(
            ICategoryService CategoryService,
            IConfiguration config,
            IMapper mapper)
        {
            _categoryservice = CategoryService;
            _config = config;
            _mapper = mapper;
        }
        public PagedResponseVM<CategoryVm> Categories { get; set; }
        public int PageIndex { get; set; }        
        public async Task OnGetAsync(string sortOrder,
            string currentFilter, string searchString, int? pageIndex)
        {
            var CategoryCriteriaDto = new CategoryCriteriaDto() {
                Search = searchString,
                SortOrder = SortOrderEnum.Accsending,
                Page = pageIndex ?? 1,
                Limit = int.Parse(_config[ConfigurationConstants.PAGING_LIMIT])
            };
            var pagedCategories = await _categoryservice.GetCategoryAsync(CategoryCriteriaDto);
            Categories = _mapper.Map<PagedResponseVM<CategoryVm>>(pagedCategories);
        }
    }
}
