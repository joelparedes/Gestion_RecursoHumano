﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Gestion_RecursoHumano.Controllers
{
    public class GestionController : Controller
    {
        
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult RegistrarEmpleado() {

            return View();
        }

    }
}
