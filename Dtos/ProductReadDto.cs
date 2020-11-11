using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FlowerStoreAPI.Dtos
{
    public class ProductReadDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Category { get; set; }

        public decimal Price { get; set; }

        //public List<Order> Orders { get; set; }
    }
}