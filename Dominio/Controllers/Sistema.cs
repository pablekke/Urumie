using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Controllers
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

        public List<string> _lenguajes = new List<string>();

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

        #region Obtener por ID

        public Usuario? EncontrarUsuarioPorId(int id)
        {
            foreach (var usuario in _usuarios)
            {
                if (usuario.Id == id)
                {
                    return usuario;
                }
            }

            return null;
        }

        public Alquiler? EncontrarAlquilerPorId(int id)
        {
            foreach (var alquiler in _alquileres)
            {
                if (alquiler.Id == id)
                {
                    return alquiler;
                }
            }

            return null;
        }

        public Solicitud? EncontrarSolicitudPorId(int id)
        {
            foreach (var solicitud in _solicitudes)
            {
                if (solicitud.Id == id)
                {
                    return solicitud;
                }
            }

            return null;
        }

        #endregion

        #region Alta a las listas

        public void AltaUsuario(Usuario? u)
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

        public void AltaAlquiler(Alquiler? a)
        {
            if (a is null)
            {
                throw new ArgumentNullException(nameof(a), "Alquiler vacío.");
            }

            a.EsValido();

            a.Propietario.AltaAlquiler(a);

            _alquileres.Add(a);
        }

        public void AltaSolicitud(Solicitud? s)
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
            u.BloquearUsuario();
        }

        public void DesbloquearUsuario(Usuario u)
        {
            u.DesbloquearUsuario();
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
            a.BloquearAlquiler();
        }

        public void DesbloquearAlquiler(Alquiler a)
        {
            a.DesbloquearAlquiler();
        }

        #endregion

        #region Precarga
    
        #region Inquilinos
            Inquilino i1 = new Inquilino(,);
        #endregion 
        {
    Foto = null,
    Nombre = "Juan",
    Apellido = "Pérez",
    Email = "juan@example.com",
    Pass = "contraseña123",
    Genero = Genero.Masculino
    // La FechaAlta se establece automáticamente en el constructor
    // FechaBaja se deja como null por defecto
};
    #endregion

    #region 
    #endregion
    #region 
    #endregion

}
}