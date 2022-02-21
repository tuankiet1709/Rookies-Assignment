using eCommerce.Shared.Enum;

namespace eCommerce.Backend.Models
{
    public class Brand
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public string SeoTitle { get; set; }
        public string SeoDescription { get; set; }
        public string SeoAlias { get; set; }
        public int SortOrder { get; set; }
        public bool IsShowOnHome { get; set; }
        public Status Status { get; set; }
        public List<Product> Products {get;set;}
    }
}