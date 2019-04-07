using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Gestion_RecursoHumano.Models
{
    
    public class Nomina : Base.BaseEntity
    {
        public DateTime Año { get; set; }
        public DateTime Mes { get; set; }
        public decimal Monto_Total { get; set; }

        private Empleado Empleado { get; set; }
        public List<Empleado> Empleados { get; set; }

    }
}