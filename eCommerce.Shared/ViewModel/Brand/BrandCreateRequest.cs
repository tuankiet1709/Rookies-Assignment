using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using eCommerce.Shared.Enum;

namespace eCommerce.Shared.ViewModel.Brand
{
    public class BrandCreateRequest
    {
        [Required]
        public string Name { get; set; }
        public IFormFile ImageFile { get; set; }
    }
}
