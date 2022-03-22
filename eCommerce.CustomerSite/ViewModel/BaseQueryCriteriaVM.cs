using eCommerce.Shared.Enum;

namespace eCommerce.CustomerSite.ViewModel
{
    public class BaseQueryCriteriaVM
    {
        public string Search { get; set; }
        public SortOrderEnum SortOrder { get; set; }
        public string SortColumn { get; set; }
        public int Limit { get; set; } = 9;
        public int Page { get; set; } = 1;
    }
}