using System;
using System.Collections.Generic;
using eCommerce.UnitTests.BackendApiTesting.Mock.MockData;
using eCommerce.Shared.Dto.Product;
using eCommerce.Shared.ViewModel.Product;

namespace eCommerce.UnitTests.BackendApiTesting.Mock.MockData;
public class ProductExistData
{
	// existing code hidden for display purpose
    public static ProductDto ExistProduct()
    {
        return new ProductDto
        {
            Id=41,
            Name = "product41",
            Description = "Description product 41",
            Details="Details product 41",
            OriginalPrice=2000000,
            Price=250000,
            IsFeatured=true,
            BrandId=4,
            CategoryId=5,
            isDeleted=false,
        };
    }
}