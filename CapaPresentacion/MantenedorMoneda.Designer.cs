namespace CapaPresentacion
{
    partial class MantenedorMoneda
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.grbDatos = new System.Windows.Forms.GroupBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSimbolo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dtpFechaRegistro = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCodigoISO = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ckbActivo = new System.Windows.Forms.CheckBox();
            this.txtMonedaID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.gbListaCondiciones = new System.Windows.Forms.GroupBox();
            this.txtBuscador = new System.Windows.Forms.TextBox();
            this.btnDesactivar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tablaMonedas = new System.Windows.Forms.DataGridView();
            this.cmbBuscarCliente = new System.Windows.Forms.ComboBox();
            this.btnInformacion = new System.Windows.Forms.Button();
            this.grbDatos.SuspendLayout();
            this.gbListaCondiciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaMonedas)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1044, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 29);
            this.button1.TabIndex = 20;
            this.button1.Text = "Cerrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(938, 43);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(100, 29);
            this.btnEditar.TabIndex = 19;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(832, 43);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(100, 29);
            this.btnNuevo.TabIndex = 17;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // grbDatos
            // 
            this.grbDatos.Controls.Add(this.btnGuardar);
            this.grbDatos.Controls.Add(this.txtPais);
            this.grbDatos.Controls.Add(this.label8);
            this.grbDatos.Controls.Add(this.txtSimbolo);
            this.grbDatos.Controls.Add(this.label7);
            this.grbDatos.Controls.Add(this.txtNombre);
            this.grbDatos.Controls.Add(this.label2);
            this.grbDatos.Controls.Add(this.label14);
            this.grbDatos.Controls.Add(this.dtpFechaRegistro);
            this.grbDatos.Controls.Add(this.label6);
            this.grbDatos.Controls.Add(this.label5);
            this.grbDatos.Controls.Add(this.txtCodigoISO);
            this.grbDatos.Controls.Add(this.label3);
            this.grbDatos.Controls.Add(this.ckbActivo);
            this.grbDatos.Controls.Add(this.txtMonedaID);
            this.grbDatos.Controls.Add(this.label1);
            this.grbDatos.Location = new System.Drawing.Point(499, 79);
            this.grbDatos.Name = "grbDatos";
            this.grbDatos.Size = new System.Drawing.Size(673, 537);
            this.grbDatos.TabIndex = 18;
            this.grbDatos.TabStop = false;
            this.grbDatos.Text = "Datos de Moneda";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(545, 343);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(103, 75);
            this.btnGuardar.TabIndex = 66;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtPais
            // 
            this.txtPais.Location = new System.Drawing.Point(134, 368);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(210, 27);
            this.txtPais.TabIndex = 65;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(46, 371);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 19);
            this.label8.TabIndex = 64;
            this.label8.Text = "Pais:";
            // 
            // txtSimbolo
            // 
            this.txtSimbolo.Location = new System.Drawing.Point(134, 313);
            this.txtSimbolo.Name = "txtSimbolo";
            this.txtSimbolo.Size = new System.Drawing.Size(210, 27);
            this.txtSimbolo.TabIndex = 63;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(46, 316);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 19);
            this.label7.TabIndex = 62;
            this.label7.Text = "Simbolo:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(134, 258);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(210, 27);
            this.txtNombre.TabIndex = 61;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 19);
            this.label2.TabIndex = 60;
            this.label2.Text = "Nombre:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(111, 154);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(18, 19);
            this.label14.TabIndex = 59;
            this.label14.Text = "*";
            // 
            // dtpFechaRegistro
            // 
            this.dtpFechaRegistro.Enabled = false;
            this.dtpFechaRegistro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaRegistro.Location = new System.Drawing.Point(134, 148);
            this.dtpFechaRegistro.Name = "dtpFechaRegistro";
            this.dtpFechaRegistro.Size = new System.Drawing.Size(105, 27);
            this.dtpFechaRegistro.TabIndex = 58;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 19);
            this.label6.TabIndex = 57;
            this.label6.Text = "Fecha :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(434, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 19);
            this.label5.TabIndex = 34;
            this.label5.Text = "Estado:";
            // 
            // txtCodigoISO
            // 
            this.txtCodigoISO.Location = new System.Drawing.Point(134, 203);
            this.txtCodigoISO.Name = "txtCodigoISO";
            this.txtCodigoISO.Size = new System.Drawing.Size(210, 27);
            this.txtCodigoISO.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 19);
            this.label3.TabIndex = 32;
            this.label3.Text = "CodigoISO:";
            // 
            // ckbActivo
            // 
            this.ckbActivo.AutoSize = true;
            this.ckbActivo.Location = new System.Drawing.Point(519, 99);
            this.ckbActivo.Name = "ckbActivo";
            this.ckbActivo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ckbActivo.Size = new System.Drawing.Size(72, 23);
            this.ckbActivo.TabIndex = 29;
            this.ckbActivo.Text = "Activo";
            this.ckbActivo.UseVisualStyleBackColor = true;
            // 
            // txtMonedaID
            // 
            this.txtMonedaID.Enabled = false;
            this.txtMonedaID.Location = new System.Drawing.Point(134, 93);
            this.txtMonedaID.Name = "txtMonedaID";
            this.txtMonedaID.ReadOnly = true;
            this.txtMonedaID.Size = new System.Drawing.Size(210, 27);
            this.txtMonedaID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo:";
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(1056, 622);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(100, 29);
            this.btnRegresar.TabIndex = 9;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // gbListaCondiciones
            // 
            this.gbListaCondiciones.Controls.Add(this.txtBuscador);
            this.gbListaCondiciones.Controls.Add(this.btnDesactivar);
            this.gbListaCondiciones.Controls.Add(this.btnLimpiar);
            this.gbListaCondiciones.Controls.Add(this.btnBuscar);
            this.gbListaCondiciones.Controls.Add(this.label4);
            this.gbListaCondiciones.Controls.Add(this.tablaMonedas);
            this.gbListaCondiciones.Controls.Add(this.cmbBuscarCliente);
            this.gbListaCondiciones.Location = new System.Drawing.Point(28, 79);
            this.gbListaCondiciones.Name = "gbListaCondiciones";
            this.gbListaCondiciones.Size = new System.Drawing.Size(453, 537);
            this.gbListaCondiciones.TabIndex = 16;
            this.gbListaCondiciones.TabStop = false;
            this.gbListaCondiciones.Text = "Lista de Monedas";
            // 
            // txtBuscador
            // 
            this.txtBuscador.Location = new System.Drawing.Point(95, 62);
            this.txtBuscador.Name = "txtBuscador";
            this.txtBuscador.Size = new System.Drawing.Size(177, 27);
            this.txtBuscador.TabIndex = 62;
            // 
            // btnDesactivar
            // 
            this.btnDesactivar.Location = new System.Drawing.Point(320, 489);
            this.btnDesactivar.Name = "btnDesactivar";
            this.btnDesactivar.Size = new System.Drawing.Size(100, 29);
            this.btnDesactivar.TabIndex = 37;
            this.btnDesactivar.Text = "Eliminar";
            this.btnDesactivar.UseVisualStyleBackColor = true;
            this.btnDesactivar.Click += new System.EventHandler(this.btnDesactivar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(352, 60);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(68, 29);
            this.btnLimpiar.TabIndex = 36;
            this.btnLimpiar.Text = "X";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(278, 60);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(68, 29);
            this.btnBuscar.TabIndex = 35;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 19);
            this.label4.TabIndex = 34;
            this.label4.Text = "Buscar:";
            // 
            // tablaMonedas
            // 
            this.tablaMonedas.AllowUserToAddRows = false;
            this.tablaMonedas.AllowUserToDeleteRows = false;
            this.tablaMonedas.AllowUserToResizeRows = false;
            this.tablaMonedas.BackgroundColor = System.Drawing.SystemColors.Window;
            this.tablaMonedas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tablaMonedas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaMonedas.Location = new System.Drawing.Point(10, 100);
            this.tablaMonedas.MultiSelect = false;
            this.tablaMonedas.Name = "tablaMonedas";
            this.tablaMonedas.ReadOnly = true;
            this.tablaMonedas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaMonedas.Size = new System.Drawing.Size(410, 383);
            this.tablaMonedas.TabIndex = 2;
            // 
            // cmbBuscarCliente
            // 
            this.cmbBuscarCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBuscarCliente.FormattingEnabled = true;
            this.cmbBuscarCliente.Items.AddRange(new object[] {
            "TODAS",
            "NOMBRE"});
            this.cmbBuscarCliente.Location = new System.Drawing.Point(10, 62);
            this.cmbBuscarCliente.Name = "cmbBuscarCliente";
            this.cmbBuscarCliente.Size = new System.Drawing.Size(79, 27);
            this.cmbBuscarCliente.TabIndex = 1;
            // 
            // btnInformacion
            // 
            this.btnInformacion.Location = new System.Drawing.Point(726, 44);
            this.btnInformacion.Name = "btnInformacion";
            this.btnInformacion.Size = new System.Drawing.Size(100, 29);
            this.btnInformacion.TabIndex = 21;
            this.btnInformacion.Text = "Mostrar";
            this.btnInformacion.UseVisualStyleBackColor = true;
            this.btnInformacion.Click += new System.EventHandler(this.btnInformacion_Click);
            // 
            // MantenedorMoneda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 658);
            this.Controls.Add(this.btnInformacion);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.grbDatos);
            this.Controls.Add(this.gbListaCondiciones);
            this.Controls.Add(this.btnRegresar);
            this.Font = new System.Drawing.Font("Tahoma", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MantenedorMoneda";
            this.Text = "Mantenimiento de Monedas";
            this.Load += new System.EventHandler(this.MantenedorMoneda_Load);
            this.grbDatos.ResumeLayout(false);
            this.grbDatos.PerformLayout();
            this.gbListaCondiciones.ResumeLayout(false);
            this.gbListaCondiciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaMonedas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.GroupBox grbDatos;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCodigoISO;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox ckbActivo;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.TextBox txtMonedaID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbListaCondiciones;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView tablaMonedas;
        private System.Windows.Forms.ComboBox cmbBuscarCliente;
        private System.Windows.Forms.DateTimePicker dtpFechaRegistro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSimbolo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnDesactivar;
        private System.Windows.Forms.Button btnInformacion;
        private System.Windows.Forms.TextBox txtBuscador;
    }
}