using CapaEntidad;
using System;
using System.Data;
using System.Data.SqlClient;

namespace CapaAccesoDatos
{
    public class datRuta
    {
        #region Singleton
        //Variable estática para la instancia
        private static readonly datRuta _instancia = new datRuta(); //Privado para evitar la instanciación directa
        public static datRuta Instancia
        {
            get
            {
                return datRuta._instancia;
            }
        }
        #endregion Singleton

        #region Metodos
        //Listado de Rutas
        public DataTable ListarRutas()
        {
            SqlCommand comando = null;
            DataTable tabla = new DataTable();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                comando = new SqlCommand("spListarRutas", cn);
                comando.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = comando.ExecuteReader();
                tabla.Load(dr);
            }
            catch (Exception ex)
            {

                Console.WriteLine("datRuta-ListarRutas. ERROR: ", ex);
            }
            finally
            {
                if (comando != null && comando.Connection != null)
                {
                    comando.Connection.Close();
                }
            }
            return tabla;
        }
        //Buscar Rutas
        public DataTable BusquedaRuta(string rutaNombre)
        {
            SqlCommand comando = null;
            DataTable tabla = new DataTable();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                comando = new SqlCommand("spBusquedaRutaNombre", cn);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Ruta", rutaNombre);
                cn.Open();
                SqlDataReader dr = comando.ExecuteReader();
                tabla.Load(dr);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en BusquedaRutas(string rutaNombre): " + ex.Message);
            }
            finally
            {
                if (comando != null && comando.Connection != null)
                {
                    comando.Connection.Close();
                }
            }
            return tabla;
        }
        //Inserta Ruta
        public Boolean InsertarRuta(entRuta ruta)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarRuta", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Registro", ruta.FechaRegistro);
                cmd.Parameters.AddWithValue("@Ruta", ruta.Nombre);
                cmd.Parameters.AddWithValue("@Origen", ruta.Origen);
                cmd.Parameters.AddWithValue("@Destino", ruta.Destino);
                cmd.Parameters.AddWithValue("@Distancia", ruta.Distancia);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    inserta = true;
                }
            }
            catch (Exception ex)
            {
                // Manejo de excepciones más detallado
                Console.WriteLine("Error en InsertarRuta(entRuta ruta): " + ex.Message);
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

        //Actualizar Ruta
        public Boolean ActualizarRuta(entRuta ruta)
        {
            SqlCommand comando = null;
            Boolean actualiza = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                comando = new SqlCommand("spActualizarRuta", cn);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@RutaID", ruta.RutaID);
                comando.Parameters.AddWithValue("@Registro", ruta.FechaRegistro);
                comando.Parameters.AddWithValue("@Ruta", ruta.Nombre);
                comando.Parameters.AddWithValue("@Origen", ruta.Origen);
                comando.Parameters.AddWithValue("@Destino", ruta.Destino);
                comando.Parameters.AddWithValue("@Distancia", ruta.Distancia);
                comando.Parameters.AddWithValue("@Activo", ruta.Activo);
                cn.Open();
                int i = comando.ExecuteNonQuery();
                if (i > 0)
                {
                    actualiza = true;
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error en datRuta, al actualizar Ruta: ", ex);
            }
            finally
            {
                if (comando != null && comando.Connection != null)
                {
                    comando.Connection.Close();
                }
            }
            return actualiza;
        }
        //deshabilitar Ruta
        public Boolean DeshabilitarRuta(entRuta ruta)
        {
            SqlCommand comando = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                comando = new SqlCommand("spDeshabilitarRuta", cn);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@RutaID", ruta.RutaID);
                cn.Open();
                int i = comando.ExecuteNonQuery();
                if (i > 0)
                {
                    delete = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("datRuta-DeshabilitarRuta. Error: ", ex.Message);
            }
            finally { comando.Connection.Close(); }
            return delete;
        }
        //Obtener Ruta por nombre
        public entRuta InformacionRutaPorNombre(string nombre)
        {
            SqlCommand cmd = null;
            entRuta ruta = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInformacionRutaNombre", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {

                    // Crear y asignar el objeto Cliente
                    ruta = new entRuta
                    {
                        RutaID = Convert.ToInt32(dr["RutaID"]),
                        FechaRegistro = Convert.ToDateTime(dr["FechaRegistro"]),
                        Nombre = dr["Nombre"].ToString(),
                        Origen = dr["Origen"].ToString(),
                        Destino = dr["Destino"].ToString(),
                        Distancia = Convert.ToDecimal(dr["Distancia"]),
                        Activo = Convert.ToBoolean(dr["Activo"])
                    };
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("public entRuta ObtenerInformacionRutaPorNombre(string nombre): " + ex.Message);
                throw;
            }
            finally
            {
                if (cmd != null && cmd.Connection != null)
                {
                    cmd.Connection.Close();
                }
            }
            return ruta;
            #endregion Metodos
        }
    }
}
