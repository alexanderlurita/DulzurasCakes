using DESIGNER.Herramientas;
using DESIGNER.Mantenimientos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DESIGNER
{
    public partial class Dashboard : Form
    {
        frmVenta ventas = new frmVenta();
        frmProducto producto = new frmProducto();
        frmCategoria categoria = new frmCategoria();
        frmPersona persona = new frmPersona();
        frmEmpresa empresa = new frmEmpresa();
        frmUsuario usuario = new frmUsuario();
        frmRol rol = new frmRol();
        public Dashboard()
        {
            InitializeComponent();
        }

        private void limpiarPanel()
        {
            if (this.pnlContenido.Controls.Count > 0)
            {
                this.pnlContenido.Controls.RemoveAt(0);
            }
            btnVentas.BackColor = Color.FromArgb(38, 38, 59);
            btnProducto.BackColor = Color.FromArgb(38, 38, 59);
            btnCategoria.BackColor = Color.FromArgb(38, 38, 59);
            btnPersona.BackColor = Color.FromArgb(38, 38, 59);
            btnEmpresa.BackColor = Color.FromArgb(38, 38, 59);
            btnUsuario.BackColor = Color.FromArgb(38, 38, 59);
            btnRol.BackColor = Color.FromArgb(38, 38, 59);
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            limpiarPanel();
            btnVentas.BackColor = Color.FromArgb(219, 217, 248);
            ventas.TopLevel = false;
            pnlContenido.Controls.Add(ventas);
            ventas.Show();
        }

        private void bntCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            limpiarPanel();
            btnProducto.BackColor = Color.FromArgb(219, 217, 248);
            producto.TopLevel = false;
            pnlContenido.Controls.Add(producto);
            producto.Show();
        }

        private void bntCategoria_Click(object sender, EventArgs e)
        {
            limpiarPanel();
            btnCategoria.BackColor = Color.FromArgb(219, 217, 248);
            categoria.TopLevel = false;
            pnlContenido.Controls.Add(categoria);
            categoria.Show();
        }

        private void btnPersona_Click(object sender, EventArgs e)
        {
            limpiarPanel();
            btnPersona.BackColor = Color.FromArgb(219, 217, 248);
            persona.TopLevel = false;
            pnlContenido.Controls.Add(persona);
            persona.Show();
        }

        private void btnEmpresa_Click(object sender, EventArgs e)
        {
            limpiarPanel();
            btnEmpresa.BackColor = Color.FromArgb(219, 217, 248);
            empresa.TopLevel = false;
            pnlContenido.Controls.Add(empresa);
            empresa.Show();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            limpiarPanel();
            btnUsuario.BackColor = Color.FromArgb(219, 217, 248);
            usuario.TopLevel = false;
            pnlContenido.Controls.Add(usuario);
            usuario.Show();
        }

        private void btnRol_Click(object sender, EventArgs e)
        {
            limpiarPanel();
            btnRol.BackColor = Color.FromArgb(219, 217, 248);
            rol.TopLevel = false;
            pnlContenido.Controls.Add(rol);
            rol.Show();
        }

        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(Dialogo.Preguntar("¿Seguro que quiere cerrar sesión?") == DialogResult.Yes)
            {
                Program.login.Show();
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
