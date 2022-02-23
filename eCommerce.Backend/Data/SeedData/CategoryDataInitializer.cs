using Microsoft.EntityFrameworkCore;
using eCommerce.Backend.Models;
using eCommerce.Shared.Enum;

namespace eCommerce.Backend.Data.SeedData
{
    public static class CategoryDataInitializer
    {
        public static void SeedCategoryData(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    Name = "Macbook's Accessories",
                    DateCreated=DateTime.Now,
                    SeoAlias="Macbook-accessories",
                    SeoDescription="The accessories products for Macbook",
                    SeoTitle="The accessories products for Macbook",
                    IsShowOnHome=true,
                    ParentId=null,
                    Status=Status.Active
                },
                new Category
                {
                    Id = 2,
                    Name = "Iphone's Accessories",
                    DateCreated=DateTime.Now,
                    SeoAlias="Iphone-accessories",
                    SeoDescription="The accessories product for Iphone",
                    SeoTitle="The accessories product for Iphone",
                    IsShowOnHome=true,
                    ParentId=null,
                    Status=Status.Active
                },
                new Category
                {
                    Id = 3,
                    Name = "Ipad's Accessories",
                    DateCreated=DateTime.Now,
                    SeoAlias="Ipad-accessories",
                    SeoDescription="The accessories product for Ipad",
                    SeoTitle="The accessories product for Ipad",
                    IsShowOnHome=true,
                    ParentId=null,
                    Status=Status.Active
                },
                new Category
                {
                    Id = 4,
                    Name = "Mechanical",
                    DateCreated=DateTime.Now,
                    SeoAlias="Mechanical",
                    SeoDescription="The Mechanical products for Apple devices",
                    SeoTitle="The Mechanical products for Apple devices",
                    IsShowOnHome=true,
                    ParentId=null,
                    Status=Status.Active
                },new Category
                {
                    Id = 5,
                    Name = "Macbook sticker",
                    DateCreated=DateTime.Now,
                    SeoAlias="macbook-sticker",
                    SeoDescription="Sticker for Macbook",
                    SeoTitle="Macbook sticker",
                    IsShowOnHome=true,
                    ParentId=1,
                    Status=Status.Active
                },new Category
                {
                    Id = 6,
                    Name = "Usb-c Hub",
                    DateCreated=DateTime.Now,
                    SeoAlias="usb-c-hub",
                    SeoDescription="Usb-c Hub",
                    SeoTitle="Usb-c Hub",
                    IsShowOnHome=true,
                    ParentId=1,
                    Status=Status.Active
                },new Category
                {
                    Id = 7,
                    Name = "Iphone Charging Cable",
                    DateCreated=DateTime.Now,
                    SeoAlias="iphone-charging-cable",
                    SeoDescription="The charging cable for Iphone",
                    SeoTitle="Iphone Charging Cable",
                    IsShowOnHome=true,
                    ParentId=2,
                    Status=Status.Active
                },new Category
                {
                    Id = 8,
                    Name = "Iphone Stand",
                    DateCreated=DateTime.Now,
                    SeoAlias="iphone-stand",
                    SeoDescription="Stand for Iphone",
                    SeoTitle="Iphone Stand",
                    IsShowOnHome=true,
                    ParentId=2,
                    Status=Status.Active
                },new Category
                {
                    Id = 9,
                    Name = "Ipad Case",
                    DateCreated=DateTime.Now,
                    SeoAlias="ipad-case",
                    SeoDescription="Case for Ipad",
                    SeoTitle="Ipad Case",
                    IsShowOnHome=true,
                    ParentId=3,
                    Status=Status.Active
                },new Category
                {
                    Id = 10,
                    Name = "Ipad Tempered Glass",
                    DateCreated=DateTime.Now,
                    SeoAlias="ipad-tempered-glass",
                    SeoDescription="Tempered glass for Ipad",
                    SeoTitle="Ipad Tempered Glass",
                    IsShowOnHome=true,
                    ParentId=3,
                    Status=Status.Active
                },new Category
                {
                    Id = 11,
                    Name = "Ipad Stand",
                    DateCreated=DateTime.Now,
                    SeoAlias="ipad-stand",
                    SeoDescription="Stand for Ipad",
                    SeoTitle="Ipad Stand",
                    IsShowOnHome=true,
                    ParentId=3,
                    Status=Status.Active
                },new Category
                {
                    Id = 12,
                    Name = "Mechanical Keyboard",
                    DateCreated=DateTime.Now,
                    SeoAlias="mechanical-keyboard",
                    SeoDescription="Mechanical Keyboard",
                    SeoTitle="Mechanical Keyboard",
                    IsShowOnHome=true,
                    ParentId=4,
                    Status=Status.Active
                },new Category
                {
                    Id = 13,
                    Name = "Mechanical Mouse",
                    DateCreated=DateTime.Now,
                    SeoAlias="mechanical-mouse",
                    SeoDescription="Mechanical Mouse",
                    SeoTitle="Mechanical Mouse",
                    IsShowOnHome=true,
                    ParentId=4,
                    Status=Status.Active
                },new Category
                {
                    Id = 14,
                    Name = "Macbook Cleaning Kit",
                    DateCreated=DateTime.Now,
                    SeoAlias="macbook-cleaning-kit",
                    SeoDescription="Macbook Cleaning Kit",
                    SeoTitle="Macbook Cleaning Kit",
                    IsShowOnHome=true,
                    ParentId=1,
                    Status=Status.Active
                }
            );
        }
    }
}