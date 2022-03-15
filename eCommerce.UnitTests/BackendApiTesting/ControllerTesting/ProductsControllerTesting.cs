using System;
using AutoMapper;
using System.Collections.Generic;
using System.Threading.Tasks;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using Xunit;
using eCommerce.Backend.Controllers;
using eCommerce.Shared.Dto;
using eCommerce.Shared.Dto.Product;
using eCommerce.UnitTests.BackendApiTesting.Mock.MockService;
using eCommerce.Shared.ViewModel.Product;

namespace eCommerce.UnitTests;

public class ProductsControllerTesting
{
    private readonly Mock<IProductService> repositoryStub = new();
    private readonly MockProductService mockProductService = new();
    public ProductsControllerTesting(){
    }
    [Fact]
    public async Task GetProductByIdAsync_WithUnexistingProduct_ReturnsNotFound()
    {
        //Arrange
        int productId=20;
        ProductDto productDto=new ProductDto();
        var productStub= new MockProductService().GetUnExistingProductByIdAsync();

        var productController= new ProductsController(productStub.Object);
        //Art
        var productResult = await productController.GetProductByIdAsync(productId);
        //Assert
        productResult.Result.Should().BeOfType<NotFoundResult>();
    }
    [Fact]
    public async Task GetProductByIdAsync_WithExistingProduct_ReturnsNotFound()
    {
        //Arrange
        int productId=1;
        ProductDto productDto=new ProductDto();
        var productStub= new MockProductService().GetProductByIdAsync(productDto);

        var productController= new ProductsController(productStub.Object);
        //Art
        var productResult = await productController.GetProductByIdAsync(productId);
        //Assert
        productResult.Value.Should().BeEquivalentTo(productDto); 
    }
    [Fact]
    public async Task PutProduct_WithExistingItem_ReturnsNoContent()
    {
        // Arrange
        ProductDto existingProduct = new ProductDto();
        existingProduct.Id=10;

        var productStub= new MockProductService().GetProductByIdAsync(existingProduct);

        var Id = existingProduct.Id;
        var itemToUpdate = new ProductUpdateRequest();

        itemToUpdate.Name="unitTest";
        itemToUpdate.Price-=50000;

        var controller = new ProductsController(productStub.Object);

        // Act
        var result = await controller.PutProduct(Id, itemToUpdate);

        // Assert
        result.Should().BeOfType<NoContentResult>();
    }

    [Fact]
    public async Task DeleteItemAsync_WithExistingItem_ReturnsNoContent()
    {
        // Arrange
        ProductDto existingProduct = new ProductDto();
        existingProduct.Id=10;
        var productStub= new MockProductService().GetProductByIdAsync(existingProduct);

        var Id = existingProduct.Id;
        var itemToUpdate = new ProductUpdateRequest();

        itemToUpdate.isDeleted=true;

        var controller = new ProductsController(productStub.Object);

        // Act
        var result = await controller.DeleteProduct(Id);

        // Assert
        result.Should().BeOfType<NoContentResult>();
    }
}