namespace CapaPresentacion
{
    partial class MantenedorUnidad
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
            this.btnMostrar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.grbDatos = new System.Windows.Forms.GroupBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtUnidad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCondicionID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbListaCondiciones = new System.Windows.Forms.GroupBox();
            this.btnDesactivar = new System.Windows.Forms.Button();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.tablaCondiciones = new System.Windows.Forms.DataGridView();
            this.cmbBuscarCliente = new System.Windows.Forms.ComboBox();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.grbDatos.SuspendLayout();
            this.gbListaCondiciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaCondiciones)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(725, 7);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(100, 29);
            this.btnMostrar.TabIndex = 23;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1043, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 29);
            this.button1.TabIndex = 22;
            this.button1.Text = "Cerrar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(937, 7);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(100, 29);
            this.btnEditar.TabIndex = 21;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(831, 7);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(100, 29);
            this.btnNuevo.TabIndex = 19;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // grbDatos
            // 
            this.grbDatos.Controls.Add(this.btnGuardar);
            this.grbDatos.Controls.Add(this.txtUnidad);
            this.grbDatos.Controls.Add(this.label2);
            this.grbDatos.Controls.Add(this.txtCondicionID);
            this.grbDatos.Controls.Add(this.label1);
            this.grbDatos.Location = new System.Drawing.Point(498, 43);
            this.grbDatos.Name = "grbDatos";
            this.grbDatos.Size = new System.Drawing.Size(673, 483);
            this.grbDatos.TabIndex = 20;
            this.grbDatos.TabStop = false;
            this.grbDatos.Text = "Datos de Condicion";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(545, 335);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(103, 75);
            this.btnGuardar.TabIndex = 60;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtUnidad
            // 
            this.txtUnidad.Location = new System.Drawing.Point(136, 180);
            this.txtUnidad.Name = "txtUnidad";
            this.txtUnidad.Size = new System.Drawing.Size(508, 22);
            this.txtUnidad.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre Unidad:";
            // 
            // txtCondicionID
            // 
            this.txtCondicionID.Enabled = false;
            this.txtCondicionID.Location = new System.Drawing.Point(136, 110);
            this.txtCondicionID.Name = "txtCondicionID";
            this.txtCondicionID.ReadOnly = true;
            this.txtCondicionID.Size = new System.Drawing.Size(210, 22);
            this.txtCondicionID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo:";
            // 
            // gbListaCondiciones
            // 
            this.gbListaCondiciones.Controls.Add(this.btnDesactivar);
            this.gbListaCondiciones.Controls.Add(this.txtBusqueda);
            this.gbListaCondiciones.Controls.Add(this.btnLimpiar);
            this.gbListaCondiciones.Controls.Add(this.btnBuscar);
            this.gbListaCondiciones.Controls.Add(this.tablaCondiciones);
            this.gbListaCondiciones.Controls.Add(this.cmbBuscarCliente);
            this.gbListaCondiciones.Location = new System.Drawing.Point(27, 43);
            this.gbListaCondiciones.Name = "gbListaCondiciones";
            this.gbListaCondiciones.Size = new System.Drawing.Size(453, 537);
            this.gbListaCondiciones.TabIndex = 18;
            this.gbListaCondiciones.TabStop = false;
            this.gbListaCondiciones.Text = "Lista de Unidades Medida";
            // 
            // btnDesactivar
            // 
            this.btnDesactivar.Location = new System.Drawing.Point(320, 489);
            this.btnDesactivar.Name = "btnDesactivar";
            this.btnDesactivar.Size = new System.Drawing.Size(100, 29);
            this.btnDesactivar.TabIndex = 38;
            this.btnDesactivar.Text = "Eliminar";
            this.btnDesactivar.UseVisualStyleBackColor = true;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(113, 56);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(159, 22);
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
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(278, 56);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(68, 29);
            this.btnBuscar.TabIndex = 35;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
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
            this.tablaCondiciones.RowHeadersWidth = 51;
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
            this.cmbBuscarCliente.Size = new System.Drawing.Size(105, 24);
            this.cmbBuscarCliente.TabIndex = 1;
            this.cmbBuscarCliente.Text = "(Todas)";
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(1043, 532);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(100, 29);
            this.btnRegresar.TabIndex = 17;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            // 
            // MantenedorUnidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 587);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.grbDatos);
            this.Controls.Add(this.gbListaCondiciones);
            this.Controls.Add(this.btnRegresar);
            this.Name = "MantenedorUnidad";
            this.Text = "MantenedorUnidad";
            this.grbDatos.ResumeLayout(false);
            this.grbDatos.PerformLayout();
            this.gbListaCondiciones.ResumeLayout(false);
            this.gbListaCondiciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaCondiciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.GroupBox grbDatos;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtUnidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCondicionID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbListaCondiciones;
        private System.Windows.Forms.Button btnDesactivar;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView tablaCondiciones;
        private System.Windows.Forms.ComboBox cmbBuscarCliente;
        private System.Windows.Forms.Button btnRegresar;
    }
}