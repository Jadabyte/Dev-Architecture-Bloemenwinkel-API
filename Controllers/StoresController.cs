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
    }
}