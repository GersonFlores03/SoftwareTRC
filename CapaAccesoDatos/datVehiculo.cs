using CapaEntidad;
using System;
using System.Data;
using System.Data.SqlClient;

namespace CapaAccesoDatos
{
    public class datVehiculo
    {
        #region Singleton
        //Variable estática para la instancia
        private static readonly datVehiculo _instancia = new datVehiculo(); //Privado para evitar la instanciación directa
        public static datVehiculo Instancia
        {
            get
            {
                return datVehiculo._instancia;
            }
        }
        #endregion Singleton

        #region Metodos
        //Listado de Vehiculos
        public DataTable ListarVehiculos()
        {
            DataTable tabla = new DataTable();
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); // Singleton
                cmd = new SqlCommand("spListarVehiculos", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                tabla.Load(dr);
                dr.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en capa datos: " + ex.Message);
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
        //InsertarCliente
        public Boolean InsertarVehiculo(entVehiculo vehiculo)
        {
            SqlCommand comando = null;
            Boolean inserta = false;
            try
            {
                // Establecer la conexión a la base de datos
                SqlConnection cn = Conexion.Instancia.Conectar();
                comando = new SqlCommand("spInsertarVehiculo", cn);
                comando.CommandType = CommandType.StoredProcedure;

                // Agregar todos los parámetros necesarios

                comando.Parameters.AddWithValue("@Placa", vehiculo.Placa);
                comando.Parameters.AddWithValue("@MarcaID", vehiculo.Marca.MarcaID);
                comando.Parameters.AddWithValue("@ClaseID", vehiculo.Clase.ClaseID);
                comando.Parameters.AddWithValue("@ColorID", vehiculo.Color.ColorID);
                comando.Parameters.AddWithValue("@Serie", vehiculo.Serie);
                comando.Parameters.AddWithValue("@Motor", vehiculo.Motor);
                comando.Parameters.AddWithValue("@Año", vehiculo.Año);
                comando.Parameters.AddWithValue("@Longitud", vehiculo.Longitud);
                comando.Parameters.AddWithValue("@Altura", vehiculo.Altura);
                comando.Parameters.AddWithValue("@Ancho", vehiculo.Ancho);
                comando.Parameters.AddWithValue("@CargaUtil", vehiculo.CargaUtil);
                comando.Parameters.AddWithValue("@Activo", vehiculo.Activo);

                // Abrir la conexión
                cn.Open();

                // Ejecutar el procedimiento almacenado
                int i = comando.ExecuteNonQuery();

                // Verificar si la inserción fue exitosa
                if (i > 0)
                {
                    inserta = true;
                }
            }
            catch (Exception e)
            {
                // Manejo de excepciones más detallado
                Console.WriteLine("Error en InsertarVehiculo(entVehiculo vehiculo):" + e.Message);
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
            return inserta;
        }
        //actualizar
        public Boolean ActualizarVehiculo(entVehiculo vehiculo)
        {
            SqlCommand comando = null;
            Boolean actualizado = false;
            try
            {
                // Establecer la conexión a la base de datos
                SqlConnection cn = Conexion.Instancia.Conectar();
                comando = new SqlCommand("spActualizarVehiculo", cn);
                comando.CommandType = CommandType.StoredProcedure;

                // Agregar todos los parámetros necesarios
                comando.Parameters.AddWithValue("@VehiculoID", vehiculo.VehiculoID);
                comando.Parameters.AddWithValue("@Placa", vehiculo.Placa);
                comando.Parameters.AddWithValue("@MarcaID", vehiculo.Marca.MarcaID);
                comando.Parameters.AddWithValue("@ClaseID", vehiculo.Clase.ClaseID);
                comando.Parameters.AddWithValue("@ColorID", vehiculo.Color.ColorID);
                comando.Parameters.AddWithValue("@Serie", vehiculo.Serie);
                comando.Parameters.AddWithValue("@Motor", vehiculo.Motor);
                comando.Parameters.AddWithValue("@Año", vehiculo.Año);
                comando.Parameters.AddWithValue("@Longitud", vehiculo.Longitud);
                comando.Parameters.AddWithValue("@Altura", vehiculo.Altura);
                comando.Parameters.AddWithValue("@Ancho", vehiculo.Ancho);
                comando.Parameters.AddWithValue("@CargaUtil", vehiculo.CargaUtil);
                comando.Parameters.AddWithValue("@Activo", vehiculo.Activo);

                // Abrir la conexión
                cn.Open();

                // Ejecutar el procedimiento almacenado
                int i = comando.ExecuteNonQuery();

                // Verificar si la inserción fue exitosa
                if (i > 0)
                {
                    actualizado = true;
                }
            }
            catch (Exception e)
            {
                // Manejo de excepciones más detallado
                Console.WriteLine("Error en ActualizarVehiculo" + e.Message);
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
            return actualizado;
        }
        //DESACTIVAR VEHICULO
        public Boolean DesactivarVehiculo(entVehiculo vehiculo)
        {
            SqlCommand comando = null;
            Boolean desactivado = false;
            try
            {
                // Establecer la conexión a la base de datos
                SqlConnection cn = Conexion.Instancia.Conectar();
                comando = new SqlCommand("spDesactivarVehiculo", cn);
                comando.CommandType = CommandType.StoredProcedure;

                // Agregar todos los parámetros necesarios
                comando.Parameters.AddWithValue("@VehiculoID", vehiculo.VehiculoID);

                // Abrir la conexión
                cn.Open();

                // Ejecutar el procedimiento almacenado
                int i = comando.ExecuteNonQuery();

                // Verificar si la inserción fue exitosa
                if (i > 0)
                {
                    desactivado = true;
                }
            }
            catch (Exception e)
            {
                // Manejo de excepciones más detallado
                Console.WriteLine("Error en DesactivarVehiculo" + e.Message);
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
            return desactivado;
        }
        //buscar vehiculo por placa
        public DataTable BusquedaVehiculo(string placa)
        {
            SqlCommand comando = null;
            DataTable tabla = new DataTable();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                comando = new SqlCommand("spBusquedaVehiculoPlaca", cn);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@Busqueda", placa);

                cn.Open();
                SqlDataReader dr = comando.ExecuteReader();
                tabla.Load(dr);
            }
            catch (Exception ex)
            {

                Console.WriteLine("BusquedaVehiculo(string placa). Error: ", ex);
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
        //OBTENER VEHICULO POR PLACA
        public entVehiculo InfoVehiculo(string placa)
        {
            SqlCommand cmd = null;
            entVehiculo vehiculo = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInformacionVehiculoPlaca", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Placa", placa);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    entMarca entMarca = new entMarca
                    {
                        MarcaID = Convert.ToInt32(dr["MarcaID"]),
                        Marca = dr["Marca"].ToString()
                    };
                    entClase entClase = new entClase
                    {
                        ClaseID = Convert.ToInt32(dr["ClaseID"]),
                        Clase = dr["Clase"].ToString()
                    };
                    entColor entColor = new entColor
                    {
                        ColorID = Convert.ToInt32(dr["ColorID"]),
                        Color = dr["Color"].ToString()
                    };
                    vehiculo = new entVehiculo
                    {
                        VehiculoID = Convert.ToInt32(dr["VehiculoID"]),
                        Placa = dr["Placa"].ToString(),
                        Marca = entMarca,
                        Clase = entClase,
                        Color = entColor,
                    };
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("public entVehiculo InfoVehiculo(string placa) " + ex.Message);
            }
            finally
            {
                if (cmd != null && cmd.Connection != null)
                {
                    cmd.Connection.Close();
                }
            }
            return vehiculo;
        }
        #endregion Metodos


    }
}
