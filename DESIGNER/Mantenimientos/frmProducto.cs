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
    public partial class frmProducto : Form
    {
        Producto producto = new Producto();
        EntProducto entProducto = new EntProducto();
        DataTable dt1, dt2 = new DataTable();
        DataView dv1, dv2 = new DataView();

        Categoria categoria = new Categoria();

        public frmProducto()
        {
            InitializeComponent();
        }

        private void cargarDatosActivos()
        {
            dt1 = producto.listarActivos();
            gridProductosActivos.DataSource = dt1;
            gridProductosActivos.ClearSelection();
            gridProductosActivos.Refresh();

            gridProductosActivos.Columns[0].Width = 50;
            gridProductosActivos.Columns[1].Width = 90;
            gridProductosActivos.Columns[2].Width = 200;
            gridProductosActivos.Columns[3].Width = 257;
            gridProductosActivos.Columns[4].Width = 113;
            gridProductosActivos.Columns[5].Width = 55;
            gridProductosActivos.Columns[6].Width = 55;

            gridProductosActivos.Columns[0].HeaderText = "ID";
            gridProductosActivos.Columns[1].HeaderText = "Categoria";
            gridProductosActivos.Columns[2].HeaderText = "Producto";
            gridProductosActivos.Columns[3].HeaderText = "Descripción";
            gridProductosActivos.Columns[4].HeaderText = "Fecha elaboración";
            gridProductosActivos.Columns[5].HeaderText = "Precio";
            gridProductosActivos.Columns[6].HeaderText = "Stock";

            dv1 = dt1.DefaultView;
        }

        private void cargarDatosInactivos()
        {
            dt2 = producto.listarInactivos();
            gridProductosInactivos.DataSource = dt2;
            gridProductosInactivos.ClearSelection();
            gridProductosInactivos.Refresh();

            gridProductosInactivos.Columns[0].Width = 50;
            gridProductosInactivos.Columns[1].Width = 90;
            gridProductosInactivos.Columns[2].Width = 200;
            gridProductosInactivos.Columns[3].Width = 257;
            gridProductosInactivos.Columns[4].Width = 113;
            gridProductosInactivos.Columns[5].Width = 55;
            gridProductosInactivos.Columns[6].Width = 55;

            gridProductosInactivos.Columns[0].HeaderText = "ID";
            gridProductosInactivos.Columns[1].HeaderText = "Categoria";
            gridProductosInactivos.Columns[2].HeaderText = "Producto";
            gridProductosInactivos.Columns[3].HeaderText = "Descripción";
            gridProductosInactivos.Columns[4].HeaderText = "Fecha elaboración";
            gridProductosInactivos.Columns[5].HeaderText = "Precio";
            gridProductosInactivos.Columns[6].HeaderText = "Stock";

            dv2 = dt2.DefaultView;
        }

        private void reiniciarForm()
        {
            entProducto.idproducto = 0;
            txtNomProducto.Clear();
            dtpFechaElaboracion.Value = DateTime.Now;
            txtDescripcion.Clear();
            txtPrecio.Clear();
            nudStock.Value = 0;
        }

        private void frmProducto_Load(object sender, EventArgs e)
        {
            cargarDatosActivos();
            cargarDatosInactivos();

            cmbCategoria.DataSource = categoria.listar();
            cmbCategoria.ValueMember = "idcategoria";
            cmbCategoria.DisplayMember = "categoria";

            tbcMenu.TabPages.Remove(tbpFormRegistro);
        }

        private void txtValorBuscado_TextChanged(object sender, EventArgs e)
        {
            if (txtValorBuscado.Text.Trim() != String.Empty)
            {
                if (tbcMenu.SelectedIndex == 0)
                {
                    dv1.RowFilter = $"[idproducto]+[categoria]+[nombreproducto]+[descripcion]+[fechaelaboracion]+[precio]+[stock] LIKE '%{txtValorBuscado.Text.Trim()}%'";
                }
                else
                {
                    dv2.RowFilter = $"[idproducto]+[categoria]+[nombreproducto]+[descripcion]+[fechaelaboracion]+[precio]+[stock] LIKE '%{txtValorBuscado.Text.Trim()}%'";
                }
            }
            else
            {
                gridProductosActivos.ClearSelection();
                dt1.DefaultView.RowFilter = null;
                gridProductosInactivos.ClearSelection();
                dt2.DefaultView.RowFilter = null;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            tbcMenu.TabPages.Clear();
            tbcMenu.TabPages.Add(tbpFormRegistro);
            cmbCategoria.SelectedValue = -1;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (
                cmbCategoria.Text == String.Empty ||
                txtNomProducto.Text.Trim() == String.Empty ||
                txtPrecio.Text.Trim() == String.Empty ||
                nudStock.Value == 0
                )
            {
                Dialogo.Informar("Complete los datos por favor");
                return;
            }

            entProducto.idcategoria = Convert.ToInt32(cmbCategoria.SelectedValue.ToString());
            entProducto.nombreproducto = txtNomProducto.Text.Trim();
            entProducto.descripcion = txtDescripcion.Text.Trim();
            entProducto.fechaelaboracion = dtpFechaElaboracion.Value;
            entProducto.precio = float.Parse(txtPrecio.Text.Trim());
            entProducto.stock = Convert.ToInt16(nudStock.Value);

            if (entProducto.idproducto == 0)
            {
                if (Dialogo.Preguntar("¿Seguro de registrar?") == DialogResult.Yes)
                {
                    if (producto.registrar(entProducto) > 0)
                    {
                        cargarDatosActivos();
                        btnCancelar.PerformClick();
                    }
                    else
                    {
                        Dialogo.Error("Error no se pudo guardar el registro");
                    }
                }
            }

            if (entProducto.idproducto > 0)
            {
                if (Dialogo.Preguntar("¿Guardar los nuevos datos?") == DialogResult.Yes)
                {
                    if (producto.editar(entProducto) > 0)
                    {
                        cargarDatosActivos();
                        btnCancelar.PerformClick();
                    }
                    else
                    {
                        Dialogo.Error("Error no se pudo editar el registro");
                    }
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (gridProductosActivos.SelectedRows.Count == 0)
            {
                Dialogo.Error("Seleccione un producto para editar");
                return;
            }

            entProducto.idproducto = Convert.ToInt32(gridProductosActivos.SelectedCells[0].Value.ToString());
            DataTable dtResult = producto.buscar(entProducto);

            if (dtResult.Rows.Count > 0)
            {
                btnNuevo.PerformClick();
                cmbCategoria.SelectedValue = dtResult.Rows[0][1].ToString();
                txtNomProducto.Text = dtResult.Rows[0][2].ToString();
                txtDescripcion.Text = dtResult.Rows[0][3].ToString();
                dtpFechaElaboracion.Value = Convert.ToDateTime(dtResult.Rows[0][4].ToString());
                txtPrecio.Text = dtResult.Rows[0][5].ToString();
                nudStock.Value = Convert.ToInt16(dtResult.Rows[0][6].ToString());
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            reiniciarForm();
            tbcMenu.TabPages.Clear();
            tbcMenu.TabPages.Add(tbpActivos);
            tbcMenu.TabPages.Add(tbpInactivos);

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (gridProductosActivos.SelectedRows.Count == 0)
            {
                Dialogo.Error("Seleccione un producto para eliminar.");
                return;
            }

            entProducto.idproducto = Convert.ToInt32(gridProductosActivos.SelectedCells[0].Value.ToString());

            if (entProducto.idproducto > 0)
            {
                if (Dialogo.Preguntar("¿Seguro de eliminar?") == DialogResult.Yes)
                {
                    if (producto.eliminar(entProducto) > 0)
                    {
                        Dialogo.Informar("Eliminado correctamente");
                        cargarDatosActivos();
                    }
                    else
                    {
                        Dialogo.Error("Problemas al eliminar");
                    }
                }

            }
        }

        private void btnActivar_Click(object sender, EventArgs e)
        {
            if (gridProductosInactivos.SelectedRows.Count == 0)
            {
                Dialogo.Error("Seleccione un producto para activar.");
                return;
            }

            entProducto.idproducto = Convert.ToInt32(gridProductosInactivos.SelectedCells[0].Value.ToString());

            if (entProducto.idproducto > 0)
            {
                if (Dialogo.Preguntar("¿Seguro de activar?") == DialogResult.Yes)
                {
                    if (producto.activar(entProducto) > 0)
                    {
                        Dialogo.Informar("Activado correctamente");
                        cargarDatosInactivos();
                    }
                    else
                    {
                        Dialogo.Error("Problemas al activar");
                    }
                }

            }
        }

        private void tbcListado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbcMenu.SelectedIndex == 0)
            {
                cargarDatosActivos();
            }
            else
            {
                cargarDatosInactivos();
            }
        }
    
    }
}
