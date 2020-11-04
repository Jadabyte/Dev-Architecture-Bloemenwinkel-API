using System.Collections.Generic;
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
        public ActionResult <IEnumerable<Product>> GetAllProducts()
        {
            var productItems = _repository.GetAllProducts();
            return Ok(productItems);
        }

        // GET api/products/{id}
        [HttpGet("{id}")]
        public ActionResult <Product> GetProductById(int id)
        {
            var productItem = _repository.GetProductById(id);
            return Ok(productItem);
        }
    }
}