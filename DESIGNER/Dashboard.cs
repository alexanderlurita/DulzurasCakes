using DESIGNER.Mantenimientos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DESIGNER
{
    public partial class Dashboard : Form
    {
        frmVenta ventas = new frmVenta();

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
            btnVentas.BackColor = Color.FromArgb(246, 247, 249);
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            limpiarPanel();
            btnVentas.BackColor = Color.FromArgb(255, 231, 231);
            ventas.TopLevel = false;
            pnlContenido.Controls.Add(ventas);
            ventas.Show();
        }

        private void bntCerrar_Click(object sender, EventArgs e)
        {

        }
    }
}
