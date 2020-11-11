using System;
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

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        // Logic for GetAll
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

        // Logic for GetById
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

        // Logic for Create
        public void CreateProduct(Product prod)
        {
            if(prod == null)
            {
                throw new ArgumentNullException(nameof(prod));
            }

            _context.Products.Add(prod);
        }

        /*public void CreateClient(Client client)
        {
            if(client == null)
            {
                throw new ArgumentNullException(nameof(client));
            }

            _context.Clients.Add(client);
        }*/

        // Logic for Update
        public void UpdateProduct(Product prod)
        {
            //Do Nothing
        }

        // Logic for Delete
        public void DeleteProduct(Product prod)
        {
            if(prod == null)
            {
                throw new ArgumentNullException(nameof(prod));
            }
            _context.Products.Remove(prod);
        }
    }
}