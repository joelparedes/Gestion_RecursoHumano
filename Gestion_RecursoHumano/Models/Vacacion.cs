using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Gestion_RecursoHumano.Models
{
    public class Vacacion : Base.BaseEntity
    {
        public String CodigoEmpleado { get; set; }

        [Required]
        public String Nombre { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Inicio_Vacaciones { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Fin_Vacaciones { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Año { get; set; } // Correspondiente a: (año)

        public String Comentario { get; set; }

        private Empleado Empleado { get; set; }
        public List<Empleado> Empleados { get; set; }
    }
}