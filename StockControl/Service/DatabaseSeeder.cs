using StockControl.Service.Repository;

namespace StockControl.Service
{
    public class DatabaseSeeder 
    {
        public static void Seed(StockContext stockContext) {
            stockContext.Database.EnsureDeleted();
            stockContext.Database.EnsureCreated();

            var item = new Model.Item();
            item.Id = 5000;
            item.StockCount = 5;

            stockContext.Item.Add(item);
            stockContext.SaveChanges();
        }
    }
}
