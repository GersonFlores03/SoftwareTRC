namespace CapaPresentacion
{
    partial class MantenedorCondicion
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
            this.label14 = new System.Windows.Forms.Label();
            this.dtpFechaRegistro = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDias = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ckbActivo = new System.Windows.Forms.CheckBox();
            this.txtCondicion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCondicionID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.gbListaCondiciones = new System.Windows.Forms.GroupBox();
            this.btnDesactivar = new System.Windows.Forms.Button();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.tablaCondiciones = new System.Windows.Forms.DataGridView();
            this.cmbBuscarCliente = new System.Windows.Forms.ComboBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.grbDatos.SuspendLayout();
            this.gbListaCondiciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaCondiciones)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1028, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 29);
            this.button1.TabIndex = 15;
            this.button1.Text = "Cerrar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(922, 24);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(100, 29);
            this.btnEditar.TabIndex = 14;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(816, 24);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(100, 29);
            this.btnNuevo.TabIndex = 12;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // grbDatos
            // 
            this.grbDatos.Controls.Add(this.btnGuardar);
            this.grbDatos.Controls.Add(this.label14);
            this.grbDatos.Controls.Add(this.dtpFechaRegistro);
            this.grbDatos.Controls.Add(this.label6);
            this.grbDatos.Controls.Add(this.label5);
            this.grbDatos.Controls.Add(this.txtDias);
            this.grbDatos.Controls.Add(this.label3);
            this.grbDatos.Controls.Add(this.ckbActivo);
            this.grbDatos.Controls.Add(this.txtCondicion);
            this.grbDatos.Controls.Add(this.label2);
            this.grbDatos.Controls.Add(this.txtCondicionID);
            this.grbDatos.Controls.Add(this.label1);
            this.grbDatos.Location = new System.Drawing.Point(483, 60);
            this.grbDatos.Name = "grbDatos";
            this.grbDatos.Size = new System.Drawing.Size(673, 483);
            this.grbDatos.TabIndex = 13;
            this.grbDatos.TabStop = false;
            this.grbDatos.Text = "Datos de Condicion";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(541, 340);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(103, 75);
            this.btnGuardar.TabIndex = 60;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(93, 178);
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
            this.dtpFechaRegistro.Location = new System.Drawing.Point(136, 178);
            this.dtpFechaRegistro.Name = "dtpFechaRegistro";
            this.dtpFechaRegistro.Size = new System.Drawing.Size(105, 27);
            this.dtpFechaRegistro.TabIndex = 58;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 178);
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
            // txtDias
            // 
            this.txtDias.Location = new System.Drawing.Point(136, 301);
            this.txtDias.Name = "txtDias";
            this.txtDias.Size = new System.Drawing.Size(210, 27);
            this.txtDias.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 19);
            this.label3.TabIndex = 32;
            this.label3.Text = "Días:";
            // 
            // ckbActivo
            // 
            this.ckbActivo.AutoSize = true;
            this.ckbActivo.Location = new System.Drawing.Point(519, 100);
            this.ckbActivo.Name = "ckbActivo";
            this.ckbActivo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ckbActivo.Size = new System.Drawing.Size(72, 23);
            this.ckbActivo.TabIndex = 29;
            this.ckbActivo.Text = "Activo";
            this.ckbActivo.UseVisualStyleBackColor = true;
            // 
            // txtCondicion
            // 
            this.txtCondicion.Location = new System.Drawing.Point(136, 237);
            this.txtCondicion.Name = "txtCondicion";
            this.txtCondicion.Size = new System.Drawing.Size(508, 27);
            this.txtCondicion.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descripcion:";
            // 
            // txtCondicionID
            // 
            this.txtCondicionID.Enabled = false;
            this.txtCondicionID.Location = new System.Drawing.Point(136, 110);
            this.txtCondicionID.Name = "txtCondicionID";
            this.txtCondicionID.ReadOnly = true;
            this.txtCondicionID.Size = new System.Drawing.Size(210, 27);
            this.txtCondicionID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo:";
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(1028, 549);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(100, 29);
            this.btnRegresar.TabIndex = 9;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // gbListaCondiciones
            // 
            this.gbListaCondiciones.Controls.Add(this.btnDesactivar);
            this.gbListaCondiciones.Controls.Add(this.txtBusqueda);
            this.gbListaCondiciones.Controls.Add(this.btnLimpiar);
            this.gbListaCondiciones.Controls.Add(this.btnBuscar);
            this.gbListaCondiciones.Controls.Add(this.tablaCondiciones);
            this.gbListaCondiciones.Controls.Add(this.cmbBuscarCliente);
            this.gbListaCondiciones.Location = new System.Drawing.Point(12, 60);
            this.gbListaCondiciones.Name = "gbListaCondiciones";
            this.gbListaCondiciones.Size = new System.Drawing.Size(453, 537);
            this.gbListaCondiciones.TabIndex = 11;
            this.gbListaCondiciones.TabStop = false;
            this.gbListaCondiciones.Text = "Lista de Condiciones de Pago";
            // 
            // btnDesactivar
            // 
            this.btnDesactivar.Location = new System.Drawing.Point(320, 489);
            this.btnDesactivar.Name = "btnDesactivar";
            this.btnDesactivar.Size = new System.Drawing.Size(100, 29);
            this.btnDesactivar.TabIndex = 38;
            this.btnDesactivar.Text = "Eliminar";
            this.btnDesactivar.UseVisualStyleBackColor = true;
            this.btnDesactivar.Click += new System.EventHandler(this.btnDesactivar_Click);
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(113, 56);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(159, 27);
            this.txtBusqueda.TabIndex = 37;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(352, 56);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(68, 29);
            this.btnLimpiar.TabIndex = 36;
            this.btnLimpiar.Text = "X";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(278, 56);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(68, 29);
            this.btnBuscar.TabIndex = 35;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // tablaCondiciones
            // 
            this.tablaCondiciones.AllowUserToAddRows = false;
            this.tablaCondiciones.AllowUserToDeleteRows = false;
            this.tablaCondiciones.AllowUserToResizeRows = false;
            this.tablaCondiciones.BackgroundColor = System.Drawing.SystemColors.Window;
            this.tablaCondiciones.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tablaCondiciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaCondiciones.Location = new System.Drawing.Point(10, 100);
            this.tablaCondiciones.MultiSelect = false;
            this.tablaCondiciones.Name = "tablaCondiciones";
            this.tablaCondiciones.ReadOnly = true;
            this.tablaCondiciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaCondiciones.Size = new System.Drawing.Size(410, 383);
            this.tablaCondiciones.TabIndex = 2;
            // 
            // cmbBuscarCliente
            // 
            this.cmbBuscarCliente.FormattingEnabled = true;
            this.cmbBuscarCliente.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cmbBuscarCliente.Location = new System.Drawing.Point(10, 56);
            this.cmbBuscarCliente.Name = "cmbBuscarCliente";
            this.cmbBuscarCliente.Size = new System.Drawing.Size(105, 27);
            this.cmbBuscarCliente.TabIndex = 1;
            this.cmbBuscarCliente.Text = "(Todas)";
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(710, 24);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(100, 29);
            this.btnMostrar.TabIndex = 16;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // MantenedorCondicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 621);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.grbDatos);
            this.Controls.Add(this.gbListaCondiciones);
            this.Controls.Add(this.btnRegresar);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MantenedorCondicion";
            this.Text = "Mantenedor de Condiciones Pago";
            this.Load += new System.EventHandler(this.MantenedorCondicionesPago_Load);
            this.grbDatos.ResumeLayout(false);
            this.grbDatos.PerformLayout();
            this.gbListaCondiciones.ResumeLayout(false);
            this.gbListaCondiciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaCondiciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.GroupBox grbDatos;
        private System.Windows.Forms.CheckBox ckbActivo;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.TextBox txtCondicion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCondicionID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbListaCondiciones;
        private System.Windows.Forms.DataGridView tablaCondiciones;
        private System.Windows.Forms.ComboBox cmbBuscarCliente;
        private System.Windows.Forms.TextBox txtDias;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dtpFechaRegistro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Button btnDesactivar;
    }
}