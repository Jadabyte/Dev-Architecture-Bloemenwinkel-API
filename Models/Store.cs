using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FlowerStoreAPI.Models
{
    public class Store
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string Street { get; set; }

        [Required]
        public string Number { get; set; }

        [Required]
        public string Phone { get; set; }

        [Required]
        public string Email { get; set; }

        public List<Order> Orders { get; set; }
    }
}