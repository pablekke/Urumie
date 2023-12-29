using System;
using System.Collections.Generic;
using System.Resources;

namespace Dominio.Controllers
{
    public class Alquiler
    {
        private static int _ultimoId { get; set; }
        public int Id { get; set; }
        public bool Bloqueado { get; set; }
        public bool Alquilado { get; set; }
        public Propietario? Propietario { get; set; }
        public string? Descripcion { get; set; }
        public Habitable habitable { get; set; }
        public string? NombreCalle { get; set; }
        public int? NumeroPuerta { get; set; }
        public bool EsApto { get; set; }
        public string? Apto { get; set; }
        public int CantidadBaños { get; set; }
        public int CantidadCuartos { get; set; }
        public bool Garage { get; set; }
        public int Pisos { get; set; }
        public
        public int Precio { get; set; }
        public int GastosComunes { get; set;}
    }
}
