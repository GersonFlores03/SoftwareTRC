using CapaEntidad;
using CapaLogicaNegocio;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

using iTextSharp.text;
using System.IO;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System.Drawing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CapaPresentacion
{
    public partial class Guias : Form
    {

        public string operacion; //OPERACION
        public int ordenID;
        public Guias()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }
        private void Guias_Load(object sender, EventArgs e)
        {

          
            dataGridProducto.Columns.Add("nombre_producto", "Nombre Producto");
            dataGridProducto.Columns.Add("nombre_secundario", "Nombre Secundario");
            dataGridProducto.Columns.Add("peso", "Peso");
            dataGridProducto.Columns.Add("cantidad", "Cantidad");
            
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MantenedorVehiculo manVehiculo = new MantenedorVehiculo();
            manVehiculo.Show();
        }



      
        public void SetOrden(string placa)
        {
            textBoxRuta.Text = placa;
           
            textBoxRuta.Enabled = false;

            button3_Click(null, null);


        }


 
      


        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ManConductor manconductor = new ManConductor();
            manconductor.Show();
        }

        private void Nuevo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }

        private string Extraer(string input) 
        {
            
            var match = Regex.Match(input, @"\(([^)]+)\)");
            if (match.Success)
            {
                return match.Groups[1].Value;
            }
            else
            {
               
                return input;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            entOrden orden = new entOrden
            {
                numero_orden = textBoxOrden.Text.Trim().ToUpper()
            };


            entVehiculo vehiculo = new entVehiculo
            {
                Placa = Extraer(textBoxVehiculo.Text)
            };
            entRuta ruta = new entRuta
            {
                Nombre = textBoxRuta.Text.Trim().ToUpper()
            };


            entConductor conductor = new entConductor
            {
                nombre_conductor = textBoxConductor.Text.Trim().ToUpper()
            };


            entProducto producto = new entProducto
            {
                nombre_producto = textBoxProducto.Text.Trim().ToUpper(),
                nombre_secundario = textBoxSecundario.Text.Trim().ToUpper(),
                peso = decimal.Parse(textBoxPesoProducto.Text.Trim().ToUpper()),
                


            };


            // Creamos orden y asignamos valores
            entGuia guia = new entGuia
            {
                ordenID = orden,
                productorId = producto,
                pesoTotal = decimal.Parse(textBoxPeso.Text.Trim().ToUpper()),
                fecha_emision = dateTimePickerEmision.Value,
                fecha_llegada = dateTimePickerllegada.Value,
                observaciones = textBoxObservaciones.Text.Trim().ToUpper(),
                cantidad = int.Parse(textBoxcantidad.Text),
                rutaID = ruta,
                conductorID = conductor,
                vehiculoId = vehiculo


            };

            bool resultado = logGuia.Instancia.InsertarGuiaTransporte(guia);
            if (resultado)
            {
                MessageBox.Show("La guia se guardó exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                operacion = "";
                this.Close();
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Guia_Formulario_BusquedaOrden guiaForms = new Guia_Formulario_BusquedaOrden(this);
            //guiaForms.Show();


            if (string.IsNullOrWhiteSpace(textBoxOrden.Text))
            {
                textBoxOrden.BackColor = Color.Red;
                MessageBox.Show("Ingresa numero de Orden", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxOrden.Focus();
                return;
            }
            else
            {
                textBoxOrden.BackColor = Color.White;
            }
            try
            {
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la información del cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

            



            if (string.IsNullOrWhiteSpace(textBoxRuta.Text))
            {
                textBoxRuta.BackColor = Color.Red;
                MessageBox.Show("Ingresa el nombre de la ruta", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxRuta.Focus();
                return;
            }
            else
            {
                textBoxRuta.BackColor = Color.White;
            }
            string rutaNombre = textBoxRuta.Text;
            try
            {
                entRuta ruta = logRuta.Instancia.InformacionRutaPorNombre(rutaNombre);
                if (ruta != null)
                {
                    textBoxRuta.Text = $"{ruta.Nombre}";
                    textBoxRuta.Enabled = false;
                }
                else
                {
                    MessageBox.Show("No se encontró la información de la ruta.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la información de la ruta: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Guia_Formulario_BusquedaOrden formsData = new Guia_Formulario_BusquedaOrden(this);
            formsData.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            // Obtener los valores de los TextBox editado por mi xd
            string nombre = textBoxProducto.Text.Trim();
            string nombreSecundario = textBoxSecundario.Text.Trim();
            string peso = textBoxPesoProducto.Text.Trim();
            string cantidad = textBoxcantidad.Text.Trim();
         




            // Validar que los valores requeridos no estén vacíos editado por gerson
            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("Por favor, complete todos los campos correctamente.");
                return;
            }


            dataGridProducto.Rows.Add(
                nombre,
                nombreSecundario,
                peso,
                cantidad
            );


          
           
        }

        private void Cantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MantenedorProducto mantenedorProducto = new MantenedorProducto();
            mantenedorProducto.Show();
        }
    }

            }
        

