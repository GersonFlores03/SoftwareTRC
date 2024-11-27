using CapaAccesoDatos;
using CapaEntidad;
using System.Data;

namespace CapaLogicaNegocio
{
    public class logOrden
    {
        #region Singleton
        //Variable estática para la instancia
        private static readonly logOrden _instancia = new logOrden(); //Privado para evitar la instanciación directa
        public static logOrden Instancia
        {
            get
            {
                return logOrden._instancia;
            }
        }
        #endregion Singleton

        #region Metodos
        //LISTADO
        public DataTable ListarOrdenes()
        {
            return datOrden.Instancia.ListarOrdenes();
        }
        //INSERTAR ORDEN
        public bool InsertarOrdenNuevo(entOrden orden)
        {
            return datOrden.Instancia.InsertarOrdenNuevo(orden);
        }
        //ACTUALIZAR OBSERVACION
        public bool ActualizarObservacion(entOrden orden)
        {
            return datOrden.Instancia.ActualizarObservacion(orden);
        }
        //BUSQUEDA ORDEN POR ID
        public DataTable BusquedaOrdenID(int id)
        {
            return datOrden.Instancia.BusquedaOrdenID(id);
        }
        //ANULAR ORDEN (DESACTIVAR ESTADO)
        //public bool ActualizarEstado(entOrden orden)
        //{
        //    return datOrden.Instancia.ActualizarEstado(orden);
        //}
        #endregion Metodos
    }
}
