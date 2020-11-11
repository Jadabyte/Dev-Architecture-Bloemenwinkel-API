using System.Collections.Generic;
using System.Threading.Tasks;
using FlowerStoreAPI.Data;
using FlowerStoreAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FlowerStoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : Controller
    {
        private readonly IFlowerStoreRepo _repository;

        public OrdersController(IFlowerStoreRepo repository)
        {
            _repository = repository;
        }

        // GET api/orders
        /// <summary>
        /// This GET-request gives you a list of all the clients of the flower store.
        /// </summary>
        /// <returns>A list of clients</returns>
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<Order>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetAllOrders()
        {
            var orderItems = await _repository.GetAllOrders();
            return Ok(orderItems);
        }

        // GET api/orders/{id}
        [HttpGet("{id}")]
        public async Task<IActionResult> GetOrderById(int id)
        {
            var orderItem = await _repository.GetOrderById(id);
            return Ok(orderItem);
        }

    }
}