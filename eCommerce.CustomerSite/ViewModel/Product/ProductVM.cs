using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using eCommerce.CustomerSite.ViewModel.Category;
using eCommerce.CustomerSite.ViewModel.Rating;

namespace eCommerce.CustomerSite.ViewModel.Product
{
    public class ProductVm
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Details { get; set; }
        public string Images{get;set;}
        public decimal OriginalPrice { get; set; }
        [DisplayFormat(DataFormatString = "{0:C0}")]
        public decimal Price { get; set; }
         public int Stock { get; set; }
        public int ViewCount { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool? IsFeatured { get; set; }
        public bool isDeleted{get;set;}
        public int BrandId {get;set;}
        public int CategoryId{get;set;}
        public int AverageRating {get;set;}
        public List<RatingVm> ProductRatings{get;set;}
        public CategoryVm Category{get;set;}

    }
}
