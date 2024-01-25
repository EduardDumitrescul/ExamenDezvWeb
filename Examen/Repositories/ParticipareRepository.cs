using Examen.Data;
using Examen.Data.Models;
using Repositories.GenericRepository;

namespace Examen.Repositories
{
    public class ParticipareRepository : GenericRepository<Participare>
    {
        public ParticipareRepository(ExamenContext dbContext) : base(dbContext)
        {
        }
    }
}
