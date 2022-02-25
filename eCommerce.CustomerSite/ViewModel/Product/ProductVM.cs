using System.ComponentModel.DataAnnotations;

namespace eCommerce.CustomerSite.ViewModel.Product
{
    public class ProductVm
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
