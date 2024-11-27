using CapaEntidad;
using CapaLogicaNegocio;
using System;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class MantenedorMoneda : Form
    {
        string operacion = "";
        int moneda_id = 0;
        public MantenedorMoneda()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                entMoneda moneda = new entMoneda
                {
                    CodigoISO = txtCodigoISO.Text.ToUpper().Trim(),
                    Moneda = txtNombre.Text.ToUpper().Trim(),
                    Simbolo = txtSimbolo.Text.ToUpper().Trim(),
                    Pais = txtPais.Text.ToUpper().Trim(),
                };

                bool resultado = logMoneda.Instancia.InsertarMoneda(moneda);

                if (resultado)
                {
                    MessageBox.Show("Agregado exitosamente.");
                    LimpiarControles();
                    ListarMonedas();
                }
                else
                {
                    MessageBox.Show("Error al guardar Ruta.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en Agregar: " + ex.Message);
            }
        }
        public void ListarMonedas()
        {
            tablaMonedas.DataSource = logMoneda.Instancia.ListarMonedas();
        }
        public void LimpiarControles()
        {
            txtMonedaID.Text = "";
            txtCodigoISO.Text = "";
            txtNombre.Text = "";
            txtSimbolo.Text = "";
            txtPais.Text = "";
        }

        private void MantenedorMoneda_Load(object sender, EventArgs e)
        {
            ListarMonedas();
            grbDatos.Enabled = false;
        }

        private void btnInformacion_Click(object sender, EventArgs e)
        {
            if (tablaMonedas.SelectedRows.Count > 0)
            {
                txtMonedaID.Text = tablaMonedas.CurrentRow.Cells[0].Value.ToString();
                dtpFechaRegistro.Text = tablaMonedas.CurrentRow.Cells[1].Value.ToString();
                txtCodigoISO.Text = tablaMonedas.CurrentRow.Cells[2].Value.ToString();
                txtNombre.Text = tablaMonedas.CurrentRow.Cells[3].Value.ToString();
                txtSimbolo.Text = tablaMonedas.CurrentRow.Cells[4].Value.ToString();
                txtPais.Text = tablaMonedas.CurrentRow.Cells[5].Value.ToString();
                ckbActivo.Checked = Convert.ToBoolean(tablaMonedas.CurrentRow.Cells[6].Value);
            }
            else
            {
                MessageBox.Show("Seleccione una fila");
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            grbDatos.Enabled = true;
            LimpiarControles();
            ckbActivo.Checked = true;
            operacion = "INSERTAR";
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            if (tablaMonedas.SelectedRows.Count > 0)
            {
                grbDatos.Enabled = true;
                txtMonedaID.Text = tablaMonedas.CurrentRow.Cells[0].Value.ToString();
                dtpFechaRegistro.Text = tablaMonedas.CurrentRow.Cells[1].Value.ToString();
                txtCodigoISO.Text = tablaMonedas.CurrentRow.Cells[2].Value.ToString();
                txtNombre.Text = tablaMonedas.CurrentRow.Cells[3].Value.ToString();
                txtSimbolo.Text = tablaMonedas.CurrentRow.Cells[4].Value.ToString();
                txtPais.Text = tablaMonedas.CurrentRow.Cells[5].Value.ToString();
                ckbActivo.Checked = Convert.ToBoolean(tablaMonedas.CurrentRow.Cells[6].Value);
                operacion = "ACTUALIZAR";
            }
            else
            {
                MessageBox.Show("Seleccione una fila");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (operacion == "")
            {
                MessageBox.Show("Seleccione operacion");
            }
            else if (operacion == "INSERTAR")
            {
                try
                {
                    entMoneda moneda = new entMoneda
                    {
                        Fecha = Convert.ToDateTime(dtpFechaRegistro.Text),
                        CodigoISO = txtCodigoISO.Text.ToUpper().Trim(),
                        Moneda = txtNombre.Text.ToUpper().Trim(),
                        Simbolo = txtSimbolo.Text.ToUpper().Trim(),
                        Pais = txtPais.Text.ToUpper().Trim(),
                        Activo = true
                    };

                    bool resultado = logMoneda.Instancia.InsertarMoneda(moneda);
                    if (resultado)
                    {

                        MessageBox.Show("INSERTADO.");
                        LimpiarControles();
                        ListarMonedas();
                        operacion = "";
                    }
                    else
                    {
                        MessageBox.Show("NO SE INSERTO.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR AL INSERTAR: " + ex.Message);
                }
            }
            else if (operacion == "ACTUALIZAR")
            {
                try
                {
                    entMoneda moneda = new entMoneda
                    {
                        MonedaID = Convert.ToInt32(txtMonedaID.Text),
                        Fecha = Convert.ToDateTime(dtpFechaRegistro.Text),
                        CodigoISO = txtCodigoISO.Text.ToUpper().Trim(),
                        Moneda = txtNombre.Text.ToUpper().Trim(),
                        Simbolo = txtSimbolo.Text.ToUpper().Trim(),
                        Pais = txtPais.Text.ToUpper().Trim(),
                        Activo = ckbActivo.Checked
                    };

                    bool resultado = logMoneda.Instancia.ActualizarMoneda(moneda);
                    if (resultado)
                    {

                        MessageBox.Show("ACTUALIZADO.");
                        LimpiarControles();
                        ListarMonedas();
                        operacion = "";
                    }
                    else
                    {
                        MessageBox.Show("NO SE ACTUALIZO.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al ACTUALIZAR: " + ex.Message);
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string cadena = txtBuscador.Text;
                tablaMonedas.DataSource = logMoneda.Instancia.BusquedaMoneda(cadena);
            }
            catch (Exception EX)
            {
                Console.WriteLine("ERROR AL BUSCAR MONEDA", EX.Message);
                throw;
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            ListarMonedas();
        }

        private void btnDesactivar_Click(object sender, EventArgs e)
        {
            if (tablaMonedas.SelectedRows.Count > 0)
            {
                moneda_id = Convert.ToInt32(tablaMonedas.CurrentRow.Cells[0].Value);
                try
                {
                    bool resultado = logMoneda.Instancia.DesactivarMoneda(moneda_id);
                    if (resultado)
                    {
                        MessageBox.Show("Estado Actualizado.");
                        ListarMonedas();
                        moneda_id = 0;
                    }
                    else
                    {
                        MessageBox.Show("No se Actualizado el Estado.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al Actualizar Estado: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Seleccione una fila");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            LimpiarControles();
            grbDatos.Enabled = false;
        }
    }
}
