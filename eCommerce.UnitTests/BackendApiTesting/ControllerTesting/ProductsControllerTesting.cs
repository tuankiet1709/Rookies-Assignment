using System;
using AutoMapper;
using System.Collections.Generic;
using System.Threading.Tasks;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Moq;
using Xunit;
using eCommerce.Backend.Controllers;
using eCommerce.Shared.Dto;
using eCommerce.Shared.Dto.Product;
using eCommerce.UnitTests.BackendApiTesting.Mock.MockService;
using eCommerce.Shared.ViewModel.Product;
using eCommerce.UnitTests.BackendApiTesting.Mock.MockData;

namespace eCommerce.UnitTests;

public class ProductsControllerTesting
{
    [Fact]
    public async Task GetProductByIdAsync_WithUnexistingProduct_ReturnsNotFound()
    {
        //Arrange
        int productId=30;
        ProductDto productDto=new ProductDto();
        var productStub= new MockProductService().GetUnExistingProductByIdAsync();

        var productController= new ProductsController(productStub.Object);
        //Art
        var productResult = await productController.GetProductByIdAsync(productId);
        //Assert
        productResult.Result.Should().BeOfType<NotFoundResult>();
    }
    [Fact]
    public async Task GetProductByIdAsync_WithExistingProduct_ReturnsProductId()
    {
        //Arrange
        int productId=31;
        ProductDto productDto=new ProductDto();
        var productStub= new MockProductService().GetProductByIdAsync(ProductIdMockData.GetProductId());

        var productController= new ProductsController(productStub.Object);
        //Art
        var productResult = await productController.GetProductByIdAsync(productId);
        //Assert
        productResult.Value.Id.Should().Be(productId); 
    }
    [Fact]
    public async Task GetProductsAsync_WithExistingItems_ShouldReturn200Status()
    {
        //Arrange
        ProductCriteriaDto productCriteriaDto = new ProductCriteriaDto(){
            Search = "",
            SortOrder = 0,
            SortColumn = "1",
            Limit = 10,
            Page = 1,
            CategoryId=null,
        };

        var productStub= new MockProductService().GetAllProductAndPaging(ProductMockData.GetProducts());

        var productController= new ProductsController(productStub.Object);
        //Art
        var result = (OkObjectResult)await productController.GetProductAsync(productCriteriaDto);

        //Assert
        result.StatusCode.Should().Be(200);
    }
    [Fact]
    public async Task GetProductsAsync_WithExistingItemsAndProductName_ShouldReturn200Status()
    {
        //Arrange
        ProductCriteriaDto productCriteriaDto = new ProductCriteriaDto(){
            Search = "product1",
            SortOrder = 0,
            SortColumn = "1",
            Limit = 10,
            Page = 1,
            CategoryId=null,
        };

        var productStub= new MockProductService().GetAllProductAndPaging(ProductMockData.GetProducts());

        var productController= new ProductsController(productStub.Object);
        //Art
        var result = (OkObjectResult)await productController.GetProductAsync(productCriteriaDto);

        //Assert
        result.StatusCode.Should().Be(200);
    }
    [Fact]
    public async Task GetProductsAsync_WithExistingItemsAndCategoryId_ShouldReturn200Status()
    {
        //Arrange
        ProductCriteriaDto productCriteriaDto = new ProductCriteriaDto(){
            Search = "",
            SortOrder = 0,
            SortColumn = "1",
            Limit = 10,
            Page = 1,
            CategoryId=5,
        };

        var productStub= new MockProductService().GetAllProductAndPaging(ProductMockData.GetProducts());

        var productController= new ProductsController(productStub.Object);
        //Art
        var result = (OkObjectResult)await productController.GetProductAsync(productCriteriaDto);

        //Assert
        result.StatusCode.Should().Be(200);
    }
    [Fact]
    public async Task CreateItemAsync_WithItemToCreate_ReturnsCreatedItem()
    {
        // Arrange
        var productDto=new ProductDto();
        var productStub= new MockProductService().CreateProduct(productDto);
        var newProduct = ProductNewData.NewProduct();
        var controller = new ProductsController(productStub.Object);

        // Act
        var result = await controller.PostProduct(newProduct);

        // Assert
        result.Should().BeOfType<OkResult>();
    }

    [Fact]
    public async Task PutProduct_WittIdAndProductUpdateRequest_ReturnsOkResult()
    {
        // Arrange
        var testId = 41;
        var itemToUpdate = new ProductUpdateRequest();

        itemToUpdate.Name="product41edit";
        itemToUpdate.Price=230000;

        var existingProduct=ProductExistData.ExistProduct();
        var editProduct=ProductEditData.EditData();
        var productStub= new MockProductService().GetProductByIdAsync(existingProduct)
                                                .UpdateProduct();

        var controller = new ProductsController(productStub.Object);

        // Act
        var result = await controller.PutProduct(testId, itemToUpdate);

        // Assert
        result.Should().BeOfType<OkResult>();
    }

    [Fact]
    public async Task DeleteItemAsync_WithId_ReturnsOkResult()
    {
        // Arrange
        int testId=41;
        var existingProduct=ProductExistData.ExistProduct();

        var productStub= new MockProductService().GetProductByIdAsync(existingProduct)
                                                .DeleteProduct();

        var controller = new ProductsController(productStub.Object);

        // Act
        var result = await controller.DeleteProduct(testId);

        // Assert
        result.Should().BeOfType<OkResult>();
    }
}