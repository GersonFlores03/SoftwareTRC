using CapaEntidad;
using CapaLogicaNegocio;
using System;
using System.Windows.Forms;

namespace CapaPresentacion
{

    public partial class MantenedorCliente : Form
    {

        string operacion = "";
        private int cliente_id = 0;

        public MantenedorCliente()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }
        private void ManCliente_Load(object sender, EventArgs e)
        {
            ListarClientes();
            ConfiguracionInicial();
        }
        private void btnMostrar_Click(object sender, EventArgs e)
        {

            if (tablaClientes.SelectedRows.Count > 0)
            {
                ConfiguracionMostrar();
                ObtenerValores();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila antes de continuar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnNuevo_Click(object sender, System.EventArgs e)
        {
            ConfiguracionNuevo();
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (tablaClientes.SelectedRows.Count > 0)
            {
                ConfiguracionEditar();
                ObtenerValores();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila antes de continuar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            ConfiguracionInicial();
        }
        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            if (tablaClientes.SelectedRows.Count > 0)
            {
                cliente_id = Convert.ToInt32(tablaClientes.CurrentRow.Cells[0].Value);
                try
                {
                    entCliente c = new entCliente
                    {
                        ClienteID = cliente_id,
                    };

                    bool resultado = logCliente.Instancia.DeshabilitarCliente(c);
                    if (resultado)
                    {
                        MessageBox.Show("El estado del cliente ha sido actualizado correctamente.", "Actualización Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ListarClientes();
                        ConfiguracionInicial();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo actualizar el estado del cliente.", "Error de Actualización", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error al actualizar el estado del cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila antes de continuar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                string ruc = txtBusqueda.Text;
                tablaClientes.DataSource = logCliente.Instancia.BusquedaRUC(ruc);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al cargar la información del cliente: " + ex.Message, "Error de Carga", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
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
                        Ubigeo_RENIEC = Convert.ToInt32(txtUbigeoRENIEC.Text.Trim())
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
            else if (operacion == "ACTUALIZAR")
            {
                try
                {
                    entUbigeo u = new entUbigeo
                    {
                        Ubigeo_RENIEC = Convert.ToInt32(txtUbigeoRENIEC.Text.Trim())
                    };

                    entCliente c = new entCliente
                    {
                        ClienteID = int.Parse(txtClienteID.Text.Trim()),
                        RazonSocial = txtEmpresa.Text.Trim(),
                        RUC = txtRUC.Text.Trim(),
                        Telefono = txtTelefono.Text.Trim(),
                        Correo = txtCorreo.Text.Trim(),
                        Direccion = txtDireccion.Text.Trim(),
                        Ubigeo = u,
                        Estado = ckbActivo.Checked
                    };

                    bool resultado = logCliente.Instancia.ActualizarCliente(c);
                    if (resultado)
                    {
                        MessageBox.Show("El cliente ha sido actualizado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ListarClientes();
                        ConfiguracionInicial();
                    }
                    else
                    {
                        MessageBox.Show("No se pudieron actualizar los datos del cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error al actualizar los datos del cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnLimpiarFiltro_Click(object sender, EventArgs e)
        {
            ListarClientes();
            LimpiarControles();
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void ListarClientes()
        {
            tablaClientes.DataSource = logCliente.Instancia.ListarClientes();
        }
        public void ObtenerValores()
        {
            txtClienteID.Text = tablaClientes.CurrentRow.Cells[0].Value.ToString();
            txtRUC.Text = tablaClientes.CurrentRow.Cells["RUC"].Value.ToString();
            txtEmpresa.Text = tablaClientes.CurrentRow.Cells["Nombre"].Value.ToString();
            txtTelefono.Text = tablaClientes.CurrentRow.Cells["Telefono"].Value.ToString();
            txtCorreo.Text = tablaClientes.CurrentRow.Cells["Correo"].Value.ToString();
            txtDireccion.Text = tablaClientes.CurrentRow.Cells["Direccion"].Value.ToString();
            txtUbigeoRENIEC.Text = tablaClientes.CurrentRow.Cells["Ubigeo"].Value.ToString();
            ckbActivo.Checked = Convert.ToBoolean(tablaClientes.CurrentRow.Cells["Activo"].Value);
        }
        public void ConfiguracionInicial()
        {
            LimpiarControles();
            grbDatos.Enabled = false;
            grbListaClientes.Enabled = true;
            btnMostrar.Enabled = true;
            btnNuevo.Enabled = true;
            btnEditar.Enabled = true;
            btnCerrar.Enabled = true;
        }
        public void ConfiguracionNuevo()
        {
            LimpiarControles();
            btnMostrar.Enabled = false;
            btnNuevo.Enabled = true;
            btnEditar.Enabled = false;
            btnCerrar.Enabled = false;

            grbListaClientes.Enabled = false;
            grbDatos.Enabled = true;
            ckbActivo.Checked = true;
            operacion = "INSERTAR";
            txtRUC.Focus();

        }
        public void ConfiguracionEditar()
        {
            LimpiarControles();
            btnMostrar.Enabled = false;
            btnNuevo.Enabled = false;
            btnEditar.Enabled = true;
            btnCerrar.Enabled = false;

            grbListaClientes.Enabled = false;
            grbDatos.Enabled = true;
            ckbActivo.Checked = true;
            operacion = "ACTUALIZAR";
            txtRUC.Focus();
        }
        public void ConfiguracionMostrar()
        {
            LimpiarControles();
            btnMostrar.Enabled = true;
            btnNuevo.Enabled = false;
            btnEditar.Enabled = false;
            btnCerrar.Enabled = false;

            grbListaClientes.Enabled = true;
            grbDatos.Enabled = false;
        }
        public void LimpiarControles()
        {
            operacion = "";
            cliente_id = 0;
            txtClienteID.Text = "";
            txtEmpresa.Text = "";
            txtRUC.Text = "";
            txtTelefono.Text = "";
            txtCorreo.Text = "";
            txtDireccion.Text = "";
            txtUbigeoRENIEC.Text = "";
            ckbActivo.Checked = false;
        }
    }
}
