using CapaEntidad;
using System;
using System.Data;
using System.Data.SqlClient;

namespace CapaAccesoDatos
{
    public class datOrden
    {
        #region Singleton
        //Variable estática para la instancia
        private static readonly datOrden _instancia = new datOrden(); //Privado para evitar la instanciación directa
        public static datOrden Instancia
        {
            get
            {
                return datOrden._instancia;
            }
        }
        #endregion Singleton
        //LISTADO DE ORDENES
        public DataTable ListarOrdenes()
        {
            SqlCommand cmd = null;
            DataTable tabla = new DataTable();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarOrdenes", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                tabla.Load(dr);
            }
            catch (Exception ex)
            {

                Console.WriteLine("public DataTable ListarOrdenes(): " + ex.Message);
            }
            finally
            {
                if (cmd != null && cmd.Connection != null)
                {
                    cmd.Connection.Close();
                }
            }
            return tabla;
        }

        //INSERTAR ORDEN
        public Boolean InsertarOrdenNuevo(entOrden orden)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarOrden", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@FechaRegistro", orden.FechaRegistro);
                cmd.Parameters.AddWithValue("@ClienteRUC", orden.Cliente.RUC);
                cmd.Parameters.AddWithValue("@VehiculoPlaca", orden.Vehiculo.Placa);
                cmd.Parameters.AddWithValue("@RutaNombre", orden.Ruta.Nombre);
                cmd.Parameters.AddWithValue("@Descripcion", orden.Descripcion);
                cmd.Parameters.AddWithValue("@CondicionID", orden.Condicion.CondicionID);
                cmd.Parameters.AddWithValue("@MonedaID", orden.Moneda.MonedaID);
                cmd.Parameters.AddWithValue("@MontoFlete", orden.Flete);
                cmd.Parameters.AddWithValue("@MontoRetorno", orden.Retorno);
                cmd.Parameters.AddWithValue("@Observaciones", orden.Observaciones);
                cmd.Parameters.AddWithValue("@Activo", true);
                cmd.Parameters.AddWithValue("@numero_orden", orden.numero_orden);

                cn.Open();
                int i = cmd.ExecuteNonQuery();

                if (i > 0)
                {
                    inserta = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("public Boolean InsertarOrdenNuevo(entOrden orden)" + ex.Message);
                //throw;
            }
            finally
            {
                if (cmd != null && cmd.Connection != null)
                {
                    cmd.Connection.Close();
                }
            }
            return inserta;
        }
        //BUSQUEDA DE ORDENES POR ID
        public DataTable BusquedaOrdenID(int ordenID)
        {
            SqlCommand cmd = null;
            DataTable tabla = new DataTable();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spBusquedaOrdenID", cn);
                cmd.Parameters.AddWithValue("@OrdenTransporteID", ordenID);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                tabla.Load(dr);
            }
            catch (Exception ex)
            {

                Console.WriteLine("public DataTable BusquedaOrdenID(int ordenID): " + ex.Message);
            }
            finally
            {
                if (cmd != null && cmd.Connection != null)
                {
                    cmd.Connection.Close();
                }
            }
            return tabla;
        }

        //Actualizar Observacion
        public Boolean ActualizarObservacion(entOrden orden)
        {
            SqlCommand cmd = null;
            Boolean resultado = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spActualizarObservacion", cn); // Asegúrate de que el nombre del SP sea correcto
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@OrdenTransporteID", orden.OrdenTransporteID);
                cmd.Parameters.AddWithValue("@Observaciones", orden.Observaciones);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                Console.WriteLine("Filas afectadas: " + i); // Mensaje de depuración
                if (i > 0)
                {
                    resultado = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("datOrden - ActualizarObservacion ERROR: " + ex.Message);
            }
            finally
            {
                if (cmd != null && cmd.Connection != null)
                {
                    cmd.Connection.Close();
                }
            }
            return resultado;
        }





    }
}
