using System;

namespace CapaEntidad
{
    public class entOrden
    {
        public int OrdenTransporteID { get; set; }
        public DateTime FechaRegistro { get; set; }
        public entCliente Cliente { get; set; }
        public entVehiculo Vehiculo { get; set; }
        public entRuta Ruta { get; set; }
        public string Descripcion { get; set; }
        public entCondicion Condicion { get; set; }
        public entMoneda Moneda { get; set; }
        public Decimal Flete { get; set; }
        public Decimal Retorno { get; set; }
       
        public Decimal IGV { get; set; }
        public string Observaciones { get; set; }
        public Boolean Activo { get; set; }

        public string numero_orden { get; set; }
    }
}
