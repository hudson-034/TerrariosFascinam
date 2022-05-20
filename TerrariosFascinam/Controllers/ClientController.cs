using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TerrariosFascinam.Model;
using TerrariosFascinam.Services;

namespace TerrariosFascinam.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClientController : ControllerBase
    {
        private readonly ILogger<ClientController> _logger;
        private IClientService _clientService;

        public ClientController(ILogger<ClientController> logger, IClientService clientService)
        {
            _logger = logger;
            _clientService = clientService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_clientService.FindAll());
        }

        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {
            var client = _clientService.FindById(id);
            if (client == null) return NotFound();
            return Ok(client);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Client client)
        {
            if (client == null) return BadRequest();
            return Ok(_clientService.Create(client));
        }

        [HttpPut]
        public IActionResult Put([FromBody] Client client)
        {
            if (client == null) return BadRequest();
            return Ok(_clientService.Update(client));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            _clientService.Delete(id);
            return NoContent();
        }
    }
}
