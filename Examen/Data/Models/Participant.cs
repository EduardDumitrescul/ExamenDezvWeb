using Models.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace Examen.Data.Models
{
    [Table("Participanti")]
    public class Participant: BaseEntity
    {
        public string nume { get; set; }

        public ICollection<Participare> Participari { get; set; } = [];
    }
}
