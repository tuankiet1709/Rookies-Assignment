using Microsoft.EntityFrameworkCore;
using eCommerce.Backend.Models;
using eCommerce.Shared.Enum;

namespace eCommerce.Backend.Data.SeedData
{
    public static class AppConfigDataInitializer
    {
        public static void SeedAppConfigData(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppConfig>().HasData(
                new AppConfig() { Key = "HomeTitle", Value = "This is home page of eCommerceWebsite" },
                new AppConfig() { Key = "HomeKeyword", Value = "This is keyword of eCommerceWebsite" },
                new AppConfig() { Key = "HomeDescription", Value = "This is description of eCommerceWebsite" }
            );
        }
    }
}