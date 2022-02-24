using Microsoft.AspNetCore.Identity;

namespace eCommerce.Backend.Models
{
    public class AppRole : IdentityRole<Guid>
    {
        public string Description { get; set; }
    }
}