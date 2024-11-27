using System;

namespace CapaEntidad
{
    public class entVehiculo
    {
        public int VehiculoID { get; set; }
        public string Placa { get; set; }
        public entMarca Marca { get; set; }
        public entClase Clase { get; set; }
        public entColor Color { get; set; }
        public string Serie { get; set; }
        public string Motor { get; set; }
        public DateTime Año { get; set; }
        public decimal Longitud { get; set; }
        public decimal Altura { get; set; }
        public decimal Ancho { get; set; }
        public int CargaUtil { get; set; }
        public Boolean Activo { get; set; }
    }
}
