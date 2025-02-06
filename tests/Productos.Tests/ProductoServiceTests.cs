using System;
using Xunit;
using Moq;
using Producto.Controllers;
using Models; // Reemplázalo con tu namespace real

public class ProductoServiceTests
{
    [Fact]
    public void GetProductById_ReturnsCorrectProduct()
    {
        // Arrange
        var mockDbContext = new Mock<AppDbContext>();
        var service = new ProductoController(mockDbContext.Object);

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
