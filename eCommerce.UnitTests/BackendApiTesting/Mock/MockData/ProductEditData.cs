using System;
using System.Collections.Generic;
using eCommerce.UnitTests.BackendApiTesting.Mock.MockData;
using eCommerce.Shared.Dto.Product;
using eCommerce.Shared.ViewModel.Product;

namespace eCommerce.UnitTests.BackendApiTesting.Mock.MockData;
public class ProductEditData
{
	// existing code hidden for display purpose
    public static ProductDto EditData()
    {
        return new ProductDto
        {
            Id=41,
            Name = "product41edit",
            Description = "Description product 41",
            Details="Details product 41",
            OriginalPrice=2000000,
            Price=230000,
            IsFeatured=true,
            BrandId=4,
            CategoryId=5,
            isDeleted=false,
        };
    }
}