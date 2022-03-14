using System.ComponentModel.DataAnnotations;

namespace eCommerce.CustomerSite.ViewModel.Product
{
    public class ProductVm
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Details { get; set; }
        public decimal OriginalPrice { get; set; }
        [DisplayFormat(DataFormatString = "{0:C0}")]
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public int ViewCount { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public bool? IsFeatured { get; set; }
        public int BrandId {get;set;}
    }
}
