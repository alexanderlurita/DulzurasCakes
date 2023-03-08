using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BOL;
using ENTITIES;

namespace DESIGNER.Mantenimientos
{
    public partial class frmDetalleVenta : Form
    {
        public DataTable data = new DataTable();
        public int idventa = 0;
        float neto=0, igv=0, subtotal=0;

        DataTable dtVenta, dtTipoPago = new DataTable();

        Venta venta = new Venta();
        EntVenta entVenta = new EntVenta();

        TipoPago tipoPago = new TipoPago();
        EntTipoPago entTipoPago = new EntTipoPago();

        public frmDetalleVenta()
        {
            InitializeComponent();
        }

        private void frmDetalleVenta_Load(object sender, EventArgs e)
        {
            entVenta.idventa = idventa;
            dtVenta = venta.buscar(entVenta);

            entTipoPago.idTipopago = Convert.ToInt32(dtVenta.Rows[0][4].ToString());
            dtTipoPago = tipoPago.buscarTipoPago(entTipoPago);

            txtComprobante.Text = dtVenta.Rows[0][5].ToString() == "B" ? "Boleta" : "Factura";
            txtNroDoc.Text = dtVenta.Rows[0][6].ToString();
            txtMetodoPago.Text = dtTipoPago.Rows[0][1].ToString();

            gridDetallesVenta.DataSource = data;
            gridDetallesVenta.ClearSelection();

            gridDetallesVenta.Columns[0].Width = 200;
            gridDetallesVenta.Columns[1].Width = 100;
            gridDetallesVenta.Columns[2].Width = 80;
            gridDetallesVenta.Columns[3].Width = 100;

            gridDetallesVenta.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            gridDetallesVenta.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            gridDetallesVenta.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            foreach (DataRow filas in data.Rows)
            {
                neto += (float)Convert.ToDecimal(filas["importe"].ToString());
            }

            igv = (float)Convert.ToDecimal(neto * 0.18);
            subtotal = neto - igv;

            lblNeto.Text = $"S/. {neto.ToString("0,0.00")}";

            txtNeto.Text = neto.ToString("0,0.00");
            txtIgv.Text = igv.ToString("0,0.00");
            txtSubtotal.Text = subtotal.ToString("0,0.00");
        }

        private void frmDetalleVenta_FormClosed(object sender, FormClosedEventArgs e)
        {
            neto = 0;
            igv = 0;
            subtotal = 0;
        }


    }
}
