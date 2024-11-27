using CapaAccesoDatos;
using CapaEntidad;
using System.Data;

namespace CapaLogicaNegocio
{
    public class logVehiculo
    {
        #region Singleton
        //Variable estática para la instancia
        private static readonly logVehiculo _instancia = new logVehiculo(); //Privado para evitar la instanciación directa
        public static logVehiculo Instancia
        {
            get
            {
                return logVehiculo._instancia;
            }
        }
        #endregion Singleton

        #region Metodos
        /*Listado de Vehiculos*/

        public DataTable ListarVehiculos()
        {
            return datVehiculo.Instancia.ListarVehiculos();
        }
        //INSERTAR VEHICULO
        public bool InsertarVehiculo(entVehiculo vehiculo)
        {
            return datVehiculo.Instancia.InsertarVehiculo(vehiculo);
        }
        //ACTUALIZAR VEHICULO
        public bool ActualizarVehiculo(entVehiculo vehiculo)
        {
            return datVehiculo.Instancia.ActualizarVehiculo(vehiculo);
        }
        //DESACTIVAR VEHICULO
        public bool DesactivarVehiculo(entVehiculo vehiculo)
        {
            return datVehiculo.Instancia.DesactivarVehiculo(vehiculo);
        }

        //BUSQUEDA VEHICULO POR PLACA
        public DataTable BuscarVehiculo(string placa)
        {
            return datVehiculo.Instancia.BusquedaVehiculo(placa);
        }

        /**/
        public entVehiculo InformacionVehiculoPorPlaca(string placa)
        {
            return datVehiculo.Instancia.InfoVehiculo(placa);
        }

        #endregion Metodos
    }
}
