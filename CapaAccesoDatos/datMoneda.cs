using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CapaAccesoDatos
{
    public class datMoneda
    {
        #region Singleton
        //Variable estática para la instancia
        private static readonly datMoneda _instancia = new datMoneda(); //Privado para evitar la instanciación directa
        public static datMoneda Instancia
        {
            get
            {
                return datMoneda._instancia;
            }
        }
        #endregion Singleton

        #region Metodos
        //Listado de Condiciones
        public List<entMoneda> ListarMonedas()
        {
            List<entMoneda> lista = new List<entMoneda>();
            SqlCommand cmd = null;
            try
            {
                // Establecer la conexión a la base de datos
                SqlConnection cn = Conexion.Instancia.Conectar(); // Singleton
                cmd = new SqlCommand("spListarMonedas", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                // Abrir la conexión
                cn.Open();

                // Ejecutar el procedimiento almacenado
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    // Crear una nueva instancia de entCliente y asignar valores
                    entMoneda moneda = new entMoneda
                    {
                        MonedaID = Convert.ToInt32(dr["ID"]),
                        Fecha = Convert.ToDateTime(dr["FechaRegistro"]),
                        CodigoISO = dr["CodigoISO"].ToString(), //codigo iso de moneda de Peru es PEN
                        Moneda = dr["Moneda"].ToString(),
                        Simbolo = dr["Simbolo"].ToString(),
                        Pais = dr["Pais"].ToString(),
                        Activo = Convert.ToBoolean(dr["Activo"])
                    };

                    // Agregar el cliente a la lista
                    lista.Add(moneda);
                }

                // Cerrar el DataReader
                dr.Close();
            }
            catch (Exception ex)
            {
                // Manejo de excepciones más detallado
                Console.WriteLine("ListarMonedas(): " + ex.Message);
            }
            finally
            {
                // Asegurarse de cerrar la conexión
                if (cmd != null && cmd.Connection != null)
                {
                    cmd.Connection.Close();
                }
            }
            return lista;
        }


        //Insertar Moneda
        public Boolean InsertarMoneda(entMoneda moneda)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                // Establecer la conexión a la base de datos
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarMoneda", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                // Agregar todos los parámetros necesarios
                cmd.Parameters.AddWithValue("@Fecha", moneda.Fecha);
                cmd.Parameters.AddWithValue("@CodigoISO", moneda.CodigoISO);
                cmd.Parameters.AddWithValue("@Moneda", moneda.Moneda);
                cmd.Parameters.AddWithValue("@Simbolo", moneda.Simbolo);
                cmd.Parameters.AddWithValue("@Pais", moneda.Pais);
                cmd.Parameters.AddWithValue("@Activo", moneda.Activo);

                // Abrir la conexión
                cn.Open();

                // Ejecutar el procedimiento almacenado
                int i = cmd.ExecuteNonQuery();

                // Verificar si la inserción fue exitosa
                if (i > 0)
                {
                    inserta = true;
                }
            }
            catch (Exception ex)
            {
                // Manejo de excepciones más detallado
                Console.WriteLine("InsertarMoneda(entMoneda moneda)" + ex.Message);
                throw;
            }
            finally
            {
                // Asegurarse de cerrar la conexión
                if (cmd != null && cmd.Connection != null)
                {
                    cmd.Connection.Close();
                }
            }
            return inserta;
        }
        //actualizar Moneda
        public Boolean ActualizaMoneda(entMoneda moneda)
        {
            SqlCommand comando = null;
            Boolean actualiza = false;
            try
            {
                // Establecer la conexión a la base de datos
                SqlConnection cn = Conexion.Instancia.Conectar();
                comando = new SqlCommand("spActualizarMoneda", cn);
                comando.CommandType = CommandType.StoredProcedure;

                // Agregar todos los parámetros necesarios
                comando.Parameters.AddWithValue("@MonedaID", moneda.MonedaID);
                comando.Parameters.AddWithValue("@Fecha", moneda.Fecha);
                comando.Parameters.AddWithValue("@CodigoISO", moneda.CodigoISO);
                comando.Parameters.AddWithValue("@Moneda", moneda.Moneda);
                comando.Parameters.AddWithValue("@Simbolo", moneda.Simbolo);
                comando.Parameters.AddWithValue("@Pais", moneda.Pais);
                comando.Parameters.AddWithValue("@Activo", moneda.Activo);

                // Abrir la conexión
                cn.Open();

                // Ejecutar el procedimiento almacenado
                int i = comando.ExecuteNonQuery();

                // Verificar si la inserción fue exitosa
                if (i > 0)
                {
                    actualiza = true;
                }
            }
            catch (Exception ex)
            {
                // Manejo de excepciones más detallado
                Console.WriteLine("ActualizaMoneda(entMoneda moneda):" + ex.Message);
                throw;
            }
            finally
            {
                // Asegurarse de cerrar la conexión
                if (comando != null && comando.Connection != null)
                {
                    comando.Connection.Close();
                }
            }
            return actualiza;
        }
        //desactivar moneda por id
        public Boolean DesactivarMoneda(int monedaID)
        {
            SqlCommand cmd = null;
            Boolean desactiva = false;
            try
            {
                // Establecer la conexión a la base de datos
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDesactivarMoneda", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                // Agregar todos los parámetros necesarios
                cmd.Parameters.AddWithValue("@MonedaID", monedaID);

                // Abrir la conexión
                cn.Open();

                // Ejecutar el procedimiento almacenado
                int i = cmd.ExecuteNonQuery();

                // Verificar si la inserción fue exitosa
                if (i > 0)
                {
                    desactiva = true;
                }
            }
            catch (Exception ex)
            {
                // Manejo de excepciones más detallado
                Console.WriteLine("DesactivarMoneda(int monedaID): " + ex.Message);
                throw;
            }
            finally
            {
                // Asegurarse de cerrar la conexión
                if (cmd != null && cmd.Connection != null)
                {
                    cmd.Connection.Close();
                }
            }
            return desactiva;
        }
        //busqueda moneda por nombre
        public DataTable BusquedaMoneda(string cadena)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = null;
            try
            {
                // Establecer la conexión a la base de datos
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spBusquedaMonedaNombre", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                // Agregar todos los parámetros necesarios
                cmd.Parameters.AddWithValue("@Busqueda", cadena);

                // Abrir la conexión
                cn.Open();

                // Ejecutar el procedimiento almacenado
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                // Manejo de excepciones más detallado
                Console.WriteLine("BusquedaMoneda(string cadena): " + ex.Message);
            }
            finally
            {
                // Asegurarse de cerrar la conexión
                if (cmd != null && cmd.Connection != null)
                {
                    cmd.Connection.Close();
                }
            }
            return dt;
        }
        #endregion Metodos
    }
}
