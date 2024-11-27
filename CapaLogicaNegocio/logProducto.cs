using CapaAccesoDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogicaNegocio
{
    public class logProducto
    {

      
        //Variable estática para la instancia
        private static readonly logProducto _instancia = new logProducto(); //Privado para evitar la instanciación directa
        public static logProducto Instancia
        {
            get
            {
                return logProducto._instancia;
            }
        }

        public DataTable ListarProducto()
        {
            return datProducto.Instancia.ListarProductos();
        }

        //INSERTAR CLIENTE
        public bool InsertarProductos(entProducto product)
        {
            return datProducto.Instancia.InsertarProducto(product);
        }


        public List<entUnidad> ObtenerUnidades()
        {
          return  datProducto.Instancia.ObtenerUnidadesMedida();
        }



    }
}
