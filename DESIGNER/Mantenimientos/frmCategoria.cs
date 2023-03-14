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
    public partial class frmCategoria : Form
    {
        Categoria categoria = new Categoria();
        EntCategoria entCategoria = new EntCategoria();
        DataTable dt = new DataTable();

        public frmCategoria()
        {
            InitializeComponent();
        }

        private void cargarDatos()
        {
            dt = categoria.listar();
            gridCategorias.DataSource = dt;
            gridCategorias.ClearSelection();
            gridCategorias.Refresh();

            gridCategorias.Columns[0].Width = 100;
            gridCategorias.Columns[1].Width = 370;

            gridCategorias.Columns[0].HeaderText = "ID";
            gridCategorias.Columns[1].HeaderText = "Categoría";
        }

        private void reiniciarForm()
        {
            entCategoria.idcategoria = 0;
            txtCategoria.Clear();
        }

        private void frmCategoria_Load(object sender, EventArgs e)
        {
            cargarDatos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtCategoria.Text.Trim() == String.Empty)
            {
                Dialogo.Informar("Complete el nombre de la categoria por favor");
                return;
            }

            entCategoria.categoria = txtCategoria.Text.Trim();

            if (entCategoria.idcategoria == 0)
            {
                if (Dialogo.Preguntar("¿Seguro de registrar?") == DialogResult.Yes)
                {
                    if (categoria.registrar(entCategoria) > 0)
                    {
                        cargarDatos();
                        reiniciarForm();
                    }
                    else
                    {
                        Dialogo.Error("Error no se pudo guardar el registro");
                    }
                }
            }

            if (entCategoria.idcategoria > 0)
            {
                if (Dialogo.Preguntar("¿Guardar los nuevos datos?") == DialogResult.Yes)
                {
                    if(categoria.editar(entCategoria) > 0)
                    {
                        cargarDatos();
                        reiniciarForm();
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
            if (gridCategorias.SelectedRows.Count == 0)
            {
                Dialogo.Error("Seleccione una categoria para editar.");
                return;
            }

            entCategoria.idcategoria = Convert.ToInt32(gridCategorias.SelectedCells[0].Value.ToString());
            DataTable dtResult = categoria.buscar(entCategoria);
            
            if (dtResult.Rows.Count > 0)
            {
                txtCategoria.Text = dtResult.Rows[0][1].ToString();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            reiniciarForm();
        }
    }
}
