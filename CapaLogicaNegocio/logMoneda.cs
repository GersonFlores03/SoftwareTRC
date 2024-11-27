using CapaAccesoDatos;
using CapaEntidad;
using System.Collections.Generic;
using System.Data;

namespace CapaLogicaNegocio
{
    public class logMoneda
    {
        #region Singleton
        private static readonly logMoneda _instancia = new logMoneda(); //Privado para evitar la instanciación directa
        public static logMoneda Instancia
        {
            get
            {
                return logMoneda._instancia;
            }
        }
        #endregion Singleton


        #region Metodos
        /*Listado de Monedas*/

        public List<entMoneda> ListarMonedas()
        {
            return datMoneda.Instancia.ListarMonedas();
        }
        /*Insertar Moneda*/
        public bool InsertarMoneda(entMoneda moneda)
        {
            return datMoneda.Instancia.InsertarMoneda(moneda);
        }
        //actualizar moneda
        public bool ActualizarMoneda(entMoneda moneda)
        {
            return datMoneda.Instancia.ActualizaMoneda(moneda);
        }
        //desactivar moneda
        public bool DesactivarMoneda(int MonedaID)
        {
            return datMoneda.Instancia.DesactivarMoneda(MonedaID);
        }
        public DataTable BusquedaMoneda(string moneda)
        {
            return datMoneda.Instancia.BusquedaMoneda(moneda);
        }
        #endregion Metodos
    }
}
