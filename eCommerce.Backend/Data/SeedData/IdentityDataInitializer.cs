using Microsoft.EntityFrameworkCore;
using eCommerce.Backend.Models;
using Microsoft.AspNetCore.Identity;
using eCommerce.Shared.Enum;

namespace eCommerce.Backend.Data.SeedData
{
    public static class IdentityDataInitializer
    {
        public static void SeedIdentityData(this ModelBuilder modelBuilder)
        {
            var userId=new Guid("CF517A65-75D0-480C-9566-601B1E607D25");
            var roleId=new Guid("725EFE2E-A534-40C4-AB0D-20C947E6C0EB");
            modelBuilder.Entity<AppRole>().HasData(new AppRole
            {
                Id = roleId,
                Name = "admin",
                NormalizedName = "admin",
                Description ="Administrator role"
            });
            var hasher = new PasswordHasher<AppUser>();
            modelBuilder.Entity<AppUser>().HasData(new AppUser
            {
                Id = userId,
                UserName = "admin",
                NormalizedUserName = "admin",
                Email = "tranhatuankiet1709@gmail.com",
                NormalizedEmail = "tranhatuankiet1709@gmail.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "123456"),
                SecurityStamp = string.Empty,
                FirstName = "Tu",
                LastName="Ki",
                Dob=DateTime.Now
                
            });
            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
            {
                RoleId = roleId,
                UserId = userId
            });
        }
    }
}