using CapaAccesoDatos;
using System.Data;

namespace CapaLogicaNegocio
{
    public class logMarca
    {
        #region Singleton
        //Variable estática para la instancia
        private static readonly logMarca _instancia = new logMarca(); //Privado para evitar la instanciación directa
        public static logMarca Instancia
        {
            get
            {
                return logMarca._instancia;
            }
        }
        #endregion Singleton

        #region Metodos
        /*Listado de Marcas de Vehiculos*/

        public DataTable ListarMarcas()
        {
            return datMarca.Instancia.ListarMarcas();
        }
        #endregion Metodos
    }
}
