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
        public DateTime Edad { get; set; }
        public string? Descripcion { get; set; }
        public int? Pais { get; set; }
        public Preferencias? Preferencias { get; set; }

        public Inquilino()
        {
            Amigos = new List<Inquilino>();
            Lenguajes = new List<int>();
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

            if (Pais == null)
            {
                throw new ArgumentNullException(nameof(Pais), "El país es requerido.");
            }

            if (Preferencias == null)
            {
                throw new ArgumentNullException(nameof(Preferencias), "Las preferencias deben ser no nulas.");
            }
        }
    }
}