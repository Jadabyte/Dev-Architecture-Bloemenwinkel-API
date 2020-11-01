namespace BasicRestAPI.Models.Domain
{
    public class ProductRepository : IProductRepository
    {
        private List<Product> products = new List<Product>();
        private int _nextId = 1;

        public ProductRepository()
        {
        Add(new Product { Name = "Roos", Category = "bloem", Price = 1.39 });
        Add(new Product { Name = "Agapanthus", Category = "bloem", Price = 4.99 });
        Add(new Product { Name = "Tulp", Category = "bloem", Price = 3.75 });
        Add(new Product { Name = "Zonnebloem", Category = "bloem", Price = 6.99 });
        Add(new Product { Name = "Camelia", Category = "bloem", Price = 3.99 });
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