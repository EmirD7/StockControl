using StockControl.Model;
using System;

namespace StockControl.Service.Repository
{
    public class CartRepository : ICartRepository
    {
        public StockContext context;
        public CartRepository(StockContext stockContext)
        {
            context = stockContext;
        }
        public void AddCart(Cart cart)
        {
            cart.TimeStamp = DateTime.Now;
            context.Cart.Add(cart);
            context.SaveChanges();
        }
    }
}
