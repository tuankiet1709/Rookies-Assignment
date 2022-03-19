using System;
using System.Collections.Generic;
using eCommerce.UnitTests.BackendApiTesting.Mock.MockData;
using eCommerce.Shared.Dto.Product;
using eCommerce.Shared.ViewModel.Product;

namespace eCommerce.UnitTests.BackendApiTesting.Mock.MockData;
public class ProductNewData
{
	// existing code hidden for display purpose
    public static ProductCreateRequest NewProduct()
    {
        return new ProductCreateRequest
        {
            Name = "product40",
            Description = "Description product 40",
            Details="Details product 40",
            OriginalPrice=2000000,
            Price=250000,
            IsFeatured=true,
            BrandId=4,
            CategoryId=5,
        };
    }
}