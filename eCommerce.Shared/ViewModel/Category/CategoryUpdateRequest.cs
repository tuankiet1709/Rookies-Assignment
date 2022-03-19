using System;
using eCommerce.Shared.Enum;

namespace eCommerce.Shared.ViewModel.Category
{
    public class CategoryUpdateRequest
    {
        public string Name { get; set; }
        public string Description {get;set;}
        public DateTime? UpdatedDate { get; set; }
        public int SortOrder { get; set; }
        public bool IsShowOnHome { get; set; }
        public int? ParentId { get; set; }
        public Status Status { get; set; }
    }
}