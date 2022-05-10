using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fogueo2.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Inicio()
        {
            return View();
        }

        public ActionResult DatosP()
        {
            ViewBag.Matricula = " 2016-4254";
            ViewBag.Carrera = "Desarrollo en Software";
            ViewBag.Nombre = "Emmanuel David";
            ViewBag.Apellido = "Carbonell Lopez";
            ViewBag.FechaNacimiento = "17/04/1998";
            ViewData["CorreoInstitucional"]= "20164254@itla.edu.do";
            ViewData["Seccion"] = "Grupo 1";

            int numag = ((23 * 23) * 23)* 2;
            ViewData["NumeroMagico"] = numag;
  
                                     
        



            return View();
        }
    }
}

