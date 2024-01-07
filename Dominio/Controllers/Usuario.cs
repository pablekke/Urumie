using System;
using System.Collections.Generic;

namespace Dominio.Controllers
{

    public partial class Usuario
    {
        private static int _ultimoId { get; set; }
        public int Id { get; set; }

        public string? Foto { get; set; }

        public string? Nombre { get; set; }

        public string? Apellido { get; set; }

        public string? Email { get; set; }

        private string? Pass { get; set; }

        public Usuario()
        {
            Id = _ultimoId++;
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
