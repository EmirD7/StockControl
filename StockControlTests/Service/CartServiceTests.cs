using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using StockControl.CustomException;
using StockControl.Model;
using StockControl.Service.Repository;
using System;

namespace StockControl.Service.Tests
{
    [TestClass()]
    public class CartServiceTests
    {
        private static Cart cart;

        [ClassInitialize()]
        public static void Initialize(TestContext testContext)
        {
            cart = new Cart();
            cart.ItemId = new Random().Next(300);
            cart.Quantity = 5;
        }

        [TestMethod()]
        public void CartServiceTest_Success()
        {
            Mock<ICartRepository> mockRepository = new Mock<ICartRepository>();
            Mock<IItemService> mockItemService = new Mock<IItemService>();

            CartService cartService = new CartService(mockRepository.Object, mockItemService.Object);
            
            int stock = 5;
            mockItemService.Setup(service => service.GetStockCount(cart.ItemId)).Returns(stock);

            cartService.AddCart(cart);
            mockItemService.Verify(service => service.GetStockCount(cart.ItemId), Times.Once);
            mockRepository.Verify(repository => repository.AddCart(cart), Times.Once);
        }

        [TestMethod()]
        public void CartServiceTest_Fail_NoStock()
        {
            Mock<ICartRepository> mockRepository = new Mock<ICartRepository>();
            Mock<IItemService> mockItemService = new Mock<IItemService>();

            CartService cartService = new CartService(mockRepository.Object, mockItemService.Object);
            int stock = 3;
            mockItemService.Setup(service => service.GetStockCount(cart.ItemId)).Returns(stock);

            Assert.ThrowsException<NoStockException>(() => cartService.AddCart(cart), "Expected no stock exception");

            mockItemService.Verify(service => service.GetStockCount(cart.ItemId), Times.Once);
            mockRepository.Verify(repository => repository.AddCart(cart), Times.Never);
        }

        [TestMethod()]
        public void CartServiceTest_Fail_AllReserved()
        {
            Mock<ICartRepository> mockRepository = new Mock<ICartRepository>();
            Mock<IItemService> mockItemService = new Mock<IItemService>();

            CartService cartService = new CartService(mockRepository.Object, mockItemService.Object);
            int stock = 10;
            mockItemService.Setup(service => service.GetStockCount(cart.ItemId)).Returns(stock);
            mockRepository.Setup(repository => repository.GetReservedItemCount(cart.ItemId)).Returns(6);


            Assert.ThrowsException<StockReservedException>(() => cartService.AddCart(cart), "Expected stock reserved exception");

            mockItemService.Verify(service => service.GetStockCount(cart.ItemId), Times.Once);
            mockRepository.Verify(repository => repository.AddCart(cart), Times.Never);
        }

    }
}