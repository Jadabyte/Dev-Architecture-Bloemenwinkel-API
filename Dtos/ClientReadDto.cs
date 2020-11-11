using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FlowerStoreAPI.Dtos
{
    public class ClientReadDto
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string Address { get; set; }

        //public List<Order> Orders { get; set; }
    }
}