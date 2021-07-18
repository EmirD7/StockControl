using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using StockControl.Model;
using StockControl.Service.Repository;
using System;

namespace StockControl.Service.Tests
{
    [TestClass()]
    public class CartServiceTests
    {
        [TestMethod()]
        public void CartServiceTest()
        {
            Mock<ICartRepository> mockRepository = new Mock<ICartRepository>();
            Mock<IItemService> mockItemService = new Mock<IItemService>();

            CartService cartService = new CartService(mockRepository.Object, mockItemService.Object);
            Cart cart = new Cart();
            cart.ItemId = new Random().Next(300);
            int stock= new Random().Next(300);
            mockItemService.Setup(service => service.GetStockCount(cart.ItemId)).Returns(stock);

            cartService.AddCart(cart);
            mockItemService.Verify(service => service.GetStockCount(cart.ItemId), Times.Once);
            mockRepository.Verify(repository=> repository.AddCart(cart),Times.Once);

        }
    }
}