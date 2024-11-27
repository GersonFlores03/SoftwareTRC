using CapaLogicaNegocio;
using System;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Orden_Formulario_BusquedaVehiculo : Form
    {
        private Orden_Formulario _ordenFormulario;
        public Orden_Formulario_BusquedaVehiculo(Orden_Formulario ordenFormulario)
        {
            InitializeComponent();
            _ordenFormulario = ordenFormulario;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void Orden_Formulario_BusquedaVehiculo_Load(object sender, EventArgs e)
        {
            ListarVehiculos();
        }
        public void ListarVehiculos()
        {
            tablaVehiculos.DataSource = logVehiculo.Instancia.ListarVehiculos();
        }

        private void tablaVehiculos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = tablaVehiculos.Rows[e.RowIndex];
                string vehiculoPlaca = fila.Cells[1].Value.ToString(); // Obtener el valor de la columna en la posición
                _ordenFormulario.SetVehiculo(vehiculoPlaca); // Llamar al método para establecer el valor en el TextBox
                this.Close();
            }
        }
    }
}
