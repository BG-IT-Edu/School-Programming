using Microsoft.EntityFrameworkCore;
using StoreDB.Data.Models;

namespace StoreDB.Data
{
    public class StoreDBContext : DbContext
    {
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=StoreDB");
        }
    }
}
