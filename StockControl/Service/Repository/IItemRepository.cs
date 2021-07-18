namespace StockControl.Service.Repository
{
    public interface IItemRepository
    {
        public int GetStockCount(int itemId);
    }
}
