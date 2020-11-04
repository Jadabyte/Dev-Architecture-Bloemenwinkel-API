using System.Collections.Generic;
using System.Linq;
using FlowerStoreAPI.Models;

namespace FlowerStoreAPI.Data
{
    public class MySqlFlowerStoreRepo : IFlowerStoreRepo
    {

        private readonly FlowerStoreContext _context;
        public MySqlFlowerStoreRepo(FlowerStoreContext context)
        {
            _context = context;
        }

        public IEnumerable<Client> GetAllClients()
        {
            return _context.Clients.ToList();
        }

        public IEnumerable<Order> GetAllOrders()
        {
            return _context.Orders.ToList();
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _context.Products.ToList();
        }

        public IEnumerable<Store> GetAllStores()
        {
            return _context.Stores.ToList();
        }

        public Client GetClientById(int id)
        {
            return _context.Clients.FirstOrDefault(p => p.Id == id);
        }

        public Order GetOrderById(int id)
        {
            return _context.Orders.FirstOrDefault(p => p.Id == id);
        }

        public Product GetProductById(int id)
        {
            return _context.Products.FirstOrDefault(p => p.Id == id);
        }

        public Store GetStoreById(int id)
        {
            return _context.Stores.FirstOrDefault(p => p.Id == id);
        }
    }
}