using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GoiztiriWeb.Models;

namespace GoiztiriWeb.Controllers
{
    public class JugadorController : Controller
    {
        // GET: Jugador
        public ActionResult Femenino()
        {
            //CREAMOS UNA INSTANCIA DEL MODELO JUGADOR
            var f1 = new Jugador()
            {
                Dorsal = 7, Nombre = "Arrate", Apellido = "Ortiz de Zarate", AnioInicio = 2014, Goles = 1, Asistencias = 1
            };
            return View(f1);
        }
    }
}