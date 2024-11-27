using CapaEntidad;
using CapaLogicaNegocio;
using System;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class MantenedorCondicion : Form
    {
        string operacion = "";
        int condicion_id = 0;
        public MantenedorCondicion()
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
                entCondicion condicion = new entCondicion
                {
                    FechaRegistro = dtpFechaRegistro.Value,
                    Condicion = txtCondicion.Text.ToUpper(),
                    Dias = Convert.ToInt32(txtDias.Text),
                    Activo = Convert.ToBoolean(ckbActivo.Checked),
                };

                bool resultado = logCondicion.Instancia.InsertarCondicion(condicion);

                if (resultado)
                {
                    MessageBox.Show("Agregado exitosamente.");
                    LimpiarControles();
                    ListarCondiciones();
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
        public void ListarCondiciones()
        {
            tablaCondiciones.DataSource = logCondicion.Instancia.ListarCondiciones();
        }
        public void LimpiarControles()
        {
            txtCondicionID.Text = "";
            txtCondicion.Text = "";
            txtDias.Text = "";
            ckbActivo.Checked = false;
        }

        private void MantenedorCondicionesPago_Load(object sender, EventArgs e)
        {
            ListarCondiciones();
            grbDatos.Enabled = false;
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (tablaCondiciones.SelectedRows.Count > 0)
            {
                txtCondicionID.Text = tablaCondiciones.CurrentRow.Cells[0].Value.ToString();
                dtpFechaRegistro.Value = Convert.ToDateTime(tablaCondiciones.CurrentRow.Cells[1].Value);
                txtCondicion.Text = tablaCondiciones.CurrentRow.Cells[2].Value.ToString();
                txtDias.Text = tablaCondiciones.CurrentRow.Cells[3].Value.ToString();
                ckbActivo.Checked = Convert.ToBoolean(tablaCondiciones.CurrentRow.Cells[4].Value);
                grbDatos.Enabled = false;
                operacion = "";
            }
            else
            {
                MessageBox.Show("SELECCIONA FILA A MOSTRAR");
            }


        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            grbDatos.Enabled = true;
            operacion = "INSERTAR";
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (tablaCondiciones.SelectedRows.Count > 0)
            {
                txtCondicionID.Text = tablaCondiciones.CurrentRow.Cells[0].Value.ToString();
                dtpFechaRegistro.Value = Convert.ToDateTime(tablaCondiciones.CurrentRow.Cells[1].Value);
                txtCondicion.Text = tablaCondiciones.CurrentRow.Cells[2].Value.ToString();
                txtDias.Text = tablaCondiciones.CurrentRow.Cells[3].Value.ToString();
                ckbActivo.Checked = Convert.ToBoolean(tablaCondiciones.CurrentRow.Cells[4].Value);
                grbDatos.Enabled = true;
                operacion = "ACTUALIZAR";
            }
            else
            {
                MessageBox.Show("SELECCIONA FILA A MOSTRAR");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (operacion == "INSERTAR")
            {
                try
                {
                    entCondicion condicion = new entCondicion
                    {
                        FechaRegistro = Convert.ToDateTime(dtpFechaRegistro.Value),
                        Condicion = txtCondicion.Text.ToUpper().Trim(),
                        Dias = Convert.ToInt32(txtDias.Text),
                        Activo = Convert.ToBoolean(ckbActivo.Checked),
                    };

                    bool resultado = logCondicion.Instancia.InsertarCondicion(condicion);

                    if (resultado)
                    {
                        MessageBox.Show("SE INSERTó.");
                        LimpiarControles();
                        ListarCondiciones();
                        grbDatos.Enabled = false;
                        operacion = "";
                    }
                    else
                    {
                        MessageBox.Show("NO SE INSERTó.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error EN INSERTAR: " + ex.Message);
                }

            }
            else if (operacion == "ACTUALIZAR")
            {
                try
                {
                    entCondicion condicion = new entCondicion
                    {
                        CondicionID = Convert.ToInt32(txtCondicionID.Text.Trim()),
                        FechaRegistro = Convert.ToDateTime(dtpFechaRegistro.Value),
                        Condicion = txtCondicion.Text.ToUpper().Trim(),
                        Dias = Convert.ToInt32(txtDias.Text),
                        Activo = Convert.ToBoolean(ckbActivo.Checked),
                    };
                    bool resultado = logCondicion.Instancia.ActualizarCondicion(condicion);
                    if (resultado)
                    {
                        MessageBox.Show("ACTUALIZADO.");
                        LimpiarControles();
                        ListarCondiciones();
                        grbDatos.Enabled = false;
                        operacion = "";
                    }
                    else
                    {
                        MessageBox.Show("NO SE ACTUALIZó.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR EN ACTUALIZAR." + ex.Message);
                    throw;
                }
            }
            else
            {
                MessageBox.Show("Seleccione operacion");
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBusqueda.Text != "")
            {
                try
                {
                    tablaCondiciones.DataSource = logCondicion.Instancia.BuscarCondicion(txtBusqueda.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR EN BUSQUEDA " + ex.Message);
                    throw;
                }

            }
            else
            {
                MessageBox.Show("Ingrese busqueda");
            }
        }

        private void btnDesactivar_Click(object sender, EventArgs e)
        {
            if (tablaCondiciones.SelectedRows.Count > 0)
            {
                condicion_id = Convert.ToInt32(tablaCondiciones.CurrentRow.Cells[0].Value);
                try
                {
                    entCondicion condicion = new entCondicion
                    {
                        CondicionID = condicion_id,
                    };
                    bool resultado = logCondicion.Instancia.DesactivarCondicion(condicion);
                    if (resultado)
                    {
                        MessageBox.Show("Estado Actualizado.");
                        ListarCondiciones();
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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBusqueda.Text = "";
            ListarCondiciones();
            LimpiarControles();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            LimpiarControles();
            grbDatos.Enabled = false;
        }
    }
}
