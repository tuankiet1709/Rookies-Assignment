using eCommerce.Shared.Enum;

namespace eCommerce.Backend.Models
{
    public class Brand
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int SortOrder { get; set; }
        public bool IsShowOnHome { get; set; }
        public Status Status { get; set; }
        public List<Product> Products {get;set;}
    }
}