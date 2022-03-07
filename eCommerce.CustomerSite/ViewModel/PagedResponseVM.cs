using System.Collections.Generic;

namespace eCommerce.CustomerSite.ViewModel
{
    public class PagedResponseVM<TViewModel> : BaseQueryCriteriaVM
    {
        public int CurrentPage { get; set; }

        public int TotalItems { get; set; }

        public int TotalPages { get; set; }

        public IEnumerable<TViewModel> Items { get; set; }

        public bool HasPreviousPage
        {
            get
            {
                return (Page > 1);
            }
        }
        public bool HasNext1Page
        {
            get
            {
                return (Page + 1 < TotalPages);
            }
        }
        public bool HasNext2Page
        {
            get
            {
                return (Page + 2 < TotalPages);
            }
        }public bool HasNext3Page
        {
            get
            {
                return (Page + 3 < TotalPages);
            }
        }
        public bool HasNextPage
        {
            get
            {
                return (Page + 4 < TotalPages);
            }
        }
    }
}
