using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GoiztiriWeb.Models
{
    public class Jugador
    {
        public string Ruta { get; set; }
        public int CodEquipo { get; set; }
        [Key]
        public int CodJugador{ get; set; }
        public int Dorsal { get; set; }
        public string Nombre{ get; set; }
        public string Apellido{ get; set; }
        public int Goles { get; set; }
        public int Asistencias { get; set; }
        public string Demarcacion{ get; set; }


    }
}