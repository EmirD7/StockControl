using StockControl.Model;
using System;
using System.Linq;

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

        public int GetReservedItemCount(int itemId)
        {
            return context.Cart
                .Where(cart => cart.ItemId == itemId)
                .Select(cart => cart.Quantity)
                .Sum();
        }
    }
}
