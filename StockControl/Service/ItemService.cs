namespace StockControl.Service.Repository
{
    public class ItemService : IItemService
    {
        public IItemRepository repository;
        public ItemService(IItemRepository itemRepository)
        {
            repository = itemRepository;
        }
        public int GetStockCount(int itemId) {
            return repository.GetStockCount(itemId);
        }
    }
}
