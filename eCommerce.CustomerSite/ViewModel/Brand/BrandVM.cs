using System.ComponentModel.DataAnnotations;

namespace eCommerce.CustomerSite.ViewModel.Brand
{
    public class BrandVm
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
