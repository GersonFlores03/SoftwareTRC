using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoDatos
{
    public  class datUnidades
    {

       
        //Variable estática para la instancia
        private static readonly datUnidades _instancia = new datUnidades(); //Privado para evitar la instanciación directa
        public static datUnidades Instancia
        {
            get
            {
                return datUnidades._instancia;
            }
        }
       

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
    }
}
