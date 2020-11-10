using BasicRestApi.API.Models;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace BasicRestApi.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClientsController : ControllerBase
    {

        private readonly ClientsRepository _repository = new ClientsRepository();
        [HttpGet]
        public ActionResult<IEnumerable<string>> GetAllClients()
        {
            var Clients = _repository.GetAll();
            if (Clients != null)
            {
                return Ok(Clients);
            }

            return NotFound();
        }

        [HttpGet("{id}")]
        public ActionResult<string> GetClientById(int id)
        {
            var Client = _repository.Get(id);
            if (Client != null)
            {
                return Ok(Client);
            }
            return NotFound();
        }

        [HttpPost]
        public ActionResult<ClientReadDto> CreateClient(ClientCreateDto clientcreatedto)
        {
            var ClientModel = _mapper.Map<Client>(clientcreatedto);
            _repository.CreateClient(ClientModel);
            return CreatedAtRoute(nameof(GetClientById),
            new
            {
                Id = ClientReadDto.Id
            },

                ClientReadDto);
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
        }
    }
}