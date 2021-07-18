using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockControl.Service
{
    public class DatabaseSeeder 
    {
        public static void Seed(Model.StockContext stockContext) {
            stockContext.Database.EnsureDeleted();
            stockContext.Database.EnsureCreated();

            var item = new Model.Item();
            item.StockCount = 5;

            stockContext.Item.Add(item);
            stockContext.SaveChanges();
        }
    }
}
