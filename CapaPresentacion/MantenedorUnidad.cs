using CapaEntidad;
using CapaLogicaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class MantenedorUnidad : Form
    {

        string operacion = "";
        private int MedidaID = 0;


        public MantenedorUnidad()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(operacion))
            {
                MessageBox.Show("Por favor, seleccione una operación antes de continuar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (operacion == "INSERTAR")
            {
                try
                {
                    entUbigeo u = new entUbigeo
                    {
                        Ubigeo_RENIEC = Convert.ToInt32(txtUnidad.Text.Trim())
                    };

                    entCliente c = new entCliente
                    {
                        RazonSocial = txtEmpresa.Text.Trim(),
                        RUC = txtRUC.Text.Trim(),
                        Telefono = txtTelefono.Text.Trim(),
                        Correo = txtCorreo.Text.Trim(),
                        Direccion = txtDireccion.Text.Trim(),
                        Ubigeo = u, // Asignar el objeto entUbigeo
                        Estado = ckbActivo.Checked
                    };

                    bool resultado = logCliente.Instancia.InsertarCliente(c);
                    if (resultado)
                    {
                        MessageBox.Show("El cliente ha sido guardado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ListarClientes();
                        ConfiguracionInicial();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo insertar el cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error al guardar el cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
