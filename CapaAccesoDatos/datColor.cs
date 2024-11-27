using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CapaAccesoDatos
{
    public class datColor
    {
        #region Singleton
        //Variable estática para la instancia
        private static readonly datColor _instancia = new datColor(); //Privado para evitar la instanciación directa
        public static datColor Instancia
        {
            get
            {
                return datColor._instancia;
            }
        }
        #endregion Singleton

        #region Metodos
        public List<entColor> ListarColores2()
        {
            List<entColor> lista = new List<entColor>();
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarColores", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entColor color = new entColor();
                    //depart.Departamento_INEI = Convert.ToInt32(dr["departamento_inei"]);
                    color.Color = dr["ColorID"].ToString();
                    color.Color = dr["Color"].ToString();
                    lista.Add(color);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en ListarColores2: " + ex.Message);
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
        //Listado de Vehiculos
        public DataTable ListarColores()
        {
            DataTable tabla = new DataTable();
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); // Singleton
                cmd = new SqlCommand("spListarColores", cn);
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
        //INSERTA
        //EDITA
        //DESACTIVA

        #endregion Metodos
    }
}
