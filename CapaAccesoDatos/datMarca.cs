using System;
using System.Data;
using System.Data.SqlClient;

namespace CapaAccesoDatos
{
    public class datMarca
    {
        #region Singleton
        //Variable estática para la instancia
        private static readonly datMarca _instancia = new datMarca(); //Privado para evitar la instanciación directa
        public static datMarca Instancia
        {
            get
            {
                return datMarca._instancia;
            }
        }
        #endregion Singleton

        #region Metodos
        //Listado de Marcas
        public DataTable ListarMarcas()
        {
            DataTable tabla = new DataTable();
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); // Singleton
                cmd = new SqlCommand("spListarMarcas", cn);
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
