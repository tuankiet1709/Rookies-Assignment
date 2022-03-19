using Microsoft.EntityFrameworkCore;
using eCommerce.Backend.Models;
using Microsoft.AspNetCore.Identity;
using eCommerce.Shared.Constants;

namespace eCommerce.Backend.Data.SeedData
{
    public static class IdentityDataInitializer
    {
        public static void SeedRoles(RoleManager<IdentityRole> roleManager)
        {
            if (!roleManager.RoleExistsAsync(SecurityConstants.USER_ROLE).Result)
            {
                IdentityRole role = new IdentityRole();
                role.Name = SecurityConstants.USER_ROLE;
                IdentityResult roleResult = roleManager.CreateAsync(role).Result;
            }

            if (!roleManager.RoleExistsAsync(SecurityConstants.ADMINISTRATION_ROLE).Result)
            {
                IdentityRole role = new IdentityRole();
                role.Name = SecurityConstants.ADMINISTRATION_ROLE;
                IdentityResult roleResult = roleManager.CreateAsync(role).Result;
            }
        }

        public static void SeedUsers(UserManager<User> userManager)
        {
            if (userManager.FindByNameAsync("user").Result == null)
            {
                User user = new User();
                user.UserName = "user";
                user.Email = "user@gmail.com";
                user.FirstName="user";
                user.LastName="client 1";

                IdentityResult result = userManager.CreateAsync(user, "User@123").Result;

                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(user,SecurityConstants.USER_ROLE).Wait();
                }
            }


            if (userManager.FindByNameAsync("admin").Result == null)
            {
                User user = new User();
                user.UserName = "admin";
                user.Email = "admin@gmail.com";
                user.FirstName="user";
                user.LastName="admin 1";

                IdentityResult result = userManager.CreateAsync(user, "Admin@123").Result;

                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(user,SecurityConstants.ADMINISTRATION_ROLE).Wait();
                }
            }
        }
    }
}