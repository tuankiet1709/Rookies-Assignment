using Microsoft.AspNetCore.Identity;

namespace eCommerce.Backend.Models
{
    public class AppUser : IdentityUser<Guid>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Dob { get; set; }
        public List<Cart> Carts{get;set;}
        public List<Order> Orders{get;set;}
    }
}