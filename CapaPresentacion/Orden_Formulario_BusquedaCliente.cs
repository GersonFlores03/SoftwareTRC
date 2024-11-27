using CapaLogicaNegocio;
using System;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Orden_Formulario_BusquedaCliente : Form
    {
        private Orden_Formulario _ordenFormulario;
        public Orden_Formulario_BusquedaCliente(Orden_Formulario orden_Formulario)
        {
            InitializeComponent();
            _ordenFormulario = orden_Formulario;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void OrdenNueva_BusquedaCliente_Load(object sender, EventArgs e)
        {
            ListarClientes();
            //dgvListaClientes.DataSource=logCliente.Instancia.ListarClientes();
        }
        private void ListarClientes()
        {
            tablaClientes.DataSource = logCliente.Instancia.ListarClientes();
        }

        private void tablaClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = tablaClientes.Rows[e.RowIndex];
                string ruta = fila.Cells[1].Value.ToString(); // Obtener el valor de la columna en la posición
                _ordenFormulario.SetCliente(ruta); // Llamar al método para establecer el valor en el TextBox
                this.Close();
            }
        }

        private void grbListaClientes_Enter(object sender, EventArgs e)
        {

        }

        private void tablaClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
