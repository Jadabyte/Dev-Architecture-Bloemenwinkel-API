using System.Collections.Generic;
using FlowerStoreAPI.Data;
using FlowerStoreAPI.Models;
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
        [HttpGet]
        public ActionResult <IEnumerable<Client>> GetAllClients()
        {
            var clientItems = _repository.GetAllClients();
            return Ok(clientItems);
        }

        // GET api/clients/{id}
        [HttpGet("{id}")]
        public ActionResult <Client> GetClientById(int id)
        {
            var clientItem = _repository.GetClientById(id);
            return Ok(clientItem);
        }
    }
}