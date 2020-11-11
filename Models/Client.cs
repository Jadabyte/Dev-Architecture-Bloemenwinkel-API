using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FlowerStoreAPI.Models
{
    public class Client
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        public string Address { get; set; }

        public List<Order> Orders { get; set; }
    }
}