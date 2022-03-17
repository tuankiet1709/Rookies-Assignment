using System;
using System.Collections.Generic;
using System.Linq;
using Moq;
using eCommerce.Backend.Models;
using eCommerce.Shared.Dto.Product;
using eCommerce.Shared.Dto;

namespace eCommerce.UnitTests.BackendApiTesting.Mock.MockData
{
    public class ProductMockData 
    {
        public static PagedResponseDto<ProductDto> GetProducts(){
             return new PagedResponseDto<ProductDto>{   
                CurrentPage=1,
                TotalItems=10,
                TotalPages=1,
                Items=new ProductDto[]{
                    new ProductDto{
                        Id = 21,
                        Name = "product1",
                        Description = "Description product 1",
                        Details="Details product 1",
                        OriginalPrice=2000000,
                        Price=250000,
                        IsFeatured=true,
                        BrandId=4,
                        CategoryId=5,
                        CreatedDate = DateTime.Now,
                    },
                    new ProductDto{
                        Id = 22,
                        Name = "product2",
                        Description = "Description product 2",
                        Details="Details product 2",
                        OriginalPrice=2000000,
                        Price=250000,
                        IsFeatured=true,
                        BrandId=4,
                        CategoryId=5,
                        CreatedDate = DateTime.Now,
                    },
                    new ProductDto{
                        Id = 23,
                        Name = "product3",
                        Description = "Description product 3",
                        Details="Details product 3",
                        OriginalPrice=2000000,
                        Price=250000,
                        IsFeatured=true,
                        BrandId=4,
                        CategoryId=5,
                        CreatedDate = DateTime.Now,
                    },
                    new ProductDto{
                        Id = 24,
                        Name = "product4",
                        Description = "Description product 4",
                        Details="Details product 4",
                        OriginalPrice=2000000,
                        Price=250000,
                        IsFeatured=true,
                        BrandId=4,
                        CategoryId=5,
                        CreatedDate = DateTime.Now,
                    },
                    new ProductDto{
                        Id = 25,
                        Name = "product5",
                        Description = "Description product 5",
                        Details="Details product 5",
                        OriginalPrice=2000000,
                        Price=250000,
                        IsFeatured=true,
                        BrandId=4,
                        CategoryId=5,
                        CreatedDate = DateTime.Now,
                    },
                    new ProductDto{
                        Id = 26,
                        Name = "product6",
                        Description = "Description product 6",
                        Details="Details product 6",
                        OriginalPrice=2000000,
                        Price=250000,
                        IsFeatured=true,
                        BrandId=4,
                        CategoryId=5,
                        CreatedDate = DateTime.Now,
                    },
                    new ProductDto{
                        Id = 27,
                        Name = "product7",
                        Description = "Description product 7",
                        Details="Details product 7",
                        OriginalPrice=2000000,
                        Price=250000,
                        IsFeatured=true,
                        BrandId=4,
                        CategoryId=5,
                        CreatedDate = DateTime.Now,
                    },
                    new ProductDto{
                        Id = 28,
                        Name = "product8",
                        Description = "Description product 8",
                        Details="Details product 8",
                        OriginalPrice=2000000,
                        Price=250000,
                        IsFeatured=true,
                        BrandId=4,
                        CategoryId=5,
                        CreatedDate = DateTime.Now,
                    },
                    new ProductDto{
                        Id = 29,
                        Name = "product9",
                        Description = "Description product 9",
                        Details="Details product 9",
                        OriginalPrice=2000000,
                        Price=250000,
                        IsFeatured=true,
                        BrandId=4,
                        CategoryId=5,
                        CreatedDate = DateTime.Now,
                    },
                    new ProductDto{
                        Id = 30,
                        Name = "product10",
                        Description = "Description product 10",
                        Details="Details product 10",
                        OriginalPrice=2000000,
                        Price=250000,
                        IsFeatured=true,
                        BrandId=4,
                        CategoryId=5,
                        CreatedDate = DateTime.Now,
                    },
                }
            };
        }
        
    }
}