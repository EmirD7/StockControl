using StockControl.Model;

namespace StockControl.Service.Repository
{
    public class CartRepository
    {
        public StockContext context;
        public CartRepository(StockContext stockContext)
        {
            context = stockContext;
        }
        public void AddCart(Cart cart)
        {
            var result = context.Cart.Add(cart);
            context.SaveChanges();
        }
    }
}
