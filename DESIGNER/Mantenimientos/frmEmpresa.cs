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
using DESIGNER.Herramientas;
using System.Data.SqlClient;

namespace DESIGNER.Mantenimientos
{
    public partial class frmEmpresa : Form
    {
        Empresa empresa = new Empresa();
        EntEmpresa entEmpresa = new EntEmpresa();
        DataTable resultado = new DataTable();

        public frmEmpresa()
        {
            InitializeComponent();
        }



        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (txtrazonsocial.Text.Trim() == String.Empty ||
                txtruc.Text.Trim().Length != 11)
            {
                Dialogo.Informar("Complete los 2 primeros campos porfavor");
            }
            else
            {
                if (Dialogo.Preguntar("¿Registrar la empresa?") == DialogResult.Yes)
                {
                    entEmpresa.razonSocial = txtrazonsocial.Text.Trim();
                    entEmpresa.ruc = txtruc.Text.Trim();
                    entEmpresa.direccion = txtdireccion.Text.Trim();
                    entEmpresa.telefono = txtTelefono.Text.Trim();
                    entEmpresa.email = txtemail.Text.Trim();

                    if (empresa.registrarEmpresa(entEmpresa) > 0)
                    {
                        
                        txtrazonsocial.Clear();
                        txtruc.Clear();
                        txtdireccion.Clear();
                        txtTelefono.Clear();
                        txtemail.Clear();
                    }
                    else
                    {
                        Dialogo.Error("Error al guardar");
                    }
                }
            }
        }

        

        

        private void btneditar_Click(object sender, EventArgs e)
        {
            if (txtId.Text.Trim() == String.Empty)
            {
                Dialogo.Informar("Ingrese ID por favor");
            }
            else
            {
                if (Dialogo.Preguntar("¿Editar empresa?") == DialogResult.Yes)
                {
                    entEmpresa.idempresa = Convert.ToInt32(txtId.Text);
                    entEmpresa.razonSocial = txtrazonsocial.Text.Trim();
                    entEmpresa.ruc = txtruc.Text.Trim();
                    entEmpresa.direccion = txtdireccion.Text.Trim();
                    entEmpresa.telefono = txtTelefono.Text.Trim();
                    entEmpresa.email = txtemail.Text.Trim();
                }
                if (empresa.editarEmpresa(entEmpresa) > 0)
                {
                   
                    txtId.Clear();
                    txtrazonsocial.Clear();
                    txtruc.Clear();
                    txtdireccion.Clear();
                    txtTelefono.Clear();
                    txtemail.Clear();
                }
                else
                {
                    Dialogo.Error("Error al editar Registro");
                }

            }
        }

        private void txtruc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (txtruc.Text != "")
                {
                    entEmpresa.ruc = txtruc.Text;
                    resultado = empresa.buscarEmpresa(entEmpresa);
                    if (resultado.Rows.Count > 0)
                    {
                        txtId.Text = resultado.Rows[0][0].ToString();
                        txtrazonsocial.Text = resultado.Rows[0][1].ToString();
                        txtruc.Text = resultado.Rows[0][2].ToString();
                        txtdireccion.Text = resultado.Rows[0][3].ToString();
                        txtTelefono.Text = resultado.Rows[0][4].ToString();
                        txtemail.Text = resultado.Rows[0][5].ToString();
                    }
                }
            }
        }

        private void frmEmpresa_Load(object sender, EventArgs e)
        {
            gridEmpresas.DataSource = empresa.listarEmpresa();
            gridEmpresas.Refresh();
            gridEmpresas.Columns[0].HeaderText = "ID";
            gridEmpresas.Columns[1].HeaderText = "Razon Social";
            gridEmpresas.Columns[2].HeaderText = "RUC";
            gridEmpresas.Columns[3].HeaderText = "Dirección";
            gridEmpresas.Columns[4].HeaderText = "Teléfono";
            gridEmpresas.Columns[5].HeaderText = "Email";
            gridEmpresas.Columns[6].Visible = false;
        }
    }
}
