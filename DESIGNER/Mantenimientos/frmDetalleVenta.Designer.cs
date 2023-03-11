namespace DESIGNER.Mantenimientos
{
    partial class frmDetalleVenta
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
            this.gridDetallesVenta = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.txtIgv = new System.Windows.Forms.TextBox();
            this.txtNeto = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtMetodoPago = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblNeto = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtComprobante = new System.Windows.Forms.TextBox();
            this.txtNroDoc = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridDetallesVenta)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridDetallesVenta
            // 
            this.gridDetallesVenta.AllowUserToAddRows = false;
            this.gridDetallesVenta.AllowUserToDeleteRows = false;
            this.gridDetallesVenta.AllowUserToResizeRows = false;
            this.gridDetallesVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDetallesVenta.Location = new System.Drawing.Point(13, 72);
            this.gridDetallesVenta.Margin = new System.Windows.Forms.Padding(4);
            this.gridDetallesVenta.Name = "gridDetallesVenta";
            this.gridDetallesVenta.ReadOnly = true;
            this.gridDetallesVenta.RowHeadersVisible = false;
            this.gridDetallesVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.gridDetallesVenta.Size = new System.Drawing.Size(500, 254);
            this.gridDetallesVenta.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "SubTotal:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "IGV:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Neto:";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(109, 184);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(100, 23);
            this.txtSubtotal.TabIndex = 4;
            this.txtSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtIgv
            // 
            this.txtIgv.Location = new System.Drawing.Point(109, 213);
            this.txtIgv.Name = "txtIgv";
            this.txtIgv.ReadOnly = true;
            this.txtIgv.Size = new System.Drawing.Size(100, 23);
            this.txtIgv.TabIndex = 4;
            this.txtIgv.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtNeto
            // 
            this.txtNeto.Location = new System.Drawing.Point(109, 242);
            this.txtNeto.Name = "txtNeto";
            this.txtNeto.ReadOnly = true;
            this.txtNeto.Size = new System.Drawing.Size(100, 23);
            this.txtNeto.TabIndex = 4;
            this.txtNeto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtMetodoPago);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lblNeto);
            this.panel1.Controls.Add(this.txtNeto);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtIgv);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtSubtotal);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(520, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(244, 339);
            this.panel1.TabIndex = 5;
            // 
            // txtMetodoPago
            // 
            this.txtMetodoPago.Location = new System.Drawing.Point(29, 92);
            this.txtMetodoPago.Name = "txtMetodoPago";
            this.txtMetodoPago.ReadOnly = true;
            this.txtMetodoPago.Size = new System.Drawing.Size(180, 23);
            this.txtMetodoPago.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Método de pago:";
            // 
            // lblNeto
            // 
            this.lblNeto.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNeto.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNeto.Location = new System.Drawing.Point(0, 0);
            this.lblNeto.Name = "lblNeto";
            this.lblNeto.Size = new System.Drawing.Size(244, 72);
            this.lblNeto.TabIndex = 5;
            this.lblNeto.Text = "S/. 0,00";
            this.lblNeto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(256, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "N° documento:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Comprobante:";
            // 
            // txtComprobante
            // 
            this.txtComprobante.Location = new System.Drawing.Point(12, 40);
            this.txtComprobante.Name = "txtComprobante";
            this.txtComprobante.ReadOnly = true;
            this.txtComprobante.Size = new System.Drawing.Size(211, 23);
            this.txtComprobante.TabIndex = 8;
            // 
            // txtNroDoc
            // 
            this.txtNroDoc.Location = new System.Drawing.Point(259, 40);
            this.txtNroDoc.Name = "txtNroDoc";
            this.txtNroDoc.ReadOnly = true;
            this.txtNroDoc.Size = new System.Drawing.Size(211, 23);
            this.txtNroDoc.TabIndex = 8;
            // 
            // frmDetalleVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 339);
            this.Controls.Add(this.txtNroDoc);
            this.Controls.Add(this.txtComprobante);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gridDetallesVenta);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmDetalleVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDetalleVenta";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmDetalleVenta_FormClosed);
            this.Load += new System.EventHandler(this.frmDetalleVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridDetallesVenta)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridDetallesVenta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.TextBox txtIgv;
        private System.Windows.Forms.TextBox txtNeto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNeto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtComprobante;
        private System.Windows.Forms.TextBox txtNroDoc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMetodoPago;
    }
}