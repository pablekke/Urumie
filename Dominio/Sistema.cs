namespace Dominio
{
    public class Sistema
    {
        #region Singleton
        private Sistema() {
            //Precarga();
        }
        private static Sistema? instance = null;
        public static Sistema GetSistema() { 
            if (instance == null)
            {
                instance = new Sistema();
            }
            return instance;
        }
        #endregion

        #region Listas
        private List<Usuario?> _usuarios = new List<Usuario?>();
        #endregion

        #region Obtener Listas
        internal List<Usuario?> GetUsuarios() { 
            return _usuarios;
        }
        #endregion

        #region Alta a las listas
            
        #endregion

        #region Usuarios
        #endregion
        #region 
        #endregion

    }
}