using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DESIGNER.Mantenimientos
{
    public partial class frmDetalleVenta : Form
    {
        public DataTable data = new DataTable();

        public frmDetalleVenta()
        {
            InitializeComponent();
        }

        private void frmDetalleVenta_Load(object sender, EventArgs e)
        {
            gridDetallesVenta.DataSource = data;
            gridDetallesVenta.ClearSelection();

            gridDetallesVenta.Columns[0].Width = 200;
            gridDetallesVenta.Columns[1].Width = 100;
            gridDetallesVenta.Columns[2].Width = 80;
            gridDetallesVenta.Columns[3].Width = 100;
        }

        
    }
}
