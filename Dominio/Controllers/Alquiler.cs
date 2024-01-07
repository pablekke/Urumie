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
        public Habitable? Habitable { get; set; }
        public string? Inmobiliaria { get; set; }
        public string? Descripcion { get; set; }
        public bool EsApto { get; set; }
        public bool Garage { get; set; }
        public bool Mascotas { get; set; }
        public int? Precio { get; set; }
        public int? GastosComunes { get; set; }

        public Alquiler()
        {
            Id = _ultimoId++;
            Bloqueado = false;
            Alquilado = false;
            Garage = false;
            Mascotas = false;
            EsApto = false;
        }
        public void Alquilar()
        {
            Alquilado = true;
        }
        public void NoAlquilar()
        {
            Alquilado = false;
        }
        public void BloquearAlquiler()
        {
            Bloqueado = true;
        }
        public void DesbloquearAlquiler()
        {
            Bloqueado = false;
        }
        public void EsValido()
        {
            if (Propietario is null)
            {
                throw new ArgumentNullException(nameof(Propietario));
            }
            if (Habitable is null)
            {
                throw new ArgumentNullException(nameof(Habitable));
            }
            if (string.IsNullOrEmpty(Descripcion))
            {
                throw new ArgumentNullException(nameof(Descripcion));
            }
            if (Precio is null)
            {
                throw new ArgumentNullException(nameof(Precio));
            }
            if (GastosComunes is null)
            {
                throw new ArgumentNullException(nameof(GastosComunes));
            }
        }
    }
}