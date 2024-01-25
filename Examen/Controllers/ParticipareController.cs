using Examen.Data.Models;
using Examen.Services;
using Microsoft.AspNetCore.Mvc;

namespace Examen.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParticipareController : ControllerBase
    {
        private readonly ParticipareService _participareService;

        public ParticipareController(ParticipareService participareService)
        {
            _participareService = participareService;
        }

        [HttpGet("all")]
        public async Task<IActionResult> GetParticipari()
        {
            return Ok(await _participareService.GetAll());
        }

        [HttpPost("create")]
        public async Task<IActionResult> CreateParticipare([FromBody] Participare participare)
        {
            await _participareService.Create(participare);
            return Ok();
        }

        [HttpPatch("update")]
        public async Task<IActionResult> UpdateParticipare([FromBody] Participare participare)
        {
            await _participareService.Update(participare);
            return Ok();
        }

        [HttpDelete("delete/${id}")]
        public IActionResult DeleteParticipare(Guid id)
        {
            _participareService.Delete(id);
            return Ok();
        }
    }
}
