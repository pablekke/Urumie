using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Controllers
{
    public class Miembro : Usuario
    {
        private List<Mensaje> _mensajes = new List<Mensaje>();
        internal int Teléfono { get; set; }
        internal DateTime FechaNacimiento { get; set; }
        internal Genero Genero { get; set; }
        internal bool EmailVerificado { get; set; }

        public Miembro() : base()
        {

        }
    }
}
