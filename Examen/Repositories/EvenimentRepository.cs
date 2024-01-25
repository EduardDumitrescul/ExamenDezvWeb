using Examen.Data;
using Examen.Data.Models;
using Repositories.GenericRepository;

namespace Examen.Repositories
{
    public class EvenimentRepository : GenericRepository<Eveniment>
    {
        public EvenimentRepository(ExamenContext dbContext) : base(dbContext)
        {
        }
    }
}
