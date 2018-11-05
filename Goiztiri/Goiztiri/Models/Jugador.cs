using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GoiztiriWeb.Models
{
    public class Jugador
    {
        public int Dorsal { get; set; }
        public string Nombre{ get; set; }
        public string Apellido{ get; set; }
        public int AnioInicio { get; set; }
        public int Goles { get; set; }
        public int Asistencias { get; set; }

    }
}