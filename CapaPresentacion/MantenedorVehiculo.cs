using CapaEntidad;
using CapaLogicaNegocio;
using System;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class MantenedorVehiculo : Form
    {
        public string operacion = ""; //OPERACION POR DEFECTO
        int vehiculoID;

        public MantenedorVehiculo()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void ManVehiculo_Load(object sender, EventArgs e)
        {
            ListarVehiculos();
            ListarColores();
            ListarMarcas();
            ListarClases();
            dtpAño.Format = DateTimePickerFormat.Custom;
            dtpAño.CustomFormat = "yyyy";
            dtpAño.ShowUpDown = true; // to prevent the calendar from being displayed
            grbDatosVehiculo.Enabled = false;
        }
        public void ListarVehiculos()
        {
            tablaVehiculos.DataSource = logVehiculo.Instancia.ListarVehiculos();
            //tablaVehiculos.Columns[1].Visible = false;
            //tablaVehiculos.Columns[2].Visible = false;
            //tablaVehiculos.Columns[3].Visible = false;
        }

        public void ListarColores()
        {
            //cmbColor.DataSource = logColor.Instancia.ListarColores2();
            cmbColor.DataSource = logColor.Instancia.ListarColores();
            cmbColor.DisplayMember = "Color";
            cmbColor.ValueMember = "ColorID";
            cmbColor.SelectedIndex = -1;
        }

        public void ListarMarcas()
        {
            cmbMarca.DataSource = logMarca.Instancia.ListarMarcas();
            cmbMarca.DisplayMember = "Marca";
            cmbMarca.ValueMember = "MarcaID";
            cmbMarca.SelectedIndex = -1;
        }

        public void ListarClases()
        {
            cmbClase.DataSource = logClase.Instancia.ListarClases();
            cmbClase.DisplayMember = "Clase";
            cmbClase.ValueMember = "ClaseID";
            cmbClase.SelectedIndex = -1;
        }

        public void LimpiarControles()
        {
            txtVehiculoID.Text = "";
            txtPlaca.Text = "";
            cmbMarca.SelectedIndex = -1;
            cmbClase.SelectedIndex = -1;
            cmbColor.SelectedIndex = -1;
            txtSerie.Text = "";
            txtMotor.Text = "";
            dtpAño.Text = "";
            txtLongitud.Text = "";
            txtAltura.Text = "";
            txtAncho.Text = "";
            txtCargaUtil.Text = "";
            ckbActivo.Checked = false;

        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (tablaVehiculos.SelectedRows.Count > 0)
            {
                grbDatosVehiculo.Enabled = true;
                operacion = "ACTUALIZAR";

                txtVehiculoID.Text = tablaVehiculos.CurrentRow.Cells[0].Value.ToString();
                txtPlaca.Text = tablaVehiculos.CurrentRow.Cells["Placa"].Value.ToString();
                cmbMarca.Text = tablaVehiculos.CurrentRow.Cells["Marca"].Value.ToString();
                cmbClase.Text = tablaVehiculos.CurrentRow.Cells["Clase"].Value.ToString();
                cmbColor.Text = tablaVehiculos.CurrentRow.Cells["Color"].Value.ToString();
                txtSerie.Text = tablaVehiculos.CurrentRow.Cells["Serie"].Value.ToString();
                txtMotor.Text = tablaVehiculos.CurrentRow.Cells["Motor"].Value.ToString();
                //dtpAño.Text = tablaVehiculos.CurrentRow.Cells["Año"].Value.ToString();
                if (int.TryParse(tablaVehiculos.CurrentRow.Cells["Año"].Value.ToString(), out int year))
                {
                    dtpAño.Value = new DateTime(year, 1, 1);
                }
                else
                {
                    MessageBox.Show("El valor de la celda no es un año válido.");
                }
                txtLongitud.Text = tablaVehiculos.CurrentRow.Cells["Longitud"].Value.ToString();
                txtAltura.Text = tablaVehiculos.CurrentRow.Cells["Altura"].Value.ToString();
                txtAncho.Text = tablaVehiculos.CurrentRow.Cells["Ancho"].Value.ToString();
                txtCargaUtil.Text = tablaVehiculos.CurrentRow.Cells["CargaUtil"].Value.ToString();
                ckbActivo.Checked = Convert.ToBoolean(tablaVehiculos.CurrentRow.Cells["Activo"].Value);
            }
            else
            {
                MessageBox.Show("Seleccione fila completa");
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            operacion = "INSERTAR";
            grbDatosVehiculo.Enabled = true;
            ckbActivo.Checked = true;
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (tablaVehiculos.SelectedRows.Count > 0)
            {
                txtVehiculoID.Text = tablaVehiculos.CurrentRow.Cells[0].Value.ToString();
                txtPlaca.Text = tablaVehiculos.CurrentRow.Cells["Placa"].Value.ToString();
                cmbMarca.Text = tablaVehiculos.CurrentRow.Cells["Marca"].Value.ToString();
                cmbClase.Text = tablaVehiculos.CurrentRow.Cells["Clase"].Value.ToString();
                cmbColor.Text = tablaVehiculos.CurrentRow.Cells["Color"].Value.ToString();
                txtSerie.Text = tablaVehiculos.CurrentRow.Cells["Serie"].Value.ToString();
                txtMotor.Text = tablaVehiculos.CurrentRow.Cells["Motor"].Value.ToString();
                //dtpAño.Text = tablaVehiculos.CurrentRow.Cells["Año"].Value.ToString();
                // Asegúrate de que el valor de la celda sea un año válido
                if (int.TryParse(tablaVehiculos.CurrentRow.Cells["Año"].Value.ToString(), out int year))
                {
                    dtpAño.Value = new DateTime(year, 1, 1);
                }
                else
                {
                    MessageBox.Show("El valor de la celda no es un año válido.");
                }

                txtLongitud.Text = tablaVehiculos.CurrentRow.Cells["Longitud"].Value.ToString();
                txtAltura.Text = tablaVehiculos.CurrentRow.Cells["Altura"].Value.ToString();
                txtAncho.Text = tablaVehiculos.CurrentRow.Cells["Ancho"].Value.ToString();
                txtCargaUtil.Text = tablaVehiculos.CurrentRow.Cells["CargaUtil"].Value.ToString();
                ckbActivo.Checked = Convert.ToBoolean(tablaVehiculos.CurrentRow.Cells["Activo"].Value);

                grbDatosVehiculo.Enabled = true;
            }
            else
            {
                MessageBox.Show("Seleccione una fila para mostrar");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (operacion == "INSERTAR")
            {
                try
                {
                    entMarca marca = new entMarca
                    {
                        MarcaID = Convert.ToInt32(cmbMarca.SelectedValue)
                    };
                    Console.WriteLine("MarcaID es: " + marca.MarcaID);
                    entClase clase = new entClase
                    {
                        ClaseID = Convert.ToInt32(cmbClase.SelectedValue)
                    };
                    Console.WriteLine("ClaseID es: " + clase.ClaseID);
                    entColor color = new entColor
                    {
                        ColorID = Convert.ToInt32(cmbColor.SelectedValue)

                    };
                    Console.WriteLine("ColorID es: " + color.ColorID);
                    int year = int.Parse(dtpAño.Text);
                    DateTime año = new DateTime(year, 1, 1); // Crear un DateTime con el primer día del año

                    entVehiculo vehiculo = new entVehiculo
                    {
                        Placa = txtPlaca.Text.Trim().ToString(),
                        Marca = marca,
                        Clase = clase,
                        Color = color,
                        Serie = txtSerie.Text.Trim(),
                        Motor = txtMotor.Text.Trim(),
                        Año = año,
                        Longitud = Convert.ToDecimal(txtLongitud.Text.ToString()),
                        Altura = Convert.ToDecimal(txtAltura.Text.ToString()),
                        Ancho = Convert.ToDecimal(txtAncho.Text.ToString()),
                        CargaUtil = Convert.ToInt32(txtCargaUtil.Text.ToString()),
                        Activo = true
                    };

                    bool resultado = logVehiculo.Instancia.InsertarVehiculo(vehiculo);

                    if (resultado)
                    {
                        MessageBox.Show("Guardado exitosamente.");
                        LimpiarControles();
                        ListarVehiculos();
                        grbDatosVehiculo.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("NO SE GUARDO.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar: " + ex.Message);
                }

            }
            else if (operacion == "ACTUALIZAR")
            {
                try
                {
                    entMarca marca = new entMarca();
                    marca.MarcaID = Convert.ToInt32(cmbMarca.SelectedValue);
                    entClase clase = new entClase();
                    clase.ClaseID = Convert.ToInt32(cmbClase.SelectedValue);
                    entColor color = new entColor();
                    color.ColorID = Convert.ToInt32(cmbColor.SelectedValue);
                    int year = int.Parse(dtpAño.Text);
                    DateTime año = new DateTime(year, 1, 1); // Crear un DateTime con el primer día del año
                    entVehiculo vehiculo = new entVehiculo
                    {
                        VehiculoID = Convert.ToInt32(txtVehiculoID.Text.ToString()),
                        Placa = txtPlaca.Text.Trim().ToString(),
                        Marca = marca,
                        Clase = clase,
                        Color = color,
                        Serie = txtSerie.Text.Trim().ToString(),
                        Motor = txtMotor.Text.Trim().ToString(),
                        Año = año,
                        Longitud = Convert.ToDecimal(txtLongitud.Text.ToString()),
                        Altura = Convert.ToDecimal(txtAltura.Text.ToString()),
                        Ancho = Convert.ToDecimal(txtAncho.Text.ToString()),
                        CargaUtil = Convert.ToInt32(txtCargaUtil.Text.ToString()),
                        Activo = true
                    };

                    bool resultado = logVehiculo.Instancia.ActualizarVehiculo(vehiculo);

                    if (resultado)
                    {
                        MessageBox.Show("exito.");
                        LimpiarControles();
                        ListarVehiculos();
                        grbDatosVehiculo.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("no se actualizo.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("SELECCIONE OPERACION");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string cadena = txtBusqueda.Text;
                tablaVehiculos.DataSource = logVehiculo.Instancia.BuscarVehiculo(cadena);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la información: " + ex.Message);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            ListarVehiculos();
            txtBusqueda.Text = "";
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            if (tablaVehiculos.SelectedRows.Count > 0)
            {
                vehiculoID = Convert.ToInt32(tablaVehiculos.CurrentRow.Cells[0].Value);
                try
                {
                    entVehiculo vehiculo = new entVehiculo
                    {
                        VehiculoID = vehiculoID
                    };

                    //bool resultado = logCliente.Instancia.DeshabilitarCliente(c);
                    bool resultado = logVehiculo.Instancia.DesactivarVehiculo(vehiculo);

                    if (resultado)
                    {
                        MessageBox.Show("Estado Actualizado.");
                        ListarVehiculos();
                    }
                    else
                    {
                        MessageBox.Show("No se Actualizado el Estado.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al DESACTIVOR Estado: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Seleccione una fila");
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            LimpiarControles();
            grbDatosVehiculo.Enabled = false;
        }
    }
}
