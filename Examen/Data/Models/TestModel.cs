
using Models.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace Examen.Data.Models
{
    [Table("TestModels")]
    public class TestModel: BaseEntity
    {
        public string Data { get; set; }
    }
}
