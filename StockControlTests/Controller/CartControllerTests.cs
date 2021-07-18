using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using StockControl.Model;
using StockControl.Service;

namespace StockControl.Controller.Tests
{
    [TestClass()]
    public class CartControllerTests
    {
        [TestMethod()]
        public void AddCartTest_Success()
        {
            Mock<ICartService> mockCartService = new Mock<ICartService>();
            CartController cartController = new CartController(mockCartService.Object);

            Cart cart = new Cart();
            cart.ItemId = 5;
            cart.Quantity = 1;
            cart.UserId = 1;
            var result = cartController.AddCart(cart) as OkObjectResult;
            mockCartService.Verify(service => service.AddCart(cart), Times.Once);

            Assert.IsNotNull(result);
            Assert.AreEqual(200, result.StatusCode);
        }

        [TestMethod()]
        public void AddCartTest_Fail()
        {
            Mock<ICartService> mockCartService = new Mock<ICartService>();
            CartController cartController = new CartController(mockCartService.Object);

            Cart cart = new Cart();
            cart.ItemId = -6;
            cart.Quantity = 1;
            cart.UserId = 1;
            var result = cartController.AddCart(cart) as BadRequestObjectResult;

            Assert.IsNotNull(result);
            Assert.AreEqual(400, result.StatusCode);
        }
    }
}