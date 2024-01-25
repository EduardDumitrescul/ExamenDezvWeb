using Models.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace Examen.Data.Models
{
    [Table("Participari")]
    public class Participare: BaseEntity
    {
        [ForeignKey(nameof(Participant))]
        public Guid IdParticipant { get; set; }

        [ForeignKey(nameof(Eveniment))]
        public Guid IdEveniment { get; set; }
    }
}
