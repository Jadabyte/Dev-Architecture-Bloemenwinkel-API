using System.Collections.Generic;
using System.Threading.Tasks;
using FlowerStoreAPI.Data;
using FlowerStoreAPI.Models;
using FlowerStoreAPI.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using FlowerStoreAPI.Profiles;

namespace FlowerStoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientsController : Controller
    {
        private readonly IFlowerStoreRepo _repository;
        private readonly IMapper _mapper;

        // Dependency injection of repository
        public ClientsController(IFlowerStoreRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
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
        /// <summary>
        /// This GET-request gives you the product that corresponds to the requested Id.
        /// </summary>
        /// <returns>Requested item by Id</returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetClientById(int id)
        {
            var clientItem = await _repository.GetClientById(id);
            return Ok(clientItem);
        }
        
        /*
        [HttpPost]
        public ActionResult<ClientReadDto> CreateClient(ClientCreateDto clientCreateDto)
        {
            var clientModel = _mapper.Map<Client>(clientCreateDto);
            _repository.CreateClient(clientModel);
            _repository.SaveChanges();

            return CreatedAtRoute(nameof(GetClientById), new { Id = ClientReadDto.Id }, ClientReadDto);
        }
        [HttpPut("{id}")]
        public ActionResult UpdateClient(int id, ClientUpdateDto clientUpdateDto)
        {
            var clientModelFromRepo = _repository.GetClientById(id);

            if (clientModelFromRepo == null)
            {
                return NotFound();
            }

            _mapper.Map(clientUpdateDto, clientModelFromRepo);
            _repository.UpdateClient(clientModelFromRepo);
            _repository.SaveChanges();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteClient(int id)
        {
            var clientModelFromRepo = _repository.GetClientById(id);
            if (clientModelFromRepo == null)
            {
                return NotFound();
            }
            _repository.DeleteClient(clientModelFromRepo);
            _repository.SaveChanges();
            return NoContent();
        }*/
    }
}