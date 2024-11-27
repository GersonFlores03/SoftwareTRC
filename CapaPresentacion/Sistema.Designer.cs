namespace CapaPresentacion
{
    partial class Sistema
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cuentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCerrarSesion = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCerrar = new System.Windows.Forms.ToolStripMenuItem();
            this.administracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiProveedores = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiConductores = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiVehiculos = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiLicencias = new System.Windows.Forms.ToolStripMenuItem();
            this.vencimientosGeneralesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.movimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOrdenes = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenesDeTrabajoParaAutorizacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procesarOrdenesDeTrabajoPorClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.guiasDeTransporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.facturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procesarFacturasPorClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rutasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCondiciones = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMonedas = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cuentaToolStripMenuItem,
            this.administracionToolStripMenuItem,
            this.movimientosToolStripMenuItem,
            this.rutasToolStripMenuItem,
            this.tsmiCondiciones,
            this.tsmiMonedas,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1424, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cuentaToolStripMenuItem
            // 
            this.cuentaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCerrarSesion,
            this.tsmiCerrar});
            this.cuentaToolStripMenuItem.Name = "cuentaToolStripMenuItem";
            this.cuentaToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.cuentaToolStripMenuItem.Text = "Opciones";
            // 
            // tsmiCerrarSesion
            // 
            this.tsmiCerrarSesion.Name = "tsmiCerrarSesion";
            this.tsmiCerrarSesion.Size = new System.Drawing.Size(176, 26);
            this.tsmiCerrarSesion.Text = "Cerrar Sesion";
            // 
            // tsmiCerrar
            // 
            this.tsmiCerrar.Name = "tsmiCerrar";
            this.tsmiCerrar.Size = new System.Drawing.Size(176, 26);
            this.tsmiCerrar.Text = "Salir";
            this.tsmiCerrar.Click += new System.EventHandler(this.tsmiCerrar_Click);
            // 
            // administracionToolStripMenuItem
            // 
            this.administracionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiClientes,
            this.tsmiProveedores,
            this.toolStripSeparator1,
            this.tsmiConductores,
            this.tsmiVehiculos,
            this.toolStripSeparator2,
            this.tsmiLicencias,
            this.vencimientosGeneralesToolStripMenuItem,
            this.toolStripSeparator3,
            this.productosToolStripMenuItem});
            this.administracionToolStripMenuItem.Name = "administracionToolStripMenuItem";
            this.administracionToolStripMenuItem.Size = new System.Drawing.Size(124, 24);
            this.administracionToolStripMenuItem.Text = "Mantenimientos";
            // 
            // tsmiClientes
            // 
            this.tsmiClientes.Name = "tsmiClientes";
            this.tsmiClientes.Size = new System.Drawing.Size(244, 26);
            this.tsmiClientes.Text = "Clientes";
            this.tsmiClientes.Click += new System.EventHandler(this.tsmiClientes_Click);
            // 
            // tsmiProveedores
            // 
            this.tsmiProveedores.Name = "tsmiProveedores";
            this.tsmiProveedores.Size = new System.Drawing.Size(244, 26);
            this.tsmiProveedores.Text = "Proveedores";
            this.tsmiProveedores.Click += new System.EventHandler(this.tsmiProveedores_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(241, 6);
            // 
            // tsmiConductores
            // 
            this.tsmiConductores.Name = "tsmiConductores";
            this.tsmiConductores.Size = new System.Drawing.Size(244, 26);
            this.tsmiConductores.Text = "Conductores";
            this.tsmiConductores.Click += new System.EventHandler(this.tsmiConductores_Click);
            // 
            // tsmiVehiculos
            // 
            this.tsmiVehiculos.Name = "tsmiVehiculos";
            this.tsmiVehiculos.Size = new System.Drawing.Size(244, 26);
            this.tsmiVehiculos.Text = "Vehiculos";
            this.tsmiVehiculos.Click += new System.EventHandler(this.tsmiVehiculos_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(241, 6);
            // 
            // tsmiLicencias
            // 
            this.tsmiLicencias.Name = "tsmiLicencias";
            this.tsmiLicencias.Size = new System.Drawing.Size(244, 26);
            this.tsmiLicencias.Text = "Licencias";
            // 
            // vencimientosGeneralesToolStripMenuItem
            // 
            this.vencimientosGeneralesToolStripMenuItem.Name = "vencimientosGeneralesToolStripMenuItem";
            this.vencimientosGeneralesToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.vencimientosGeneralesToolStripMenuItem.Text = "Vencimientos Generales";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(241, 6);
            // 
            // movimientosToolStripMenuItem
            // 
            this.movimientosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiOrdenes,
            this.ordenesDeTrabajoParaAutorizacionToolStripMenuItem,
            this.procesarOrdenesDeTrabajoPorClienteToolStripMenuItem,
            this.toolStripSeparator4,
            this.guiasDeTransporteToolStripMenuItem,
            this.toolStripSeparator5,
            this.facturasToolStripMenuItem,
            this.procesarFacturasPorClienteToolStripMenuItem});
            this.movimientosToolStripMenuItem.Name = "movimientosToolStripMenuItem";
            this.movimientosToolStripMenuItem.Size = new System.Drawing.Size(103, 24);
            this.movimientosToolStripMenuItem.Text = "Movimientos";
            // 
            // tsmiOrdenes
            // 
            this.tsmiOrdenes.Name = "tsmiOrdenes";
            this.tsmiOrdenes.Size = new System.Drawing.Size(280, 26);
            this.tsmiOrdenes.Text = "Ordenes";
            this.tsmiOrdenes.Click += new System.EventHandler(this.tsmiOrdenes_Click_1);
            // 
            // ordenesDeTrabajoParaAutorizacionToolStripMenuItem
            // 
            this.ordenesDeTrabajoParaAutorizacionToolStripMenuItem.Name = "ordenesDeTrabajoParaAutorizacionToolStripMenuItem";
            this.ordenesDeTrabajoParaAutorizacionToolStripMenuItem.Size = new System.Drawing.Size(280, 26);
            this.ordenesDeTrabajoParaAutorizacionToolStripMenuItem.Text = "Ordenes para Autorizacion";
            // 
            // procesarOrdenesDeTrabajoPorClienteToolStripMenuItem
            // 
            this.procesarOrdenesDeTrabajoPorClienteToolStripMenuItem.Name = "procesarOrdenesDeTrabajoPorClienteToolStripMenuItem";
            this.procesarOrdenesDeTrabajoPorClienteToolStripMenuItem.Size = new System.Drawing.Size(280, 26);
            this.procesarOrdenesDeTrabajoPorClienteToolStripMenuItem.Text = "Procesar Ordenes por Cliente";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(277, 6);
            // 
            // guiasDeTransporteToolStripMenuItem
            // 
            this.guiasDeTransporteToolStripMenuItem.Name = "guiasDeTransporteToolStripMenuItem";
            this.guiasDeTransporteToolStripMenuItem.Size = new System.Drawing.Size(280, 26);
            this.guiasDeTransporteToolStripMenuItem.Text = "Guias de Transporte";
            this.guiasDeTransporteToolStripMenuItem.Click += new System.EventHandler(this.guiasDeTransporteToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(277, 6);
            // 
            // facturasToolStripMenuItem
            // 
            this.facturasToolStripMenuItem.Name = "facturasToolStripMenuItem";
            this.facturasToolStripMenuItem.Size = new System.Drawing.Size(280, 26);
            this.facturasToolStripMenuItem.Text = "Facturas";
            // 
            // procesarFacturasPorClienteToolStripMenuItem
            // 
            this.procesarFacturasPorClienteToolStripMenuItem.Name = "procesarFacturasPorClienteToolStripMenuItem";
            this.procesarFacturasPorClienteToolStripMenuItem.Size = new System.Drawing.Size(280, 26);
            this.procesarFacturasPorClienteToolStripMenuItem.Text = "Procesar Facturas por Cliente";
            // 
            // rutasToolStripMenuItem
            // 
            this.rutasToolStripMenuItem.Name = "rutasToolStripMenuItem";
            this.rutasToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.rutasToolStripMenuItem.Text = "Rutas";
            this.rutasToolStripMenuItem.Click += new System.EventHandler(this.rutasToolStripMenuItem_Click);
            // 
            // tsmiCondiciones
            // 
            this.tsmiCondiciones.Name = "tsmiCondiciones";
            this.tsmiCondiciones.Size = new System.Drawing.Size(155, 24);
            this.tsmiCondiciones.Text = "Condiciones de Pago";
            this.tsmiCondiciones.Click += new System.EventHandler(this.tsmiCondiciones_Click);
            // 
            // tsmiMonedas
            // 
            this.tsmiMonedas.Name = "tsmiMonedas";
            this.tsmiMonedas.Size = new System.Drawing.Size(81, 24);
            this.tsmiMonedas.Text = "Monedas";
            this.tsmiMonedas.Click += new System.EventHandler(this.tsmiMonedas_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.productosToolStripMenuItem.Text = "Productos";
            this.productosToolStripMenuItem.Click += new System.EventHandler(this.productosToolStripMenuItem_Click);
            // 
            // Sistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(219)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1424, 761);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Sistema";
            this.Text = "Sistema para Transportes";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem administracionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiClientes;
        private System.Windows.Forms.ToolStripMenuItem tsmiProveedores;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmiConductores;
        private System.Windows.Forms.ToolStripMenuItem tsmiVehiculos;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem vencimientosGeneralesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiLicencias;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem movimientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiOrdenes;
        private System.Windows.Forms.ToolStripMenuItem procesarOrdenesDeTrabajoPorClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem ordenesDeTrabajoParaAutorizacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem facturasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procesarFacturasPorClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guiasDeTransporteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiMonedas;
        private System.Windows.Forms.ToolStripMenuItem tsmiCondiciones;
        private System.Windows.Forms.ToolStripMenuItem cuentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiCerrarSesion;
        private System.Windows.Forms.ToolStripMenuItem tsmiCerrar;
        private System.Windows.Forms.ToolStripMenuItem rutasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
    }
}

