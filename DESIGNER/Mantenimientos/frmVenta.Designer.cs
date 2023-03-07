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
            this.tbcVentas = new System.Windows.Forms.TabControl();
            this.tbpVentas = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtValorBuscado = new System.Windows.Forms.TextBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.gridVentas = new System.Windows.Forms.DataGridView();
            this.tbpNuevaVenta = new System.Windows.Forms.TabPage();
            this.btnAtras = new System.Windows.Forms.Button();
            this.tbcDetalleVenta = new System.Windows.Forms.TabControl();
            this.tbpCliente = new System.Windows.Forms.TabPage();
            this.btnAnadir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbpProductos = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIdProducto = new System.Windows.Forms.TextBox();
            this.tbpPago = new System.Windows.Forms.TabPage();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.CIdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CImporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
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
            this.panel1.SuspendLayout();
            this.tbpPago.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
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
            this.rbtnBoleta.TabIndex = 3;
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
            this.rbtnFactura.TabIndex = 0;
            this.rbtnFactura.Text = "Factura";
            this.rbtnFactura.UseVisualStyleBackColor = true;
            this.rbtnFactura.CheckedChanged += new System.EventHandler(this.rbtnFactura_CheckedChanged);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(9, 493);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(115, 46);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(939, 493);
            this.btnSiguiente.Margin = new System.Windows.Forms.Padding(4);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(111, 46);
            this.btnSiguiente.TabIndex = 0;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(19, 107);
            this.lblDni.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(35, 17);
            this.lblDni.TabIndex = 2;
            this.lblDni.Text = "DNI:";
            // 
            // cmbMedioPago
            // 
            this.cmbMedioPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMedioPago.FormattingEnabled = true;
            this.cmbMedioPago.Location = new System.Drawing.Point(159, 51);
            this.cmbMedioPago.Margin = new System.Windows.Forms.Padding(4);
            this.cmbMedioPago.Name = "cmbMedioPago";
            this.cmbMedioPago.Size = new System.Drawing.Size(132, 25);
            this.cmbMedioPago.TabIndex = 7;
            this.cmbMedioPago.SelectedIndexChanged += new System.EventHandler(this.cmbMedioPago_SelectedIndexChanged);
            // 
            // txtClienteOrRazonSocial
            // 
            this.txtClienteOrRazonSocial.Enabled = false;
            this.txtClienteOrRazonSocial.Location = new System.Drawing.Point(177, 128);
            this.txtClienteOrRazonSocial.Margin = new System.Windows.Forms.Padding(4);
            this.txtClienteOrRazonSocial.Name = "txtClienteOrRazonSocial";
            this.txtClienteOrRazonSocial.Size = new System.Drawing.Size(264, 23);
            this.txtClienteOrRazonSocial.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Medio pago:";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(179, 107);
            this.lblCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(58, 17);
            this.lblCliente.TabIndex = 4;
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
            // 
            // txtNeto
            // 
            this.txtNeto.Location = new System.Drawing.Point(99, 249);
            this.txtNeto.Margin = new System.Windows.Forms.Padding(4);
            this.txtNeto.Name = "txtNeto";
            this.txtNeto.ReadOnly = true;
            this.txtNeto.Size = new System.Drawing.Size(132, 23);
            this.txtNeto.TabIndex = 13;
            // 
            // txtIgv
            // 
            this.txtIgv.Location = new System.Drawing.Point(99, 202);
            this.txtIgv.Margin = new System.Windows.Forms.Padding(4);
            this.txtIgv.Name = "txtIgv";
            this.txtIgv.ReadOnly = true;
            this.txtIgv.Size = new System.Drawing.Size(132, 23);
            this.txtIgv.TabIndex = 11;
            // 
            // txtDniOrRuc
            // 
            this.txtDniOrRuc.Location = new System.Drawing.Point(23, 128);
            this.txtDniOrRuc.Margin = new System.Windows.Forms.Padding(4);
            this.txtDniOrRuc.MaxLength = 8;
            this.txtDniOrRuc.Name = "txtDniOrRuc";
            this.txtDniOrRuc.Size = new System.Drawing.Size(135, 23);
            this.txtDniOrRuc.TabIndex = 15;
            this.txtDniOrRuc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDniOrRuc_KeyPress);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(542, 128);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(259, 23);
            this.dateTimePicker1.TabIndex = 17;
            // 
            // cmbProductos
            // 
            this.cmbProductos.FormattingEnabled = true;
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
            this.btnReiniciar.Location = new System.Drawing.Point(536, 162);
            this.btnReiniciar.Margin = new System.Windows.Forms.Padding(4);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(100, 30);
            this.btnReiniciar.TabIndex = 24;
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(536, 124);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(100, 30);
            this.btnAgregar.TabIndex = 25;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
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
            this.gridDetalles.AllowUserToResizeRows = false;
            this.gridDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDetalles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CIdProducto,
            this.CDescripcion,
            this.CPrecio,
            this.CCantidad,
            this.CImporte});
            this.gridDetalles.Location = new System.Drawing.Point(23, 223);
            this.gridDetalles.Margin = new System.Windows.Forms.Padding(4);
            this.gridDetalles.MultiSelect = false;
            this.gridDetalles.Name = "gridDetalles";
            this.gridDetalles.ReadOnly = true;
            this.gridDetalles.RowHeadersVisible = false;
            this.gridDetalles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridDetalles.Size = new System.Drawing.Size(613, 165);
            this.gridDetalles.TabIndex = 30;
            // 
            // tbcVentas
            // 
            this.tbcVentas.Controls.Add(this.tbpVentas);
            this.tbcVentas.Controls.Add(this.tbpNuevaVenta);
            this.tbcVentas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcVentas.Location = new System.Drawing.Point(0, 0);
            this.tbcVentas.Margin = new System.Windows.Forms.Padding(4);
            this.tbcVentas.Name = "tbcVentas";
            this.tbcVentas.SelectedIndex = 0;
            this.tbcVentas.Size = new System.Drawing.Size(1067, 588);
            this.tbcVentas.TabIndex = 31;
            // 
            // tbpVentas
            // 
            this.tbpVentas.Controls.Add(this.groupBox2);
            this.tbpVentas.Controls.Add(this.btnNuevo);
            this.tbpVentas.Controls.Add(this.gridVentas);
            this.tbpVentas.Location = new System.Drawing.Point(4, 26);
            this.tbpVentas.Margin = new System.Windows.Forms.Padding(4);
            this.tbpVentas.Name = "tbpVentas";
            this.tbpVentas.Padding = new System.Windows.Forms.Padding(4);
            this.tbpVentas.Size = new System.Drawing.Size(1059, 558);
            this.tbpVentas.TabIndex = 0;
            this.tbpVentas.Text = "Ventas";
            this.tbpVentas.UseVisualStyleBackColor = true;
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
            this.btnNuevo.Location = new System.Drawing.Point(848, 123);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
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
            this.gridVentas.Location = new System.Drawing.Point(36, 123);
            this.gridVentas.Margin = new System.Windows.Forms.Padding(4);
            this.gridVentas.MultiSelect = false;
            this.gridVentas.Name = "gridVentas";
            this.gridVentas.ReadOnly = true;
            this.gridVentas.RowHeadersVisible = false;
            this.gridVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridVentas.Size = new System.Drawing.Size(732, 297);
            this.gridVentas.TabIndex = 0;
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
            this.tbpNuevaVenta.Size = new System.Drawing.Size(1059, 558);
            this.tbpNuevaVenta.TabIndex = 1;
            this.tbpNuevaVenta.Text = "Nueva venta";
            this.tbpNuevaVenta.UseVisualStyleBackColor = true;
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(821, 493);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(111, 46);
            this.btnAtras.TabIndex = 15;
            this.btnAtras.Text = "Atrás";
            this.btnAtras.UseVisualStyleBackColor = true;
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
            this.tbcDetalleVenta.Size = new System.Drawing.Size(1051, 458);
            this.tbcDetalleVenta.TabIndex = 0;
            // 
            // tbpCliente
            // 
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
            this.tbpCliente.Size = new System.Drawing.Size(1043, 428);
            this.tbpCliente.TabIndex = 0;
            this.tbpCliente.Text = "Datos del cliente";
            this.tbpCliente.UseVisualStyleBackColor = true;
            // 
            // btnAnadir
            // 
            this.btnAnadir.Location = new System.Drawing.Point(437, 128);
            this.btnAnadir.Name = "btnAnadir";
            this.btnAnadir.Size = new System.Drawing.Size(75, 23);
            this.btnAnadir.TabIndex = 21;
            this.btnAnadir.Text = "añadir";
            this.btnAnadir.UseVisualStyleBackColor = true;
            this.btnAnadir.Click += new System.EventHandler(this.btnAnadir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.rbtnFactura);
            this.groupBox1.Controls.Add(this.rbtnBoleta);
            this.groupBox1.Location = new System.Drawing.Point(851, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(185, 85);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 30);
            this.label5.TabIndex = 19;
            this.label5.Text = "BOLETA";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(538, 107);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 17);
            this.label11.TabIndex = 18;
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
            this.tbpProductos.Size = new System.Drawing.Size(1043, 428);
            this.tbpProductos.TabIndex = 1;
            this.tbpProductos.Text = "Selección de productos";
            this.tbpProductos.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.txtIgv);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtNeto);
            this.panel1.Controls.Add(this.txtSubtotal);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(790, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(249, 420);
            this.panel1.TabIndex = 35;
            // 
            // label13
            // 
            this.label13.Dock = System.Windows.Forms.DockStyle.Top;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(0, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(249, 40);
            this.label13.TabIndex = 34;
            this.label13.Text = "S/. NETO";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.tbpPago.Controls.Add(this.btnFinalizar);
            this.tbpPago.Controls.Add(this.cmbMedioPago);
            this.tbpPago.Controls.Add(this.label1);
            this.tbpPago.Location = new System.Drawing.Point(4, 26);
            this.tbpPago.Margin = new System.Windows.Forms.Padding(4);
            this.tbpPago.Name = "tbpPago";
            this.tbpPago.Padding = new System.Windows.Forms.Padding(4);
            this.tbpPago.Size = new System.Drawing.Size(1043, 428);
            this.tbpPago.TabIndex = 2;
            this.tbpPago.Text = "Método de pago";
            this.tbpPago.UseVisualStyleBackColor = true;
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Location = new System.Drawing.Point(885, 351);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(108, 37);
            this.btnFinalizar.TabIndex = 8;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // CIdProducto
            // 
            this.CIdProducto.HeaderText = "ID";
            this.CIdProducto.Name = "CIdProducto";
            this.CIdProducto.ReadOnly = true;
            this.CIdProducto.Width = 50;
            // 
            // CDescripcion
            // 
            this.CDescripcion.HeaderText = "Descripción";
            this.CDescripcion.Name = "CDescripcion";
            this.CDescripcion.ReadOnly = true;
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
            this.nudCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // frmVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 588);
            this.Controls.Add(this.tbcVentas);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tbpPago.ResumeLayout(false);
            this.tbpPago.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAnadir;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.TextBox txtIdProducto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn CImporte;
        private System.Windows.Forms.NumericUpDown nudCantidad;
    }
}