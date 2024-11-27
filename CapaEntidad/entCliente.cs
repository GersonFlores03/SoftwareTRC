using System;

namespace CapaEntidad
{
    public class entCliente
    {
        public int ClienteID { get; set; }
        public string RUC { get; set; }
        public string RazonSocial { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string Direccion { get; set; }
        public entUbigeo Ubigeo { get; set; } // Cambiado de int a entUbigeo
        public Boolean Estado { get; set; }
    }
}
