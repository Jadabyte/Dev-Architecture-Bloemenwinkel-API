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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>().HasData(new Client { Id = 1, FirstName = "John", LastName = "Swan", Email = "john.swan@example.com", Password = "JohnSwan123", Address = "ABC Street 1, Antwerp" });
            modelBuilder.Entity<Client>().HasData(new Client { Id = 2, FirstName = "Jack", LastName = "Shoveler", Email = "jack.shoveler@example.com", Password = "Js!123", Address = "DEF Street 2, Ghent" });
            modelBuilder.Entity<Client>().HasData(new Client { Id = 3, FirstName = "Jason", LastName = "Sparrow", Email = "jason.sparrow@example.com", Password = "SparrowIsMyName456", Address = "GHI Street 3, Brussels" });
            modelBuilder.Entity<Client>().HasData(new Client { Id = 4, FirstName = "Justin", LastName = "Starling", Email = "justin.starling@example.com", Password = "JustinWho?13", Address = "JKL Street 4, Bruges" });
            modelBuilder.Entity<Client>().HasData(new Client { Id = 5, FirstName = "Joseph", LastName = "Swift", Email = "joseph.swift@example.com", Password = "EasyPassword$9", Address = "MNO Street 5, Ostend" });

            modelBuilder.Entity<Store>().HasData(new Store { Id = 1, City = "Brussels", Street = "Nieuwstraat", Number = "12", Phone = "02 123 456", Email = "brussels@flowerstore.com" });
            modelBuilder.Entity<Store>().HasData(new Store { Id = 2, City = "Antwerp", Street = "Meir", Number = "130", Phone = "03 123 456", Email = "antwerp@flowerstore.com" });
            modelBuilder.Entity<Store>().HasData(new Store { Id = 3, City = "Ghent", Street = "Veldstraat", Number = "28", Phone = "09 123 456", Email = "ghent@flowerstore.com" });

            modelBuilder.Entity<Product>().HasData(new Product { Id = 1, Name = "Rose", Category = "Flowering plant", Price = 4.50M });
            modelBuilder.Entity<Product>().HasData(new Product { Id = 2, Name = "Tulip", Category = "Spring-blooming", Price = 2.50M });
            modelBuilder.Entity<Product>().HasData(new Product { Id = 3, Name = "Orchid", Category = "Flowering plant", Price = 2.50M });
            modelBuilder.Entity<Product>().HasData(new Product { Id = 4, Name = "Iris", Category = "Flowering plant", Price = 1.50M });
            modelBuilder.Entity<Product>().HasData(new Product { Id = 5, Name = "Sunflower", Category = "Flowering plant", Price = 3.50M });

            modelBuilder.Entity<Order>().HasData(new Order { Id = 1, Date = new System.DateTime(2020, 10, 18, 9, 30, 28), ClientId = 3, StoreId = 1, ProductId = 5 });
            modelBuilder.Entity<Order>().HasData(new Order { Id = 2, Date = new System.DateTime(2020, 10, 18, 10, 15, 33), ClientId = 1, StoreId = 2, ProductId = 4 });
            modelBuilder.Entity<Order>().HasData(new Order { Id = 3, Date = new System.DateTime(2020, 10, 18, 11, 58, 12), ClientId = 2, StoreId = 2, ProductId = 3 });
            modelBuilder.Entity<Order>().HasData(new Order { Id = 4, Date = new System.DateTime(2020, 10, 21, 9, 45, 46), ClientId = 5, StoreId = 3, ProductId = 1 });
            modelBuilder.Entity<Order>().HasData(new Order { Id = 5, Date = new System.DateTime(2020, 10, 21, 10, 02, 13), ClientId = 4, StoreId = 1, ProductId = 2 });
        }
    }
}