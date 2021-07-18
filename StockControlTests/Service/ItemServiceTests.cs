using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using StockControl.Model;
using System;

namespace StockControl.Service.Repository.Tests
{
    [TestClass()]
    public class ItemServiceTests
    {
        [TestMethod()]
        public void ItemServiceTest()
        {
            Mock<IItemRepository> mockRepository = new Mock<IItemRepository>();
            ItemService itemService = new ItemService(mockRepository.Object);

            int itemId = new Random().Next(300);

            itemService.GetStockCount(itemId);
            mockRepository.Verify(repository=>repository.GetStockCount(itemId),Times.Once);
        }
    }
}