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
using CrystalDecisions.CrystalReports.Engine;
using DESIGNER.Herramientas;
using DESIGNER.Modales;
using DESIGNER.Reportes;
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

        mdCliente modalcliente = new mdCliente();
        mdEmpresa modalempresa = new mdEmpresa();

        VisorReporte formulario;
        SaveFileDialog saveFileDialog;

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
            gridVentas.Columns["empresa"].DisplayIndex = 2;
            gridVentas.Columns["vendedor"].DisplayIndex = 3;
            gridVentas.Columns["fechaventa"].DisplayIndex = 4;

            //Formateando columnas
            gridVentas.Columns["idventa"].Width = 80;
            gridVentas.Columns["cliente"].Width = 240;
            gridVentas.Columns["empresa"].Width = 240;
            gridVentas.Columns["vendedor"].Width = 100;
            gridVentas.Columns["fechaventa"].Width = 113;

            gridVentas.Columns["idventa"].HeaderText = "ID";
            gridVentas.Columns["cliente"].HeaderText = "Cliente";
            gridVentas.Columns["empresa"].HeaderText = "Empresa";
            gridVentas.Columns["vendedor"].HeaderText = "Vendedor";
            gridVentas.Columns["fechaventa"].HeaderText = "Fecha de venta";

            gridVentas.ClearSelection();
            gridVentas.Refresh();

            dv = dt.DefaultView;
        }

        private void reiniciarDatosCliente()
        {
            txtDniOrRuc.Clear();
            txtClienteOrRazonSocial.Clear();
            btnAnadirQuitar.Text = "Añadir";
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
            btnSiguiente.Text = "Siguiente";

            gridDetalles.Rows.Clear();
            txtIgv.Clear();
            txtNeto.Clear();
            txtSubtotal.Clear();
            lblNeto.Text = "S/. 0,00";

            gridResumen.Columns.Clear();
            gridResumen.Rows.Clear();

            cmbMedioPago.SelectedValue = 1;
            txtMPSubtotal.Clear();
            txtMPIgv.Clear();
            txtMPNeto.Clear();
            lblMPNeto.Text = "S/. 0,00";
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

            lblNeto.Text = $"S/. {suma.ToString("0,0.00")}";
            txtNeto.Text = suma.ToString("0,0.00");

            //igv
            double neto = Convert.ToDouble(txtNeto.Text);
            double igv = neto * 0.18;
            txtIgv.Text = igv.ToString("0,0.00");

            //subtotal
            double subtotal = neto - igv;
            txtSubtotal.Text = subtotal.ToString("0,0.00");
        }

        private void lanzarReporte(ReportClass reporteVisualizar)
        {
            formulario = new VisorReporte();
            formulario.visorRpt.ReportSource = reporteVisualizar;
            formulario.visorRpt.RefreshReport();
            formulario.ShowDialog();
        }

        private void exportarPDF(ReportClass reporteVisualizar, string titulo)
        {
            saveFileDialog = new SaveFileDialog();

            saveFileDialog.Title = "Exportando datos como PDF";
            saveFileDialog.Filter = "*.PDF|*.pdf";
            saveFileDialog.FileName = "Reporte de " + titulo;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                reporteVisualizar.Refresh();
                reporteVisualizar.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, saveFileDialog.FileName);
            }
        }

        private void frmVenta_Load(object sender, EventArgs e)
        {
            cargarDatos();
            tbcVentas.TabPages.Remove(tbpNuevaVenta);

            //Asignando datos
            entVenta.tipodocumento = "B";
            entVenta.idpersona = 0;
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
                               $"empresa LIKE '%{valorBuscar}%' OR " +
                               $"vendedor LIKE '%{valorBuscar}%'";
            }
            else
            {
                gridVentas.ClearSelection();
                dt.DefaultView.RowFilter = null;
            }
        }

        private void gridVentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridVentas.Columns[e.ColumnIndex].Name == "Detalles")
            {
                entDetalleVenta.idventa = Convert.ToInt32(gridVentas.CurrentRow.Cells["idventa"].Value.ToString());
                dtDetallesVenta = detalleVenta.listarDetallesVenta(entDetalleVenta);

                if (dtDetallesVenta.Rows.Count > 0)
                {
                    frmdetalleventa.idventa = entDetalleVenta.idventa;
                    frmdetalleventa.data = dtDetallesVenta;
                    frmdetalleventa.ShowDialog();
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

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            switch (cmbReportes.Text)
            {
                case "Reporte 1":
                    lanzarReporte(new Reporte01());
                    break;
                case "Reporte 2":
                    lanzarReporte(new Reporte02());
                    break;
                case "Reporte 3":
                    lanzarReporte(new Reporte03());
                    break;
                case "Reporte 4":
                    lanzarReporte(new Reporte04());
                    break;
                default:
                    Dialogo.Informar("Seleccione un reporte para visualizar");
                    break;
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            switch (cmbReportes.Text)
            {
                case "Reporte 1":
                    exportarPDF(new Reporte01(), "Ventas realizadas por usuarios en el último mes");
                    break;
                case "Reporte 2":
                    exportarPDF(new Reporte02(), "Productos vendidos por un usuario por semana");
                    break;
                case "Reporte 3":
                    exportarPDF(new Reporte03(), "Dias de la semana con mayor ventas");
                    break;
                case "Reporte 4":
                    exportarPDF(new Reporte04(), "Productos más vendidos en los últimos 7 días");
                    break;
                default:
                    Dialogo.Informar("Seleccione un reporte para exportar");
                    break;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            reiniciarDatosCliente();
            reiniciarDatosProductos();
            reiniciarDatosPago();

            rbtnBoleta.Checked = true;

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
                btnSiguiente.Text = "Siguiente";
                tbcDetalleVenta.TabPages.Clear();
                tbcDetalleVenta.TabPages.Add(tbpProductos);
                cmbProductos.SelectedValue = -1;

                gridResumen.Columns.Clear();
                gridResumen.Rows.Clear();
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (tbcDetalleVenta.SelectedTab == tbpCliente)
            {
                if (rbtnFactura.Checked == true)
                {
                    if (
                        txtClienteOrRazonSocial.Text.Trim() == String.Empty || 
                        txtDniOrRuc.Text.Trim() == String.Empty
                        )
                    {
                        Dialogo.Informar("Debe de llenar los campos");
                        return;
                    }
                }

                tbcDetalleVenta.TabPages.Clear();
                tbcDetalleVenta.TabPages.Add(tbpProductos);
                btnAtras.Visible = true;
                cmbProductos.SelectedValue = -1;
            }
            else if (tbcDetalleVenta.SelectedTab == tbpProductos)
            {
                if (gridDetalles.Rows.Count > 0)
                {
                    btnSiguiente.Text = "Finalizar venta";

                    tbcDetalleVenta.TabPages.Clear();
                    tbcDetalleVenta.TabPages.Add(tbpPago);
                    entVenta.idtipopago = 1;

                    foreach (DataGridViewColumn cw in gridDetalles.Columns)
                    {
                        if (cw.HeaderText != "Eliminar")
                        {
                            gridResumen.Columns.Add(cw.Name, cw.HeaderText);                        
                        }
                    }
                    foreach (DataGridViewRow rw in gridDetalles.Rows)
                    {
                        gridResumen.Rows.Add(
                            rw.Cells["CIdProducto"].Value.ToString(),
                            rw.Cells["CProducto"].Value.ToString(),
                            rw.Cells["CPrecio"].Value.ToString(),
                            rw.Cells["CCantidad"].Value.ToString(),
                            rw.Cells["CImporte"].Value.ToString()
                        );
                    }

                    txtRClienteOrRazonSocial.Text = txtClienteOrRazonSocial.Text;
                    txtRDniOrRuc.Text = txtDniOrRuc.Text;
                    txtRComprobante.Text = lblBoletaFactura.Text;

                    lblMPNeto.Text = lblNeto.Text;
                    txtMPSubtotal.Text = txtSubtotal.Text;
                    txtMPIgv.Text = txtIgv.Text;
                    txtMPNeto.Text = txtNeto.Text;
                }
                else
                {
                    Dialogo.Informar("Tenga al menos un producto");
                }
            }
            else
            {
                if (Dialogo.Preguntar("¿Finalizar venta?") == DialogResult.Yes)
                {
                    entVenta.idusuario = Program.login.idusuario;
                    venta.registrar(entVenta);

                    DataTable dtUltimaVenta = venta.getUltimaVenta();
                    entDetalleVenta.idventa = Convert.ToInt32(dtUltimaVenta.Rows[0][0].ToString());

                    foreach (DataGridViewRow row in gridDetalles.Rows)
                    {
                        entDetalleVenta.idproducto = Convert.ToInt32(row.Cells["CIdProducto"].Value.ToString());
                        entDetalleVenta.cantidad = Convert.ToInt32(row.Cells["CCantidad"].Value.ToString());
                        entDetalleVenta.precioventa = (float)Convert.ToDecimal(row.Cells["CPrecio"].Value.ToString());

                        detalleVenta.registrar(entDetalleVenta);
                        producto.descontarStock(entDetalleVenta.idproducto, entDetalleVenta.cantidad);
                    }

                    Dialogo.Informar("Venta realizada correctamente");

                    btnCancelar.PerformClick();
                    cargarDatos();
                }
            }
        }

        private void rbtnBoleta_CheckedChanged(object sender, EventArgs e)
        {
            reiniciarDatosCliente();
            entVenta.tipodocumento = "B";
            entVenta.idempresa = 0;
            lblBoletaFactura.Text = "BOLETA";
            lblDni.Text = "DNI:";
            txtDniOrRuc.MaxLength = 8;
            lblCliente.Text = "Cliente:";
        }

        private void rbtnFactura_CheckedChanged(object sender, EventArgs e)
        {
            reiniciarDatosCliente();
            entVenta.tipodocumento = "F";
            entVenta.idpersona = 0;
            lblBoletaFactura.Text = "FACTURA";
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
                        btnAnadirQuitar.Text = "Quitar";
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
                        btnAnadirQuitar.Text = "Quitar";
                    }
                    else
                    {
                        Dialogo.Error("No existe en la base de datos.");
                    }
                }
            }
        }

        private void txtDniOrRuc_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtDniOrRuc.Text, "[^0-9]"))
            {
                txtDniOrRuc.Text = txtDniOrRuc.Text.Remove(txtDniOrRuc.Text.Length - 1);
            }
        }

        private void btnAnadirQuitar_Click(object sender, EventArgs e)
        {
            if (btnAnadirQuitar.Text == "Añadir")
            {
                if (rbtnBoleta.Checked)
                {
                    modalcliente.WindowState = FormWindowState.Normal;
                    modalcliente.ShowDialog();

                    txtDniOrRuc.Text = modalcliente.dni;
                    if (txtDniOrRuc.Text.Trim() != String.Empty)
                    {
                        entPersona.dni = txtDniOrRuc.Text;
                        DataTable dt = persona.buscarPersonaDni(entPersona);
                        txtClienteOrRazonSocial.Text = dt.Rows[0][1].ToString();
                        entVenta.idpersona = Convert.ToInt32(dt.Rows[0][0].ToString());
                        btnAnadirQuitar.Text = "Quitar";
                    }
                }
                else
                {
                    modalempresa.WindowState = FormWindowState.Normal;
                    modalempresa.ShowDialog();

                    txtDniOrRuc.Text = modalempresa.ruc;
                    if (txtDniOrRuc.Text.Trim() != String.Empty)
                    {
                        entEmpresa.ruc = txtDniOrRuc.Text;
                        DataTable dt = empresa.buscarEmpresa(entEmpresa);
                        txtClienteOrRazonSocial.Text = dt.Rows[0][1].ToString();
                        entVenta.idempresa = Convert.ToInt32(dt.Rows[0][0].ToString());
                        btnAnadirQuitar.Text = "Añadir";
                    }
                }
            }
            else
            {
                txtClienteOrRazonSocial.Clear();
                txtDniOrRuc.Clear();
                btnAnadirQuitar.Text = "Añadir";

                entVenta.idpersona = 0;
                entVenta.idempresa = 0;
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
                Icon icono = new Icon(Environment.CurrentDirectory + @"\..\..\Resources\borrar.ico");
                e.Graphics.DrawIcon(icono, e.CellBounds.Left + 19, e.CellBounds.Top + 0);
                gridDetalles.Rows[e.RowIndex].Height = icono.Height + 1;
                gridDetalles.Columns[e.ColumnIndex].Width = icono.Width + 10;
                e.Handled = true;
                gridDetalles.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
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

        private void cmbMedioPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            entVenta.idtipopago = Convert.ToInt16(cmbMedioPago.SelectedValue.ToString());
        }

        
    }
}
