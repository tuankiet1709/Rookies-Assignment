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
                    DateCreated=DateTime.Now,
                    SeoAlias="Andora",
                    SeoDescription="Andora's accessories",
                    SeoTitle="Andora's accessories",
                    IsShowOnHome=true,
                    Status=Status.Active
                },
                new Brand
                {
                    Id = 2,
                    Name = "Apple",
                    Image ="",
                    DateCreated=DateTime.Now,
                    SeoAlias="Apple",
                    SeoDescription="Apple's accessories",
                    SeoTitle="Apple's accessories",
                    IsShowOnHome=true,
                    Status=Status.Active
                },new Brand
                {
                    Id = 3,
                    Name = "Anker",
                    Image ="",
                    DateCreated=DateTime.Now,
                    SeoAlias="Anker",
                    SeoDescription="Anker's accessories",
                    SeoTitle="Anker's accessories",
                    IsShowOnHome=true,
                    Status=Status.Active
                },new Brand
                {
                    Id = 4,
                    Name = "Baseus",
                    Image ="",
                    DateCreated=DateTime.Now,
                    SeoAlias="Baseus",
                    SeoDescription="Baseus's accessories",
                    SeoTitle="Baseus's accessories",
                    IsShowOnHome=true,
                    Status=Status.Active
                },new Brand
                {
                    Id = 5,
                    Name = "Hyper",
                    Image ="",
                    DateCreated=DateTime.Now,
                    SeoAlias="Hyper",
                    SeoDescription="Hyper's accessories",
                    SeoTitle="Hyper's accessories",
                    IsShowOnHome=true,
                    Status=Status.Active
                },new Brand
                {
                    Id = 6,
                    Name = "Filco",
                    Image ="",
                    DateCreated=DateTime.Now,
                    SeoAlias="Filco",
                    SeoDescription="Filco's accessories",
                    SeoTitle="Filco's accessories",
                    IsShowOnHome=true,
                    Status=Status.Active
                },new Brand
                {
                    Id = 7,
                    Name = "JCPAL",
                    Image ="",
                    DateCreated=DateTime.Now,
                    SeoAlias="JCPAL",
                    SeoDescription="JCPAL's accessories",
                    SeoTitle="JCPAL's accessories",
                    IsShowOnHome=true,
                    Status=Status.Active
                },new Brand
                {
                    Id = 8,
                    Name = "Keychrone",
                    Image ="",
                    DateCreated=DateTime.Now,
                    SeoAlias="Keychrone",
                    SeoDescription="Keychrone's accessories",
                    SeoTitle="Keychrone's accessories",
                    IsShowOnHome=true,
                    Status=Status.Active
                },new Brand
                {
                    Id = 9,
                    Name = "Lofree",
                    Image ="",
                    DateCreated=DateTime.Now,
                    SeoAlias="Lofree",
                    SeoDescription="Lofree's accessories",
                    SeoTitle="Lofree's accessories",
                    IsShowOnHome=true,
                    Status=Status.Active
                },new Brand
                {
                    Id = 10,
                    Name = "Logitech",
                    Image ="",
                    DateCreated=DateTime.Now,
                    SeoAlias="Logitech",
                    SeoDescription="Logitech's accessories",
                    SeoTitle="Logitech's accessories",
                    IsShowOnHome=true,
                    Status=Status.Active
                },new Brand
                {
                    Id = 11,
                    Name = "Mocoll",
                    Image ="",
                    DateCreated=DateTime.Now,
                    SeoAlias="Mocoll",
                    SeoDescription="Mocoll's accessories",
                    SeoTitle="Mocoll's accessories",
                    IsShowOnHome=true,
                    Status=Status.Active
                },new Brand
                {
                    Id = 13,
                    Name = "Philips",
                    Image ="",
                    DateCreated=DateTime.Now,
                    SeoAlias="Philips",
                    SeoDescription="Philips's accessories",
                    SeoTitle="Philips's accessories",
                    IsShowOnHome=true,
                    Status=Status.Active
                },new Brand
                {
                    Id = 14,
                    Name = "Tucano",
                    Image ="",
                    DateCreated=DateTime.Now,
                    SeoAlias="Tucano",
                    SeoDescription="Tucano's accessories",
                    SeoTitle="Tucano's accessories",
                    IsShowOnHome=true,
                    Status=Status.Active
                },new Brand
                {
                    Id = 15,
                    Name = "WIWU",
                    Image ="",
                    DateCreated=DateTime.Now,
                    SeoAlias="WIWU",
                    SeoDescription="WIWU's accessories",
                    SeoTitle="WIWU's accessories",
                    IsShowOnHome=true,
                    Status=Status.Active
                }
            );
        }
    }
}