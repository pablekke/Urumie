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
    }
}
