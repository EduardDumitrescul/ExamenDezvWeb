using Examen.Data.Models;
using Examen.Repositories;
using Repositories.TestRepository;

namespace Examen.Services
{
    public class ParticipareService
    {
        private readonly ParticipareRepository _participareRepository;

        public ParticipareService(ParticipareRepository participareRepository)
        {
            _participareRepository = participareRepository;
        }

        public async Task<List<Participare>> GetAll()
        {
            return await _participareRepository.GetAllAsync();
        }

        public async Task Create(Participare participare)
        {
            await _participareRepository.CreateAsync(participare);
            await _participareRepository.SaveAsync();
        }

        public void Delete(Guid id)
        {
            _participareRepository.DeleteById(id);
            _participareRepository.SaveAsync();
        }

        public async Task Update(Participare participare)
        {
            _participareRepository.Update(participare);
            await _participareRepository.SaveAsync();
        }
    }
}
