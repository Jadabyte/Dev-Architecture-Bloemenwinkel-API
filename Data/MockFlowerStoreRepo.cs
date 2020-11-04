using System.Collections.Generic;
using FlowerStoreAPI.Models;

namespace FlowerStoreAPI.Data
{
    public class MockFlowerStoreRepo : IFlowerStoreRepo
    {
        public IEnumerable<Client> GetAllClients()
        {
            var clients = new List<Client>
            {
                new Client { Id=0, FirstName="Peter", LastName="Jackson", Email="peter.jackson@email.com", Password="Test123", Address="XYZ Street, 45, TestCity1" },
                new Client { Id=1, FirstName="Lola", LastName="Peters", Email="lola.peters@email.com", Password="123XYZ", Address="ABC Street, 37, TestCity2" },
                new Client { Id=2, FirstName="Morgan", LastName="Winners", Email="morgan.winners@email.com", Password="ABCabc123", Address="KLM Street, 18, TestCity3" }
            };

            return clients;
        }

        public IEnumerable<Order> GetAllOrders()
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Product> GetAllProducts()
        {
            var products = new List<Product>
            {
                new Product { Id=0, Name="Tulip", Category="Dutch flowers", Price=5 },
                new Product { Id=1, Name="Rose", Category="Beautiful flowers", Price=4 },
                new Product { Id=3, Name="Violet", Category="Small flowers", Price=7 }
            };

            return products;
        }

        public IEnumerable<Store> GetAllStores()
        {
            var stores = new List<Store>
            {
                new Store { Id=0, City="Antwerp", Street="Meir", Number="1", Phone="28382392", Email="antwerp@test.com" },
                new Store { Id=1, City="Mechelen", Street="Bruul", Number="8", Phone="4356435", Email="mechelen@test.com" },
                new Store { Id=3, City="Brussels", Street="Nieuwstraat", Number="4", Phone="65234524", Email="brussels@test.com" }
            };

            return stores;
        }

        public Client GetClientById(int id)
        {
            return new Client { Id=0, FirstName="Peter", LastName="Jackson", Email="peter.jackson@email.com", Password="Test123", Address="XYZ Street, 45, TestCity" };
        }

        public Order GetOrderById(int id)
        {
            throw new System.NotImplementedException();
        }

        public Product GetProductById(int id)
        {
            return new Product { Id=0, Name="Tulip", Category="Dutch flowers", Price=5 };
        }

        public Store GetStoreById(int id)
        {
            return new Store { Id=0, City="Antwerp", Street="Meir", Number="1", Phone="28382392", Email="antwerp@test.com" };
        }

    }
}