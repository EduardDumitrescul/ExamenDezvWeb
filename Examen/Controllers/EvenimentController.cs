using Examen.Data.Models;
using Examen.Services;
using Microsoft.AspNetCore.Mvc;
using Services.TestService;

namespace Examen.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EvenimentController : ControllerBase
    {
        private readonly EvenimentService _evenimentService;

        public EvenimentController(EvenimentService evenimentService)
        {
            _evenimentService = evenimentService;
        }

        [HttpGet("all")]
        public async Task<IActionResult> GetEvenimente()
        {
            return Ok(await _evenimentService.GetAll());
        }

        [HttpPost("create")]
        public async Task<IActionResult> CreateEveniment([FromBody] Eveniment eveniment)
        {
            await _evenimentService.Create(eveniment);
            return Ok();
        }

        [HttpPatch("update")]
        public async Task<IActionResult> UpdateEveniment([FromBody] Eveniment eveniment)
        {
            await _evenimentService.Update(eveniment);
            return Ok();
        }

        [HttpDelete("delete/${id}")]
        public IActionResult DeleteEveniment(Guid id)
        {
            _evenimentService.Delete(id);
            return Ok();
        }
    }
}
