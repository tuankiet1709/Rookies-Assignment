using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using eCommerce.Shared.Enum;

namespace RookieShop.Shared
{
    public class BrandCreateRequest
    {
        [Required]
        public string Name { get; set; }
        public IFormFile ImageFile { get; set; }
    }
}
