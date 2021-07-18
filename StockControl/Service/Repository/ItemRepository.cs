using StockControl.CustomException;
using StockControl.Model;
using System.Threading.Tasks;

namespace StockControl.Service.Repository
{
    public class ItemRepository
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
