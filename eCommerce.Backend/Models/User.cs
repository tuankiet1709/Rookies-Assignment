using Microsoft.AspNetCore.Identity;

namespace eCommerce.Backend.Models
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Cart> Carts{get;set;}
        public List<Order> Orders{get;set;}
        // public User() : base()
        // {
        // }

        // public User(string userName) : base(userName)
        // {
        // }
        
    }
}