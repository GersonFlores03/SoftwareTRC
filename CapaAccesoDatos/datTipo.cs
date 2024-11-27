using System;
using System.Data;
using System.Data.SqlClient;

namespace CapaAccesoDatos
{
    public class datTipo
    {
        #region Singleton
        //Variable estática para la instancia
        private static readonly datTipo _instancia = new datTipo(); //Privado para evitar la instanciación directa
        public static datTipo Instancia
        {
            get
            {
                return datTipo._instancia;
            }
        }
        #endregion Singleton

        #region Metodos
        //listar
        public DataTable ListarClases()
        {
            DataTable tabla = new DataTable();
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); // Singleton
                cmd = new SqlCommand("spListarClases", cn);
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
        #endregion Metodos
    }
}
