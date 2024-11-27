using CapaAccesoDatos;
using CapaEntidad;
using System.Data;

namespace CapaLogicaNegocio
{
    public class logRuta
    {
        #region Singleton
        //Variable estática para la instancia
        private static readonly logRuta _instancia = new logRuta(); //Privado para evitar la instanciación directa
        public static logRuta Instancia
        {
            get
            {
                return logRuta._instancia;
            }
        }
        #endregion Singleton

        #region Metodos
        //Listado de Rutas
        public DataTable ListarRutas()
        {
            return datRuta.Instancia.ListarRutas();
        }
        //busca
        public DataTable BuscarRutas(string ruta)
        {
            return datRuta.Instancia.BusquedaRuta(ruta);
        }
        //Inserta
        public bool InsertaRuta(entRuta ruta)
        {
            return datRuta.Instancia.InsertarRuta(ruta);
        }
        //ACTUALIZA
        public bool ActualizaRuta(entRuta ruta)
        {
            return datRuta.Instancia.ActualizarRuta(ruta);
        }
        //DESHABILITA
        public bool DeshabilitaRuta(entRuta ruta)
        {
            return datRuta.Instancia.DeshabilitarRuta(ruta);
        }
        //OBTENER RUTA POR nombre
        public entRuta InformacionRutaPorNombre(string nombre)
        {
            return datRuta.Instancia.InformacionRutaPorNombre(nombre);
        }
        #endregion Metodos
    }
}
