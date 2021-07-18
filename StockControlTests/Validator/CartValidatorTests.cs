using Microsoft.VisualStudio.TestTools.UnitTesting;
using StockControl.CustomException;
using StockControl.Model;
using System;

namespace StockControl.Validator.Tests
{
    [TestClass()]
    public class CartValidatorTests
    {
        [TestMethod()]
        public void ValidateTest_Success()
        {
            Cart cart = new Cart();
            cart.ItemId = 1;
            cart.Quantity = 2;
            cart.UserId = 3;
            cart.TimeStamp = DateTime.Now;

            try
            {
                CartValidator.Validate(cart);
            }
            catch (InvalidCartException)
            {
                Assert.Fail("Not expected invalid cart exception.");
            }
        }

        [TestMethod()]
        public void ValidateTest_Fail()
        {
            Cart cart = new Cart();
            cart.ItemId = 1;
            cart.Quantity = -2;
            cart.UserId = 3;
            cart.TimeStamp = DateTime.Now;

            Assert.ThrowsException<InvalidCartException>(() => CartValidator.Validate(cart), "Expected invalid cart exception.");
        }
    }
}