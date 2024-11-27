using CapaAccesoDatos;
using CapaEntidad;
using System.Collections.Generic;
using System.Data;

namespace CapaLogicaNegocio
{
    public class logColor
    {
        #region Singleton
        //Variable estática para la instancia
        private static readonly logColor _instancia = new logColor(); //Privado para evitar la instanciación directa
        public static logColor Instancia
        {
            get
            {
                return logColor._instancia;
            }
        }
        #endregion Singleton

        #region Metodos
        /*Listado de Colores de Vehiculos*/

        public DataTable ListarColores()
        {
            return datColor.Instancia.ListarColores();
        }

        public List<entColor> ListarColores2()
        {
            return datColor.Instancia.ListarColores2();
        }
        #endregion Metodos
    }
}
