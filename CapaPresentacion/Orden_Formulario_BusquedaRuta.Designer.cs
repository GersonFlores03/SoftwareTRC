namespace CapaPresentacion
{
    partial class Orden_Formulario_BusquedaRuta
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLimpiarFiltro = new System.Windows.Forms.Button();
            this.txtBuscador = new System.Windows.Forms.TextBox();
            this.btnBuscarRuta = new System.Windows.Forms.Button();
            this.cmbBuscarCliente = new System.Windows.Forms.ComboBox();
            this.tablaRutas = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaRutas)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLimpiarFiltro);
            this.groupBox1.Controls.Add(this.txtBuscador);
            this.groupBox1.Controls.Add(this.btnBuscarRuta);
            this.groupBox1.Controls.Add(this.cmbBuscarCliente);
            this.groupBox1.Controls.Add(this.tablaRutas);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(469, 584);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista de Rutas Verificadas";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnLimpiarFiltro
            // 
            this.btnLimpiarFiltro.Location = new System.Drawing.Point(377, 68);
            this.btnLimpiarFiltro.Name = "btnLimpiarFiltro";
            this.btnLimpiarFiltro.Size = new System.Drawing.Size(64, 29);
            this.btnLimpiarFiltro.TabIndex = 39;
            this.btnLimpiarFiltro.Text = "X";
            this.btnLimpiarFiltro.UseVisualStyleBackColor = true;
            // 
            // txtBuscador
            // 
            this.txtBuscador.Location = new System.Drawing.Point(118, 69);
            this.txtBuscador.Name = "txtBuscador";
            this.txtBuscador.Size = new System.Drawing.Size(183, 32);
            this.txtBuscador.TabIndex = 16;
            // 
            // btnBuscarRuta
            // 
            this.btnBuscarRuta.Location = new System.Drawing.Point(307, 67);
            this.btnBuscarRuta.Name = "btnBuscarRuta";
            this.btnBuscarRuta.Size = new System.Drawing.Size(64, 29);
            this.btnBuscarRuta.TabIndex = 14;
            this.btnBuscarRuta.Text = "Buscar";
            this.btnBuscarRuta.UseVisualStyleBackColor = true;
            // 
            // cmbBuscarCliente
            // 
            this.cmbBuscarCliente.FormattingEnabled = true;
            this.cmbBuscarCliente.Location = new System.Drawing.Point(7, 70);
            this.cmbBuscarCliente.Name = "cmbBuscarCliente";
            this.cmbBuscarCliente.Size = new System.Drawing.Size(105, 32);
            this.cmbBuscarCliente.TabIndex = 15;
            this.cmbBuscarCliente.Text = "Codigo:";
            // 
            // tablaRutas
            // 
            this.tablaRutas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaRutas.Location = new System.Drawing.Point(6, 106);
            this.tablaRutas.Name = "tablaRutas";
            this.tablaRutas.RowHeadersWidth = 51;
            this.tablaRutas.Size = new System.Drawing.Size(436, 454);
            this.tablaRutas.TabIndex = 12;
            this.tablaRutas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaRutas_CellClick);
            // 
            // Orden_Formulario_BusquedaRuta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 627);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Orden_Formulario_BusquedaRuta";
            this.Text = "Orden_Formulario_BusquedaRuta";
            this.Load += new System.EventHandler(this.Orden_Formulario_BusquedaRuta_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaRutas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLimpiarFiltro;
        private System.Windows.Forms.TextBox txtBuscador;
        private System.Windows.Forms.Button btnBuscarRuta;
        private System.Windows.Forms.ComboBox cmbBuscarCliente;
        private System.Windows.Forms.DataGridView tablaRutas;
    }
}