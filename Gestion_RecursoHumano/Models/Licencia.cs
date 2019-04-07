using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Gestion_RecursoHumano.Models
{
    [Table("Licencia")]
    public class Licencia : Base.BaseEntity
    {
        public String CodigoEmpleado { get; set; }

        [Required(ErrorMessage ="Campo obligatorio")]
        public String Nombre { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Inicio_Permiso { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Fin_Permiso { get; set; }

        [Required]
        public String Motivo { get; set; }
        public String Comentario { get; set; }
        
        public Empleado Empleado { get; set; }
        public List<Empleado> Empleados { get; set; }
    }
}