using Examen.Data.Models;
using Examen.Repositories;
using Repositories.TestRepository;

namespace Examen.Services
{
    public class EvenimentService
    {
        private readonly EvenimentRepository _evenimentRepository;

        public EvenimentService(EvenimentRepository evenimentRepository)
        {
            _evenimentRepository = evenimentRepository;
        }

        public async Task<List<Eveniment>> GetAll()
        {
            return await _evenimentRepository.GetAllAsync();
        }

        public async Task Create(Eveniment eveniment)
        {
            eveniment.Id = Guid.NewGuid();
            eveniment.Participari = [];
            await _evenimentRepository.CreateAsync(eveniment);
            await _evenimentRepository.SaveAsync();
        }

        public void Delete(Guid id)
        {
            _evenimentRepository.DeleteById(id);
            _evenimentRepository.SaveAsync();
        }

        public async Task Update(Eveniment eveniment)
        {
            _evenimentRepository.Update(eveniment);
            await _evenimentRepository.SaveAsync();
        }
    }
}
