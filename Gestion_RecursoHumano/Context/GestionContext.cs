using Gestion_RecursoHumano.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Gestion_RecursoHumano.Context
{
    public class GestionContext: DbContext 
    {
        public GestionContext()
            : base("DefaultConnection")
        {
            
        }

        public DbSet<Empleado> Empleados { get; set; }  // Listado empleados
        public DbSet<Departamento> Departamentos { get; set; } // listado departamentos

        public System.Data.Entity.DbSet<Gestion_RecursoHumano.Models.Cargo> Cargoes { get; set; }
        //public DbSet<Cargo> Cargos { get; set; } // listado de cargos
        //public DbSet<Licencia> Licencias { get; set; } //listado licencias
        //public DbSet<Permiso> Permisos { get; set; } // listado permisos
        //public DbSet<Vacacion> Vacaciones { get; set; } // listado de vacaciones

    }
}