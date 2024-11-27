using System;

namespace CapaEntidad
{
    public class entCondicion
    {
        public int CondicionID { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string Condicion { get; set; }
        public int Dias { get; set; }
        public Boolean Activo { get; set; }
    }
}
