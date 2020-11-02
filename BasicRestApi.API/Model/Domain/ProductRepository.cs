using BasicRestApi.Models.Domain;
using System;
using System.Collections.Generic;

namespace BasicRestAPI.Models.Domain
{
    public class ProductRepository : IProductRepository
    {
        private List<Product> products = new List<Product>();
        private int _nextId = 1;

        public ProductRepository()
        {
        Add(new Product { Name = "Roos", Category = "bloem", Price = 139 });
        Add(new Product { Name = "Agapanthus", Category = "bloem", Price = 499 });
        Add(new Product { Name = "Tulp", Category = "bloem", Price = 375 });
        Add(new Product { Name = "Zonnebloem", Category = "bloem", Price = 69 });
        Add(new Product { Name = "Camelia", Category = "bloem", Price = 399 });
    }

        public IEnumerable<Product> GetAll()
        {
            return products;
        }

        public Product Get(int id)
        {
            return products.Find(p => p.Id == id);
        }

        public Product Add(Product item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }
            item.Id = _nextId++;
            products.Add(item);
            return item;
        }

        public void Remove(int id)
        {
            products.RemoveAll(p => p.Id == id);
        }

        public bool Update(Product item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }
            int index = products.FindIndex(p => p.Id == item.Id);
            if (index == -1)
            {
                return false;
            }
            products.RemoveAt(index);
            products.Add(item);
            return true;
        }
    }
}