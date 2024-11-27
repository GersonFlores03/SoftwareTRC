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

namespace CapaPresentacion
{
    public partial class Guia_Formulario_BusquedaOrden : Form
    {

        private Guias _guia;
        public Guia_Formulario_BusquedaOrden(Guias guiasForms)
        {
            InitializeComponent();
            _guia = guiasForms;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;

        }

        public void ListarOrden()
        {
            tablaOrdenes.DataSource = logRuta.Instancia.ListarRutas();
        }


        private void Guia_Formulario_BusquedaOrden_Load(object sender, EventArgs e)
        {
            ListarOrden();


        }

        private void tablaOrdenes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = tablaOrdenes.Rows[e.RowIndex];
                string orden = fila.Cells[2].Value.ToString();
              
                // Obtener el valor de la columna en la posición
                _guia.SetOrden(orden); // Llamar al método para establecer el valor en el TextBox
                this.Close();
            }
        }
    }


}
