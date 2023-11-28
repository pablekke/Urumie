namespace Dominio
{
    public class Sistema
    {
        #region Singleton
        private Sistema() {
            //Precarga();
        }
        private static Sistema instance = null;
        public static Sistema GetSistema() { 
            if (instance == null)
            {
                instance = new Sistema();
            }
            return instance;
        }
        #endregion

    }
}