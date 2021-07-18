﻿using Microsoft.EntityFrameworkCore;

namespace StockControl.Model
{
    public class StockContext : DbContext
    {
        public DbSet<Cart> Cart { get; set; }
        public DbSet<Item> Item { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlite($"Data Source=stock.db");
    }
}
