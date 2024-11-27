namespace CapaPresentacion
{
    partial class Orden_Formulario_BusquedaVehiculo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grbListaVehiculos = new System.Windows.Forms.GroupBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnDeshabilitar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.tablaVehiculos = new System.Windows.Forms.DataGridView();
            this.cmbBuscarCliente = new System.Windows.Forms.ComboBox();
            this.grbListaVehiculos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaVehiculos)).BeginInit();
            this.SuspendLayout();
            // 
            // grbListaVehiculos
            // 
            this.grbListaVehiculos.Controls.Add(this.btnLimpiar);
            this.grbListaVehiculos.Controls.Add(this.btnDeshabilitar);
            this.grbListaVehiculos.Controls.Add(this.btnBuscar);
            this.grbListaVehiculos.Controls.Add(this.txtBusqueda);
            this.grbListaVehiculos.Controls.Add(this.tablaVehiculos);
            this.grbListaVehiculos.Controls.Add(this.cmbBuscarCliente);
            this.grbListaVehiculos.Location = new System.Drawing.Point(12, 12);
            this.grbListaVehiculos.Name = "grbListaVehiculos";
            this.grbListaVehiculos.Size = new System.Drawing.Size(499, 597);
            this.grbListaVehiculos.TabIndex = 216;
            this.grbListaVehiculos.TabStop = false;
            this.grbListaVehiculos.Text = "Lista de Vehiculos";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(418, 27);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(68, 29);
            this.btnLimpiar.TabIndex = 16;
            this.btnLimpiar.Text = "X";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnDeshabilitar
            // 
            this.btnDeshabilitar.Location = new System.Drawing.Point(386, 666);
            this.btnDeshabilitar.Name = "btnDeshabilitar";
            this.btnDeshabilitar.Size = new System.Drawing.Size(100, 29);
            this.btnDeshabilitar.TabIndex = 15;
            this.btnDeshabilitar.Text = "Eliminar";
            this.btnDeshabilitar.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(344, 27);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(68, 29);
            this.btnBuscar.TabIndex = 14;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(136, 27);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(202, 27);
            this.txtBusqueda.TabIndex = 2;
            // 
            // tablaVehiculos
            // 
            this.tablaVehiculos.BackgroundColor = System.Drawing.SystemColors.Window;
            this.tablaVehiculos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tablaVehiculos.Location = new System.Drawing.Point(10, 60);
            this.tablaVehiculos.Name = "tablaVehiculos";
            this.tablaVehiculos.Size = new System.Drawing.Size(476, 511);
            this.tablaVehiculos.TabIndex = 2;
            this.tablaVehiculos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaVehiculos_CellClick);
            // 
            // cmbBuscarCliente
            // 
            this.cmbBuscarCliente.FormattingEnabled = true;
            this.cmbBuscarCliente.Location = new System.Drawing.Point(10, 26);
            this.cmbBuscarCliente.Name = "cmbBuscarCliente";
            this.cmbBuscarCliente.Size = new System.Drawing.Size(120, 27);
            this.cmbBuscarCliente.TabIndex = 1;
            this.cmbBuscarCliente.Text = "Buscar Placa";
            // 
            // Orden_Formulario_BusquedaVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 636);
            this.Controls.Add(this.grbListaVehiculos);
            this.Font = new System.Drawing.Font("Tahoma", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Orden_Formulario_BusquedaVehiculo";
            this.Text = "Orden_Formulario_BusquedaVehiculo";
            this.Load += new System.EventHandler(this.Orden_Formulario_BusquedaVehiculo_Load);
            this.grbListaVehiculos.ResumeLayout(false);
            this.grbListaVehiculos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaVehiculos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbListaVehiculos;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnDeshabilitar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.DataGridView tablaVehiculos;
        private System.Windows.Forms.ComboBox cmbBuscarCliente;
    }
}