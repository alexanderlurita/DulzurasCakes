namespace DESIGNER
{
    partial class Dashboard
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
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lblNombreusu = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.btnreportes = new System.Windows.Forms.Button();
            this.btnconsulta = new System.Windows.Forms.Button();
            this.btnRegistroventas = new System.Windows.Forms.Button();
            this.btnprincipal = new System.Windows.Forms.Button();
            this.lblrol = new System.Windows.Forms.Label();
            this.FECHA = new System.Windows.Forms.Label();
            this.HORA = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Moccasin;
            this.splitContainer1.Panel1.Controls.Add(this.lblNombreusu);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.btnCerrarSesion);
            this.splitContainer1.Panel1.Controls.Add(this.btnreportes);
            this.splitContainer1.Panel1.Controls.Add(this.btnconsulta);
            this.splitContainer1.Panel1.Controls.Add(this.btnRegistroventas);
            this.splitContainer1.Panel1.Controls.Add(this.btnprincipal);
            this.splitContainer1.Panel1.Controls.Add(this.lblrol);
            this.splitContainer1.Panel1.Controls.Add(this.FECHA);
            this.splitContainer1.Panel1.Controls.Add(this.HORA);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Snow;
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Size = new System.Drawing.Size(800, 407);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 0;
            // 
            // lblNombreusu
            // 
            this.lblNombreusu.AutoSize = true;
            this.lblNombreusu.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreusu.Location = new System.Drawing.Point(133, 137);
            this.lblNombreusu.Name = "lblNombreusu";
            this.lblNombreusu.Size = new System.Drawing.Size(0, 13);
            this.lblNombreusu.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(97, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Dulzura\'s Cakes";
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.Color.Cornsilk;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.Location = new System.Drawing.Point(20, 303);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(236, 30);
            this.btnCerrarSesion.TabIndex = 7;
            this.btnCerrarSesion.Text = "Cerrar Sesion";
            this.btnCerrarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            // 
            // btnreportes
            // 
            this.btnreportes.BackColor = System.Drawing.Color.Cornsilk;
            this.btnreportes.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreportes.Location = new System.Drawing.Point(21, 273);
            this.btnreportes.Name = "btnreportes";
            this.btnreportes.Size = new System.Drawing.Size(237, 31);
            this.btnreportes.TabIndex = 6;
            this.btnreportes.Text = "Reportes";
            this.btnreportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnreportes.UseVisualStyleBackColor = false;
            // 
            // btnconsulta
            // 
            this.btnconsulta.BackColor = System.Drawing.Color.Cornsilk;
            this.btnconsulta.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconsulta.Location = new System.Drawing.Point(20, 243);
            this.btnconsulta.Name = "btnconsulta";
            this.btnconsulta.Size = new System.Drawing.Size(237, 31);
            this.btnconsulta.TabIndex = 5;
            this.btnconsulta.Text = "Consulta de ventas";
            this.btnconsulta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnconsulta.UseVisualStyleBackColor = false;
            // 
            // btnRegistroventas
            // 
            this.btnRegistroventas.BackColor = System.Drawing.Color.Cornsilk;
            this.btnRegistroventas.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistroventas.Location = new System.Drawing.Point(20, 213);
            this.btnRegistroventas.Name = "btnRegistroventas";
            this.btnRegistroventas.Size = new System.Drawing.Size(237, 31);
            this.btnRegistroventas.TabIndex = 4;
            this.btnRegistroventas.Text = "Registro de Ventas";
            this.btnRegistroventas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistroventas.UseVisualStyleBackColor = false;
            // 
            // btnprincipal
            // 
            this.btnprincipal.BackColor = System.Drawing.Color.Cornsilk;
            this.btnprincipal.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprincipal.Location = new System.Drawing.Point(20, 186);
            this.btnprincipal.Name = "btnprincipal";
            this.btnprincipal.Size = new System.Drawing.Size(237, 28);
            this.btnprincipal.TabIndex = 3;
            this.btnprincipal.Text = "Principal";
            this.btnprincipal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnprincipal.UseVisualStyleBackColor = false;
            // 
            // lblrol
            // 
            this.lblrol.AutoSize = true;
            this.lblrol.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrol.Location = new System.Drawing.Point(97, 170);
            this.lblrol.Name = "lblrol";
            this.lblrol.Size = new System.Drawing.Size(99, 13);
            this.lblrol.TabIndex = 2;
            this.lblrol.Text = "ADMINISTRADOR";
            // 
            // FECHA
            // 
            this.FECHA.AutoSize = true;
            this.FECHA.Location = new System.Drawing.Point(159, 413);
            this.FECHA.Name = "FECHA";
            this.FECHA.Size = new System.Drawing.Size(0, 13);
            this.FECHA.TabIndex = 1;
            // 
            // HORA
            // 
            this.HORA.AutoSize = true;
            this.HORA.Location = new System.Drawing.Point(24, 413);
            this.HORA.Name = "HORA";
            this.HORA.Size = new System.Drawing.Size(0, 13);
            this.HORA.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(214, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Bienvenidooooo :D";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 407);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Dashboard_FormClosing);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Button btnreportes;
        private System.Windows.Forms.Button btnconsulta;
        private System.Windows.Forms.Button btnRegistroventas;
        private System.Windows.Forms.Button btnprincipal;
        private System.Windows.Forms.Label lblrol;
        private System.Windows.Forms.Label FECHA;
        private System.Windows.Forms.Label HORA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNombreusu;
    }
}