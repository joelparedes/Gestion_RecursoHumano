using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Gestion_RecursoHumano.Models
{
    public class Departamento : Base.BaseEntity
    {
        [Required]
        public String Codigo_Depto { get; set; }

        [StringLength(50)]
        public String Nombre_Depto { get; set; }

        public Empleado Empleado { get; set; }
        public List<Empleado> Empleados { get; set; }  
    }
}