using System;

namespace CapaEntidad
{
    public class entRuta
    {
        public int RutaID { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string Nombre { get; set; }
        public string Origen { get; set; }
        public string Destino { get; set; }
        public Decimal Distancia { get; set; }
        public Boolean Activo { get; set; }
    }
}
