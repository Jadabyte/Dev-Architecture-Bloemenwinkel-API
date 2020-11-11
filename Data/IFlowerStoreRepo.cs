using System.Collections.Generic;
using System.Threading.Tasks;
using FlowerStoreAPI.Models;

namespace FlowerStoreAPI.Data
{
    public interface IFlowerStoreRepo
    {
        bool SaveChanges();

        Task<IEnumerable<Store>> GetAllStores();
        Task<Store> GetStoreById(int id);

        Task<IEnumerable<Product>> GetAllProducts();
        Task<Product> GetProductById(int id);
        void CreateProduct(Product prod);

        Task<IEnumerable<Client>> GetAllClients();
        Task<Client> GetClientById(int id);
        //void CreateClient(Client client);

        Task<IEnumerable<Order>> GetAllOrders();
        Task<Order> GetOrderById(int id);
    }
}