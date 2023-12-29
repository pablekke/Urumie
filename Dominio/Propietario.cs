using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Propietario : Usuario
    {
        private List<Alquiler> _alquileres = new List<Alquiler>();

        public Propietario(string? foto, string? nombre, string? apellido, string? email, string? pass) :base(foto, nombre, apellido, email, pass)
        {
        }

        public void AltaAlquiler(Alquiler a)
        {
            a.EsValido();
            _alquileres.Add(a);
        }

    }
}
