using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Controllers
{
    public class Inquilino : Miembro
    {
        private List<Inquilino>? Amigos { get; set; }
        private List<int>? Lenguajes { get; set; }
        public string? Descripcion { get; set; }
        public Genero? GeneroPreferido { get; set; }
        public int? ZonaPreferida { get; set; }
        public List<int>? ZonasAlternativas { get; set; }
        public int? PresupuestoMin { get; set; }
        public int? PresupuestoMax { get; set; }
        public int? EdadMin { get; set; }
        public int? EdadMax { get; set; }

        public Inquilino()
        {
            Amigos = new List<Inquilino>();
            Lenguajes = new List<int>();
            ZonasAlternativas = new List<int>();
        }

        public List<Inquilino>? GetAmigos()
        {
            return Amigos;
        }

        public void AddAmigo(Inquilino a)
        {
            if (Amigos == null)
            {
                Amigos = new List<Inquilino>();
            }

            a.EsValido();

            if (Amigos.Contains(a))
            {
                throw new InvalidOperationException("El amigo ya está en la lista.");
            }

            Amigos.Add(a);
        }

        public List<int>? GetLenguajes()
        {
            return Lenguajes;
        }

        public void AddLenguaje(int l)
        {
            if (Lenguajes == null)
            {
                Lenguajes = new List<int>();
            }
            if (Lenguajes.Contains(l))
            {
                throw new InvalidOperationException("El lenguajes ya está en la lista.");
            }
            Lenguajes.Add(l);
        }

        public override void EsValido()
        {
            base.EsValido();
            if (string.IsNullOrEmpty(Descripcion))
            {
                throw new ArgumentNullException(nameof(Descripcion), "La descripción es requerida.");
            }

            if (GeneroPreferido == null)
            {
                throw new ArgumentNullException(nameof(GeneroPreferido), "El género preferido es requerido.");
            }

            if (ZonaPreferida == null)
            {
                throw new ArgumentNullException(nameof(ZonaPreferida), "La zona preferida es requerida.");
            }

            if (PresupuestoMin == null || PresupuestoMax == null || PresupuestoMin > PresupuestoMax)
            {
                throw new ArgumentException("Los valores de presupuesto son inválidos.");
            }

            if (EdadMin == null || EdadMax == null || EdadMin > EdadMax)
            {
                throw new ArgumentException("Los valores de edad son inválidos.");
            }
        }
    }
}