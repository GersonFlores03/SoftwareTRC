namespace CapaPresentacion
{
    partial class Guia_Formulario_BusquedaOrden
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
            this.grbListaClientes = new System.Windows.Forms.GroupBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.tablaOrdenes = new System.Windows.Forms.DataGridView();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cmbBuscarCliente = new System.Windows.Forms.ComboBox();
            this.grbListaClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaOrdenes)).BeginInit();
            this.SuspendLayout();
            // 
            // grbListaClientes
            // 
            this.grbListaClientes.Controls.Add(this.btnLimpiar);
            this.grbListaClientes.Controls.Add(this.tablaOrdenes);
            this.grbListaClientes.Controls.Add(this.txtBusqueda);
            this.grbListaClientes.Controls.Add(this.btnBuscar);
            this.grbListaClientes.Controls.Add(this.cmbBuscarCliente);
            this.grbListaClientes.Location = new System.Drawing.Point(34, 32);
            this.grbListaClientes.Name = "grbListaClientes";
            this.grbListaClientes.Size = new System.Drawing.Size(566, 286);
            this.grbListaClientes.TabIndex = 8;
            this.grbListaClientes.TabStop = false;
            this.grbListaClientes.Text = "Lista Ordenes";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(411, 66);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(68, 29);
            this.btnLimpiar.TabIndex = 13;
            this.btnLimpiar.Text = "X";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // tablaOrdenes
            // 
            this.tablaOrdenes.AllowUserToAddRows = false;
            this.tablaOrdenes.AllowUserToDeleteRows = false;
            this.tablaOrdenes.AllowUserToResizeColumns = false;
            this.tablaOrdenes.AllowUserToResizeRows = false;
            this.tablaOrdenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaOrdenes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tablaOrdenes.Location = new System.Drawing.Point(10, 112);
            this.tablaOrdenes.MultiSelect = false;
            this.tablaOrdenes.Name = "tablaOrdenes";
            this.tablaOrdenes.ReadOnly = true;
            this.tablaOrdenes.RowHeadersWidth = 51;
            this.tablaOrdenes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaOrdenes.Size = new System.Drawing.Size(476, 136);
            this.tablaOrdenes.TabIndex = 3;
           // this.tablaOrdenes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaOrdenes_CellContentClick);
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(121, 67);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(210, 22);
            this.txtBusqueda.TabIndex = 2;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(337, 66);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(68, 29);
            this.btnBuscar.TabIndex = 0;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // cmbBuscarCliente
            // 
            this.cmbBuscarCliente.FormattingEnabled = true;
            this.cmbBuscarCliente.Location = new System.Drawing.Point(10, 67);
            this.cmbBuscarCliente.Name = "cmbBuscarCliente";
            this.cmbBuscarCliente.Size = new System.Drawing.Size(105, 24);
            this.cmbBuscarCliente.TabIndex = 1;
            this.cmbBuscarCliente.Text = "Buscar RUC:";
            // 
            // Guia_Formulario_BusquedaOrden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 365);
            this.Controls.Add(this.grbListaClientes);
            this.Name = "Guia_Formulario_BusquedaOrden";
            this.Text = "Guia_Formulario_BusquedaOrden";
            this.Load += new System.EventHandler(this.Guia_Formulario_BusquedaOrden_Load);
            this.grbListaClientes.ResumeLayout(false);
            this.grbListaClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaOrdenes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbListaClientes;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.DataGridView tablaOrdenes;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox cmbBuscarCliente;
    }
}