using CapaAccesoDatos;
using System.Data;

namespace CapaLogicaNegocio
{
    public class logClase
    {
        #region Singleton
        //Variable estática para la instancia
        private static readonly logClase _instancia = new logClase(); //Privado para evitar la instanciación directa
        public static logClase Instancia
        {
            get
            {
                return logClase._instancia;
            }
        }
        #endregion Singleton

        #region Metodos
        //listar
        public DataTable ListarClases()
        {
            return datTipo.Instancia.ListarClases();
        }
        #endregion Metodos
    }
}
