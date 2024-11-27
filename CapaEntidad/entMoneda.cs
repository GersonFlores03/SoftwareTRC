using System;

namespace CapaEntidad
{
    public class entMoneda
    {
        public int MonedaID { get; set; }
        public DateTime Fecha { get; set; }

        public string CodigoISO { get; set; }
        public string Moneda { get; set; }
        public string Simbolo { get; set; }
        public string Pais { get; set; }
        public Boolean Activo { get; set; }
    }
}
