namespace CapaPresentacion
{
    partial class MantenedorRuta
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
            this.grbDatosRuta = new System.Windows.Forms.GroupBox();
            this.Guardar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbDestino = new System.Windows.Forms.ComboBox();
            this.cmbOrigen = new System.Windows.Forms.ComboBox();
            this.txtDistancia = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFechaRegistro = new System.Windows.Forms.DateTimePicker();
            this.ckbActivo = new System.Windows.Forms.CheckBox();
            this.btnLlenarRuta = new System.Windows.Forms.Button();
            this.txtRutaID = new System.Windows.Forms.TextBox();
            this.txtRuta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tablaRutas = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLimpiarFiltro = new System.Windows.Forms.Button();
            this.btnEliminarFila = new System.Windows.Forms.Button();
            this.txtBuscador = new System.Windows.Forms.TextBox();
            this.btnBuscarRuta = new System.Windows.Forms.Button();
            this.cmbBuscarCliente = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.grbDatosRuta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaRutas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbDatosRuta
            // 
            this.grbDatosRuta.Controls.Add(this.Guardar);
            this.grbDatosRuta.Controls.Add(this.label9);
            this.grbDatosRuta.Controls.Add(this.cmbDestino);
            this.grbDatosRuta.Controls.Add(this.cmbOrigen);
            this.grbDatosRuta.Controls.Add(this.txtDistancia);
            this.grbDatosRuta.Controls.Add(this.label6);
            this.grbDatosRuta.Controls.Add(this.label5);
            this.grbDatosRuta.Controls.Add(this.label1);
            this.grbDatosRuta.Controls.Add(this.dtpFechaRegistro);
            this.grbDatosRuta.Controls.Add(this.ckbActivo);
            this.grbDatosRuta.Controls.Add(this.btnLlenarRuta);
            this.grbDatosRuta.Controls.Add(this.txtRutaID);
            this.grbDatosRuta.Controls.Add(this.txtRuta);
            this.grbDatosRuta.Controls.Add(this.label4);
            this.grbDatosRuta.Controls.Add(this.label3);
            this.grbDatosRuta.Controls.Add(this.label2);
            this.grbDatosRuta.Location = new System.Drawing.Point(496, 114);
            this.grbDatosRuta.Name = "grbDatosRuta";
            this.grbDatosRuta.Size = new System.Drawing.Size(677, 458);
            this.grbDatosRuta.TabIndex = 13;
            this.grbDatosRuta.TabStop = false;
            this.grbDatosRuta.Text = "Datos de Ruta";
            // 
            // Guardar
            // 
            this.Guardar.Location = new System.Drawing.Point(549, 362);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(100, 71);
            this.Guardar.TabIndex = 57;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = true;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(478, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 24);
            this.label9.TabIndex = 54;
            this.label9.Text = "Estado:";
            // 
            // cmbDestino
            // 
            this.cmbDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDestino.FormattingEnabled = true;
            this.cmbDestino.Location = new System.Drawing.Point(169, 200);
            this.cmbDestino.Name = "cmbDestino";
            this.cmbDestino.Size = new System.Drawing.Size(210, 32);
            this.cmbDestino.TabIndex = 49;
            // 
            // cmbOrigen
            // 
            this.cmbOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrigen.FormattingEnabled = true;
            this.cmbOrigen.Location = new System.Drawing.Point(169, 132);
            this.cmbOrigen.Name = "cmbOrigen";
            this.cmbOrigen.Size = new System.Drawing.Size(210, 32);
            this.cmbOrigen.TabIndex = 48;
            this.cmbOrigen.SelectedIndexChanged += new System.EventHandler(this.cmbOrigen_SelectedIndexChanged);
            // 
            // txtDistancia
            // 
            this.txtDistancia.Location = new System.Drawing.Point(169, 321);
            this.txtDistancia.Name = "txtDistancia";
            this.txtDistancia.Size = new System.Drawing.Size(105, 32);
            this.txtDistancia.TabIndex = 45;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 329);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 24);
            this.label6.TabIndex = 44;
            this.label6.Text = "Distancia (KM):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 24);
            this.label5.TabIndex = 42;
            this.label5.Text = "Dpto. Destino:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 24);
            this.label1.TabIndex = 40;
            this.label1.Text = "Dpto. Origen:";
            // 
            // dtpFechaRegistro
            // 
            this.dtpFechaRegistro.Enabled = false;
            this.dtpFechaRegistro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaRegistro.Location = new System.Drawing.Point(169, 82);
            this.dtpFechaRegistro.Name = "dtpFechaRegistro";
            this.dtpFechaRegistro.Size = new System.Drawing.Size(105, 32);
            this.dtpFechaRegistro.TabIndex = 39;
            // 
            // ckbActivo
            // 
            this.ckbActivo.AutoSize = true;
            this.ckbActivo.Location = new System.Drawing.Point(568, 32);
            this.ckbActivo.Name = "ckbActivo";
            this.ckbActivo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ckbActivo.Size = new System.Drawing.Size(86, 28);
            this.ckbActivo.TabIndex = 38;
            this.ckbActivo.Text = "Activo";
            this.ckbActivo.UseVisualStyleBackColor = true;
            // 
            // btnLlenarRuta
            // 
            this.btnLlenarRuta.Location = new System.Drawing.Point(549, 265);
            this.btnLlenarRuta.Name = "btnLlenarRuta";
            this.btnLlenarRuta.Size = new System.Drawing.Size(100, 30);
            this.btnLlenarRuta.TabIndex = 7;
            this.btnLlenarRuta.Text = "Llenar";
            this.btnLlenarRuta.UseVisualStyleBackColor = true;
            this.btnLlenarRuta.Click += new System.EventHandler(this.btnLlenarRuta_Click);
            // 
            // txtRutaID
            // 
            this.txtRutaID.Location = new System.Drawing.Point(169, 33);
            this.txtRutaID.Name = "txtRutaID";
            this.txtRutaID.ReadOnly = true;
            this.txtRutaID.Size = new System.Drawing.Size(105, 32);
            this.txtRutaID.TabIndex = 7;
            // 
            // txtRuta
            // 
            this.txtRuta.Location = new System.Drawing.Point(169, 265);
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.ReadOnly = true;
            this.txtRuta.Size = new System.Drawing.Size(370, 32);
            this.txtRuta.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ruta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Código:";
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(1073, 578);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(100, 29);
            this.btnRegresar.TabIndex = 33;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // textBox8
            // 
            this.textBox8.Enabled = false;
            this.textBox8.Location = new System.Drawing.Point(120, 566);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(144, 32);
            this.textBox8.TabIndex = 13;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(4, 569);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(136, 24);
            this.label13.TabIndex = 12;
            this.label13.Text = "Total Tramos:";
            // 
            // tablaRutas
            // 
            this.tablaRutas.AllowUserToAddRows = false;
            this.tablaRutas.AllowUserToDeleteRows = false;
            this.tablaRutas.AllowUserToResizeRows = false;
            this.tablaRutas.BackgroundColor = System.Drawing.Color.White;
            this.tablaRutas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tablaRutas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaRutas.Location = new System.Drawing.Point(6, 106);
            this.tablaRutas.MultiSelect = false;
            this.tablaRutas.Name = "tablaRutas";
            this.tablaRutas.ReadOnly = true;
            this.tablaRutas.RowHeadersWidth = 51;
            this.tablaRutas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaRutas.Size = new System.Drawing.Size(436, 454);
            this.tablaRutas.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLimpiarFiltro);
            this.groupBox1.Controls.Add(this.btnEliminarFila);
            this.groupBox1.Controls.Add(this.txtBuscador);
            this.groupBox1.Controls.Add(this.btnBuscarRuta);
            this.groupBox1.Controls.Add(this.cmbBuscarCliente);
            this.groupBox1.Controls.Add(this.tablaRutas);
            this.groupBox1.Controls.Add(this.textBox8);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(469, 634);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista de Rutas Verificadas";
            // 
            // btnLimpiarFiltro
            // 
            this.btnLimpiarFiltro.Location = new System.Drawing.Point(377, 68);
            this.btnLimpiarFiltro.Name = "btnLimpiarFiltro";
            this.btnLimpiarFiltro.Size = new System.Drawing.Size(64, 29);
            this.btnLimpiarFiltro.TabIndex = 39;
            this.btnLimpiarFiltro.Text = "X";
            this.btnLimpiarFiltro.UseVisualStyleBackColor = true;
            this.btnLimpiarFiltro.Click += new System.EventHandler(this.btnLimpiarFiltro_Click);
            // 
            // btnEliminarFila
            // 
            this.btnEliminarFila.Location = new System.Drawing.Point(342, 569);
            this.btnEliminarFila.Name = "btnEliminarFila";
            this.btnEliminarFila.Size = new System.Drawing.Size(100, 29);
            this.btnEliminarFila.TabIndex = 38;
            this.btnEliminarFila.Text = "Eliminar";
            this.btnEliminarFila.UseVisualStyleBackColor = true;
            this.btnEliminarFila.Click += new System.EventHandler(this.btnEliminarFila_Click);
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
            this.btnBuscarRuta.Click += new System.EventHandler(this.btnBuscarRuta_Click);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1045, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 29);
            this.button1.TabIndex = 36;
            this.button1.Text = "Cerrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(939, 79);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(100, 29);
            this.btnEditar.TabIndex = 35;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(833, 79);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(100, 29);
            this.btnNuevo.TabIndex = 34;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(727, 79);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(100, 29);
            this.btnMostrar.TabIndex = 37;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // MantenedorRuta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 658);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grbDatosRuta);
            this.Controls.Add(this.btnRegresar);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MantenedorRuta";
            this.Text = "Mantenimiento de Rutas";
            this.Load += new System.EventHandler(this.MantenedorRuta_Load);
            this.grbDatosRuta.ResumeLayout(false);
            this.grbDatosRuta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaRutas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDatosRuta;
        private System.Windows.Forms.Button btnLlenarRuta;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtRutaID;
        private System.Windows.Forms.TextBox txtRuta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView tablaRutas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.TextBox txtBuscador;
        private System.Windows.Forms.Button btnBuscarRuta;
        private System.Windows.Forms.ComboBox cmbBuscarCliente;
        private System.Windows.Forms.CheckBox ckbActivo;
        private System.Windows.Forms.TextBox txtDistancia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbDestino;
        private System.Windows.Forms.ComboBox cmbOrigen;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpFechaRegistro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.Button btnLimpiarFiltro;
        private System.Windows.Forms.Button btnEliminarFila;
        private System.Windows.Forms.Button btnMostrar;
    }
}