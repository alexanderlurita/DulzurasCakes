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
    public partial class mdCliente : Form
    {
        Persona persona = new Persona();
        EntPersona entPersona = new EntPersona();

        public string dni;

        public mdCliente()
        {
            InitializeComponent();
        }
        private void limpiarForm()
        {
            txtapellido.Clear();
            txtnombre.Clear();
            txtdni.Clear();
            txttelefono.Clear();
            txtdireccion.Clear();
            txtcorreo.Clear();
        }

        private void btnañadir_Click(object sender, EventArgs e)
        {
            if (
                txtapellido.Text.Trim() == String.Empty || 
                txtnombre.Text.Trim() == String.Empty || 
                txtdni.Text.Trim().Length != 8
                )
            {
                Dialogo.Informar("Le faltan completar los campos obligarios");
            }
            else
            {
                entPersona.apellidos = txtapellido.Text;
                entPersona.nombres = txtnombre.Text;
                entPersona.dni = txtdni.Text;
                dni = txtdni.Text;
                entPersona.direccion = txtdireccion.Text;
                entPersona.telefono = txttelefono.Text;
                entPersona.email = txtcorreo.Text;
 
                if (Dialogo.Preguntar("¿Guardamos Registro?") == DialogResult.Yes)
                {
                    if (persona.registrarPersona(entPersona) > 0)
                    {
                        limpiarForm();
                        this.Close();
                    }
                    else
                    {
                        Dialogo.Error("El Cliente ya se encuentra registrado");
                    }
                }
            }
            
        }
    }
}
