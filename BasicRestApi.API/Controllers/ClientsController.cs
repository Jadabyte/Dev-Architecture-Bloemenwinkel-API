using BasicRestApi.API.Models;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace BasicRestApi.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClientsController : ControllerBase
    {
        [HttpGet]
        public ActionResult <IList<string>> GetAllClients()
        {
            return new List<string> { "value1", "value2" };
        }

        [HttpGet("{id}")]
        public ActionResult <IList<string>> GetClientById(int id)
        {
            return new List<string> { "value1" };
        }

        [HttpPost]
        public ActionResult CreateClient(string input)
        {
            return NotFound();
        }

        [HttpPut("{id}")]
        public ActionResult UpdateClient(string input)
        {
            return NotFound();
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteClient(int id)
        {
            return NotFound();
        }
    }
}