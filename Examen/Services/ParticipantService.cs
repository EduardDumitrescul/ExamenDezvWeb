using Examen.Data.Models;
using Examen.Repositories;
using Repositories.TestRepository;

namespace Examen.Services
{
    public class ParticipantService
    {
        private readonly ParticipantRepository _participntRepository;

        public ParticipantService(ParticipantRepository participantRepository)
        {
            _participntRepository = participantRepository;
        }

        public async Task<List<Participant>> GetAll()
        {
            return await _participntRepository.GetAllAsync();
        }

        public async Task Create(Participant participant)
        {
            participant.Id = Guid.NewGuid();
            await _participntRepository.CreateAsync(participant);
            await _participntRepository.SaveAsync();
        }

        public void Delete(Guid id)
        {
            _participntRepository.DeleteById(id);
            _participntRepository.SaveAsync();
        }

        public async Task Update(Participant participant)
        {
            _participntRepository.Update(participant);
            await _participntRepository.SaveAsync();
        }
    }
}
