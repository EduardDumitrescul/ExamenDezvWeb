using Examen.Data.Models;
using Examen.Services;
using Microsoft.AspNetCore.Mvc;

namespace Examen.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParticipantController : ControllerBase
    {
        private readonly ParticipantService _participantService;

        public ParticipantController(ParticipantService participantService)
        {
            _participantService = participantService;
        }

        [HttpGet("all")]
        public async Task<IActionResult> GetParticipanti()
        {
            return Ok(await _participantService.GetAll());
        }

        [HttpPost("create")]
        public async Task<IActionResult> CreateParticipant([FromBody] Participant participant)
        {
            await _participantService.Create(participant);
            return Ok();
        }

        [HttpPatch("update")]
        public async Task<IActionResult> UpdateParticipant([FromBody] Participant participant)
        {
            await _participantService.Update(participant);
            return Ok();
        }

        [HttpDelete("delete/${id}")]
        public IActionResult DeleteParticipant(Guid id)
        {
            _participantService.Delete(id);
            return Ok();
        }
    }
}
