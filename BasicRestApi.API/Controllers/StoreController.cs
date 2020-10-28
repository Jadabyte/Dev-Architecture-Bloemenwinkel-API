using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BasicRestApi.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StoreController : Controller
    {
        // GET: api/Store

        [HttpGet]
        public IEnumerable<Store> Get()
        {
            return GetStores();
        }

        // GET: api/Store/2

        [HttpGet("{id}", Name = "Get")]
        public Store Get(int id)
        {
            return GetStores().Find(e => e.Id == id);
        }

        // POST: api/Store

        [HttpPost]
        [Produces("applications/json")]
        public Store Post([FromBody] Store store)
        {
            // Logic to create new store.
            return new Store();
        }

        // PUT: api/Store/2

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Store store)
        {
            // Logic to update a store.
        }

        // DELETE: api/Store/2

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            // Logic to delete a store.
        }

        private List<Store> GetStores()
        {
            return new List<Store>()
            {
                new Store()
                {
                    Id = 1,
                    City = "Antwerp",
                    Street = "Meir",
                    Number = "10",
                    Phone = "+32 3 666 22 11",
                    Email = "antwerp@test.com"
                },

                new Store()
                {
                    Id = 2,
                    City = "Mechelen",
                    Street = "Bruul",
                    Number = "20",
                    Phone = "+32 3 222 33 88",
                    Email = "mechelen@test.com"
                }

            };
        }
    }
}
