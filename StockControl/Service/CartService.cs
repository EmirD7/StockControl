using StockControl.CustomException;
using StockControl.Model;
using StockControl.Service.Repository;

namespace StockControl.Service
{
    public class CartService : ICartService
    {
        public ICartRepository repository;
        public IItemService itemService;
        public CartService(ICartRepository cartRepository, IItemService itemService)
        {
            repository = cartRepository;
            this.itemService = itemService;
        }

        public void AddCart(Cart cart)
        {
            if (itemService.GetStockCount(cart.ItemId) == 0)
                throw new NoStockException(cart.ItemId);

            repository.AddCart(cart);
        }
    }
}
