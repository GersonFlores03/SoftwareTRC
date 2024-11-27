using CapaLogicaNegocio;
using System;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Orden_Formulario_BusquedaRuta : Form
    {
        private Orden_Formulario _ordenFormulario;
        public Orden_Formulario_BusquedaRuta(Orden_Formulario ordenFormulario)
        {
            InitializeComponent();
            _ordenFormulario = ordenFormulario;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void Orden_Formulario_BusquedaRuta_Load(object sender, EventArgs e)
        {
            ListarRutas();
        }
        public void ListarRutas()
        {
            tablaRutas.DataSource = logRuta.Instancia.ListarRutas();
        }

        private void tablaRutas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = tablaRutas.Rows[e.RowIndex];
                string rutaNombre = fila.Cells[2].Value.ToString(); // Obtener el valor de la columna en la posición 2 NOMBRE
                _ordenFormulario.SetRuta(rutaNombre); // Llamar al método para establecer el valor en el TextBox
                this.Close();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
