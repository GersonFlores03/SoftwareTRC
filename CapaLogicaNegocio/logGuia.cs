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
    public class logGuia
    {

        private static readonly logGuia _instancia = new logGuia(); //Privado para evitar la instanciación directa
        public static logGuia Instancia
        {
            get
            {
                return logGuia._instancia;
            }
        }

        //INSERTAR GUIA
        public bool InsertarGuiaTransporte(entGuia guia)
        {
            return datGuia.Instancia.InsertarGuiaNueva(guia);
        }

    }
}
