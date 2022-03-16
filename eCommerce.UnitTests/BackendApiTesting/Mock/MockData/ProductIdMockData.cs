using System;
using System.Collections.Generic;
using eCommerce.UnitTests.BackendApiTesting.Mock.MockData;
using eCommerce.Shared.Dto.Product;
namespace eCommerce.UnitTests.BackendApiTesting.Mock.MockData;
public class ProductIdMockData
{
	// existing code hidden for display purpose
    public static ProductDto GetProductId()
    {
        return new ProductDto
        {
            Id = 31,
            Name = "product31",
            Description = "Description product 31",
            Details="Details product 31",
            OriginalPrice=2000000,
            Price=250000,
            IsFeatured=true,
            BrandId=4,
            CategoryId=5,
            CreatedDate = DateTime.Now,
        };
    }
}