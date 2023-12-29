using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Sistema
    {
        #region Singleton

        private Sistema()
        {
            //Precarga();
        }

        private static Sistema? instance = null;

        public static Sistema GetSistema()
        {
            if (instance == null)
            {
                instance = new Sistema();
            }
            return instance;
        }

        #endregion

        #region Listas

        private List<Usuario?> _usuarios = new List<Usuario?>();

        private List<Alquiler?> _alquileres = new List<Alquiler?>();

        private List<Solicitud?> _solicitudes = new List<Solicitud?>();

        #endregion

        #region Obtener Listas

        internal List<Usuario?> GetUsuarios()
        {
            return _usuarios;
        }

        internal List<Alquiler?> GetAlquileres()
        {
            return _alquileres;
        }

        internal List<Solicitud?> GetSolicitudes()
        {
            return _solicitudes;
        }

        #endregion

        #region Alta a las listas

        internal void AltaUsuario(Usuario u)
        {
            if (u is null)
            {
                throw new ArgumentNullException(nameof(u), "Usuario vacío.");
            }

            u.EsValido();

            if (ExisteEmail(u.Email))
            {
                throw new InvalidOperationException("Ese email ya fue registrado.");
            }

            _usuarios.Add(u);
        }

        public void AltaAlquiler(Alquiler a)
        {
            if (a is null)
            {
                throw new ArgumentNullException(nameof(a), "Alquiler vacío.");
            }

            a.EsValido();

            a.Dueño.AltaAlquiler(a);
            _alquileres.Add(a);
        }

        public void AltaSolicitud(Solicitud s)
        {
            if (s is null)
            {
                throw new ArgumentNullException(nameof(s), "Alquiler vacío.");
            }

            s.EsValido();

            _solicitudes.Add(s);
        }

        #endregion

        #region Login
        //Devuelve el primero que coincida
        public Usuario? Login(string email, string pass)
        {
            return _usuarios.FirstOrDefault(u => u.Email == email && u.Pass == pass);
        }

        //Devuelve verdadero si el email ya existe
        public bool ExisteEmail(string email)
        {
            return _usuarios.Any(u => u.Email == email);
        }
        #endregion

        #region Usuarios

        public void BloquearUsuario(Usuario u)
        {
            u.Bloquear();
        }

        public void DesbloquearUsuario(Usuario u)
        {
            u.Desbloquear();
        }

        #endregion

        #region Alquileres

        public void Alquilar(Alquiler a)
        {
            a.Alquilar();
        }

        public void NoAlquilar(Alquiler a)
        {
            a.NoAlquilar();
        }

        public void BloquearAlquiler(Alquiler a)
        {
            a.Bloquear();
        }

        public void DesbloquearAlquiler(Alquiler a)
        {
            a.Desbloquear();
        }

        #endregion

        #region 
        #endregion
        #region 
        #endregion
        #region 
        #endregion
        #region 
        #endregion

    }
}