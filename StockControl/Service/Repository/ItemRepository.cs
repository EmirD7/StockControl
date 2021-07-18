using StockControl.CustomException;
using StockControl.Model;

namespace StockControl.Service.Repository
{
    public class ItemRepository : IItemRepository
    {
        private StockContext context;

        public ItemRepository(StockContext stockContext)
        {
            context = stockContext;
        }
        public int GetStockCount(int itemId)
        {
            var result = context.Item.Find(itemId);

            if (result == null)
            {
                throw new ItemNotFoundException(itemId);
            }
            return result.StockCount;
        }

    }
}
