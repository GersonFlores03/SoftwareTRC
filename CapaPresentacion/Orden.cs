using CapaLogicaNegocio;
using System;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Orden : Form
    {
        public Orden()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            txtBusqueda.Focus();
        }

        private void Ordenes_Load(object sender, EventArgs e)
        {
            ListarOrdenes();
        }

        private void ListarOrdenes()
        {
            //tablaOrdenes.DataSource = logOrden.Instancia.ListaEntOrdenOrdenes();
            tablaOrdenes.DataSource = logOrden.Instancia.ListarOrdenes();
        }

        private void btnOrdenNueva_Click(object sender, EventArgs e)
        {
            Orden_Formulario frm_nuevo = new Orden_Formulario();
            //frm_nuevo.grbDatos.Enabled = true;
            frm_nuevo.operacion = "INSERTAR";
            frm_nuevo.ListarCondiciones();
            frm_nuevo.ListarMonedas();

            //frm_nuevo.CalcularTotales();
            frm_nuevo.SetControlesNuevaOrden();
            frm_nuevo.CalcularTotales();
            frm_nuevo.ShowDialog();
            ListarOrdenes();
        }

        private void btnMostrarInformacion_Click(object sender, EventArgs e)
        {
            if (tablaOrdenes.SelectedRows.Count > 0)
            {
                Orden_Formulario frm_nuevo = new Orden_Formulario();
                frm_nuevo.grbDatos.Enabled = false;
                frm_nuevo.operacion = "MOSTRAR";
                frm_nuevo.ListarCondiciones();
                frm_nuevo.ListarMonedas();
                frm_nuevo.ordenID = Convert.ToInt32(tablaOrdenes.CurrentRow.Cells[0].Value); //ID
                frm_nuevo.dtpFechaRegistro.Value = Convert.ToDateTime(tablaOrdenes.CurrentRow.Cells[1].Value); //FECHA
                frm_nuevo.txtCliente.Text = tablaOrdenes.CurrentRow.Cells[2].Value.ToString(); //CLIENTE
                frm_nuevo.txtVehiculo.Text = tablaOrdenes.CurrentRow.Cells[3].Value.ToString(); //VEHICULO
                frm_nuevo.txtRuta.Text = tablaOrdenes.CurrentRow.Cells[4].Value.ToString(); //RUTA
                frm_nuevo.txtDescripcion.Text = tablaOrdenes.CurrentRow.Cells[5].Value.ToString(); //DESCRIPCION
                frm_nuevo.cmbCondicion.Text = tablaOrdenes.CurrentRow.Cells[6].Value.ToString(); //CONDICION DE PAGO
                frm_nuevo.cmbMoneda.Text = tablaOrdenes.CurrentRow.Cells[7].Value.ToString(); //MONEDA
                frm_nuevo.txtMontoFlete.Text = tablaOrdenes.CurrentRow.Cells[8].Value.ToString(); //MONTO FLETE
                frm_nuevo.txtMontoRetorno.Text = tablaOrdenes.CurrentRow.Cells[9].Value.ToString(); //MONTO RETORNO

                Console.WriteLine("monto retorno .value es: " + Convert.ToInt32(tablaOrdenes.CurrentRow.Cells[9].Value));
                if (Convert.ToInt32(tablaOrdenes.CurrentRow.Cells[9].Value) > 0)
                {
                    frm_nuevo.rbtIdaRetorno.Checked = true;
                }
                else
                {
                    frm_nuevo.rbtIda.Checked = true;
                }

                frm_nuevo.txtObservaciones.Text = tablaOrdenes.CurrentRow.Cells[10].Value.ToString(); //OBSERVACIONES
                //frm_nuevo.ckbActivo.Checked = Convert.ToBoolean(tablaOrdenes.CurrentRow.Cells[11].Value.ToString()); //ESTADO

                frm_nuevo.CalcularTotales();
                frm_nuevo.ShowDialog();
                ListarOrdenes();
            }
            else
            {
                MessageBox.Show("Seleccione una fila");
            }
        }

        private void btnBuscarLimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                int ordenID = Convert.ToInt32(txtBusqueda.Text);
                tablaOrdenes.DataSource = logOrden.Instancia.BusquedaOrdenID(ordenID);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al buscar la orden: " + ex.Message, "Error de búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBusqueda.Text = "";
            ListarOrdenes();
            txtBusqueda.Focus();
        }
    }
}
