using System;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class ManProveedor : Form
    {
        public ManProveedor()
        {
            InitializeComponent();
            // Establece la posición inicial del formulario en el centro de la pantalla
            this.StartPosition = FormStartPosition.CenterScreen;

            // Desactiva la capacidad de maximizar el formulario
            this.MaximizeBox = false;

            // Establece el estilo del borde del formulario para que sea un cuadro de diálogo fijo
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void gbListaClientes_Enter(object sender, EventArgs e)
        {

        }

        private void gbDatos_Enter(object sender, EventArgs e)
        {

        }
    }
}
