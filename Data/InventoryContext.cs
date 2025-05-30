using Microsoft.EntityFrameworkCore;
using SmartInventoryApp.Models;
using System.Configuration;

namespace SmartInventoryApp.Data
{
    public class InventoryContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connStr = ConfigurationManager.ConnectionStrings["InventoryDb"].ConnectionString;

            optionsBuilder.UseSqlServer(connStr);
        }
    }
}
