using System.Collections.Generic;
using System.Threading.Tasks;
using FlowerStoreAPI.Data;
using FlowerStoreAPI.Models;
using FlowerStoreAPI.Dtos;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using FlowerStoreAPI.Profiles;
using Microsoft.AspNetCore.Http;

namespace FlowerStoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : Controller
    {
        private readonly IFlowerStoreRepo _repository;
        private readonly IMapper _mapper;

        // Dependency injection of repository
        public ProductsController(IFlowerStoreRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        // GET api/products
        /// <summary>
        /// This GET-request gives you a list of all the products
        /// </summary>
        /// <returns>List of Products</returns>
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<Product>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetAllProducts()
        {
            var productItems = await _repository.GetAllProducts();
            return Ok(productItems);
        }

        // GET api/products/{id}
        /// <summary>
        /// This GET-request gives you the product that corresponds to the requested Id.
        /// </summary>
        /// <returns>Requested item by Id</returns>
        [HttpGet("{id}", Name="GetProductById")]
        public async Task<IActionResult> GetProductById(int id)
        {
            var productItem = await _repository.GetProductById(id);
            return Ok(productItem);
        }

        // POST api/values
        /// <summary>
        /// This POST-request allows you to create a product.
        /// </summary>
        /// <returns>Created Product</returns>
        [HttpPost]
        public ActionResult<ProductReadDto>CreateProduct(ProductCreateDto productCreateDto)
        {
            var productModel = _mapper.Map<Product>(productCreateDto);
            _repository.CreateProduct(productModel);
            _repository.SaveChanges();

            var productReadDto = _mapper.Map<ProductReadDto>(productModel);
            
            return Ok(productModel);
            //return CreatedAtRoute(nameof(GetProductById), new { Id = ProductReadDto.Id }, ProductReadDto);
        }

        // PUT api/values/5
        /// <summary>
        /// This POST-request allows you to update a product.
        /// </summary>
        /// <returns>Update Product</returns>
        [HttpPut("{id}")]
        public ActionResult UpdateProduct(int id, ProductUpdateDto productUpdateDto)
        {
            var productModelFromRepo = _repository.GetProductById(id);
            if(productModelFromRepo == null)
            {
                return NotFound();
            }
            _mapper.Map(productUpdateDto, productModelFromRepo);
            //_repository.UpdateProduct(productModelFromRepo);
            _repository.SaveChanges();
            return NoContent();
        }

        // DELETE api/values/5
        /// <summary>
        /// This POST-request allows you to delete a product.
        /// </summary>
        /// <returns>Deleted Product</returns>
        [HttpDelete("{id}")]
        public ActionResult DeleteProduct(int id)
        {
            var productModelFromRepo = _repository.GetProductById(id);
            if (productModelFromRepo == null)
            {
                return NotFound();
            }
            //_repository.DeleteProduct(productModelFromRepo);
            _repository.SaveChanges();
            return NoContent();
        }
    }
}