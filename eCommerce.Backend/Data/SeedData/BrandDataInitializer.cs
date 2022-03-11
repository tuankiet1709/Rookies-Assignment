using Microsoft.EntityFrameworkCore;
using eCommerce.Backend.Models;
using eCommerce.Shared.Enum;

namespace eCommerce.Backend.Data.SeedData
{
    public static class BrandDataInitializer
    {
        public static void SeedBrandData(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Brand>().HasData(
                new Brand
                {
                    Id = 1,
                    Name = "Andora",
                    Image ="",
                    CreatedDate=DateTime.Now,
                    IsShowOnHome=true,
                    Status=Status.Active
                },
                new Brand
                {
                    Id = 2,
                    Name = "Apple",
                    Image ="",
                    CreatedDate=DateTime.Now,
                    IsShowOnHome=true,
                    Status=Status.Active
                },new Brand
                {
                    Id = 3,
                    Name = "Anker",
                    Image ="",
                    CreatedDate=DateTime.Now,
                    IsShowOnHome=true,
                    Status=Status.Active
                },new Brand
                {
                    Id = 4,
                    Name = "Baseus",
                    Image ="",
                    CreatedDate=DateTime.Now,
                    IsShowOnHome=true,
                    Status=Status.Active
                },new Brand
                {
                    Id = 5,
                    Name = "Hyper",
                    Image ="",
                    CreatedDate=DateTime.Now,
                    IsShowOnHome=true,
                    Status=Status.Active
                },new Brand
                {
                    Id = 6,
                    Name = "Filco",
                    Image ="",
                    CreatedDate=DateTime.Now,
                    IsShowOnHome=true,
                    Status=Status.Active
                },new Brand
                {
                    Id = 7,
                    Name = "JCPAL",
                    Image ="",
                    CreatedDate=DateTime.Now,
                    IsShowOnHome=true,
                    Status=Status.Active
                },new Brand
                {
                    Id = 8,
                    Name = "Keychrone",
                    Image ="",
                    CreatedDate=DateTime.Now,
                    IsShowOnHome=true,
                    Status=Status.Active
                },new Brand
                {
                    Id = 9,
                    Name = "Lofree",
                    Image ="",
                    CreatedDate=DateTime.Now,
                    IsShowOnHome=true,
                    Status=Status.Active
                },new Brand
                {
                    Id = 10,
                    Name = "Logitech",
                    Image ="",
                    CreatedDate=DateTime.Now,
                    IsShowOnHome=true,
                    Status=Status.Active
                },new Brand
                {
                    Id = 11,
                    Name = "Mocoll",
                    Image ="",
                    CreatedDate=DateTime.Now,
                    IsShowOnHome=true,
                    Status=Status.Active
                },new Brand
                {
                    Id = 13,
                    Name = "Philips",
                    Image ="",
                    CreatedDate=DateTime.Now,
                    IsShowOnHome=true,
                    Status=Status.Active
                },new Brand
                {
                    Id = 14,
                    Name = "Tucano",
                    Image ="",
                    CreatedDate=DateTime.Now,
                    IsShowOnHome=true,
                    Status=Status.Active
                },new Brand
                {
                    Id = 15,
                    Name = "WIWU",
                    Image ="",
                    CreatedDate=DateTime.Now,
                    IsShowOnHome=true,
                    Status=Status.Active
                }
            );
        }
    }
}