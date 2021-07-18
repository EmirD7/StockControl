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
            int stockCount = itemService.GetStockCount(cart.ItemId);
            int reservedCount = repository.GetReservedItemCount(cart.ItemId);

            if (cart.Quantity > stockCount)
            {
                throw new NoStockException(cart.ItemId, stockCount);
            }
            else if (cart.Quantity>(stockCount-reservedCount))
            {
                throw new StockReservedException(cart.ItemId, (stockCount - reservedCount));
            }

            repository.AddCart(cart);
        }
    }
}
