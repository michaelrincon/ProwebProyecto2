using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Logica;
using Proyecto.Models;

namespace Proyecto.Controllers
{
    public class CiudadController : Controller
    {
        [Authorize(Roles ="Usuario")]
        // GET: Ciudad
        public ActionResult Index()
        {

            Int32 idciu = (int)TempData["idciu"];
            var listadepartamentos = new CiudadLogica().GetCiudadesDepartamento(idciu);
            TempData["idciu"] = idciu;
            return View(listadepartamentos);
        }


        // GET: Ciudad/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Ciudad/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,NombreCiudad")] Ciudad ciudad)
        {
            if (ModelState.IsValid)
            {
                Int32 idciu = (int)TempData["idciu"];
                new CiudadLogica().Create(ciudad,idciu);
                return RedirectToAction("Index");
            }

            return View(ciudad);
        }

        // GET: Ciudad/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ciudad ciudad = new CiudadLogica().GetCiudadById(id ?? 0);
            if (ciudad == null)
            {
                return HttpNotFound();
            }
            return View(ciudad);
        }

        // POST: Ciudad/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,NombreCiudad")] Ciudad ciudad)
        {
            if (ModelState.IsValid)
            {
                new CiudadLogica().Update(ciudad);
                return RedirectToAction("Index");
            }
            return View(ciudad);
        }

        // GET: Ciudad/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ciudad ciudad = new CiudadLogica().GetCiudadById(id ?? 0);
            if (ciudad == null)
            {
                return HttpNotFound();
            }
            return View(ciudad);
        }

        // POST: Ciudad/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            new CiudadLogica().Delete(id);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
            }
            base.Dispose(disposing);
        }
    }
}
