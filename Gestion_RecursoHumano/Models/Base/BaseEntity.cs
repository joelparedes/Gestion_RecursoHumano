
using System.ComponentModel.DataAnnotations;

namespace Gestion_RecursoHumano.Models.Base
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
    }
}