using System;
using Xunit;
using Moq;
using Producto.Controllers;
using Models;
using MassTransit; // Reemplázalo con tu namespace real

public class ProductoServiceTests
{
    [Fact]
    public void GetProductById_ReturnsCorrectProduct()
    {
        // Arrange
        var mockDbContext = new Mock<AppDbContext>();
        var mockBus = new Mock<IBus>();
        var service = new ProductoController(mockDbContext.Object, mockBus.Object);

        // Act
        var result = service.Get();

        // Assert
        Assert.NotNull(result);
    }


     [Fact]
    public void GetTotal()
    {
        // Arrange
        var a = 11; 
        var b = 1; 
        var c = a + b;

        // Assert
        Assert.Equal(12, c);
    }
}
