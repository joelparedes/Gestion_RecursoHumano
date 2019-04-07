﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Gestion_RecursoHumano.Models
{
    public class Cargo
    {
        [Key]
        public int Id_Cargo { get; set; }
        [Required]
        public String Nombre_Cargo { get; set; }
            
        public Empleado Empleado { get; set; }
        public List<Empleado> Empleados { get; set; }
    }
}