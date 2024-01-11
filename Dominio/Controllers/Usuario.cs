using System;
using System.Collections.Generic;
using System.Net.Http.Headers;

namespace Dominio.Controllers
{

    public partial class Usuario
    {
        private static int _ultimoId { get; set; }
        public int Id { get; set; }
        public bool Bloqueado { get; set; }
        public string? Foto { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? Email { get; set; }
        public string? Pass { get; set; }
        public DateTime? FechaAlta { get; set; }
        public DateTime? FechaBaja { get; set; }

        public Usuario()
        {
            Id = _ultimoId++;
            FechaAlta = DateTime.Now;
            FechaBaja = null;
        }
        public Usuario(bool bloqueado, string foto, string nombre, string apellido, string email, string pass, Genero genero)
        {
            Id = _ultimoId++;
            Bloqueado = bloqueado;
            Foto = foto;
            Nombre = nombre;
            Apellido = apellido;
            Email = email;
            Pass = pass;
            FechaAlta = DateTime.Now;
            FechaBaja = null;
        }

        public void BloquearUsuario() {
            Bloqueado = true;
        }
        public void DesbloquearUsuario()
        {
            Bloqueado = false;
        }

        public bool ValidarCredenciales(string e , string p) {
            bool ret = false;
            if (Email == e && Pass == p) { 
                ret = true;
            }
            return ret;
        }

        public virtual void EsValido()
        {
            if (string.IsNullOrEmpty(Foto))
            {
                throw new ArgumentNullException(nameof(Foto), "La foto es requerida.");
            }
            if (string.IsNullOrEmpty(Nombre))
            {
                throw new ArgumentNullException(nameof(Nombre), "El nombre es requerido.");
            }
            if (string.IsNullOrEmpty(Apellido))
            {
                throw new ArgumentNullException(nameof(Apellido), "El apellido es requerido.");
            }
            if (string.IsNullOrEmpty(Email))
            {
                throw new ArgumentNullException(nameof(Email), "El email es requerido.");
            }
            if (string.IsNullOrEmpty(Email))
            {
                throw new ArgumentNullException(nameof(Pass), "La contraseña es requerida.");
            }
        }
    }
}