using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Gestion_RecursoHumano.Models
{
    public class Salida_Empleado : Base.BaseEntity
    {
        //[ForeignKey("Empleado")]
        //[Column("CodigoEmpleado")]
        
        public String CodigoEmpleado { get; set; }

        //[ForeignKeyAttribute (DisplayColumnAttribute ("Nombre_Empleado"))]
        public String Nombre_Empleado { get; set; }

        [Required]
        public String Tipo_Salida { get; set; } //(Renuncia, Despido, Desahucio)

        [Required]
        public String Motivo { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Fecha_Salida { get; set; }

        private Empleado Empleado { get; set; }
        public List<Empleado> Empleados { get; set; }
    }
}