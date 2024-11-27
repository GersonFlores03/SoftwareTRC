using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entGuia
    {

        public entOrden ordenID { get; set; }
        public entProducto productorId { get; set; }
        public string estado { get; set; }
        public decimal pesoTotal { get; set; }
        public DateTime fecha_emision { get; set; }
        public DateTime fecha_llegada { get; set; }
        public string observaciones { get; set; }
        public int cantidad { get; set; }
        public entRuta rutaID { get; set; }

        public int guia_id { get; set; }

        public entConductor conductorID {  get; set; }

        public entVehiculo vehiculoId { get; set; }
























    }
}
