using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Alquiler
    {
        private static int _ultimoId { get; set; }
        public int Id { get; set; }
        internal Propietario Dueño { get; set; }
        internal string Descripcion { get; set; }
        internal string NombreCalle { get; set; }
        internal int NumeroPuerta { get; set; }
        internal bool EsApto { get; set; }
        internal string? Apto { get; set; }
        internal int CantidadBaños { get; set; }
        internal int CantidadCuartos { get; set; }
        internal bool Garage { get; set; }
        internal int Pisos { get; set; }
        internal int GastosComunes { get; set; }
        internal int Precio { get; set; }
        internal bool Alquilado { get; set; }
        internal bool Bloqueado { get; set; }

        public Alquiler(Propietario propietario, string descripcion, string nombreCalle, int numeroPuerta, bool esApto, string? apto, int cantidadBaños, int cantidadCuartos, bool garage, int pisos, int gastosComunes, int precio)
        {
            Id = _ultimoId++;
            Descripcion = descripcion;
            Dueño = propietario;
            NombreCalle = nombreCalle;
            NumeroPuerta = numeroPuerta;
            EsApto = esApto;
            Apto = apto;
            CantidadBaños = cantidadBaños;
            CantidadCuartos = cantidadCuartos;
            Garage = garage;
            Pisos = pisos;
            GastosComunes = gastosComunes;
            Precio = precio;
            Bloqueado = false;
            Alquilado = false;
        }
        
        public Alquiler()
        {
            Id = _ultimoId++;
            Bloqueado = false;
            Alquilado = false;
        }

        public void Alquilar()
        {
            Alquilado = true;
        }

        public void NoAlquilar()
        {
            Alquilado = false;
        }

        public void Bloquear()
        {
            Bloqueado = true;
        }

        public void Desbloquear()
        {
            Bloqueado = false;
        }

        public void EsValido()
        {
            if (string.IsNullOrEmpty(Descripcion))
            {
                throw new ArgumentNullException("Descripción vacía.");
            }
            if (string.IsNullOrEmpty(NombreCalle))
            {
                throw new ArgumentNullException("Nombre de calle vacío.");
            }
            if (NumeroPuerta <= 0)
            {
                throw new ArgumentException("Número de puerta inválido.");
            }
            if (CantidadBaños < 0)
            {
                throw new ArgumentException("Cantidad de baños inválida.");
            }
            if (CantidadCuartos < 0)
            {
                throw new ArgumentException("Cantidad de cuartos inválida.");
            }
            if (Pisos <= 0)
            {
                throw new ArgumentException("Número de pisos inválido.");
            }
            if (GastosComunes < 0)
            {
                throw new ArgumentException("Gastos comunes inválidos.");
            }
            if (Precio <= 0)
            {
                throw new ArgumentException("Precio inválido.");
            }
        }

        public override string ToString()
        {
            return $"Id: {Id}, Descripción: {Descripcion ?? "N/A"}, Calle: {NombreCalle ?? "N/A"}, Número: {NumeroPuerta}, " +
                $"Apto: {Apto ?? "N/A"}, Baños: {CantidadBaños}, Cuartos: {CantidadCuartos}, Garage: {Garage}, " +
                $"Pisos: {Pisos}, Gastos comunes: {GastosComunes}, Precio: {Precio}, Alquilado: {Alquilado}, Bloqueado: {Bloqueado}";
        }

    }
}
