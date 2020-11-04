using System.Collections.Generic;
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
        public ActionResult <IEnumerable<Store>> GetAllStores()
        {
            var storeItems = _repository.GetAllStores();
            return Ok(storeItems);
        }

        // GET api/stores/{id}
        [HttpGet("{id}")]
        public ActionResult <Store> GetStoreById(int id)
        {
            var storeItem = _repository.GetStoreById(id);
            return Ok(storeItem);
        }
    }
}