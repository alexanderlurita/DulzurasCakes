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
        EntProducto entProducto = new EntProducto();
        EntDetalleVenta entDetalleVenta = new EntDetalleVenta();

        DataTable dt = new DataTable(); //GridVentas
        DataView dv = new DataView(); //ViewVentas
        DataTable dtDetallesVenta = new DataTable(); //Detalles de una venta
        DataTable resultado = new DataTable();
        string valorBuscar;

        frmDetalleVenta frmdetalleventa = new frmDetalleVenta();

        MdRegistro modalcliente = new MdRegistro();
        MdEmpresa modalempresa = new MdEmpresa();

        public frmVenta()
        {
            InitializeComponent();
        }

        private void cargarDatos()
        {
            dt = venta.listar();
            gridVentas.DataSource = dt;

            gridVentas.Columns["idventa"].DisplayIndex = 0;
            gridVentas.Columns["cliente"].DisplayIndex = 1;
            gridVentas.Columns["razonsocial"].DisplayIndex = 2;
            gridVentas.Columns["vendedor"].DisplayIndex = 3;
            gridVentas.Columns["fechaventa"].DisplayIndex = 4;

            //Formateando columnas
            gridVentas.Columns["idventa"].Width = 100;
            gridVentas.Columns["cliente"].Width = 200;
            gridVentas.Columns["razonsocial"].Width = 200;
            gridVentas.Columns["vendedor"].Width = 90;
            gridVentas.Columns["fechaventa"].Width = 113;

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

        private void calcularPagos()
        {
            float suma = 0;
            foreach (DataGridViewRow row in gridDetalles.Rows)
            {
                if (row.Cells["CImporte"].Value != null)
                {
                    suma += (float)row.Cells["CImporte"].Value;
                }
            }


            lblNeto.Text = $"S/. {suma}";
            txtNeto.Text = Convert.ToString(suma);

            //igv
            double neto = Convert.ToDouble(txtNeto.Text);
            double igv = neto * 0.18;
            txtIgv.Text = Convert.ToString(igv);

            //subtotal
            double subtotal = neto - igv;
            txtSubtotal.Text = Convert.ToString(subtotal);
        }

        private void frmVenta_Load(object sender, EventArgs e)
        {
            cargarDatos();
            tbcVentas.TabPages.Remove(tbpNuevaVenta);

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

            //Instancia de un boton columna para eliminar
            DataGridViewButtonColumn btncol = new DataGridViewButtonColumn();
            btncol.Name = "Eliminar";
            gridDetalles.Columns.Add(btncol);
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

        private void gridVentas_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {

        }

        private void gridVentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridVentas.Columns[e.ColumnIndex].Name == "Detalles")
            {
                entDetalleVenta.idventa = Convert.ToInt32(gridVentas.CurrentRow.Cells["idventa"].Value.ToString());
                dtDetallesVenta = detalleVenta.listarDetallesVenta(entDetalleVenta);

                if (dtDetallesVenta.Rows.Count > 0)
                {
                    frmdetalleventa.data = dtDetallesVenta;
                    frmdetalleventa.ShowDialog();
                    //foreach (DataRow detalles in dtDetallesVenta.Rows)
                    //{    
                    //    neto += (float)Convert.ToDecimal(detalles["precioventa"].ToString());
                    //}

                    //Dialogo.Informar(neto.ToString());
                }
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            tbcVentas.TabPages.Clear();
            tbcVentas.TabPages.Add(tbpNuevaVenta);
            tbcDetalleVenta.TabPages.Clear();
            tbcDetalleVenta.TabPages.Add(tbpCliente);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            cargarDatos();
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
            if (rbtnBoleta.Checked)
            {
                modalcliente.WindowState = FormWindowState.Normal;
                modalcliente.ShowDialog();
            }
            else
            {
                modalempresa.WindowState = FormWindowState.Normal;
                modalempresa.ShowDialog();
            }
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
            if (cmbProductos.SelectedIndex == -1)
            {
                Dialogo.Informar("Seleccione un producto para continuar.");
            }
            else
            {
                int idproducto = Convert.ToInt32(txtIdProducto.Text);
                string producto = cmbProductos.Text;
                float precio = (float)Convert.ToDecimal(txtPrecio.Text);
                float cantidad = (float)Convert.ToDecimal(nudCantidad.Value);
                float importe = cantidad * precio;
                if (cantidad > (float)Convert.ToDecimal(txtStock.Text))
                {
                    Dialogo.Informar("La cantidad deseada no se encuentra disponble");
                }
                else
                {
                    gridDetalles.Rows.Add(idproducto, producto, precio, cantidad, importe);
                    calcularPagos();
                    reiniciarDatosProductos();
                }
            }
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            reiniciarDatosProductos();
        }

        private void gridDetalles_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && gridDetalles.Columns[e.ColumnIndex].Name == "Eliminar" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                DataGridViewButtonCell celbutton = gridDetalles.Rows[e.RowIndex].Cells["Eliminar"] as DataGridViewButtonCell;
                Icon icono = new Icon(Environment.CurrentDirectory + @"\borrar.ico");
                e.Graphics.DrawIcon(icono, e.CellBounds.Left + 25, e.CellBounds.Top + 5);
                gridDetalles.Rows[e.RowIndex].Height = icono.Height + 8;
                gridDetalles.Columns[e.ColumnIndex].Width = icono.Width + 50;
                e.Handled = true;
            }
        }

        private void gridDetalles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridDetalles.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                gridDetalles.Rows.RemoveAt(entVenta.idventa);
                calcularPagos();
            }
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
        }

        private void cmbMedioPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            entVenta.idtipopago = Convert.ToInt16(cmbMedioPago.SelectedValue.ToString());
        }

        
    }
}
