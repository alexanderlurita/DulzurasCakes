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

namespace DESIGNER.Modales
{
    public partial class mdEmpresa : Form
    {
        Empresa empresa = new Empresa();
        EntEmpresa entEmpresa = new EntEmpresa();

        public string ruc;

        public mdEmpresa()
        {
            InitializeComponent();
        }
        private void limpiarForm()
        {
            txtrazonsocial.Clear();
            txtruc.Clear();
            txttelefono.Clear();
            txtdireccion.Clear();
            txtcorreo.Clear();
        }

        private void btnañadir_Click(object sender, EventArgs e)
        {
            if (    
                txtrazonsocial.Text.Trim() == String.Empty || 
                txtruc.Text.Trim().Length != 11
                )
            {
                Dialogo.Informar("le faltan completar los campos obligarios");
            }
            else
            {
                entEmpresa.razonSocial = txtrazonsocial.Text;
                entEmpresa.ruc = txtruc.Text;
                ruc = txtruc.Text;
                entEmpresa.direccion = txtdireccion.Text;
                entEmpresa.telefono = txttelefono.Text;
                entEmpresa.email = txtcorreo.Text; 
                if (Dialogo.Preguntar("¿Guardamos Registro?") == DialogResult.Yes)
                {
                    if (empresa.registrarEmpresa(entEmpresa) > 0)
                    {
                        limpiarForm();
                        this.Close();
                    }
                    else
                    {
                        Dialogo.Error("El ruc ya existe");
                    }
                }
            }
        }

    }
}
