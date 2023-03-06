namespace DESIGNER.Mantenimientos
{
    partial class frmProducto
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
            this.label1 = new System.Windows.Forms.Label();
            this.gridProductosActivos = new System.Windows.Forms.DataGridView();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.tbcMenu = new System.Windows.Forms.TabControl();
            this.tbpActivos = new System.Windows.Forms.TabPage();
            this.tbpInactivos = new System.Windows.Forms.TabPage();
            this.btnActivar = new System.Windows.Forms.Button();
            this.gridProductosInactivos = new System.Windows.Forms.DataGridView();
            this.tbpFormRegistro = new System.Windows.Forms.TabPage();
            this.dtpFechaElaboracion = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.nudStock = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtNomProducto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtValorBuscado = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridProductosActivos)).BeginInit();
            this.tbcMenu.SuspendLayout();
            this.tbpActivos.SuspendLayout();
            this.tbpInactivos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProductosInactivos)).BeginInit();
            this.tbpFormRegistro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStock)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Productos";
            // 
            // gridProductosActivos
            // 
            this.gridProductosActivos.AllowUserToAddRows = false;
            this.gridProductosActivos.AllowUserToDeleteRows = false;
            this.gridProductosActivos.AllowUserToResizeRows = false;
            this.gridProductosActivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProductosActivos.Location = new System.Drawing.Point(19, 26);
            this.gridProductosActivos.MultiSelect = false;
            this.gridProductosActivos.Name = "gridProductosActivos";
            this.gridProductosActivos.ReadOnly = true;
            this.gridProductosActivos.RowHeadersVisible = false;
            this.gridProductosActivos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridProductosActivos.Size = new System.Drawing.Size(805, 323);
            this.gridProductosActivos.TabIndex = 1;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(841, 40);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 2;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(841, 78);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 3;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(841, 116);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // tbcMenu
            // 
            this.tbcMenu.Controls.Add(this.tbpActivos);
            this.tbcMenu.Controls.Add(this.tbpInactivos);
            this.tbcMenu.Controls.Add(this.tbpFormRegistro);
            this.tbcMenu.Location = new System.Drawing.Point(37, 127);
            this.tbcMenu.Name = "tbcMenu";
            this.tbcMenu.SelectedIndex = 0;
            this.tbcMenu.Size = new System.Drawing.Size(936, 432);
            this.tbcMenu.TabIndex = 5;
            this.tbcMenu.SelectedIndexChanged += new System.EventHandler(this.tbcListado_SelectedIndexChanged);
            // 
            // tbpActivos
            // 
            this.tbpActivos.Controls.Add(this.btnEliminar);
            this.tbpActivos.Controls.Add(this.gridProductosActivos);
            this.tbpActivos.Controls.Add(this.btnEditar);
            this.tbpActivos.Controls.Add(this.btnNuevo);
            this.tbpActivos.Location = new System.Drawing.Point(4, 26);
            this.tbpActivos.Name = "tbpActivos";
            this.tbpActivos.Padding = new System.Windows.Forms.Padding(3);
            this.tbpActivos.Size = new System.Drawing.Size(928, 402);
            this.tbpActivos.TabIndex = 0;
            this.tbpActivos.Text = "Activos";
            this.tbpActivos.UseVisualStyleBackColor = true;
            // 
            // tbpInactivos
            // 
            this.tbpInactivos.Controls.Add(this.btnActivar);
            this.tbpInactivos.Controls.Add(this.gridProductosInactivos);
            this.tbpInactivos.Location = new System.Drawing.Point(4, 26);
            this.tbpInactivos.Name = "tbpInactivos";
            this.tbpInactivos.Padding = new System.Windows.Forms.Padding(3);
            this.tbpInactivos.Size = new System.Drawing.Size(928, 402);
            this.tbpInactivos.TabIndex = 1;
            this.tbpInactivos.Text = "Inactivos";
            this.tbpInactivos.UseVisualStyleBackColor = true;
            // 
            // btnActivar
            // 
            this.btnActivar.Location = new System.Drawing.Point(817, 27);
            this.btnActivar.Name = "btnActivar";
            this.btnActivar.Size = new System.Drawing.Size(75, 23);
            this.btnActivar.TabIndex = 1;
            this.btnActivar.Text = "Activar";
            this.btnActivar.UseVisualStyleBackColor = true;
            this.btnActivar.Click += new System.EventHandler(this.btnActivar_Click);
            // 
            // gridProductosInactivos
            // 
            this.gridProductosInactivos.AllowUserToAddRows = false;
            this.gridProductosInactivos.AllowUserToDeleteRows = false;
            this.gridProductosInactivos.AllowUserToResizeRows = false;
            this.gridProductosInactivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProductosInactivos.Location = new System.Drawing.Point(19, 27);
            this.gridProductosInactivos.MultiSelect = false;
            this.gridProductosInactivos.Name = "gridProductosInactivos";
            this.gridProductosInactivos.ReadOnly = true;
            this.gridProductosInactivos.RowHeadersVisible = false;
            this.gridProductosInactivos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridProductosInactivos.Size = new System.Drawing.Size(750, 347);
            this.gridProductosInactivos.TabIndex = 0;
            // 
            // tbpFormRegistro
            // 
            this.tbpFormRegistro.Controls.Add(this.txtPrecio);
            this.tbpFormRegistro.Controls.Add(this.dtpFechaElaboracion);
            this.tbpFormRegistro.Controls.Add(this.label7);
            this.tbpFormRegistro.Controls.Add(this.nudStock);
            this.tbpFormRegistro.Controls.Add(this.label6);
            this.tbpFormRegistro.Controls.Add(this.label5);
            this.tbpFormRegistro.Controls.Add(this.txtDescripcion);
            this.tbpFormRegistro.Controls.Add(this.txtNomProducto);
            this.tbpFormRegistro.Controls.Add(this.label4);
            this.tbpFormRegistro.Controls.Add(this.label3);
            this.tbpFormRegistro.Controls.Add(this.btnCancelar);
            this.tbpFormRegistro.Controls.Add(this.btnGuardar);
            this.tbpFormRegistro.Controls.Add(this.cmbCategoria);
            this.tbpFormRegistro.Controls.Add(this.label2);
            this.tbpFormRegistro.Location = new System.Drawing.Point(4, 26);
            this.tbpFormRegistro.Name = "tbpFormRegistro";
            this.tbpFormRegistro.Padding = new System.Windows.Forms.Padding(3);
            this.tbpFormRegistro.Size = new System.Drawing.Size(928, 402);
            this.tbpFormRegistro.TabIndex = 2;
            this.tbpFormRegistro.Text = "Nuevo producto";
            this.tbpFormRegistro.UseVisualStyleBackColor = true;
            // 
            // dtpFechaElaboracion
            // 
            this.dtpFechaElaboracion.CustomFormat = "";
            this.dtpFechaElaboracion.Location = new System.Drawing.Point(233, 216);
            this.dtpFechaElaboracion.Name = "dtpFechaElaboracion";
            this.dtpFechaElaboracion.Size = new System.Drawing.Size(262, 23);
            this.dtpFechaElaboracion.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(54, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Fecha de elaboración:";
            // 
            // nudStock
            // 
            this.nudStock.Location = new System.Drawing.Point(337, 264);
            this.nudStock.Name = "nudStock";
            this.nudStock.Size = new System.Drawing.Size(120, 23);
            this.nudStock.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(268, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Stock:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Precio:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(57, 122);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(438, 85);
            this.txtDescripcion.TabIndex = 7;
            // 
            // txtNomProducto
            // 
            this.txtNomProducto.Location = new System.Drawing.Point(233, 68);
            this.txtNomProducto.Name = "txtNomProducto";
            this.txtNomProducto.Size = new System.Drawing.Size(261, 23);
            this.txtNomProducto.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Descripción:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombre de producto:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(270, 354);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(84, 23);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(159, 354);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(233, 34);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(261, 25);
            this.cmbCategoria.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Categoria";
            // 
            // txtValorBuscado
            // 
            this.txtValorBuscado.Location = new System.Drawing.Point(6, 23);
            this.txtValorBuscado.Name = "txtValorBuscado";
            this.txtValorBuscado.Size = new System.Drawing.Size(916, 23);
            this.txtValorBuscado.TabIndex = 7;
            this.txtValorBuscado.TextChanged += new System.EventHandler(this.txtValorBuscado_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtValorBuscado);
            this.groupBox1.Location = new System.Drawing.Point(41, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(928, 61);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(113, 264);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 23);
            this.txtPrecio.TabIndex = 16;
            // 
            // frmProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 588);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbcMenu);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProducto";
            this.Load += new System.EventHandler(this.frmProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridProductosActivos)).EndInit();
            this.tbcMenu.ResumeLayout(false);
            this.tbpActivos.ResumeLayout(false);
            this.tbpInactivos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridProductosInactivos)).EndInit();
            this.tbpFormRegistro.ResumeLayout(false);
            this.tbpFormRegistro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStock)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridProductosActivos;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TabControl tbcMenu;
        private System.Windows.Forms.TabPage tbpActivos;
        private System.Windows.Forms.TabPage tbpInactivos;
        private System.Windows.Forms.DataGridView gridProductosInactivos;
        private System.Windows.Forms.Button btnActivar;
        private System.Windows.Forms.TextBox txtValorBuscado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabPage tbpFormRegistro;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNomProducto;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudStock;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpFechaElaboracion;
        private System.Windows.Forms.TextBox txtPrecio;
    }
}