using CapaAccesoDatos;
using CapaEntidad;
using System;
using System.Data;
namespace CapaLogicaNegocio
{
    public class logCliente
    {
        #region Singleton
        //Variable estática para la instancia
        private static readonly logCliente _instancia = new logCliente(); //Privado para evitar la instanciación directa
        public static logCliente Instancia
        {
            get
            {
                return logCliente._instancia;
            }
        }
        #endregion Singleton

        #region Metodos
        //LISTAR CLIENTES
        public DataTable ListarClientes()
        {
            return datCliente.Instancia.ListarClientes();
        }

        //INSERTAR CLIENTE
        public bool InsertarCliente(entCliente Cli)
        {
            return datCliente.Instancia.InsertarCliente(Cli);
        }

        //INSERTAR UNIDAD
        public bool InsertarUnidad(entUnidad unidad)
        {
            return datCliente.Instancia.InsertarUnidad(unidad);
        }

















        //ACTUALIZAR CLIENTE
        public bool ActualizarCliente(entCliente Cli)
        {
            return datCliente.Instancia.ActualizarCliente(Cli);
        }
        //DESACTIVAR CLIENTE
        public bool DeshabilitarCliente(entCliente Cli)
        {
            return datCliente.Instancia.DesactivarCliente(Cli);
        }
        //BUSQUEDA CLIENTE POR RUC
        public DataTable BusquedaRUC(string ruc)
        {
            return datCliente.Instancia.Busqueda(ruc);
        }

        //OBTENER Cliente por ID
        public entCliente InformacionClientePorID(int idCliente)
        {
            return datCliente.Instancia.ObtenerInfoCliente(idCliente);
        }
        //OBTENER CLIENTE POR RUC
        public entCliente InformacionClientePorRUC(string NumeroRUC)
        {
            try
            {
                return datCliente.Instancia.ObtenerInfoCliente(NumeroRUC);
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR EN CAPA LOGICA DE CLIENTE" + ex);
                return null;
            }
        }
        #endregion Metodos
    }
}
