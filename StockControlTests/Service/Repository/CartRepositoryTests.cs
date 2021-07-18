using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using StockControl.Model;
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace StockControl.Service.Repository.Tests
{
    [TestClass()]
    public class CartRepositoryTests
    {
        [TestMethod()]
        public void AddCartTest()
        {
            int randomNumber = new Random().Next(300);

            Mock<StockContext> mockContext = new Mock<StockContext>();
            Mock<DbSet<Cart>> mockCartTable = new Mock<DbSet<Cart>>();
            Cart cart = new Cart();

            mockContext.Object.Cart = mockCartTable.Object;
            
            CartRepository cartRepository = new CartRepository(mockContext.Object);

            cartRepository.AddCart(cart);
            mockCartTable.Verify(table => table.Add(cart), Times.Once);
            mockContext.Verify(context => context.SaveChanges(),Times.Once);
        }
    }
}