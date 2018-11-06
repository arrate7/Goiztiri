using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Goiztiri.Models;
using GoiztiriWeb.Models;

namespace Goiztiri.Controllers
{
    public class JugadoresController : Controller
    {
        private GoiztiriFContext db = new GoiztiriFContext();

        // GET: Jugadores
        public ActionResult Index()
        {
            return View(db.Jugadores.ToList());
        }

        public ActionResult Femenino()
        {
            return View(db.Jugadores.ToList());
        }

        // GET: Jugadores/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Jugador jugador = db.Jugadores.Find(id);
            if (jugador == null)
            {
                return HttpNotFound();
            }
            return View(jugador);
        }

        // GET: Jugadores/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Jugadores/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CodJugador,Ruta,CodEquipo,Dorsal,Nombre,Apellido,Goles,Asistencias,Demarcacion")] Jugador jugador)
        {
            if (ModelState.IsValid)
            {
                db.Jugadores.Add(jugador);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(jugador);
        }

        // GET: Jugadores/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Jugador jugador = db.Jugadores.Find(id);
            if (jugador == null)
            {
                return HttpNotFound();
            }
            return View(jugador);
        }

        // POST: Jugadores/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CodJugador,Ruta,CodEquipo,Dorsal,Nombre,Apellido,Goles,Asistencias,Demarcacion")] Jugador jugador)
        {
            if (ModelState.IsValid)
            {
                db.Entry(jugador).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(jugador);
        }

        // GET: Jugadores/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Jugador jugador = db.Jugadores.Find(id);
            if (jugador == null)
            {
                return HttpNotFound();
            }
            return View(jugador);
        }

        // POST: Jugadores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Jugador jugador = db.Jugadores.Find(id);
            db.Jugadores.Remove(jugador);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
