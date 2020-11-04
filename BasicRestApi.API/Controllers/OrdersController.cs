using System.Collections.Generic;
using BasicRestApi.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace BasicRestApi.API.Controllers
{
    [Route("api/orders")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly MockOrdersRepo _repository = new MockOrdersRepo();
        // GET api/orders
        [HttpGet]
        public ActionResult<IEnumerable<Order>> GetAllOrders()
        {
            var orderItems = _repository.GetAppOrders();

            return Ok(orderItems);
        }

        //GET api/orders/{id}
        [HttpGet("{id}")]
        public ActionResult<Order> GetOrderById(int id)
        {
            var orderItem = _repository.GetOrderById(id);
            return Ok(orderItem);
        }
    }
}