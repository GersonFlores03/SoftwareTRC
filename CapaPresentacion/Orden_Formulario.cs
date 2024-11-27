using CapaEntidad;
using CapaLogicaNegocio;
using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Orden_Formulario : Form
    {
        public string operacion; //OPERACION
        public int ordenID;


        public Orden_Formulario()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }
        private void Orden_Formulario_Load(object sender, EventArgs e)
        {

        }

        private string Extraer(string input) // Método para extraer cadena entre paréntesis
        {
            // Expresión regular para encontrar el texto entre paréntesis
            var match = Regex.Match(input, @"\(([^)]+)\)");
            if (match.Success)
            {
                return match.Groups[1].Value;
            }
            else
            {
                // Si no se encuentra texto entre paréntesis, devolver el texto original
                return input;
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (operacion == "INSERTAR")
            {
                int val = 0;
                if (cmbCondicion.SelectedIndex == -1)
                {
                    Console.WriteLine("Selecciona Condicion de Pago");
                    val++;
                }
                if (cmbMoneda.SelectedIndex == -1)
                {
                    Console.WriteLine("Selecciona Moneda");
                    val++;
                }
                if (string.IsNullOrWhiteSpace(txtCliente.Text))
                {
                    Console.WriteLine("Ingresa Cliente");
                    val++;
                }
                if (string.IsNullOrWhiteSpace(txtVehiculo.Text))
                {
                    Console.WriteLine("Ingresa Vehiculo");
                    val++;
                }
                if (string.IsNullOrWhiteSpace(txtRuta.Text))
                {
                    Console.WriteLine("Ingresa Ruta");
                    val++;
                }
                if (string.IsNullOrWhiteSpace(txtDescripcion.Text) || txtDescripcion.Text.Length <= 20)
                {
                    MessageBox.Show("Por favor, ingresa una descripción de más de 20 caracteres.", "Descripción Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    val++;
                }
                //if (rbtIda.Checked)
                //{
                //    Console.WriteLine("Selecciona Modalidad");
                //    val++;
                //}
                if (string.IsNullOrWhiteSpace(txtMontoFlete.Text))
                {
                    Console.WriteLine("Ingresa Monto Flete");
                    val++;
                }
                if (string.IsNullOrWhiteSpace(txtMontoRetorno.Text))
                {
                    Console.WriteLine("Ingresa Monto Retorno");
                    val++;
                }
                if (val == 0)
                {
                    try
                    {
                        entCliente cliente = new entCliente
                        {
                            RUC = Extraer(txtCliente.Text)
                        };
                        Console.WriteLine("ruc para insertar fue: " + cliente.RUC);
                        entVehiculo vehiculo = new entVehiculo
                        {
                            Placa = Extraer(txtVehiculo.Text)
                        };
                        entRuta ruta = new entRuta
                        {
                            Nombre = txtRuta.Text.Trim().ToUpper()
                        };
                        entCondicion condicion = new entCondicion
                        {
                            CondicionID = Convert.ToInt32(cmbCondicion.SelectedValue)
                        };
                        entMoneda entMoneda = new entMoneda
                        {
                            MonedaID = Convert.ToInt32(cmbMoneda.SelectedValue)
                        };

                        // Creamos orden y asignamos valores
                        entOrden orden = new entOrden
                        {
                            FechaRegistro = dtpFechaRegistro.Value,
                            Cliente = cliente,
                            Vehiculo = vehiculo,
                            Ruta = ruta,
                            Descripcion = txtDescripcion.Text.Trim().ToUpper(),
                            Condicion = condicion,
                            Moneda = entMoneda,
                            Flete = Math.Round(Convert.ToDecimal(txtMontoFlete.Text), 2),
                            Retorno = Math.Round(Convert.ToDecimal(txtMontoRetorno.Text), 2),
                            Observaciones = txtObservaciones.Text.Trim().ToUpper(),
                            Activo = true,
                            numero_orden = txtNumeroOrden.Text.Trim().ToUpper(),
                            
                        };

                        bool resultado = logOrden.Instancia.InsertarOrdenNuevo(orden);
                        if (resultado)
                        {
                            MessageBox.Show("La orden se guardó exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            operacion = "";
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo guardar la orden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocurrió un error al guardar la orden: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        throw;
                    }
                }
            }
            else if (operacion == "ACTUALIZAR")
            {
                //try
                //{
                //    entOrden orden = new entOrden
                //    {
                //        OrdenTransporteID = Convert.ToInt32(ordenID),
                //        Observaciones = txtObservaciones.Text.Trim().ToUpper()
                //    };
                //    bool resultado = logOrden.Instancia.ActualizarObservacion(orden);

                //    // Mensajes de depuración mejorados
                //    if (resultado)
                //    {
                //        Console.WriteLine("Depuración: La orden con ID " + orden.OrdenTransporteID + " se actualizó correctamente.");
                //        MessageBox.Show("Orden actualizada.", "Actualización Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //        this.Close();
                //    }
                //    else
                //    {
                //        Console.WriteLine("Depuración: La orden con ID " + orden.OrdenTransporteID + " no se pudo actualizar.");
                //        MessageBox.Show("No se actualizó la orden.", "Error de Actualización", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    }
                //}
                //catch (Exception ex)
                //{
                //    Console.WriteLine("Depuración: Error al actualizar la orden con ID " + ordenID + ". Detalles del error: " + ex.Message);
                //    MessageBox.Show("Ocurrió un error al actualizar la orden: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
            }
        }
        public void SetControlesNuevaOrden()
        {
            rbtIda.Checked = true;
            txtMontoRetorno.Enabled = false;
            txtMontoFlete.Text = "0";
            txtMontoRetorno.Text = "0";
        }
        private void btnCambiarFleteOrdenTrabajo_Click(object sender, EventArgs e)
        {
            CalcularTotales();
        }
        private void btnBuscarClienteRUC_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCliente.Text))
            {
                txtCliente.BackColor = Color.Red;
                MessageBox.Show("Ingresa RUC de cliente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCliente.Focus();
                return;
            }
            else
            {
                txtCliente.BackColor = Color.White;
            }
            try
            {
                string clienteRUC = txtCliente.Text;
                entCliente cliente = logCliente.Instancia.InformacionClientePorRUC(clienteRUC);
                if (cliente != null)
                {
                    txtCliente.Text = $"({cliente.RUC}) - {cliente.RazonSocial} - {cliente.Ubigeo.Departamento}/{cliente.Ubigeo.Provincia}/{cliente.Ubigeo.Distrito}";
                    txtCliente.Enabled = false;
                }
                else
                {
                    MessageBox.Show("No se encontró la información del cliente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la información del cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnBusqVehiculoPlaca_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtVehiculo.Text))
            {
                txtVehiculo.BackColor = Color.Red;
                MessageBox.Show("Ingresa la placa del vehículo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtVehiculo.Focus();
                return;
            }
            else
            {
                txtVehiculo.BackColor = Color.White;
            }
            string vehiculoPlaca = txtVehiculo.Text;
            try
            {
                entVehiculo vehiculo = logVehiculo.Instancia.InformacionVehiculoPorPlaca(vehiculoPlaca);
                if (vehiculo != null)
                {
                    txtVehiculo.Text = $"({vehiculo.Placa}) - {vehiculo.Marca.Marca} - {vehiculo.Clase.Clase} - {vehiculo.Color.Color}";
                    txtVehiculo.Enabled = false;
                }
                else
                {
                    MessageBox.Show("No se encontró la información del vehículo.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la información del vehículo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnBuscarRutaNombre_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRuta.Text))
            {
                txtRuta.BackColor = Color.Red;
                MessageBox.Show("Ingresa el nombre de la ruta", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRuta.Focus();
                return;
            }
            else
            {
                txtRuta.BackColor = Color.White;
            }
            string rutaNombre = txtRuta.Text;
            try
            {
                entRuta ruta = logRuta.Instancia.InformacionRutaPorNombre(rutaNombre);
                if (ruta != null)
                {
                    txtRuta.Text = $"{ruta.Nombre}";
                    txtRuta.Enabled = false;
                }
                else
                {
                    MessageBox.Show("No se encontró la información de la ruta.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la información de la ruta: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnLimpiarClienteRUC_Click(object sender, EventArgs e)
        {
            txtCliente.Enabled = true;
            txtCliente.BackColor = Color.White;
            txtCliente.Text = "";
        }
        private void btnLimpiarVehiculoPlaca_Click(object sender, EventArgs e)
        {
            txtVehiculo.Enabled = true;
            txtVehiculo.BackColor = Color.White;
            txtVehiculo.Text = "";
        }
        private void btnLimpiarRutaNombre_Click(object sender, EventArgs e)
        {
            txtRuta.Enabled = true;
            txtRuta.BackColor = Color.White;
            txtRuta.Text = "";
        }
        private void rbtIda_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtIda.Checked)
            {
                txtMontoRetorno.Enabled = false;
                //txtMontoFlete.Text = "0";
                //txtMontoRetorno.Text = "0";
            }
            else if (rbtIdaRetorno.Checked)
            {
                txtMontoRetorno.Enabled = true;
            }
        }
        public void ListarCondiciones()
        {
            cmbCondicion.DataSource = logCondicion.Instancia.ListarCondiciones();
            cmbCondicion.DisplayMember = "Condicion";
            cmbCondicion.ValueMember = "CondicionID";
            cmbCondicion.SelectedIndex = -1;
        }
        public void ListarMonedas()
        {
            cmbMoneda.DataSource = logMoneda.Instancia.ListarMonedas();
            cmbMoneda.DisplayMember = "CodigoISO";
            cmbMoneda.ValueMember = "MonedaID";
            cmbMoneda.SelectedIndex = -1;
        }
        public void CalcularTotales()
        {
            decimal montoFlete = Convert.ToDecimal(txtMontoFlete.Text);
            decimal montoRetorno = Convert.ToDecimal(txtMontoRetorno.Text);
            decimal porcentajeIGV = Convert.ToDecimal(0.18);
            if (rbtIda.Checked)
            {
                montoRetorno = 0;
            }

            decimal montoSubTotal = montoFlete + montoRetorno;
            decimal montoIGV = montoSubTotal * porcentajeIGV;
            decimal montoTotal = montoSubTotal + montoIGV;

            txtMontoSubTotal.Text = Math.Round(montoSubTotal, 2).ToString();
            txtMontoIGV.Text = Math.Round(montoIGV, 2).ToString();
            txtMontoTotal.Text = Math.Round(montoTotal, 2).ToString();
        }

        private void btnBuscarClienteModal_Click(object sender, EventArgs e)
        {
            Orden_Formulario_BusquedaCliente orden_Formulario_BusquedaCliente = new Orden_Formulario_BusquedaCliente(this);
            orden_Formulario_BusquedaCliente.ShowDialog();
        }
        public void SetCliente(string clienteRUC)
        {
            txtCliente.Text = clienteRUC;
            txtCliente.Enabled = false;
            btnBuscarClienteRUC_Click(null, null);
        }

        private void btnBuscarVehiculoModal_Click(object sender, EventArgs e)
        {
            Orden_Formulario_BusquedaVehiculo orden_Formulario_BusquedaVehiculo = new Orden_Formulario_BusquedaVehiculo(this);
            orden_Formulario_BusquedaVehiculo.ShowDialog();
        }
        public void SetVehiculo(string vehiculoPlaca)
        {
            txtVehiculo.Text = vehiculoPlaca;
            txtVehiculo.Enabled = false;
            btnBusqVehiculoPlaca_Click(null, null);
        }
        private void btnBuscarRutaModal_Click(object sender, EventArgs e)
        {
            Orden_Formulario_BusquedaRuta orden_Formulario_BusquedaRuta = new Orden_Formulario_BusquedaRuta(this);
            orden_Formulario_BusquedaRuta.ShowDialog();
        }
        public void SetRuta(string rutaNombre)
        {
            txtRuta.Text = rutaNombre;
            txtRuta.Enabled = false;
            btnBuscarRutaNombre_Click(null, null);
        }

        private void btnAgregarGuia_Click(object sender, EventArgs e)
        {
            Guias guias = new Guias();
            guias.Show();
        }

        private void txtCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTramoOrdenTrabajo_Click(object sender, EventArgs e)
        {

        }
    }
}
