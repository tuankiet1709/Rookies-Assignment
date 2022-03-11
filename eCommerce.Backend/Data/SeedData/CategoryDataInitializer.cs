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
                    Description="Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                    CreatedDate=DateTime.Now,
                    IsShowOnHome=true,
                    ParentId=null,
                    Status=Status.Active
                },
                new Category
                {
                    Id = 2,
                    Name = "Iphone's Accessories",
                    Description="Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                    CreatedDate=DateTime.Now,
                    IsShowOnHome=true,
                    ParentId=null,
                    Status=Status.Active
                },
                new Category
                {
                    Id = 3,
                    Name = "Ipad's Accessories",
                    Description="Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                    CreatedDate=DateTime.Now,
                    IsShowOnHome=true,
                    ParentId=null,
                    Status=Status.Active
                },
                new Category
                {
                    Id = 4,
                    Name = "Mechanical",
                    Description="Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                    CreatedDate=DateTime.Now,
                    IsShowOnHome=true,
                    ParentId=null,
                    Status=Status.Active
                },new Category
                {
                    Id = 5,
                    Name = "Macbook sticker",
                    Description="Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                    CreatedDate=DateTime.Now,
                    IsShowOnHome=true,
                    ParentId=1,
                    Status=Status.Active
                },new Category
                {
                    Id = 6,
                    Name = "Usb-c Hub",
                    Description="Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                    CreatedDate=DateTime.Now,
                    IsShowOnHome=true,
                    ParentId=1,
                    Status=Status.Active
                },new Category
                {
                    Id = 7,
                    Name = "Iphone Charging Cable",
                    Description="Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                    CreatedDate=DateTime.Now,
                    IsShowOnHome=true,
                    ParentId=2,
                    Status=Status.Active
                },new Category
                {
                    Id = 8,
                    Name = "Iphone Stand",
                    Description="Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                    CreatedDate=DateTime.Now,
                    IsShowOnHome=true,
                    ParentId=2,
                    Status=Status.Active
                },new Category
                {
                    Id = 9,
                    Name = "Ipad Case",
                    Description="Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                    CreatedDate=DateTime.Now,
                    IsShowOnHome=true,
                    ParentId=3,
                    Status=Status.Active
                },new Category
                {
                    Id = 10,
                    Name = "Ipad Tempered Glass",
                    Description="Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                    CreatedDate=DateTime.Now,
                    IsShowOnHome=true,
                    ParentId=3,
                    Status=Status.Active
                },new Category
                {
                    Id = 11,
                    Name = "Ipad Stand",
                    Description="Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                    CreatedDate=DateTime.Now,
                    IsShowOnHome=true,
                    ParentId=3,
                    Status=Status.Active
                },new Category
                {
                    Id = 12,
                    Name = "Mechanical Keyboard",
                    Description="Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                    CreatedDate=DateTime.Now,
                    IsShowOnHome=true,
                    ParentId=4,
                    Status=Status.Active
                },new Category
                {
                    Id = 13,
                    Name = "Mechanical Mouse",
                    Description="Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                    CreatedDate=DateTime.Now,
                    IsShowOnHome=true,
                    ParentId=4,
                    Status=Status.Active
                },new Category
                {
                    Id = 14,
                    Name = "Macbook Cleaning Kit",
                    Description="Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                    CreatedDate=DateTime.Now,
                    IsShowOnHome=true,
                    ParentId=1,
                    Status=Status.Active
                }
            );
        }
    }
}