using System.Collections.Generic;
using FlowerStoreAPI.Data;
using FlowerStoreAPI.Models;
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
        [HttpGet]
        public ActionResult <IEnumerable<Order>> GetAllOrders()
        {
            var orderItems = _repository.GetAllOrders();
            return Ok(orderItems);
        }

        // GET api/orders/{id}
        [HttpGet("{id}")]
        public ActionResult <Order> GetOrderById(int id) {
            var orderItem = _repository.GetOrderById(id);
            return Ok(orderItem);
        }

    }
}