using System.Collections.Generic;
using System.Threading.Tasks;
using FlowerStoreAPI.Models;

namespace FlowerStoreAPI.Data
{
    public interface IFlowerStoreRepo
    {
        Task<IEnumerable<Store>> GetAllStores();
        Task<Store> GetStoreById(int id);
        Task<IEnumerable<Product>> GetAllProducts();
        Task<Product> GetProductById(int id);
        Task<Client> GetClientById(int id);
        Task<IEnumerable<Order>> GetAllOrders();
        Task<Order> GetOrderById(int id);
        Task<IEnumerable<Client>> GetAllClients();
    }
}