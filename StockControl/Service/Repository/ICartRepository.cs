using StockControl.Model;

namespace StockControl.Service.Repository
{
    public interface ICartRepository
    {
        public void AddCart(Cart cart);

        public int GetReservedItemCount(int itemId);
    }
}
