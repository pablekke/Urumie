using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Controllers
{
    public class Propietario : Usuario
    {
        private List<Alquiler> _alquileres = new List<Alquiler>();

        public Propietario() : base()
        {
        }

        public void AltaAlquiler(Alquiler? a)
        {
            a.EsValido();
            _alquileres.Add(a);
        }

    }
}
