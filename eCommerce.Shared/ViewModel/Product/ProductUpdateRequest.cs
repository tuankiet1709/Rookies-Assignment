using System;

namespace eCommerce.Shared.ViewModel.Product
{
    public class ProductUpdateRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Details { get; set; }
        public string SeoTitle { get; set; }
        public string SeoDescription { get; set; }
        public string SeoAlias { get; set; }
        public DateTime? DateModified { get; set; }
        public bool? IsFeatured { get; set; }

    }
}