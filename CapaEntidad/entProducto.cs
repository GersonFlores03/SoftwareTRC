using System;


namespace CapaEntidad
{
    public class entProducto
    {
        

        public entUnidad MedidaID { get; set; }
        public string nombre_producto { get; set; }
        public string nombre_secundario{ get; set; }
        public string descripcion { get; set; }
        public int stock { get; set; }
        public decimal peso { get; set; }
       
        public DateTime fecha_registro { get; set; }

        public string estado { get; set; }

        public int ProductoID { get; set; }



    }
}
