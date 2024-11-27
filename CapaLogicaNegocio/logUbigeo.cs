using CapaAccesoDatos;
using CapaEntidad;
using System.Collections.Generic;
using System.Data;

namespace CapaLogicaNegocio
{
    public class logUbigeo
    {

        #region Singleton
        private static readonly logUbigeo _instancia = new logUbigeo();
        public static logUbigeo Instancia
        {
            get { return _instancia; }
        }
        #endregion Singleton

        #region Metodos
        public DataTable VerificarDepartamentos(string departamentoOrigen, string departamentoDestino)
        {
            return datUbigeo.Instancia.ObtenerDepartamentos(departamentoOrigen, departamentoDestino);
        }

        //LISTAR DEPARTAMENTOS
        public List<entUbigeo> ListarDepartamentos()
        {
            return datUbigeo.Instancia.ListarDepartamentos();
        }
        #endregion Metodos

    }
}
