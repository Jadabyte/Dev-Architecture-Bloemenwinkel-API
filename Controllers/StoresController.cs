using System.Collections.Generic;
using System.Threading.Tasks;
using FlowerStoreAPI.Data;
using FlowerStoreAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace FlowerStoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StoresController : Controller
    {
        private readonly IFlowerStoreRepo _repository;

        // Dependency injection of repository
        public StoresController(IFlowerStoreRepo repository)
        {
            _repository = repository;
        }

        // private readonly MockFlowerStoreRepo _repository = new MockFlowerStoreRepo();
        
        // GET api/stores
        [HttpGet]
        public async Task<IActionResult> GetAllStores()
        {
            var storeItems = await _repository.GetAllStores();
            return Ok(storeItems);
        }

        // GET api/stores/{id}
        [HttpGet("{id}")]
        public async Task<IActionResult> GetStoreById(int id)
        {
            var storeItem = await _repository.GetStoreById(id);
            return Ok(storeItem);
        }
        /*
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
        }*/
    }
}