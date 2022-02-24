using Microsoft.EntityFrameworkCore;
using eCommerce.Backend.Models;
using eCommerce.Shared.Enum;

namespace eCommerce.Backend.Data.SeedData
{
    public static class ProductCategoryDataInitializer
    {
        public static void SeedProductCategoryData(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductCategory>().HasData(
                new ProductCategory
                {
                    ProductId = 1,
                    CategoryId=14
                },new ProductCategory
                {
                    ProductId = 1,
                    CategoryId=1,
                },new ProductCategory
                {
                    ProductId = 2,
                    CategoryId=6,
                },new ProductCategory
                {
                    ProductId = 2,
                    CategoryId=1,
                },new ProductCategory
                {
                    ProductId = 3,
                    CategoryId=1
                },new ProductCategory
                {
                    ProductId = 3,
                    CategoryId=5
                },new ProductCategory
                {
                    ProductId = 4,
                    CategoryId = 2
                },new ProductCategory
                {
                    ProductId = 4,
                    CategoryId = 7
                },new ProductCategory
                {
                    ProductId = 5,
                    CategoryId = 2
                },new ProductCategory
                {
                    ProductId = 5,
                    CategoryId = 3
                },new ProductCategory
                {
                    ProductId = 5,
                    CategoryId = 8
                },new ProductCategory
                {
                    ProductId = 5,
                    CategoryId = 11
                },new ProductCategory
                {
                    ProductId = 6,
                    CategoryId = 3
                },new ProductCategory
                {
                    ProductId = 6,
                    CategoryId = 9
                },new ProductCategory
                {
                    ProductId = 7,
                    CategoryId = 3,
                },new ProductCategory
                {
                    ProductId = 7,
                    CategoryId = 10,
                },new ProductCategory
                {
                    ProductId = 8,
                    CategoryId=4
                },new ProductCategory
                {
                    ProductId = 8,
                    CategoryId=12
                },new ProductCategory
                {
                    ProductId = 9,
                    CategoryId=4
                },new ProductCategory
                {
                    ProductId = 9,
                    CategoryId=13
                }
            );
        }
    }
}