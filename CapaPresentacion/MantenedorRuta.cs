using CapaEntidad;
using CapaLogicaNegocio;
using System;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class MantenedorRuta : Form
    {
        int rutaID = 0;
        string operacion = "";
        public MantenedorRuta()
        {
            InitializeComponent();
        }
        private void ListarRutas()
        {
            tablaRutas.DataSource = logRuta.Instancia.ListarRutas();
        }
        private void LimpiarControles()
        {
            txtRutaID.Text = "";
            txtRuta.Text = "";
            cmbOrigen.SelectedIndex = -1;
            cmbDestino.SelectedIndex = -1;
            txtDistancia.Text = "";
            ckbActivo.Checked = false;
        }

        private void MantenedorRuta_Load(object sender, EventArgs e)
        {
            grbDatosRuta.Enabled = false;
            ListarRutas();
            ListarOrigenes();
            ListarDestinos();
        }
        private void ListarOrigenes()
        {
            cmbOrigen.DataSource = logUbigeo.Instancia.ListarDepartamentos();
            cmbOrigen.DisplayMember = "Departamento";
            cmbOrigen.ValueMember = "Departamento";
            cmbOrigen.SelectedIndex = -1;
        }
        private void ListarDestinos()
        {
            cmbDestino.DataSource = logUbigeo.Instancia.ListarDepartamentos();
            cmbDestino.DisplayMember = "Departamento";
            //cmbDestino.ValueMember = "departamento_inei";
            cmbDestino.SelectedIndex = -1;
        }

        private void btnLlenarRuta_Click(object sender, EventArgs e)
        {
            txtRuta.Text = "";
            txtRuta.Text = cmbOrigen.Text + " - " + cmbDestino.Text;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarControles();
            grbDatosRuta.Enabled = true;
            ckbActivo.Checked = true;
            operacion = "INSERTAR";
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (tablaRutas.SelectedRows.Count > 0)
            {
                grbDatosRuta.Enabled = true;
                operacion = "ACTUALIZAR";

                txtRutaID.Text = tablaRutas.CurrentRow.Cells[0].Value.ToString();
                dtpFechaRegistro.Text = tablaRutas.CurrentRow.Cells[1].Value.ToString();
                txtRuta.Text = tablaRutas.CurrentRow.Cells["Nombre"].Value.ToString();
                cmbOrigen.Text = tablaRutas.CurrentRow.Cells["Origen"].Value.ToString();
                cmbDestino.Text = tablaRutas.CurrentRow.Cells["Destino"].Value.ToString();
                txtDistancia.Text = tablaRutas.CurrentRow.Cells["Distancia"].Value.ToString();
                ckbActivo.Checked = Convert.ToBoolean(tablaRutas.CurrentRow.Cells["Activo"].Value);

            }
            else
            {
                MessageBox.Show("Seleccione ruta a editar");
            }
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            if (operacion == "")
            {
                MessageBox.Show("Seleccione operacion");
            }
            else if (operacion == "INSERTAR")
            {
                try
                {

                    entRuta ruta = new entRuta
                    {
                        FechaRegistro = dtpFechaRegistro.Value,
                        Nombre = txtRuta.Text.ToString(),
                        Origen = cmbOrigen.Text.ToString(),
                        Destino = cmbDestino.Text.ToString(),
                        Distancia = Convert.ToDecimal(txtDistancia.Text),
                        Activo = ckbActivo.Checked
                    };
                    bool resultado = logRuta.Instancia.InsertaRuta(ruta);
                    if (resultado)
                    {

                        MessageBox.Show("exito.");
                        LimpiarControles();
                        ListarRutas();
                        operacion = "";
                        grbDatosRuta.Enabled = false;

                    }
                    else
                    {
                        MessageBox.Show("no se insertó");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al insertar: " + ex.Message);
                }
            }
            else if (operacion == "ACTUALIZAR")
            {
                try
                {
                    entRuta c = new entRuta
                    {
                        RutaID = Convert.ToInt32(txtRutaID.Text),
                        FechaRegistro = dtpFechaRegistro.Value,
                        Nombre = txtRuta.Text.ToString(),
                        Origen = cmbOrigen.Text.ToString(),
                        Destino = cmbDestino.Text.ToString(),
                        Distancia = Convert.ToDecimal(txtDistancia.Text),
                        Activo = ckbActivo.Checked
                    };

                    bool resultado = logRuta.Instancia.ActualizaRuta(c);

                    if (resultado)
                    {
                        MessageBox.Show("Cliente actualizado.");
                        LimpiarControles();
                        ListarRutas();
                        operacion = "";
                        grbDatosRuta.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("No se actualizaron datos.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar datos: " + ex.Message);
                }
            }
            else
            {
            }

        }

        private void btnBuscarRuta_Click(object sender, EventArgs e)
        {
            try
            {
                string ruta = txtBuscador.Text;
                tablaRutas.DataSource = logRuta.Instancia.BuscarRutas(ruta);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la información del cliente: " + ex.Message);
            }
        }

        private void btnLimpiarFiltro_Click(object sender, EventArgs e)
        {
            tablaRutas.DataSource = logRuta.Instancia.ListarRutas();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (tablaRutas.SelectedRows.Count > 0)
            {
                grbDatosRuta.Enabled = false;
                operacion = "";

                txtRutaID.Text = tablaRutas.CurrentRow.Cells[0].Value.ToString(); //ID
                dtpFechaRegistro.Text = tablaRutas.CurrentRow.Cells[1].Value.ToString();
                txtRuta.Text = tablaRutas.CurrentRow.Cells["Nombre"].Value.ToString();
                cmbOrigen.Text = tablaRutas.CurrentRow.Cells["Origen"].Value.ToString();
                cmbDestino.Text = tablaRutas.CurrentRow.Cells["Destino"].Value.ToString();
                txtDistancia.Text = tablaRutas.CurrentRow.Cells["Distancia"].Value.ToString();
                ckbActivo.Checked = Convert.ToBoolean(tablaRutas.CurrentRow.Cells["Activo"].Value);

            }
            else
            {
                MessageBox.Show("Seleccione ruta a mostrar");
            }
        }

        private void btnEliminarFila_Click(object sender, EventArgs e)
        {
            if (tablaRutas.SelectedRows.Count > 0)
            {
                rutaID = Convert.ToInt32(tablaRutas.CurrentRow.Cells[0].Value);
                try
                {
                    entRuta c = new entRuta
                    {
                        RutaID = rutaID,
                    };

                    bool resultado = logRuta.Instancia.DeshabilitaRuta(c);
                    if (resultado)
                    {
                        MessageBox.Show("Estado Actualizado.");
                        ListarRutas();
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

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            grbDatosRuta.Enabled = false;
            LimpiarControles();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
