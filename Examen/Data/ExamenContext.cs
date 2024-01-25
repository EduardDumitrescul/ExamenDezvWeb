using Examen.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Examen.Data
{
    public class ExamenContext: DbContext
    {
        public ExamenContext(DbContextOptions<ExamenContext> options) : base(options) { }

        public DbSet<Eveniment> Evenimente {  get; set; }
        public DbSet<Participant> Participanti {  get; set; }
        public DbSet<Participare> Participari {  get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
