using System.Collections.Generic;
using System.Threading.Tasks;
using FlowerStoreAPI.Data;
using FlowerStoreAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace FlowerStoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : Controller
    {
        private readonly IFlowerStoreRepo _repository;

        // Dependency injection of repository
        public ProductsController(IFlowerStoreRepo repository)
        {
            _repository = repository;
        }

        // GET api/products
        [HttpGet]
        public async Task<IActionResult> GetAllProducts()
        {
            var productItems = await _repository.GetAllProducts();
            return Ok(productItems);
        }

        // GET api/products/{id}
        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductById(int id)
        {
            var productItem = await _repository.GetProductById(id);
            return Ok(productItem);
        }
    }
}