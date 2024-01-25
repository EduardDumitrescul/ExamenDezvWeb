using Microsoft.EntityFrameworkCore;
using Models.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace Examen.Data.Models
{
    [Table("Evenimente")]
    public class Eveniment: BaseEntity
    {
        public string denumire {  get; set; }

        public ICollection<Participare> Participari { get; set; }
    }
}
