namespace CapaPresentacion
{
    partial class MantenedorVehiculo
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
            this.grbListaVehiculos = new System.Windows.Forms.GroupBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnDeshabilitar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.tablaVehiculos = new System.Windows.Forms.DataGridView();
            this.cmbBuscarCliente = new System.Windows.Forms.ComboBox();
            this.grbDatosVehiculo = new System.Windows.Forms.GroupBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dtpAño = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbClase = new System.Windows.Forms.ComboBox();
            this.ckbActivo = new System.Windows.Forms.CheckBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtVehiculoID = new System.Windows.Forms.TextBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtAncho = new System.Windows.Forms.TextBox();
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLongitud = new System.Windows.Forms.TextBox();
            this.cmbColor = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCargaUtil = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtMotor = new System.Windows.Forms.TextBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.grbListaVehiculos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaVehiculos)).BeginInit();
            this.grbDatosVehiculo.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1126, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 29);
            this.button1.TabIndex = 218;
            this.button1.Text = "Cerrar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(1020, 47);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(100, 29);
            this.btnEditar.TabIndex = 217;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(914, 47);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(100, 29);
            this.btnNuevo.TabIndex = 216;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // grbListaVehiculos
            // 
            this.grbListaVehiculos.Controls.Add(this.btnLimpiar);
            this.grbListaVehiculos.Controls.Add(this.btnDeshabilitar);
            this.grbListaVehiculos.Controls.Add(this.btnBuscar);
            this.grbListaVehiculos.Controls.Add(this.txtBusqueda);
            this.grbListaVehiculos.Controls.Add(this.tablaVehiculos);
            this.grbListaVehiculos.Controls.Add(this.cmbBuscarCliente);
            this.grbListaVehiculos.Location = new System.Drawing.Point(12, 17);
            this.grbListaVehiculos.Name = "grbListaVehiculos";
            this.grbListaVehiculos.Size = new System.Drawing.Size(510, 702);
            this.grbListaVehiculos.TabIndex = 215;
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
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnDeshabilitar
            // 
            this.btnDeshabilitar.Location = new System.Drawing.Point(386, 666);
            this.btnDeshabilitar.Name = "btnDeshabilitar";
            this.btnDeshabilitar.Size = new System.Drawing.Size(100, 29);
            this.btnDeshabilitar.TabIndex = 15;
            this.btnDeshabilitar.Text = "Eliminar";
            this.btnDeshabilitar.UseVisualStyleBackColor = true;
            this.btnDeshabilitar.Click += new System.EventHandler(this.btnDeshabilitar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(344, 27);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(68, 29);
            this.btnBuscar.TabIndex = 14;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
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
            this.tablaVehiculos.AllowUserToAddRows = false;
            this.tablaVehiculos.AllowUserToDeleteRows = false;
            this.tablaVehiculos.AllowUserToResizeRows = false;
            this.tablaVehiculos.BackgroundColor = System.Drawing.SystemColors.Window;
            this.tablaVehiculos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tablaVehiculos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tablaVehiculos.Location = new System.Drawing.Point(10, 60);
            this.tablaVehiculos.MultiSelect = false;
            this.tablaVehiculos.Name = "tablaVehiculos";
            this.tablaVehiculos.ReadOnly = true;
            this.tablaVehiculos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaVehiculos.Size = new System.Drawing.Size(476, 604);
            this.tablaVehiculos.TabIndex = 2;
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
            // grbDatosVehiculo
            // 
            this.grbDatosVehiculo.Controls.Add(this.btnGuardar);
            this.grbDatosVehiculo.Controls.Add(this.dtpAño);
            this.grbDatosVehiculo.Controls.Add(this.label3);
            this.grbDatosVehiculo.Controls.Add(this.cmbClase);
            this.grbDatosVehiculo.Controls.Add(this.ckbActivo);
            this.grbDatosVehiculo.Controls.Add(this.label16);
            this.grbDatosVehiculo.Controls.Add(this.txtVehiculoID);
            this.grbDatosVehiculo.Controls.Add(this.txtAltura);
            this.grbDatosVehiculo.Controls.Add(this.label4);
            this.grbDatosVehiculo.Controls.Add(this.txtPlaca);
            this.grbDatosVehiculo.Controls.Add(this.label17);
            this.grbDatosVehiculo.Controls.Add(this.txtAncho);
            this.grbDatosVehiculo.Controls.Add(this.cmbMarca);
            this.grbDatosVehiculo.Controls.Add(this.label14);
            this.grbDatosVehiculo.Controls.Add(this.label22);
            this.grbDatosVehiculo.Controls.Add(this.label6);
            this.grbDatosVehiculo.Controls.Add(this.txtLongitud);
            this.grbDatosVehiculo.Controls.Add(this.cmbColor);
            this.grbDatosVehiculo.Controls.Add(this.label23);
            this.grbDatosVehiculo.Controls.Add(this.label5);
            this.grbDatosVehiculo.Controls.Add(this.txtCargaUtil);
            this.grbDatosVehiculo.Controls.Add(this.label15);
            this.grbDatosVehiculo.Controls.Add(this.txtSerie);
            this.grbDatosVehiculo.Controls.Add(this.label1);
            this.grbDatosVehiculo.Controls.Add(this.label11);
            this.grbDatosVehiculo.Controls.Add(this.txtMotor);
            this.grbDatosVehiculo.Location = new System.Drawing.Point(528, 82);
            this.grbDatosVehiculo.Name = "grbDatosVehiculo";
            this.grbDatosVehiculo.Size = new System.Drawing.Size(724, 599);
            this.grbDatosVehiculo.TabIndex = 214;
            this.grbDatosVehiculo.TabStop = false;
            this.grbDatosVehiculo.Text = "Datos de Vehiculo";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(569, 455);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(129, 63);
            this.btnGuardar.TabIndex = 222;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dtpAño
            // 
            this.dtpAño.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAño.Location = new System.Drawing.Point(125, 363);
            this.dtpAño.Name = "dtpAño";
            this.dtpAño.Size = new System.Drawing.Size(210, 27);
            this.dtpAño.TabIndex = 221;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 367);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 19);
            this.label3.TabIndex = 219;
            this.label3.Text = "Año Modelo:";
            // 
            // cmbClase
            // 
            this.cmbClase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClase.FormattingEnabled = true;
            this.cmbClase.Location = new System.Drawing.Point(125, 179);
            this.cmbClase.Name = "cmbClase";
            this.cmbClase.Size = new System.Drawing.Size(210, 27);
            this.cmbClase.TabIndex = 218;
            // 
            // ckbActivo
            // 
            this.ckbActivo.AutoSize = true;
            this.ckbActivo.Location = new System.Drawing.Point(358, 88);
            this.ckbActivo.Name = "ckbActivo";
            this.ckbActivo.Size = new System.Drawing.Size(72, 23);
            this.ckbActivo.TabIndex = 216;
            this.ckbActivo.Text = "Activo";
            this.ckbActivo.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(19, 45);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 19);
            this.label16.TabIndex = 210;
            this.label16.Text = "Codigo:";
            // 
            // txtVehiculoID
            // 
            this.txtVehiculoID.Location = new System.Drawing.Point(125, 41);
            this.txtVehiculoID.Name = "txtVehiculoID";
            this.txtVehiculoID.ReadOnly = true;
            this.txtVehiculoID.Size = new System.Drawing.Size(105, 27);
            this.txtVehiculoID.TabIndex = 211;
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(496, 177);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(105, 27);
            this.txtAltura.TabIndex = 209;
            this.txtAltura.Text = "00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 19);
            this.label4.TabIndex = 160;
            this.label4.Text = "Placa:";
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(125, 87);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(210, 27);
            this.txtPlaca.TabIndex = 161;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(17, 183);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(52, 19);
            this.label17.TabIndex = 164;
            this.label17.Text = "Clase:";
            // 
            // txtAncho
            // 
            this.txtAncho.Location = new System.Drawing.Point(496, 224);
            this.txtAncho.Name = "txtAncho";
            this.txtAncho.Size = new System.Drawing.Size(105, 27);
            this.txtAncho.TabIndex = 203;
            this.txtAncho.Text = "00";
            // 
            // cmbMarca
            // 
            this.cmbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Location = new System.Drawing.Point(125, 133);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(210, 27);
            this.cmbMarca.TabIndex = 170;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(358, 227);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(93, 19);
            this.label14.TabIndex = 201;
            this.label14.Text = "Ancho (Mt.)";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(358, 180);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(94, 19);
            this.label22.TabIndex = 200;
            this.label22.Text = "Altura (m.):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 19);
            this.label6.TabIndex = 167;
            this.label6.Text = "Color:";
            // 
            // txtLongitud
            // 
            this.txtLongitud.Location = new System.Drawing.Point(496, 128);
            this.txtLongitud.Name = "txtLongitud";
            this.txtLongitud.Size = new System.Drawing.Size(105, 27);
            this.txtLongitud.TabIndex = 199;
            // 
            // cmbColor
            // 
            this.cmbColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbColor.FormattingEnabled = true;
            this.cmbColor.Location = new System.Drawing.Point(125, 225);
            this.cmbColor.Name = "cmbColor";
            this.cmbColor.Size = new System.Drawing.Size(210, 27);
            this.cmbColor.TabIndex = 168;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(358, 131);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(113, 19);
            this.label23.TabIndex = 198;
            this.label23.Text = "Longitud (m.):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 19);
            this.label5.TabIndex = 169;
            this.label5.Text = "Marca:";
            // 
            // txtCargaUtil
            // 
            this.txtCargaUtil.Location = new System.Drawing.Point(496, 366);
            this.txtCargaUtil.Name = "txtCargaUtil";
            this.txtCargaUtil.Size = new System.Drawing.Size(105, 27);
            this.txtCargaUtil.TabIndex = 197;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(358, 369);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(116, 19);
            this.label15.TabIndex = 195;
            this.label15.Text = "Carga Util (KG)";
            // 
            // txtSerie
            // 
            this.txtSerie.Location = new System.Drawing.Point(125, 271);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(210, 27);
            this.txtSerie.TabIndex = 187;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 321);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 19);
            this.label1.TabIndex = 182;
            this.label1.Text = "N° Motor:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 275);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 19);
            this.label11.TabIndex = 186;
            this.label11.Text = "N° Serie:";
            // 
            // txtMotor
            // 
            this.txtMotor.Location = new System.Drawing.Point(125, 317);
            this.txtMotor.Name = "txtMotor";
            this.txtMotor.Size = new System.Drawing.Size(210, 27);
            this.txtMotor.TabIndex = 183;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(808, 47);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(100, 29);
            this.btnMostrar.TabIndex = 219;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(1126, 690);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(100, 29);
            this.btnRegresar.TabIndex = 220;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // MantenedorVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 757);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.grbListaVehiculos);
            this.Controls.Add(this.grbDatosVehiculo);
            this.Font = new System.Drawing.Font("Tahoma", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MantenedorVehiculo";
            this.Text = "ManVehiculos";
            this.Load += new System.EventHandler(this.ManVehiculo_Load);
            this.grbListaVehiculos.ResumeLayout(false);
            this.grbListaVehiculos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaVehiculos)).EndInit();
            this.grbDatosVehiculo.ResumeLayout(false);
            this.grbDatosVehiculo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.GroupBox grbListaVehiculos;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.DataGridView tablaVehiculos;
        private System.Windows.Forms.ComboBox cmbBuscarCliente;
        private System.Windows.Forms.GroupBox grbDatosVehiculo;
        private System.Windows.Forms.CheckBox ckbActivo;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtVehiculoID;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtAncho;
        private System.Windows.Forms.ComboBox cmbMarca;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtLongitud;
        private System.Windows.Forms.ComboBox cmbColor;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCargaUtil;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtMotor;
        private System.Windows.Forms.ComboBox cmbClase;
        private System.Windows.Forms.DateTimePicker dtpAño;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnDeshabilitar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnRegresar;
    }
}