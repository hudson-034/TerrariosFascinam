using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TerrariosFascinam.Business;
using TerrariosFascinam.Model;

namespace TerrariosFascinam.Controllers
{
    [ApiVersion("1")]
    [ApiController]
    [Route("api/[controller]/v{version:ApiVersion}")]
    public class InvestmentController : ControllerBase
    {
        private readonly ILogger<InvestmentController> _logger;
        private IInvestmentBusiness _investmentBusiness;

        public InvestmentController(ILogger<InvestmentController> logger, IInvestmentBusiness investmentBusiness)
        {
            _logger = logger;
            _investmentBusiness = investmentBusiness;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_investmentBusiness.FindAll());
        }

        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {
            var client = _investmentBusiness.FindById(id);
            if (client == null) return NotFound();
            return Ok(client);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Investment investment)
        {
            if (investment == null) return BadRequest();
            return Ok(_investmentBusiness.Create(investment));
        }

        [HttpPut]
        public IActionResult Put([FromBody] Investment investment)
        {
            if (investment == null) return BadRequest();
            return Ok(_investmentBusiness.Update(investment));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            _investmentBusiness.Delete(id);
            return NoContent();
        }
    }
}
