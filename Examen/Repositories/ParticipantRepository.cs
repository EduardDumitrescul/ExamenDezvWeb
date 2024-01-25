using Examen.Data;
using Examen.Data.Models;
using Repositories.GenericRepository;

namespace Examen.Repositories
{
    public class ParticipantRepository : GenericRepository<Participant>
    {
        public ParticipantRepository(ExamenContext dbContext) : base(dbContext)
        {
        }
    }
}
