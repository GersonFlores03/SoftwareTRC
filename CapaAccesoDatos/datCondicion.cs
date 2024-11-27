using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CapaAccesoDatos
{
    public class datCondicion
    {
        #region Singleton
        //Variable estática para la instancia
        private static readonly datCondicion _instancia = new datCondicion(); //Privado para evitar la instanciación directa
        public static datCondicion Instancia
        {
            get
            {
                return datCondicion._instancia;
            }
        }
        #endregion Singleton

        #region Metodos
        //Listado de Condiciones
        public List<entCondicion> ListarCondiciones()
        {
            List<entCondicion> lista = new List<entCondicion>();
            SqlCommand cmd = null;
            try
            {
                // Establecer la conexión a la base de datos
                SqlConnection cn = Conexion.Instancia.Conectar(); // Singleton
                cmd = new SqlCommand("spListarCondiciones", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                // Abrir la conexión
                cn.Open();

                // Ejecutar el procedimiento almacenado
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    // Crear una nueva instancia de entCliente y asignar valores
                    entCondicion condicion = new entCondicion();
                    condicion.CondicionID = Convert.ToInt32(dr["CondicionID"]);
                    condicion.FechaRegistro = Convert.ToDateTime(dr["FechaRegistro"]);
                    condicion.Condicion = dr["Condicion"].ToString();
                    condicion.Dias = Convert.ToInt32(dr["Dias"]);
                    condicion.Activo = Convert.ToBoolean(dr["Activo"]);

                    // Agregar el cliente a la lista
                    lista.Add(condicion);
                }

                // Cerrar el DataReader
                dr.Close();
            }
            catch (Exception ex)
            {
                // Manejo de excepciones más detallado
                Console.WriteLine("Error en ListarCondiciones: " + ex.Message);
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

        //Insertar Condicion
        public Boolean InsertarCondicion(entCondicion condicion)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarCondicion", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@FechaRegistro", condicion.FechaRegistro);
                cmd.Parameters.AddWithValue("@Condicion", condicion.Condicion);
                cmd.Parameters.AddWithValue("@Dias", condicion.Dias);
                cmd.Parameters.AddWithValue("@Activo", condicion.Activo);
                cn.Open();
                int i = cmd.ExecuteNonQuery();

                // Verificar si la inserción fue exitosa
                if (i > 0)
                {
                    inserta = true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("InsertarCondicion(entCondicion condicion)" + e.Message);
                throw;
            }
            finally
            {
                if (cmd != null && cmd.Connection != null)
                { cmd.Connection.Close(); }
            }
            return inserta;
        }

        //ACTUALIZAR CONDICION
        public Boolean ActualizarCondicion(entCondicion condicion)
        {
            SqlCommand cmd = null;
            Boolean actualiza = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spActualizarcondicion", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CondicionID", condicion.CondicionID);
                cmd.Parameters.AddWithValue("@FechaRegistro", condicion.FechaRegistro);
                cmd.Parameters.AddWithValue("@Condicion", condicion.Condicion);
                cmd.Parameters.AddWithValue("@Dias", condicion.Dias);
                cmd.Parameters.AddWithValue("@Activo", condicion.Activo);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    actualiza = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("ActualizarCondicion(entCondicion condicion)", ex.Message);
                throw;
            }
            finally
            {
                if (cmd != null && cmd.Connection != null)
                { cmd.Connection.Close(); }
            }
            return actualiza;
        }
        //DESACTIVAR CONDICION
        public Boolean DesactivarCondicion(entCondicion condicion)
        {
            SqlCommand cmd = null;
            Boolean desactiva = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDesactivarCondicion", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CondicionID", condicion.CondicionID);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    desactiva = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("DesactivarCondicion(entCondicion condicion)", ex.Message);
                throw;
            }
            finally
            {
                if (cmd != null && cmd.Connection != null)
                { cmd.Connection.Close(); }
            }
            return desactiva;
        }
        //Buscar condicion por contenido
        public DataTable Busqueda(string contenido)
        {
            SqlCommand comando = null;
            DataTable tabla = new DataTable();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                comando = new SqlCommand("spBusquedaCondicionContenido", cn);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Busqueda", contenido);
                cn.Open();
                SqlDataReader dr = comando.ExecuteReader();
                tabla.Load(dr);
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR EN Busqueda(string contenido):", ex);
                throw;
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
        #endregion Metodos
    }
}
