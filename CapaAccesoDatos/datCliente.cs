using CapaEntidad;
using System;
using System.Data;
using System.Data.SqlClient;

namespace CapaAccesoDatos
{
    public class datCliente
    {
        #region Singleton
        //Variable estática para la instancia
        private static readonly datCliente _instancia = new datCliente(); //Privado para evitar la instanciación directa
        public static datCliente Instancia
        {
            get
            {
                return datCliente._instancia;
            }
        }
        #endregion Singleton

        #region Metodos

        //LISTADO DE CLIENTES
        public DataTable ListarClientes()
        {
            SqlCommand cmd = null;
            DataTable tabla = new DataTable();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarClientes", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                tabla.Load(dr);
            }
            catch (Exception ex)
            {

                Console.WriteLine("public DataTable ListarClientes(): ", ex);
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

        //INSERTAR CLIENTE
        public Boolean InsertarCliente(entCliente cliente)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NumeroRUC", cliente.RUC);
                cmd.Parameters.AddWithValue("@RazonSocial", cliente.RazonSocial);
                cmd.Parameters.AddWithValue("@Telefono", cliente.Telefono);
                cmd.Parameters.AddWithValue("@Correo", cliente.Correo);
                cmd.Parameters.AddWithValue("@Direccion", cliente.Direccion);
                cmd.Parameters.AddWithValue("@Ubigeo_RENIEC", cliente.Ubigeo.Ubigeo_RENIEC);

                cn.Open();
                int i = cmd.ExecuteNonQuery();

                if (i > 0)
                {
                    inserta = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("public Boolean InsertarCliente(entCliente cliente): " + ex.Message);
                throw;
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

        //ACTUALIZAR CLIENTE
        public Boolean ActualizarCliente(entCliente cliente)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spActualizarCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ClienteID", cliente.ClienteID);
                cmd.Parameters.AddWithValue("@NumeroRUC", cliente.RUC);
                cmd.Parameters.AddWithValue("@RazonSocial", cliente.RazonSocial);
                cmd.Parameters.AddWithValue("@Telefono", cliente.Telefono);
                cmd.Parameters.AddWithValue("@Correo", cliente.Correo);
                cmd.Parameters.AddWithValue("@Direccion", cliente.Direccion);
                cmd.Parameters.AddWithValue("@Ubigeo_RENIEC", cliente.Ubigeo.Ubigeo_RENIEC);
                cmd.Parameters.AddWithValue("@Estado", cliente.Estado);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    edita = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("public Boolean ActualizarCliente(entCliente cliente):" + ex);
                throw;
            }
            finally
            {
                if (cmd != null && cmd.Connection != null)
                {
                    cmd.Connection.Close();
                }
            }
            return edita;
        }

        //DESACTIVAR CLIENTE
        public Boolean DesactivarCliente(entCliente cliente)
        {
            SqlCommand comando = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                comando = new SqlCommand("spDeshabilitarCliente", cn);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@ClienteID", cliente.ClienteID);
                cn.Open();
                int i = comando.ExecuteNonQuery();
                if (i > 0)
                {
                    delete = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("datCliente-DeshabilitarCliente error: ", ex);
            }
            finally { comando.Connection.Close(); }
            return delete;
        }
        //BUSQUEDA DE CLIENTE POR RUC
        public DataTable Busqueda(string ruc)
        {
            SqlCommand cmd = null;
            DataTable tabla = new DataTable();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spBusquedaClienteRUC", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@RUC", ruc);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                tabla.Load(dr);
            }
            catch (Exception ex)
            {
                Console.WriteLine("BusquedaRUC(string ruc). Error: ", ex);
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
        //Obtener Informacion Cliente Por ID
        public entCliente ObtenerInfoCliente(int ClienteID)
        {
            SqlCommand cmd = null;
            entCliente cliente = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInformacionClienteID", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ClienteID", ClienteID);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    // Crear y asignar el objeto Ubigeo
                    entUbigeo ubigeo = new entUbigeo
                    {
                        UbigeoID = Convert.ToInt32(dr["Ubigeo"]),
                    };

                    cliente = new entCliente
                    {
                        ClienteID = Convert.ToInt32(dr["ClienteID"]),
                        RUC = dr["NumeroRUC"].ToString(),
                        RazonSocial = dr["RazonSocial"].ToString(),
                        Telefono = dr["Telefono"].ToString(),
                        Correo = dr["Correo"].ToString(),
                        Direccion = dr["Dirección"].ToString(),
                        Ubigeo = ubigeo,
                        Estado = Convert.ToBoolean(dr["Estado"])
                    };
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("datCliente - InformacionClienteID ERROR: " + ex.Message);
            }
            finally
            {
                if (cmd != null && cmd.Connection != null)
                {
                    cmd.Connection.Close();
                }
            }
            return cliente;
        }

        //OBTENER Cliente POR RUC
        public entCliente ObtenerInfoCliente(string RUC)
        {
            SqlCommand cmd = null;
            entCliente cliente = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInformacionClienteRuc", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@RUC", RUC);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    // Crear y asignar el objeto Ubigeo
                    entUbigeo ubigeo = new entUbigeo
                    {
                        UbigeoID = Convert.ToInt32(dr["UbigeoID"]),
                        Ubigeo_RENIEC = Convert.ToInt32(dr["Ubigeo_RENIEC"]),
                        //Ubigeo_INEI = Convert.ToInt32(dr["Ubigeo_INEI"]),
                        //Departamento_INEI = Convert.ToInt32(dr["departamento_inei"]),
                        Departamento = dr["Departamento"].ToString(),
                        //Provincia_INEI = Convert.ToInt32(dr["provincia_inei"]),
                        Provincia = dr["Provincia"].ToString(),
                        Distrito = dr["Distrito"].ToString(),
                        //Region = dr["region"].ToString()
                    };

                    // Crear y asignar el objeto Cliente
                    cliente = new entCliente
                    {
                        ClienteID = Convert.ToInt32(dr["ClienteID"]),
                        RUC = dr["RUC"].ToString(),
                        RazonSocial = dr["Empresa"].ToString(),
                        Telefono = dr["Telefono"].ToString(),
                        Correo = dr["Correo"].ToString(),
                        Direccion = dr["Direccion"].ToString(),
                        Ubigeo = ubigeo, // Asignar el objeto Ubigeo
                        Estado = Convert.ToBoolean(dr["Activo"])
                    };
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("public entCliente ObtenerInfoCliente(string RUC): " + ex.Message);
                throw;
            }
            finally
            {
                if (cmd != null && cmd.Connection != null)
                {
                    cmd.Connection.Close();
                }
            }
            return cliente;
        }




        //UNIDAD MEDIDA
        public Boolean InsertarUnidad(entUnidad unidad)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarUnidades", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre_unidad", unidad.nombreunidad);
                
                cn.Open();
                int i = cmd.ExecuteNonQuery();

                if (i > 0)
                {
                    inserta = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("public Boolean InsertarCliente(entCliente cliente): " + ex.Message);
                throw;
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























        #endregion metodos
    }
}
