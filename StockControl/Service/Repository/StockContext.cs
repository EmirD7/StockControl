using Microsoft.EntityFrameworkCore;
using StockControl.Model;

namespace StockControl.Service.Repository
{
    public class StockContext : DbContext
    {
        public DbSet<Cart> Cart { get; set; }
        public DbSet<Item> Item { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlite($"Data Source=stock.db");
    }
}
