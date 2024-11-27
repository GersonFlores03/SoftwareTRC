using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CapaAccesoDatos
{
    public class datUbigeo
    {
        private static readonly datUbigeo _instancia = new datUbigeo();
        public static datUbigeo Instancia
        {
            get { return _instancia; }
        }

        #region Metodos
        //Listar Departamentos
        public List<entUbigeo> ListarDepartamentos()
        {
            List<entUbigeo> lista = new List<entUbigeo>();
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarDepartamentos", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entUbigeo depart = new entUbigeo();
                    //depart.Departamento_INEI = Convert.ToInt32(dr["departamento_inei"]);
                    depart.Departamento = dr["Departamento"].ToString();
                    lista.Add(depart);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en ListarDepartamentos: " + ex.Message);
            }
            finally
            {
                if (dr != null)
                {
                    dr.Close();
                }
                if (cmd != null && cmd.Connection != null)
                {
                    cmd.Connection.Close();
                }
            }
            return lista;
        }
        public DataTable ObtenerDepartamentos(string departamentoOrigen, string departamentoDestino)
        {
            DataTable dataTable = new DataTable();
            SqlCommand cmd = null;
            try
            {
                // Establecer la conexión a la base de datos
                SqlConnection cn = Conexion.Instancia.Conectar(); // Singleton
                cmd = new SqlCommand("spObtenerDepartamentos", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                // Agregar parámetros
                cmd.Parameters.AddWithValue("@DepartamentoOrigen", departamentoOrigen);
                cmd.Parameters.AddWithValue("@DepartamentoDestino", departamentoDestino);

                // Abrir la conexión
                cn.Open();

                // Ejecutar el procedimiento almacenado
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en ObtenerDepartamentos(string departamentoOrigen, string departamentoDestino): " + ex.Message);
            }
            finally
            {
                // Asegurarse de cerrar la conexión
                if (cmd != null && cmd.Connection != null)
                {
                    cmd.Connection.Close();
                }
            }
            return dataTable;
        }
        #endregion Metodos

    }
}
