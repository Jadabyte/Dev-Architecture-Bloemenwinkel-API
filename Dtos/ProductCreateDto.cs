using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FlowerStoreAPI.Dtos
{
    public class ProductCreateDto
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Category { get; set; }

        [Required]
        public decimal Price { get; set; }

        //public List<Order> Orders { get; set; }
    }
}