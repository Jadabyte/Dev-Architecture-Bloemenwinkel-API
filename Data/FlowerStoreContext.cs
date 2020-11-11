using FlowerStoreAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FlowerStoreAPI.Data
{
    public class FlowerStoreContext : DbContext
    {
        public FlowerStoreContext(DbContextOptions<FlowerStoreContext> opt) : base(opt)
        {
            
        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Store> Stores { get; set; }
    }
}