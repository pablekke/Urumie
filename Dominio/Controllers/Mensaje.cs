using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Controllers
{
    public class Mensaje
    {
        private static int _ultimoId { get; set; }
        public int Id { get; set; }
        public string? Contenido { get; set; }
        public Miembro? Emisor { get; set; }
        public Miembro? Receptor { get; set; }
        public DateTime? FechaEnvio { get; set; }

        public Mensaje() { }
        public void EsValido()
        {
            if (string.IsNullOrEmpty(Contenido))
            {
                throw new ArgumentNullException(nameof(Contenido), "El contenido es requerido y no puede estar vacío.");
            }

            if (Emisor == null)
            {
                throw new ArgumentNullException(nameof(Emisor), "El emisor es requerido.");
            }

            if (Receptor == null)
            {
                throw new ArgumentNullException(nameof(Receptor), "El receptor es requerido.");
            }

            if (FechaEnvio == null || FechaEnvio > DateTime.Now)
            {
                throw new ArgumentException("La fecha de envío es inválida.");
            }
        }
    }
}

