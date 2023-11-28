using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    internal class Usuario
    {
        public int UltimoId = 1;
        internal int Id { get; set; }
        internal string? Foto { get; set; }
        internal string? Nombre { get; set; }
        internal string? Apellido { get; set; }
        internal string? Email { get; set; }
        internal string? Pass { get; set; }
        internal bool Bloqueado { get; set; }

        internal Usuario(string? foto, string? nombre, string? apellido, string? email, string? pass)
        {
            Id = UltimoId++;
            Foto = foto;
            Nombre = nombre;
            Apellido = apellido;
            Email = email;
            Pass = pass;
            Bloqueado = false;
        }

        internal Usuario()
        {
            Id = UltimoId++;
            Bloqueado = false;
        }

        internal bool ValidarCredenciales(string e, string p)
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

        internal void Bloquear()
        {
            Bloqueado = true;
        }
        internal void Desbloquear()
        {
            Bloqueado = false;
        }

        internal virtual void EsValido()
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
