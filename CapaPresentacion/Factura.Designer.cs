namespace CapaPresentacion
{
    partial class Factura
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblOpciones = new System.Windows.Forms.Label();
            this.txtDatosCliente = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnPagar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.lblFiltrar = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dTP4Mes = new System.Windows.Forms.DateTimePicker();
            this.dTP3Año = new System.Windows.Forms.DateTimePicker();
            this.bFiltrar = new System.Windows.Forms.Button();
            this.dTP2Fechas = new System.Windows.Forms.DateTimePicker();
            this.dTP1Fechas = new System.Windows.Forms.DateTimePicker();
            this.rB3Fechas = new System.Windows.Forms.RadioButton();
            this.rB2AñoFecha = new System.Windows.Forms.RadioButton();
            this.rB1Todas = new System.Windows.Forms.RadioButton();
            this.pnllDatoCliente = new System.Windows.Forms.Panel();
            this.ComboBuscar = new System.Windows.Forms.ComboBox();
            this.textBoxRuc = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnllDatoCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dataGridView1.Location = new System.Drawing.Point(12, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1002, 286);
            this.dataGridView1.TabIndex = 41;
            // 
            // Column1
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Column1.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column1.HeaderText = "Fecha";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Serie y N°";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Cliente";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "SubTotal";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "% I.G.V";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Monto I.G.V";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Total (S/.)";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Valor Referencial";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Estado";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // lblOpciones
            // 
            this.lblOpciones.AutoSize = true;
            this.lblOpciones.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpciones.Location = new System.Drawing.Point(16, 377);
            this.lblOpciones.Name = "lblOpciones";
            this.lblOpciones.Size = new System.Drawing.Size(87, 19);
            this.lblOpciones.TabIndex = 40;
            this.lblOpciones.Text = "Opciones ";
            // 
            // txtDatosCliente
            // 
            this.txtDatosCliente.AutoSize = true;
            this.txtDatosCliente.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDatosCliente.Location = new System.Drawing.Point(12, -1);
            this.txtDatosCliente.Name = "txtDatosCliente";
            this.txtDatosCliente.Size = new System.Drawing.Size(129, 19);
            this.txtDatosCliente.TabIndex = 36;
            this.txtDatosCliente.Text = "Buscar Factura";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btnPagar);
            this.panel2.Controls.Add(this.btnModificar);
            this.panel2.Location = new System.Drawing.Point(12, 389);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1003, 86);
            this.panel2.TabIndex = 39;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(871, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 33);
            this.button1.TabIndex = 26;
            this.button1.Text = "Imprimir ";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnPagar
            // 
            this.btnPagar.Location = new System.Drawing.Point(57, 29);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(75, 33);
            this.btnPagar.TabIndex = 23;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(163, 29);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(87, 33);
            this.btnModificar.TabIndex = 25;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // lblFiltrar
            // 
            this.lblFiltrar.AutoSize = true;
            this.lblFiltrar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltrar.Location = new System.Drawing.Point(288, -1);
            this.lblFiltrar.Name = "lblFiltrar";
            this.lblFiltrar.Size = new System.Drawing.Size(91, 19);
            this.lblFiltrar.TabIndex = 35;
            this.lblFiltrar.Text = "Filtrar por";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dTP4Mes);
            this.panel1.Controls.Add(this.dTP3Año);
            this.panel1.Controls.Add(this.bFiltrar);
            this.panel1.Controls.Add(this.dTP2Fechas);
            this.panel1.Controls.Add(this.dTP1Fechas);
            this.panel1.Controls.Add(this.rB3Fechas);
            this.panel1.Controls.Add(this.rB2AñoFecha);
            this.panel1.Controls.Add(this.rB1Todas);
            this.panel1.Location = new System.Drawing.Point(284, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(731, 70);
            this.panel1.TabIndex = 38;
            // 
            // dTP4Mes
            // 
            this.dTP4Mes.CustomFormat = "MM";
            this.dTP4Mes.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTP4Mes.Location = new System.Drawing.Point(257, 25);
            this.dTP4Mes.Name = "dTP4Mes";
            this.dTP4Mes.Size = new System.Drawing.Size(41, 20);
            this.dTP4Mes.TabIndex = 9;
            // 
            // dTP3Año
            // 
            this.dTP3Año.CustomFormat = "yyyy";
            this.dTP3Año.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTP3Año.Location = new System.Drawing.Point(186, 25);
            this.dTP3Año.Name = "dTP3Año";
            this.dTP3Año.Size = new System.Drawing.Size(65, 20);
            this.dTP3Año.TabIndex = 8;
            // 
            // bFiltrar
            // 
            this.bFiltrar.Location = new System.Drawing.Point(640, 7);
            this.bFiltrar.Name = "bFiltrar";
            this.bFiltrar.Size = new System.Drawing.Size(75, 58);
            this.bFiltrar.TabIndex = 7;
            this.bFiltrar.Text = "Filtrar";
            this.bFiltrar.UseVisualStyleBackColor = true;
            // 
            // dTP2Fechas
            // 
            this.dTP2Fechas.CustomFormat = "dd-MM-yyyy";
            this.dTP2Fechas.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTP2Fechas.Location = new System.Drawing.Point(523, 24);
            this.dTP2Fechas.Name = "dTP2Fechas";
            this.dTP2Fechas.Size = new System.Drawing.Size(102, 20);
            this.dTP2Fechas.TabIndex = 6;
            // 
            // dTP1Fechas
            // 
            this.dTP1Fechas.CustomFormat = "dd-MM-yyyy";
            this.dTP1Fechas.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTP1Fechas.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dTP1Fechas.Location = new System.Drawing.Point(414, 24);
            this.dTP1Fechas.Name = "dTP1Fechas";
            this.dTP1Fechas.Size = new System.Drawing.Size(103, 20);
            this.dTP1Fechas.TabIndex = 5;
            // 
            // rB3Fechas
            // 
            this.rB3Fechas.AutoSize = true;
            this.rB3Fechas.Location = new System.Drawing.Point(323, 28);
            this.rB3Fechas.Name = "rB3Fechas";
            this.rB3Fechas.Size = new System.Drawing.Size(66, 17);
            this.rB3Fechas.TabIndex = 2;
            this.rB3Fechas.TabStop = true;
            this.rB3Fechas.Text = "Fechas :";
            this.rB3Fechas.UseVisualStyleBackColor = true;
            // 
            // rB2AñoFecha
            // 
            this.rB2AñoFecha.AutoSize = true;
            this.rB2AñoFecha.Location = new System.Drawing.Point(79, 28);
            this.rB2AñoFecha.Name = "rB2AñoFecha";
            this.rB2AñoFecha.Size = new System.Drawing.Size(75, 17);
            this.rB2AñoFecha.TabIndex = 1;
            this.rB2AñoFecha.TabStop = true;
            this.rB2AñoFecha.Text = "Año y Mes";
            this.rB2AñoFecha.UseVisualStyleBackColor = true;
            // 
            // rB1Todas
            // 
            this.rB1Todas.AutoSize = true;
            this.rB1Todas.Location = new System.Drawing.Point(3, 28);
            this.rB1Todas.Name = "rB1Todas";
            this.rB1Todas.Size = new System.Drawing.Size(55, 17);
            this.rB1Todas.TabIndex = 0;
            this.rB1Todas.TabStop = true;
            this.rB1Todas.Text = "Todas";
            this.rB1Todas.UseVisualStyleBackColor = true;
            // 
            // pnllDatoCliente
            // 
            this.pnllDatoCliente.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnllDatoCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnllDatoCliente.Controls.Add(this.ComboBuscar);
            this.pnllDatoCliente.Controls.Add(this.textBoxRuc);
            this.pnllDatoCliente.Location = new System.Drawing.Point(12, 12);
            this.pnllDatoCliente.Name = "pnllDatoCliente";
            this.pnllDatoCliente.Size = new System.Drawing.Size(265, 70);
            this.pnllDatoCliente.TabIndex = 37;
            // 
            // ComboBuscar
            // 
            this.ComboBuscar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ComboBuscar.FormattingEnabled = true;
            this.ComboBuscar.ImeMode = System.Windows.Forms.ImeMode.On;
            this.ComboBuscar.Location = new System.Drawing.Point(6, 24);
            this.ComboBuscar.Name = "ComboBuscar";
            this.ComboBuscar.Size = new System.Drawing.Size(125, 21);
            this.ComboBuscar.TabIndex = 23;
            this.ComboBuscar.Text = "Buscar por N°";
            // 
            // textBoxRuc
            // 
            this.textBoxRuc.Location = new System.Drawing.Point(146, 24);
            this.textBoxRuc.Name = "textBoxRuc";
            this.textBoxRuc.Size = new System.Drawing.Size(103, 20);
            this.textBoxRuc.TabIndex = 20;
            // 
            // Factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 484);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblOpciones);
            this.Controls.Add(this.txtDatosCliente);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblFiltrar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnllDatoCliente);
            this.Name = "Factura";
            this.Text = "Factura";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnllDatoCliente.ResumeLayout(false);
            this.pnllDatoCliente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.Label lblOpciones;
        private System.Windows.Forms.Label txtDatosCliente;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label lblFiltrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dTP4Mes;
        private System.Windows.Forms.DateTimePicker dTP3Año;
        private System.Windows.Forms.Button bFiltrar;
        private System.Windows.Forms.DateTimePicker dTP2Fechas;
        private System.Windows.Forms.DateTimePicker dTP1Fechas;
        private System.Windows.Forms.RadioButton rB3Fechas;
        private System.Windows.Forms.RadioButton rB2AñoFecha;
        private System.Windows.Forms.RadioButton rB1Todas;
        private System.Windows.Forms.Panel pnllDatoCliente;
        private System.Windows.Forms.ComboBox ComboBuscar;
        private System.Windows.Forms.TextBox textBoxRuc;
    }
}