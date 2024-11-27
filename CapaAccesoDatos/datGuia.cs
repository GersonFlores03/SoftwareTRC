using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoDatos
{
    public class datGuia
    {
        //Variable estática para la instancia
        private static readonly datGuia _instancia = new datGuia(); //Privado para evitar la instanciación directa
        public static datGuia Instancia
        {
            get
            {
                return datGuia._instancia;
            }
        }



        public Boolean InsertarGuiaNueva(entGuia guia)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarGuiaTransporte", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@numero_Orden", guia.ordenID.numero_orden);
                cmd.Parameters.AddWithValue("@nombreProducto", guia.productorId.nombre_producto);
                cmd.Parameters.AddWithValue("@estado", guia.estado);
                cmd.Parameters.AddWithValue("@pesoTotal", guia.pesoTotal);
                cmd.Parameters.AddWithValue("@fecha_emision", guia.fecha_emision);
                cmd.Parameters.AddWithValue("@fecha_llegada", guia.fecha_llegada);
                cmd.Parameters.AddWithValue("@Observaciones", guia.observaciones);
                cmd.Parameters.AddWithValue("@cantidad", guia.cantidad);
                cmd.Parameters.AddWithValue("@nombreRuta", guia.rutaID.Nombre);
                cmd.Parameters.AddWithValue("@nombreConductor", guia.conductorID.nombre_conductor);
                cmd.Parameters.AddWithValue("@VehiculoPlaca", guia.vehiculoId.Placa);

                cn.Open();
                int i = cmd.ExecuteNonQuery();

                if (i > 0)
                {
                    inserta = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("public Boolean InsertarOrdenNuevo(entOrden orden)" + ex.Message);
                //throw;
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


    }
}
