using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Gestion_RecursoHumano.Models
{
    public class Permiso : Base.BaseEntity
    {
        //[ForeignKey("Empleado")]
        
        public String CodigoEmpleado { get; set; }
        public String Nombre_Empleado { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Inicio_Permiso { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Fin_Permiso { get; set; }
        public String Comentario { get; set; }

        private Empleado Empleado { get; set; }
        public List<Empleado> Empleados { get; set; }
    }
}
