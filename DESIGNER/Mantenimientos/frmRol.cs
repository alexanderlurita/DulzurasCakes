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
    public partial class frmRol : Form
    {
        Rol rol = new Rol();
        EntRol entRol = new EntRol();
        DataTable dt = new DataTable();
        DataView dv = new DataView();
        public frmRol()
        {
            InitializeComponent();
        }

        private void FormRol_Load(object sender, EventArgs e)
        {
            cargardatos();

            gridRol.Columns[0].Width = 50;
            gridRol.Columns[1].Width = 150;
        }

        private void cargardatos()
        {
            dt = rol.listarRoles();
            gridRol.DataSource = dt;
            if (gridRol.SelectedRows.Count > 0)
            {
                gridRol.SelectedRows[0].Selected = false;
            }

            gridRol.Refresh();
            dv = dt.DefaultView;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string datoRol = txtRol.Text.Trim();

            if(entRol.idrol == 0)
            {
                if(datoRol == string.Empty)
                {
                    Dialogo.Informar("Complete el campo de rol para continuar");
                }
                else
                {
                    if(Dialogo.Preguntar("¿Está seguro de guardar?") == DialogResult.Yes)
                    {
                        entRol.nombreRol = datoRol;
                        if (rol.registrarRol(entRol) > 0)
                        {
                            cargardatos();
                            txtRol.Clear();
                        }
                    }
                }
            }
            if(entRol.idrol > 0)
            {
                if (datoRol == string.Empty)
                {
                    Dialogo.Informar("Complete el campo de rol para continuar");
                }
                else
                {
                    if (Dialogo.Preguntar("¿Está seguro de guardar?") == DialogResult.Yes)
                    {
                        entRol.idrol = entRol.idrol;
                        entRol.nombreRol = datoRol;
                        if (rol.editarRol(entRol) > 0)
                        {
                            cargardatos();
                            txtRol.Clear();
                        }

                        Dialogo.Informar("Datos actualizados correctamente");
                    }
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            btnGuardar.Text = "Actualizar";
            entRol.idrol = Convert.ToInt32(gridRol.SelectedCells[0].Value.ToString());
            DataTable dtresultado = rol.buscarRol(entRol);
            if(dtresultado.Rows.Count > 0)
            {
                txtRol.Text = dtresultado.Rows[0][1].ToString();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtRol.Clear();
        }

        private void txtBuscador_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscador.Text.Trim() != String.Empty)
            {
                dv.RowFilter = "rol LIKE '%" + txtBuscador.Text.Trim() + "%'";
            }
            else
            {
                gridRol.ClearSelection();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            cargardatos();
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            txtBuscador.Clear();
        }
    }
}
