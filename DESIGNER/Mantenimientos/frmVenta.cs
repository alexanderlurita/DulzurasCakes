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
using DESIGNER.Herramientas;
using ENTITIES;

namespace DESIGNER.Mantenimientos
{
    public partial class frmVenta : Form
    {
        Venta venta = new Venta();
        Persona persona = new Persona();
        Empresa empresa = new Empresa();
        Producto producto = new Producto();
        TipoPago tipoPago = new TipoPago();
        DetalleVenta detalleVenta = new DetalleVenta();

        EntVenta entVenta = new EntVenta();
        EntPersona entPersona = new EntPersona();
        EntEmpresa entEmpresa = new EntEmpresa();
        EntTipoPago entTipoPago = new EntTipoPago();
        EntProducto entProducto = new EntProducto();
        EntDetalleVenta entDetalleVenta = new EntDetalleVenta();

        DataTable dt = new DataTable();
        DataView dv = new DataView();
        DataTable resultado = new DataTable();
        string valorBuscar;

        public frmVenta()
        {
            InitializeComponent();
        }

        private void cargarDatos()
        {
            dt = venta.listar();
            gridVentas.DataSource = dt;
            gridVentas.ClearSelection();
            gridVentas.Refresh();

            dv = dt.DefaultView;
        }

        private void reiniciarDatosCliente()
        {
            txtDniOrRuc.Clear();
            txtClienteOrRazonSocial.Clear();
        }

        private void reiniciarDatosProductos()
        {
            txtIdProducto.Clear();
            cmbProductos.SelectedValue = -1;
            txtDescripcion.Clear();
            txtStock.Clear();
            txtPrecio.Clear();
            nudCantidad.Value = 1;
        }

        private void reiniciarDatosPago()
        {

        }

        private void frmVenta_Load(object sender, EventArgs e)
        {
            cargarDatos();
            tbcVentas.TabPages.Remove(tbpNuevaVenta);

            //Formateando columnas
            gridVentas.Columns[0].Width = 100;
            gridVentas.Columns[1].Width = 200;
            gridVentas.Columns[2].Width = 200;
            gridVentas.Columns[3].Width = 90;
            gridVentas.Columns[4].Width = 113;

            //Asignando datos
            entVenta.tipodocumento = "B";
            entVenta.idempresa = 0;

            
            // ComboBox Producto
            DataTable dtProducto = producto.listarActivos();
            AutoCompleteStringCollection registros = new AutoCompleteStringCollection();
            foreach (DataRow row in dtProducto.Rows)
            {
                registros.Add(Convert.ToString(row["nombreproducto"]));
            }
            cmbProductos.DataSource = dtProducto;
            cmbProductos.ValueMember = "idproducto";
            cmbProductos.DisplayMember = "nombreproducto";
            cmbProductos.AutoCompleteCustomSource = registros;
            cmbProductos.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbProductos.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cmbProductos.SelectedValue = -1;

            // ComboBox Medio Pago
            cmbMedioPago.DataSource = tipoPago.listarTipoPagos();
            cmbMedioPago.ValueMember = "idtipopago";
            cmbMedioPago.DisplayMember = "tipopago";

        }

        private void txtValorBuscado_TextChanged(object sender, EventArgs e)
        {
            if (txtValorBuscado.Text.Trim() != String.Empty)
            {
                valorBuscar = txtValorBuscado.Text.Trim();
                dv.RowFilter = $"cliente LIKE '%{valorBuscar}%' OR " +
                               $"razonsocial LIKE '%{valorBuscar}%' OR " +
                               $"vendedor LIKE '%{valorBuscar}%'";
            }
            else
            {
                gridVentas.ClearSelection();
                dt.DefaultView.RowFilter = null;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            tbcVentas.TabPages.Clear();
            tbcVentas.TabPages.Add(tbpNuevaVenta);
            tbcDetalleVenta.TabPages.Clear();
            tbcDetalleVenta.TabPages.Add(tbpCliente);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            reiniciarDatosCliente();

            btnAtras.Visible = false;
            tbcVentas.TabPages.Clear();
            tbcVentas.TabPages.Add(tbpVentas);
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            if (tbcDetalleVenta.SelectedTab == tbpProductos)
            {
                tbcDetalleVenta.TabPages.Clear();
                tbcDetalleVenta.TabPages.Add(tbpCliente);
                btnAtras.Visible = false;
            }
            else if (tbcDetalleVenta.SelectedTab == tbpPago)
            {
                tbcDetalleVenta.TabPages.Clear();
                tbcDetalleVenta.TabPages.Add(tbpProductos);
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (tbcDetalleVenta.SelectedTab == tbpCliente)
            {
                tbcDetalleVenta.TabPages.Clear();
                tbcDetalleVenta.TabPages.Add(tbpProductos);
                btnAtras.Visible = true;
                cmbProductos.SelectedValue = -1;
            }
            else if (tbcDetalleVenta.SelectedTab == tbpProductos)
            {
                tbcDetalleVenta.TabPages.Clear();
                tbcDetalleVenta.TabPages.Add(tbpPago);
                entVenta.idtipopago = 1;
            }
        }

        private void rbtnBoleta_CheckedChanged(object sender, EventArgs e)
        {
            reiniciarDatosCliente();
            entVenta.tipodocumento = "B";
            entVenta.idempresa = 0;
            lblDni.Text = "DNI:";
            txtDniOrRuc.MaxLength = 8;
            lblCliente.Text = "Cliente:";
        }

        private void rbtnFactura_CheckedChanged(object sender, EventArgs e)
        {
            reiniciarDatosCliente();
            entVenta.tipodocumento = "F";
            entVenta.idpersona = 0;
            lblDni.Text = "RUC:";
            txtDniOrRuc.MaxLength = 11;
            lblCliente.Text = "Razón Social:";
        }

        private void txtDniOrRuc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter) && txtDniOrRuc.Text.Trim() != String.Empty)
            {
                if (rbtnBoleta.Checked)
                {
                    entPersona.dni = txtDniOrRuc.Text;
                    resultado = persona.buscarPersonaDni(entPersona);
                    if (resultado.Rows.Count > 0)
                    {
                        entVenta.idpersona = Convert.ToInt32(resultado.Rows[0][0].ToString());
                        txtClienteOrRazonSocial.Text = resultado.Rows[0][1].ToString();
                    }
                    else
                    {
                        Dialogo.Error("No existe en la base de datos.");
                    }
                }
                else
                {
                    entEmpresa.ruc = txtDniOrRuc.Text.Trim();
                    resultado = empresa.buscarEmpresa(entEmpresa);
                    if (resultado.Rows.Count > 0)
                    {
                        entVenta.idempresa = Convert.ToInt32(resultado.Rows[0][0].ToString());
                        txtClienteOrRazonSocial.Text = resultado.Rows[0][1].ToString();
                    }
                    else
                    {
                        Dialogo.Error("No existe en la base de datos.");
                    }
                }
            }
        }

        private void btnAnadir_Click(object sender, EventArgs e)
        {

        }

        private void cmbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            entProducto.idproducto = Convert.ToInt32(cmbProductos.SelectedValue);
            DataTable dtProducto = producto.buscar(entProducto);
            if (dtProducto.Rows.Count > 0)
            {
                txtIdProducto.Text = dtProducto.Rows[0][0].ToString();
                txtDescripcion.Text = dtProducto.Rows[0][3].ToString();
                txtPrecio.Text = dtProducto.Rows[0][5].ToString();
                txtStock.Text = dtProducto.Rows[0][6].ToString();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (
                cmbProductos.SelectedValue.ToString() != String.Empty && 
                nudCantidad.Text.ToString() != String.Empty
                )
            {
                int idproducto = Convert.ToInt32(txtIdProducto.Text);
                string descripcion = txtDescripcion.Text;
                float precio = (float)Convert.ToDecimal(txtPrecio.Text);
                float cantidad = (float)Convert.ToDecimal(nudCantidad.Value);
                float importe = cantidad * entProducto.precio;
                gridDetalles.Rows.Add(idproducto, descripcion, precio, cantidad, importe);
            }
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            reiniciarDatosProductos();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            entVenta.idusuario = 1;
            venta.registrar(entVenta);

            DataTable dtUltimaVenta = venta.getUltimaVenta();
            entDetalleVenta.idventa = Convert.ToInt32(dtUltimaVenta.Rows[0][0].ToString());

            foreach (DataGridViewRow row in gridDetalles.Rows)
            {
                entDetalleVenta.idproducto = Convert.ToInt32(row.Cells["CIdProducto"].Value.ToString());
                entDetalleVenta.cantidad = Convert.ToInt32(row.Cells["CCantidad"].Value.ToString());
                entDetalleVenta.precioventa = (float)Convert.ToDecimal(row.Cells["CPrecio"].Value.ToString());

                detalleVenta.registrar(entDetalleVenta);
            }

            Dialogo.Informar("Venta realizada correctamente");

            //MessageBox.Show(entVenta.idpersona.ToString());
            //MessageBox.Show(entVenta.idempresa.ToString());
            //MessageBox.Show(entVenta.idusuario.ToString());
            //MessageBox.Show(entVenta.idtipopago.ToString());
            //MessageBox.Show(entVenta.tipodocumento.ToString());
            //MessageBox.Show(entVenta.idventa.ToString());

        }

        private void cmbMedioPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            entVenta.idtipopago = Convert.ToInt16(cmbMedioPago.SelectedValue.ToString());
        }
    }
}
