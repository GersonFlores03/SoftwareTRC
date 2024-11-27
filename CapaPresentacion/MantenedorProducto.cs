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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CapaPresentacion
{
    public partial class MantenedorProducto : Form
    {


        string operacion = "";
        private int producto_id = 0;



        public MantenedorProducto()
        {
            InitializeComponent();
        }

        private void MantenedorProducto_Load(object sender, EventArgs e)
        {
            List<entUnidad> unidades = logProducto.Instancia.ObtenerUnidades();

            if (unidades.Count == 0)
            {
                MessageBox.Show("No se encontraron unidades de medida.");
            }
            else
            {
                cmbProducto.DataSource = unidades;
                cmbProducto.DisplayMember = "nombreunidad";
                cmbProducto.ValueMember = "MedidaID";
            }
        }






        public void LimpiarControles()
        {
            operacion = "";
            producto_id = 0;
            txtNombre.Text = "";
            txtSecundario.Text = "";
            txtStock.Text = "";
            txtSecundario.Text = "";
            txtPeso.Text = "";

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
                    entProducto producto = new entProducto
                    {
                        MedidaID = new entUnidad
                        {
                            MedidaID = (int)cmbProducto.SelectedValue
                        },
                        nombre_producto = txtNombre.Text.Trim(),
                        nombre_secundario = txtSecundario.Text.Trim(),
                        descripcion = txtDescripcion.Text.Trim(),
                        stock = int.Parse(txtStock.Text.Trim()),
                        peso = decimal.Parse(txtPeso.Text.Trim()),
                        fecha_registro = dtpFechaRegistro.Value
                      
                    };

                    bool resultado = logProducto.Instancia.InsertarProductos(producto);

                    Console.WriteLine(resultado);

                    if (resultado == true)
                    {
                        MessageBox.Show("El producto ha sido guardado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //ListarClientes();
                        //ConfiguracionInicial();
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
                        Ubigeo_RENIEC = Convert.ToInt32(txtPeso.Text.Trim())
                    };

                    entCliente c = new entCliente
                    {
                        ClienteID = int.Parse(txtClienteID.Text.Trim()),
                        RazonSocial = txtNombre.Text.Trim(),
                       // RUC = txtRUC.Text.Trim(),
                        Telefono = txtSecundario.Text.Trim(),
                        Correo = txtDescripcion.Text.Trim(),
                        Direccion = txtStock.Text.Trim(),
                        Ubigeo = u,
                        Estado = ckbActivo.Checked
                    };

                    bool resultado = logCliente.Instancia.ActualizarCliente(c);
                    if (resultado)
                    {
                        MessageBox.Show("El cliente ha sido actualizado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                       // ListarClientes();
                        //ConfiguracionInicial();
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




       


        private void btnNuevo_Click(object sender, EventArgs e)
        {
            ConfiguracionNuevo();
        }

        private void dtpFechaRegistro_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
