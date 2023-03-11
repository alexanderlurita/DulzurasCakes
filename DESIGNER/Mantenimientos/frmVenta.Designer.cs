namespace DESIGNER.Mantenimientos
{
    partial class frmVenta
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
            this.rbtnBoleta = new System.Windows.Forms.RadioButton();
            this.rbtnFactura = new System.Windows.Forms.RadioButton();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.lblDni = new System.Windows.Forms.Label();
            this.cmbMedioPago = new System.Windows.Forms.ComboBox();
            this.txtClienteOrRazonSocial = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.txtNeto = new System.Windows.Forms.TextBox();
            this.txtIgv = new System.Windows.Forms.TextBox();
            this.txtDniOrRuc = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cmbProductos = new System.Windows.Forms.ComboBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.gridDetalles = new System.Windows.Forms.DataGridView();
            this.CIdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CImporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbcVentas = new System.Windows.Forms.TabControl();
            this.tbpVentas = new System.Windows.Forms.TabPage();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtValorBuscado = new System.Windows.Forms.TextBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.gridVentas = new System.Windows.Forms.DataGridView();
            this.Detalles = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tbpNuevaVenta = new System.Windows.Forms.TabPage();
            this.btnAtras = new System.Windows.Forms.Button();
            this.tbcDetalleVenta = new System.Windows.Forms.TabControl();
            this.tbpCliente = new System.Windows.Forms.TabPage();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnAnadir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblBoletaFactura = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbpProductos = new System.Windows.Forms.TabPage();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNeto = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIdProducto = new System.Windows.Forms.TextBox();
            this.tbpPago = new System.Windows.Forms.TabPage();
            this.txtRComprobante = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.gridResumen = new System.Windows.Forms.DataGridView();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtRDniOrRuc = new System.Windows.Forms.TextBox();
            this.txtRClienteOrRazonSocial = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblMPNeto = new System.Windows.Forms.Label();
            this.txtMPIgv = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtMPNeto = new System.Windows.Forms.TextBox();
            this.txtMPSubtotal = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridDetalles)).BeginInit();
            this.tbcVentas.SuspendLayout();
            this.tbpVentas.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridVentas)).BeginInit();
            this.tbpNuevaVenta.SuspendLayout();
            this.tbcDetalleVenta.SuspendLayout();
            this.tbpCliente.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tbpProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            this.panel1.SuspendLayout();
            this.tbpPago.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridResumen)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbtnBoleta
            // 
            this.rbtnBoleta.AutoSize = true;
            this.rbtnBoleta.Checked = true;
            this.rbtnBoleta.Location = new System.Drawing.Point(22, 53);
            this.rbtnBoleta.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnBoleta.Name = "rbtnBoleta";
            this.rbtnBoleta.Size = new System.Drawing.Size(67, 21);
            this.rbtnBoleta.TabIndex = 1;
            this.rbtnBoleta.TabStop = true;
            this.rbtnBoleta.Text = "Boleta";
            this.rbtnBoleta.UseVisualStyleBackColor = true;
            this.rbtnBoleta.CheckedChanged += new System.EventHandler(this.rbtnBoleta_CheckedChanged);
            // 
            // rbtnFactura
            // 
            this.rbtnFactura.AutoSize = true;
            this.rbtnFactura.Location = new System.Drawing.Point(97, 53);
            this.rbtnFactura.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnFactura.Name = "rbtnFactura";
            this.rbtnFactura.Size = new System.Drawing.Size(75, 21);
            this.rbtnFactura.TabIndex = 2;
            this.rbtnFactura.Text = "Factura";
            this.rbtnFactura.UseVisualStyleBackColor = true;
            this.rbtnFactura.CheckedChanged += new System.EventHandler(this.rbtnFactura_CheckedChanged);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(65)))), ((int)(((byte)(54)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(9, 503);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(149, 46);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "CANCELAR VENTA";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(110)))), ((int)(((byte)(228)))));
            this.btnSiguiente.FlatAppearance.BorderSize = 0;
            this.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiguiente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSiguiente.ForeColor = System.Drawing.Color.White;
            this.btnSiguiente.Location = new System.Drawing.Point(880, 503);
            this.btnSiguiente.Margin = new System.Windows.Forms.Padding(4);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(149, 46);
            this.btnSiguiente.TabIndex = 2;
            this.btnSiguiente.Text = "SIGUIENTE";
            this.btnSiguiente.UseVisualStyleBackColor = false;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDni.Location = new System.Drawing.Point(20, 141);
            this.lblDni.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(35, 17);
            this.lblDni.TabIndex = 0;
            this.lblDni.Text = "DNI:";
            // 
            // cmbMedioPago
            // 
            this.cmbMedioPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMedioPago.FormattingEnabled = true;
            this.cmbMedioPago.Location = new System.Drawing.Point(12, 62);
            this.cmbMedioPago.Margin = new System.Windows.Forms.Padding(4);
            this.cmbMedioPago.Name = "cmbMedioPago";
            this.cmbMedioPago.Size = new System.Drawing.Size(219, 25);
            this.cmbMedioPago.TabIndex = 7;
            this.cmbMedioPago.SelectedIndexChanged += new System.EventHandler(this.cmbMedioPago_SelectedIndexChanged);
            // 
            // txtClienteOrRazonSocial
            // 
            this.txtClienteOrRazonSocial.Location = new System.Drawing.Point(117, 183);
            this.txtClienteOrRazonSocial.Margin = new System.Windows.Forms.Padding(4);
            this.txtClienteOrRazonSocial.Name = "txtClienteOrRazonSocial";
            this.txtClienteOrRazonSocial.ReadOnly = true;
            this.txtClienteOrRazonSocial.Size = new System.Drawing.Size(264, 23);
            this.txtClienteOrRazonSocial.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Medio pago:";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCliente.Location = new System.Drawing.Point(20, 186);
            this.lblCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(58, 17);
            this.lblCliente.TabIndex = 2;
            this.lblCliente.Text = "Cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 163);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Subtotal:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 205);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "IGV:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 252);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Neto:";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(99, 160);
            this.txtSubtotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(132, 23);
            this.txtSubtotal.TabIndex = 9;
            this.txtSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtNeto
            // 
            this.txtNeto.Location = new System.Drawing.Point(99, 249);
            this.txtNeto.Margin = new System.Windows.Forms.Padding(4);
            this.txtNeto.Name = "txtNeto";
            this.txtNeto.ReadOnly = true;
            this.txtNeto.Size = new System.Drawing.Size(132, 23);
            this.txtNeto.TabIndex = 13;
            this.txtNeto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtIgv
            // 
            this.txtIgv.Location = new System.Drawing.Point(99, 202);
            this.txtIgv.Margin = new System.Windows.Forms.Padding(4);
            this.txtIgv.Name = "txtIgv";
            this.txtIgv.ReadOnly = true;
            this.txtIgv.Size = new System.Drawing.Size(132, 23);
            this.txtIgv.TabIndex = 11;
            this.txtIgv.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDniOrRuc
            // 
            this.txtDniOrRuc.Location = new System.Drawing.Point(117, 138);
            this.txtDniOrRuc.Margin = new System.Windows.Forms.Padding(4);
            this.txtDniOrRuc.MaxLength = 8;
            this.txtDniOrRuc.Name = "txtDniOrRuc";
            this.txtDniOrRuc.Size = new System.Drawing.Size(264, 23);
            this.txtDniOrRuc.TabIndex = 1;
            this.txtDniOrRuc.TextChanged += new System.EventHandler(this.txtDniOrRuc_TextChanged);
            this.txtDniOrRuc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDniOrRuc_KeyPress);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(23, 59);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(266, 23);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // cmbProductos
            // 
            this.cmbProductos.FormattingEnabled = true;
            this.cmbProductos.IntegralHeight = false;
            this.cmbProductos.ItemHeight = 17;
            this.cmbProductos.Location = new System.Drawing.Point(154, 42);
            this.cmbProductos.Margin = new System.Windows.Forms.Padding(4);
            this.cmbProductos.Name = "cmbProductos";
            this.cmbProductos.Size = new System.Drawing.Size(344, 25);
            this.cmbProductos.TabIndex = 19;
            this.cmbProductos.SelectedIndexChanged += new System.EventHandler(this.cmbProducto_SelectedIndexChanged);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(23, 105);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ReadOnly = true;
            this.txtDescripcion.Size = new System.Drawing.Size(475, 23);
            this.txtDescripcion.TabIndex = 20;
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(23, 169);
            this.txtStock.Margin = new System.Windows.Forms.Padding(4);
            this.txtStock.MaxLength = 3;
            this.txtStock.Name = "txtStock";
            this.txtStock.ReadOnly = true;
            this.txtStock.Size = new System.Drawing.Size(112, 23);
            this.txtStock.TabIndex = 21;
            this.txtStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(204, 169);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecio.MaxLength = 8;
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.ReadOnly = true;
            this.txtPrecio.Size = new System.Drawing.Size(112, 23);
            this.txtPrecio.TabIndex = 22;
            this.txtPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(65)))), ((int)(((byte)(54)))));
            this.btnReiniciar.FlatAppearance.BorderSize = 0;
            this.btnReiniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReiniciar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReiniciar.ForeColor = System.Drawing.Color.White;
            this.btnReiniciar.Location = new System.Drawing.Point(573, 162);
            this.btnReiniciar.Margin = new System.Windows.Forms.Padding(4);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(100, 30);
            this.btnReiniciar.TabIndex = 24;
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = false;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(110)))), ((int)(((byte)(228)))));
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(573, 124);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(100, 30);
            this.btnAgregar.TabIndex = 25;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 84);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 17);
            this.label7.TabIndex = 26;
            this.label7.Text = "Descripción:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 148);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 17);
            this.label8.TabIndex = 27;
            this.label8.Text = "Stock:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(201, 148);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 17);
            this.label9.TabIndex = 28;
            this.label9.Text = "Precio:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(383, 148);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 17);
            this.label10.TabIndex = 29;
            this.label10.Text = "Cantidad:";
            // 
            // gridDetalles
            // 
            this.gridDetalles.AllowUserToAddRows = false;
            this.gridDetalles.AllowUserToResizeColumns = false;
            this.gridDetalles.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridDetalles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDetalles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CIdProducto,
            this.CProducto,
            this.CPrecio,
            this.CCantidad,
            this.CImporte});
            this.gridDetalles.Location = new System.Drawing.Point(23, 218);
            this.gridDetalles.Margin = new System.Windows.Forms.Padding(4);
            this.gridDetalles.MultiSelect = false;
            this.gridDetalles.Name = "gridDetalles";
            this.gridDetalles.ReadOnly = true;
            this.gridDetalles.RowHeadersVisible = false;
            this.gridDetalles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridDetalles.Size = new System.Drawing.Size(644, 219);
            this.gridDetalles.TabIndex = 30;
            this.gridDetalles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridDetalles_CellClick);
            this.gridDetalles.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.gridDetalles_CellPainting);
            // 
            // CIdProducto
            // 
            this.CIdProducto.HeaderText = "ID";
            this.CIdProducto.Name = "CIdProducto";
            this.CIdProducto.ReadOnly = true;
            this.CIdProducto.Width = 50;
            // 
            // CProducto
            // 
            this.CProducto.HeaderText = "Producto";
            this.CProducto.Name = "CProducto";
            this.CProducto.ReadOnly = true;
            this.CProducto.Width = 150;
            // 
            // CPrecio
            // 
            this.CPrecio.HeaderText = "Precio unitario";
            this.CPrecio.Name = "CPrecio";
            this.CPrecio.ReadOnly = true;
            this.CPrecio.Width = 150;
            // 
            // CCantidad
            // 
            this.CCantidad.HeaderText = "Cantidad";
            this.CCantidad.Name = "CCantidad";
            this.CCantidad.ReadOnly = true;
            // 
            // CImporte
            // 
            this.CImporte.HeaderText = "Importe";
            this.CImporte.Name = "CImporte";
            this.CImporte.ReadOnly = true;
            // 
            // tbcVentas
            // 
            this.tbcVentas.Controls.Add(this.tbpVentas);
            this.tbcVentas.Controls.Add(this.tbpNuevaVenta);
            this.tbcVentas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcVentas.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbcVentas.Location = new System.Drawing.Point(0, 0);
            this.tbcVentas.Margin = new System.Windows.Forms.Padding(4);
            this.tbcVentas.Name = "tbcVentas";
            this.tbcVentas.SelectedIndex = 0;
            this.tbcVentas.Size = new System.Drawing.Size(1046, 588);
            this.tbcVentas.TabIndex = 31;
            // 
            // tbpVentas
            // 
            this.tbpVentas.Controls.Add(this.btnActualizar);
            this.tbpVentas.Controls.Add(this.groupBox2);
            this.tbpVentas.Controls.Add(this.btnNuevo);
            this.tbpVentas.Controls.Add(this.gridVentas);
            this.tbpVentas.Location = new System.Drawing.Point(4, 26);
            this.tbpVentas.Margin = new System.Windows.Forms.Padding(4);
            this.tbpVentas.Name = "tbpVentas";
            this.tbpVentas.Padding = new System.Windows.Forms.Padding(4);
            this.tbpVentas.Size = new System.Drawing.Size(1038, 558);
            this.tbpVentas.TabIndex = 0;
            this.tbpVentas.Text = "Ventas";
            this.tbpVentas.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(916, 170);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(96, 33);
            this.btnActualizar.TabIndex = 3;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtValorBuscado);
            this.groupBox2.Location = new System.Drawing.Point(36, 46);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(732, 58);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscar";
            // 
            // txtValorBuscado
            // 
            this.txtValorBuscado.Location = new System.Drawing.Point(6, 22);
            this.txtValorBuscado.Name = "txtValorBuscado";
            this.txtValorBuscado.Size = new System.Drawing.Size(720, 23);
            this.txtValorBuscado.TabIndex = 0;
            this.txtValorBuscado.TextChanged += new System.EventHandler(this.txtValorBuscado_TextChanged);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(916, 123);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(96, 31);
            this.btnNuevo.TabIndex = 1;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // gridVentas
            // 
            this.gridVentas.AllowUserToAddRows = false;
            this.gridVentas.AllowUserToDeleteRows = false;
            this.gridVentas.AllowUserToResizeColumns = false;
            this.gridVentas.AllowUserToResizeRows = false;
            this.gridVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Detalles});
            this.gridVentas.Location = new System.Drawing.Point(36, 123);
            this.gridVentas.Margin = new System.Windows.Forms.Padding(4);
            this.gridVentas.MultiSelect = false;
            this.gridVentas.Name = "gridVentas";
            this.gridVentas.ReadOnly = true;
            this.gridVentas.RowHeadersVisible = false;
            this.gridVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridVentas.Size = new System.Drawing.Size(830, 297);
            this.gridVentas.TabIndex = 0;
            this.gridVentas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridVentas_CellClick);
            // 
            // Detalles
            // 
            this.Detalles.HeaderText = "Detalles";
            this.Detalles.Name = "Detalles";
            this.Detalles.ReadOnly = true;
            this.Detalles.Text = "ver";
            this.Detalles.UseColumnTextForButtonValue = true;
            // 
            // tbpNuevaVenta
            // 
            this.tbpNuevaVenta.Controls.Add(this.btnAtras);
            this.tbpNuevaVenta.Controls.Add(this.tbcDetalleVenta);
            this.tbpNuevaVenta.Controls.Add(this.btnCancelar);
            this.tbpNuevaVenta.Controls.Add(this.btnSiguiente);
            this.tbpNuevaVenta.Location = new System.Drawing.Point(4, 26);
            this.tbpNuevaVenta.Margin = new System.Windows.Forms.Padding(4);
            this.tbpNuevaVenta.Name = "tbpNuevaVenta";
            this.tbpNuevaVenta.Padding = new System.Windows.Forms.Padding(4);
            this.tbpNuevaVenta.Size = new System.Drawing.Size(1038, 558);
            this.tbpNuevaVenta.TabIndex = 1;
            this.tbpNuevaVenta.Text = "Nueva venta";
            this.tbpNuevaVenta.UseVisualStyleBackColor = true;
            // 
            // btnAtras
            // 
            this.btnAtras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(110)))), ((int)(((byte)(228)))));
            this.btnAtras.FlatAppearance.BorderSize = 0;
            this.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtras.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAtras.ForeColor = System.Drawing.Color.White;
            this.btnAtras.Location = new System.Drawing.Point(724, 503);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(149, 46);
            this.btnAtras.TabIndex = 1;
            this.btnAtras.Text = "ATRÁS";
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Visible = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // tbcDetalleVenta
            // 
            this.tbcDetalleVenta.Controls.Add(this.tbpCliente);
            this.tbcDetalleVenta.Controls.Add(this.tbpProductos);
            this.tbcDetalleVenta.Controls.Add(this.tbpPago);
            this.tbcDetalleVenta.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbcDetalleVenta.Location = new System.Drawing.Point(4, 4);
            this.tbcDetalleVenta.Margin = new System.Windows.Forms.Padding(4);
            this.tbcDetalleVenta.Name = "tbcDetalleVenta";
            this.tbcDetalleVenta.SelectedIndex = 0;
            this.tbcDetalleVenta.Size = new System.Drawing.Size(1030, 490);
            this.tbcDetalleVenta.TabIndex = 0;
            // 
            // tbpCliente
            // 
            this.tbpCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.tbpCliente.Controls.Add(this.btnLimpiar);
            this.tbpCliente.Controls.Add(this.btnAnadir);
            this.tbpCliente.Controls.Add(this.groupBox1);
            this.tbpCliente.Controls.Add(this.label11);
            this.tbpCliente.Controls.Add(this.lblDni);
            this.tbpCliente.Controls.Add(this.txtDniOrRuc);
            this.tbpCliente.Controls.Add(this.lblCliente);
            this.tbpCliente.Controls.Add(this.txtClienteOrRazonSocial);
            this.tbpCliente.Controls.Add(this.dateTimePicker1);
            this.tbpCliente.Location = new System.Drawing.Point(4, 26);
            this.tbpCliente.Margin = new System.Windows.Forms.Padding(4);
            this.tbpCliente.Name = "tbpCliente";
            this.tbpCliente.Padding = new System.Windows.Forms.Padding(4);
            this.tbpCliente.Size = new System.Drawing.Size(1022, 460);
            this.tbpCliente.TabIndex = 0;
            this.tbpCliente.Text = "Datos del cliente";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(65)))), ((int)(((byte)(54)))));
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(381, 183);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(31, 23);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "X";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnAnadir
            // 
            this.btnAnadir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(110)))), ((int)(((byte)(228)))));
            this.btnAnadir.FlatAppearance.BorderSize = 0;
            this.btnAnadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnadir.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnadir.ForeColor = System.Drawing.Color.White;
            this.btnAnadir.Location = new System.Drawing.Point(410, 183);
            this.btnAnadir.Name = "btnAnadir";
            this.btnAnadir.Size = new System.Drawing.Size(75, 23);
            this.btnAnadir.TabIndex = 6;
            this.btnAnadir.Text = "Añadir";
            this.btnAnadir.UseVisualStyleBackColor = false;
            this.btnAnadir.Click += new System.EventHandler(this.btnAnadir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblBoletaFactura);
            this.groupBox1.Controls.Add(this.rbtnFactura);
            this.groupBox1.Controls.Add(this.rbtnBoleta);
            this.groupBox1.Location = new System.Drawing.Point(830, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(185, 85);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // lblBoletaFactura
            // 
            this.lblBoletaFactura.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBoletaFactura.Font = new System.Drawing.Font("Century Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBoletaFactura.Location = new System.Drawing.Point(3, 19);
            this.lblBoletaFactura.Name = "lblBoletaFactura";
            this.lblBoletaFactura.Size = new System.Drawing.Size(179, 30);
            this.lblBoletaFactura.TabIndex = 0;
            this.lblBoletaFactura.Text = "BOLETA";
            this.lblBoletaFactura.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 39);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 17);
            this.label11.TabIndex = 0;
            this.label11.Text = "Fecha actual:";
            // 
            // tbpProductos
            // 
            this.tbpProductos.Controls.Add(this.nudCantidad);
            this.tbpProductos.Controls.Add(this.panel1);
            this.tbpProductos.Controls.Add(this.label12);
            this.tbpProductos.Controls.Add(this.label6);
            this.tbpProductos.Controls.Add(this.txtIdProducto);
            this.tbpProductos.Controls.Add(this.cmbProductos);
            this.tbpProductos.Controls.Add(this.gridDetalles);
            this.tbpProductos.Controls.Add(this.label7);
            this.tbpProductos.Controls.Add(this.label10);
            this.tbpProductos.Controls.Add(this.txtDescripcion);
            this.tbpProductos.Controls.Add(this.label9);
            this.tbpProductos.Controls.Add(this.btnAgregar);
            this.tbpProductos.Controls.Add(this.label8);
            this.tbpProductos.Controls.Add(this.btnReiniciar);
            this.tbpProductos.Controls.Add(this.txtPrecio);
            this.tbpProductos.Controls.Add(this.txtStock);
            this.tbpProductos.Location = new System.Drawing.Point(4, 26);
            this.tbpProductos.Margin = new System.Windows.Forms.Padding(4);
            this.tbpProductos.Name = "tbpProductos";
            this.tbpProductos.Padding = new System.Windows.Forms.Padding(4);
            this.tbpProductos.Size = new System.Drawing.Size(1022, 460);
            this.tbpProductos.TabIndex = 1;
            this.tbpProductos.Text = "Selección de productos";
            this.tbpProductos.UseVisualStyleBackColor = true;
            // 
            // nudCantidad
            // 
            this.nudCantidad.Location = new System.Drawing.Point(386, 169);
            this.nudCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(112, 23);
            this.nudCantidad.TabIndex = 36;
            this.nudCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.lblNeto);
            this.panel1.Controls.Add(this.txtIgv);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtNeto);
            this.panel1.Controls.Add(this.txtSubtotal);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(769, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(249, 452);
            this.panel1.TabIndex = 35;
            // 
            // lblNeto
            // 
            this.lblNeto.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNeto.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNeto.Location = new System.Drawing.Point(0, 0);
            this.lblNeto.Name = "lblNeto";
            this.lblNeto.Size = new System.Drawing.Size(249, 53);
            this.lblNeto.TabIndex = 34;
            this.lblNeto.Text = "S/. 0,00";
            this.lblNeto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(151, 21);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 17);
            this.label12.TabIndex = 33;
            this.label12.Text = "Producto:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 17);
            this.label6.TabIndex = 32;
            this.label6.Text = "ID:";
            // 
            // txtIdProducto
            // 
            this.txtIdProducto.Location = new System.Drawing.Point(23, 44);
            this.txtIdProducto.Name = "txtIdProducto";
            this.txtIdProducto.ReadOnly = true;
            this.txtIdProducto.Size = new System.Drawing.Size(84, 23);
            this.txtIdProducto.TabIndex = 31;
            // 
            // tbpPago
            // 
            this.tbpPago.Controls.Add(this.txtRComprobante);
            this.tbpPago.Controls.Add(this.label19);
            this.tbpPago.Controls.Add(this.gridResumen);
            this.tbpPago.Controls.Add(this.label18);
            this.tbpPago.Controls.Add(this.label17);
            this.tbpPago.Controls.Add(this.txtRDniOrRuc);
            this.tbpPago.Controls.Add(this.txtRClienteOrRazonSocial);
            this.tbpPago.Controls.Add(this.label13);
            this.tbpPago.Controls.Add(this.label5);
            this.tbpPago.Controls.Add(this.panel2);
            this.tbpPago.Location = new System.Drawing.Point(4, 26);
            this.tbpPago.Margin = new System.Windows.Forms.Padding(4);
            this.tbpPago.Name = "tbpPago";
            this.tbpPago.Padding = new System.Windows.Forms.Padding(4);
            this.tbpPago.Size = new System.Drawing.Size(1022, 460);
            this.tbpPago.TabIndex = 2;
            this.tbpPago.Text = "Método de pago";
            this.tbpPago.UseVisualStyleBackColor = true;
            // 
            // txtRComprobante
            // 
            this.txtRComprobante.Location = new System.Drawing.Point(363, 81);
            this.txtRComprobante.Name = "txtRComprobante";
            this.txtRComprobante.ReadOnly = true;
            this.txtRComprobante.Size = new System.Drawing.Size(151, 23);
            this.txtRComprobante.TabIndex = 46;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(360, 61);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(154, 17);
            this.label19.TabIndex = 45;
            this.label19.Text = "Tipo de comprobante:";
            // 
            // gridResumen
            // 
            this.gridResumen.AllowUserToAddRows = false;
            this.gridResumen.AllowUserToResizeColumns = false;
            this.gridResumen.AllowUserToResizeRows = false;
            this.gridResumen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridResumen.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridResumen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridResumen.Location = new System.Drawing.Point(27, 210);
            this.gridResumen.Margin = new System.Windows.Forms.Padding(4);
            this.gridResumen.MultiSelect = false;
            this.gridResumen.Name = "gridResumen";
            this.gridResumen.ReadOnly = true;
            this.gridResumen.RowHeadersVisible = false;
            this.gridResumen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridResumen.Size = new System.Drawing.Size(517, 219);
            this.gridResumen.TabIndex = 44;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label18.Location = new System.Drawing.Point(23, 26);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(84, 19);
            this.label18.TabIndex = 43;
            this.label18.Text = "Resumen:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(24, 189);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(129, 17);
            this.label17.TabIndex = 41;
            this.label17.Text = "Productos a llevar:";
            // 
            // txtRDniOrRuc
            // 
            this.txtRDniOrRuc.Location = new System.Drawing.Point(27, 127);
            this.txtRDniOrRuc.Name = "txtRDniOrRuc";
            this.txtRDniOrRuc.ReadOnly = true;
            this.txtRDniOrRuc.Size = new System.Drawing.Size(279, 23);
            this.txtRDniOrRuc.TabIndex = 40;
            // 
            // txtRClienteOrRazonSocial
            // 
            this.txtRClienteOrRazonSocial.Location = new System.Drawing.Point(27, 81);
            this.txtRClienteOrRazonSocial.Name = "txtRClienteOrRazonSocial";
            this.txtRClienteOrRazonSocial.ReadOnly = true;
            this.txtRClienteOrRazonSocial.Size = new System.Drawing.Size(279, 23);
            this.txtRClienteOrRazonSocial.TabIndex = 39;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(24, 107);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 17);
            this.label13.TabIndex = 38;
            this.label13.Text = "DNI:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 17);
            this.label5.TabIndex = 37;
            this.label5.Text = "Cliente/Razón social:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.lblMPNeto);
            this.panel2.Controls.Add(this.cmbMedioPago);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtMPIgv);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.txtMPNeto);
            this.panel2.Controls.Add(this.txtMPSubtotal);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(769, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(249, 452);
            this.panel2.TabIndex = 36;
            // 
            // lblMPNeto
            // 
            this.lblMPNeto.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblMPNeto.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMPNeto.Location = new System.Drawing.Point(0, 401);
            this.lblMPNeto.Name = "lblMPNeto";
            this.lblMPNeto.Size = new System.Drawing.Size(249, 51);
            this.lblMPNeto.TabIndex = 34;
            this.lblMPNeto.Text = "S/. 0,00";
            this.lblMPNeto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMPIgv
            // 
            this.txtMPIgv.Location = new System.Drawing.Point(99, 202);
            this.txtMPIgv.Margin = new System.Windows.Forms.Padding(4);
            this.txtMPIgv.Name = "txtMPIgv";
            this.txtMPIgv.ReadOnly = true;
            this.txtMPIgv.Size = new System.Drawing.Size(132, 23);
            this.txtMPIgv.TabIndex = 11;
            this.txtMPIgv.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 163);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 17);
            this.label14.TabIndex = 8;
            this.label14.Text = "Subtotal:";
            // 
            // txtMPNeto
            // 
            this.txtMPNeto.Location = new System.Drawing.Point(99, 249);
            this.txtMPNeto.Margin = new System.Windows.Forms.Padding(4);
            this.txtMPNeto.Name = "txtMPNeto";
            this.txtMPNeto.ReadOnly = true;
            this.txtMPNeto.Size = new System.Drawing.Size(132, 23);
            this.txtMPNeto.TabIndex = 13;
            this.txtMPNeto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtMPSubtotal
            // 
            this.txtMPSubtotal.Location = new System.Drawing.Point(99, 160);
            this.txtMPSubtotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtMPSubtotal.Name = "txtMPSubtotal";
            this.txtMPSubtotal.ReadOnly = true;
            this.txtMPSubtotal.Size = new System.Drawing.Size(132, 23);
            this.txtMPSubtotal.TabIndex = 9;
            this.txtMPSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(9, 205);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(35, 17);
            this.label15.TabIndex = 10;
            this.label15.Text = "IGV:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(9, 252);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(44, 17);
            this.label16.TabIndex = 12;
            this.label16.Text = "Neto:";
            // 
            // frmVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 588);
            this.Controls.Add(this.tbcVentas);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmVenta";
            this.Load += new System.EventHandler(this.frmVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridDetalles)).EndInit();
            this.tbcVentas.ResumeLayout(false);
            this.tbpVentas.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridVentas)).EndInit();
            this.tbpNuevaVenta.ResumeLayout(false);
            this.tbcDetalleVenta.ResumeLayout(false);
            this.tbpCliente.ResumeLayout(false);
            this.tbpCliente.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tbpProductos.ResumeLayout(false);
            this.tbpProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tbpPago.ResumeLayout(false);
            this.tbpPago.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridResumen)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RadioButton rbtnBoleta;
        private System.Windows.Forms.RadioButton rbtnFactura;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.ComboBox cmbMedioPago;
        private System.Windows.Forms.TextBox txtClienteOrRazonSocial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.TextBox txtNeto;
        private System.Windows.Forms.TextBox txtIgv;
        private System.Windows.Forms.TextBox txtDniOrRuc;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cmbProductos;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView gridDetalles;
        private System.Windows.Forms.TabControl tbcVentas;
        private System.Windows.Forms.TabPage tbpVentas;
        private System.Windows.Forms.DataGridView gridVentas;
        private System.Windows.Forms.TabPage tbpNuevaVenta;
        private System.Windows.Forms.TabControl tbcDetalleVenta;
        private System.Windows.Forms.TabPage tbpCliente;
        private System.Windows.Forms.TabPage tbpProductos;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TabPage tbpPago;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtValorBuscado;
        private System.Windows.Forms.Label lblBoletaFactura;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAnadir;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.TextBox txtIdProducto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblNeto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.DataGridViewButtonColumn Detalles;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblMPNeto;
        private System.Windows.Forms.TextBox txtMPIgv;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtMPNeto;
        private System.Windows.Forms.TextBox txtMPSubtotal;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn CImporte;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRDniOrRuc;
        private System.Windows.Forms.TextBox txtRClienteOrRazonSocial;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DataGridView gridResumen;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtRComprobante;
    }
}