using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Moq;
using eCommerce.Backend.Controllers;
using eCommerce.Backend.Models;
using eCommerce.Backend.Services;
using eCommerce.Shared.Dto.Product;
using eCommerce.Shared.Dto;
using eCommerce.Shared.ViewModel.Product;

namespace eCommerce.UnitTests.BackendApiTesting.Mock.MockService
{
    public class MockProductService : Mock<IProductService>
    {
        public MockProductService GetUnExistingProductByIdAsync()
        {
            Setup(x => x.GetProductByIdAsync(It.IsAny<int>())).ReturnsAsync((ProductDto)null);

            return this;
        }
        public MockProductService GetProductByIdAsync(ProductDto result)
        {
            Setup(x => x.GetProductByIdAsync(It.IsAny<int>())).ReturnsAsync(result);

            return this;
        }
        public MockProductService GetAllProductAndPaging(PagedResponseDto<ProductDto> result)
        {
            Setup(x => x.GetProductAsync(It.IsAny<ProductCriteriaDto>())).ReturnsAsync(result);

            return this;
        }
    }
}