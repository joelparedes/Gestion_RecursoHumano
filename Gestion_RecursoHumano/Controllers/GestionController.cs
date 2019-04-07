using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Unity;
using Gestion_RecursoHumano.Repositories;
using Gestion_RecursoHumano.Models;

namespace Gestion_RecursoHumano.Controllers
{
    public class GestionController : Controller
    {
        #region Repositories
        [Dependency]
        public IEmpleadoRepository empleadoRepository { get; set; }
        #endregion

        public ActionResult Index()
        {
            return View();
        }

        //funcion para agregar un nuevo empleado
        public ActionResult NuevoEmpleado(Empleado empleado)
        {
            //esta linea guarda el empleado recibido por el controller desde la vista
            this.empleadoRepository.Add(empleado);

            //esta linea hace el save, es decir guarda los cambios
            this.empleadoRepository.Save();

            //esta linea redirige el controller la metodo Index() del controller
            return RedirectToAction("Index");
        }

        //para actualizar un empleado
        public ActionResult ActualizarEmpleado(Empleado empleado)
        {
            if(this.empleadoRepository.Exist(x => x.Id == empleado.Id))
            {
                this.empleadoRepository.Update(empleado);
                this.empleadoRepository.Save();
            }
            return RedirectToAction("Index");
        }

        //funcion para buscar un empleado
        public ActionResult BuscarEmpleado(string textoBusqueda)
        {
            //esta linea busca al empleado por el nombre o por el apellido
            var empleado = this.empleadoRepository.Select(x => 
            x.Nombre_Empleado.Contains(textoBusqueda)
            || x.Apellido.Contains(textoBusqueda)
            );
            return RedirectToAction("Index", empleado);
        }

        public ActionResult RegistrarEmpleado()
        {

            return View();
        }

    }
}
