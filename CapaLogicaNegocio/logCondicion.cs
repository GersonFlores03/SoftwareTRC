using CapaAccesoDatos;
using CapaEntidad;
using System.Collections.Generic;
using System.Data;

namespace CapaLogicaNegocio
{
    public class logCondicion
    {
        #region Singleton
        private static readonly logCondicion _instancia = new logCondicion(); //Privado para evitar la instanciación directa
        public static logCondicion Instancia
        {
            get
            {
                return logCondicion._instancia;
            }
        }
        #endregion Singleton


        #region Metodos
        /*Listado de Condiciones*/

        public List<entCondicion> ListarCondiciones()
        {
            return datCondicion.Instancia.ListarCondiciones();
        }
        /*Insertar Condicion*/
        public bool InsertarCondicion(entCondicion condicion)
        {
            return datCondicion.Instancia.InsertarCondicion(condicion);
        }
        //ACTUALIZAR CONDICION
        public bool ActualizarCondicion(entCondicion condicion)
        {
            return datCondicion.Instancia.ActualizarCondicion(condicion);
        }

        //desactivar CONDICION
        public bool DesactivarCondicion(entCondicion condicion)
        {
            return datCondicion.Instancia.DesactivarCondicion(condicion);
        }
        //Buscar condicion por contenido
        public DataTable BuscarCondicion(string condicion)
        {
            return datCondicion.Instancia.Busqueda(condicion);
        }
        #endregion Metodos
    }
}
