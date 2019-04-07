using Gestion_RecursoHumano.Context;
using Gestion_RecursoHumano.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gestion_RecursoHumano.Services
{
    public class GestionRepository
    {
        public List<Empleado> GetEmpleados() {
            using (var db = new GestionContext() )
            {
                return db.Empleados.ToList();
            }
        }
    }
}