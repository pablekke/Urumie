using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Usuario
    {
        private static int _ultimoId { get; set; }
        public int Id { get; set; }
        internal string? Foto { get; set; }
        internal string? Nombre { get; set; }
        internal string? Apellido { get; set; }
        internal string? Email { get; set; }
        internal string? Pass { get; set; }
        internal bool Bloqueado { get; set; }

        public Usuario(string? foto, string? nombre, string? apellido, string? email, string? pass)
        {
            Id = _ultimoId++;
            Foto = foto;
            Nombre = nombre;
            Apellido = apellido;
            Email = email;
            Pass = pass;
            Bloqueado = false;
        }

        public Usuario()
        {
            Id = _ultimoId++;
            Bloqueado = false;
        }

        public bool ValidarCredenciales(string e, string p)
        {
            if (string.IsNullOrEmpty(e))
            {
                throw new ArgumentNullException("Email vacío.");
            }
            if (string.IsNullOrEmpty(p))
            {
                throw new ArgumentNullException("Contraseña vacía.");
            }
            return (e == Email && p == Pass);
        }

        public void Bloquear()
        {
            Bloqueado = true;
        }

        public void Desbloquear()
        {
            Bloqueado = false;
        }

        public virtual void EsValido()
        {
            if (string.IsNullOrEmpty(Nombre))
            {
                throw new ArgumentNullException("Nombre vacío.");
            }
            if (string.IsNullOrEmpty(Apellido))
            {
                throw new ArgumentNullException("Apellido vacío.");
            }
            if (string.IsNullOrEmpty(Email))
            {
                throw new ArgumentNullException("Email vacío.");
            }
            if (string.IsNullOrEmpty(Pass))
            {
                throw new ArgumentNullException("Contraseña vacía.");
            }
            if (string.IsNullOrEmpty(Foto))
            {
                throw new ArgumentNullException("Nombre vacío.");
            }

        }

        public override string ToString()
        {
            return $"Id: {Id}, Foto: {Foto ?? "N/A"}, Nombre: {Nombre ?? "N/A"}, Apellido: {Apellido ?? "N/A"}, Email: {Email ?? "N/A"}, Bloqueado: {Bloqueado}";
        }
    }
}
