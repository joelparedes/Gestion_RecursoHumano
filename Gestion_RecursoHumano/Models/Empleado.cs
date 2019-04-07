using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Gestion_RecursoHumano.Models
{
    public class Empleado : Base.BaseEntity
    {
        [Key]
        [Column(Order = 2)]
        [Index(IsUnique = true)]
        [StringLength(4)]
        public String CodigoEmpleado { get; set; }

        [Required (ErrorMessage ="Campo obligatorio")]
        [StringLength(50)]
        public String Nombre_Empleado { get; set; }

        [Required]
        [StringLength(50)]
        public String Apellido { get; set; }

        [DataType(DataType.PhoneNumber)]
        //[StringLength(10)]
        [MaxLength(10), MinLength(9)]
        public String Telefono { get; set; }

        // [ForeignKey("Departamento")]
        public int Id_Depto { get; set; }

        [Required]
        public String Nombre_Depto { get; set; }

        [Required]
        public String Id_Cargo { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime FechaIngreso { get; set; }

        public decimal Salario { get; set; }

        public String status { get; set; }

        public Departamento Departamento { get; set; } 
        public Cargo Cargo { get; set; }
        public Licencia Licencia { get; set; }
        public Permiso Permiso { get; set; }
        public Salida_Empleado Salida_Empleado { get; set; }
        public Vacacion Vacacion { get; set; }
        public Nomina Nomina { get; set; }

    }
}