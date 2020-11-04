using System.Collections.Generic;
using FlowerStoreAPI.Models;

namespace FlowerStoreAPI.Data
{
    public interface IFlowerStoreRepo
    {
        IEnumerable<Store> GetAllStores();
        Store GetStoreById(int id);
        IEnumerable<Product> GetAllProducts();
        Product GetProductById(int id);
        IEnumerable<Client> GetAllClients();
        Client GetClientById(int id);
        IEnumerable<Order> GetAllOrders();
        Order GetOrderById(int id);
    }
}