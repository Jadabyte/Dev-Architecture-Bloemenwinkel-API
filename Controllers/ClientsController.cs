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
    public class ClientsController : Controller
    {

        private readonly IFlowerStoreRepo _repository;

        // Dependency injection of repository
        public ClientsController(IFlowerStoreRepo repository)
        {
            _repository = repository;
        }

        // GET api/clients
        /// <summary>
        /// This GET-request gives you a list of all the clients of the flower store.
        /// </summary>
        /// <returns>A list of clients</returns>
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<Client>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetAllClients()
        {
            var clientItems = await _repository.GetAllClients();
            return Ok(clientItems);
        }

        // GET api/clients/{id}
        [HttpGet("{id}")]
        public async Task<IActionResult> GetClientById(int id)
        {
            var clientItem = await _repository.GetClientById(id);
            return Ok(clientItem);
        }
    }
}