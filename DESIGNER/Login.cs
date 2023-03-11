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
using CryptSharp;


namespace DESIGNER
{
    public partial class Login : Form
    {
        DataTable tabla = new DataTable();
        EntUsuario entUsuario = new EntUsuario();
        Usuario usuario = new Usuario();

        public Login()
        {
            InitializeComponent();
        }


        private void btniniciosesion_Click(object sender, EventArgs e)
        {
            entUsuario.nombreusuario = txtNombreusuario.Text;
            string claveacceso = txtcontraseña.Text;

            tabla = usuario.iniciarSesion(entUsuario);
            if (tabla.Rows.Count > 0)
            {
                string enciptado = tabla.Rows[0][4].ToString();
                bool inicioSesion = Crypter.CheckPassword(claveacceso, enciptado);

                if (inicioSesion)
                {
                    Dialogo.Informar("iniciando.....");
                    Dashboard dashboard = new Dashboard();
                    dashboard.lblUsuario.Text = entUsuario.nombreusuario;
                    dashboard.lblrol.Text = tabla.Rows[0][5].ToString();
                    dashboard.Show();
                    this.Hide();
                }
                else
                {
                    Dialogo.Error("contraseña incorrecta");
                }
            }
            else
            {
                MessageBox.Show("No existe el usuario: " + entUsuario.nombreusuario);
            }
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }



        private void txtcontraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }


    }
}
