using Fogueo2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fogueo2.Controllers
{
    public class AsignaturasController : Controller
    {
        // GET: Asignaturas
        public ActionResult Index()
        {
            //return View();
            var Asignaturas = from a in RecuperaAsignaturas()
                              orderby a.Id
                              select a;

            return View(Asignaturas); 
        }

        // GET: Asignaturas/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Asignaturas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Asignaturas/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Asignaturas/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Asignaturas/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Asignaturas/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Asignaturas/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        [NonAction]
        public List<Asignaturas> RecuperaAsignaturas()
        {
            return new List<Asignaturas>
            {
                new Asignaturas
                {
                    Id=006,
                    Nombre="Programacion II",
                    Creditos=4,
                },
                new Asignaturas
                {
                    Id=006,
                    Nombre="Auditoria Informatica",
                    Creditos=4,
                }
            };
        }
    }
}
