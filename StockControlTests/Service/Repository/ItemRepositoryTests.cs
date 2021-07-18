using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using StockControl.Model;
using System;
using Microsoft.EntityFrameworkCore;

namespace StockControl.Service.Repository.Tests
{
    [TestClass()]
    public class ItemRepositoryTests
    {

        [TestMethod()]
        public void GetStockCountTest()
        {
            int randomNumber = new Random().Next(300);

            StockContext context = new StockContext();
            Mock<DbSet<Item>> mockItemTable = new Mock<DbSet<Item>>();
            Mock<Item> mockItem = new Mock<Item>();

            mockItemTable.Setup(item=>item.Find(randomNumber)).Returns(mockItem.Object);
            context.Item = mockItemTable.Object;
            ItemRepository itemRepository = new ItemRepository(context);
            
            itemRepository.GetStockCount(randomNumber);
            mockItemTable.Verify(table => table.Find(randomNumber),Times.Once);
        }
    }
}