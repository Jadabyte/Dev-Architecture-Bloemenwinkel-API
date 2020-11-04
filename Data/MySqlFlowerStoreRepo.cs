using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FlowerStoreAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FlowerStoreAPI.Data
{
    public class MySqlFlowerStoreRepo : IFlowerStoreRepo
    {
        private readonly FlowerStoreContext _context;
        public MySqlFlowerStoreRepo(FlowerStoreContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Client>> GetAllClients()
        {
            return await _context.Clients.ToListAsync();
        }

        public async Task<IEnumerable<Order>> GetAllOrders()
        {
            return await _context.Orders.ToListAsync();
        }

        public async Task<IEnumerable<Product>> GetAllProducts()
        {
            return await _context.Products.ToListAsync();
        }

        public async Task<IEnumerable<Store>> GetAllStores()
        {
            return await _context.Stores.ToListAsync();
        }

        public async Task<Client> GetClientById(int id)
        {
            return await _context.Clients.FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<Order> GetOrderById(int id)
        {
            return await _context.Orders.FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<Product> GetProductById(int id)
        {
            return await _context.Products.FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<Store> GetStoreById(int id)
        {
            return await _context.Stores.FirstOrDefaultAsync(p => p.Id == id);
        }
    }
}