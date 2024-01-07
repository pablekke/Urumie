using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Controllers
{
    public class Miembro : Usuario
    {
        private List<Mensaje> _mensajes = new List<Mensaje>();
        internal int? Telefono { get; set; }
        internal DateTime? FechaNacimiento { get; set; }
        internal Genero? Genero { get; set; }
        internal bool EmailVerificado { get; set; }

        public Miembro() : base()
        {
            EmailVerificado = false;
        }
        public override void EsValido()
        {
            base.EsValido();

            if (Telefono == null)
            {
                throw new ArgumentException("El número de teléfono es requerido.");
            }

            if (FechaNacimiento == null || FechaNacimiento > DateTime.Now)
            {
                throw new ArgumentException("La fecha de nacimiento no es válida.");
            }

            if (Genero == null)
            {
                throw new ArgumentNullException(nameof(Genero), "El género es requerido.");
            }
        }
    }
}
