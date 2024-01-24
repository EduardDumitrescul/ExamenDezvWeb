using Microsoft.EntityFrameworkCore;

namespace Examen.Data
{
    public class ExamenContext: DbContext
    {
        public ExamenContext(DbContextOptions<ExamenContext> options) : base(options) { }
    }
}
