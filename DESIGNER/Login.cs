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
using CryptSharp;
using DESIGNER.Herramientas;
using DESIGNER.Mantenimientos;
using ENTITIES;

namespace DESIGNER
{
    public partial class Login : Form
    {
        DataTable dtUser = new DataTable();
        EntUsuario entUsuario = new EntUsuario();
        Usuario usuario = new Usuario();

        public int idusuario;
        public Login()
        {
            InitializeComponent();
        }

        private void btniniciosesion_Click(object sender, EventArgs e)
        {
            if (
                txtNombreusuario.Text.Trim() != String.Empty && 
                txtContrasenia.Text.Trim() != String.Empty
                )
            {
                entUsuario.nombreusuario = txtNombreusuario.Text;
                string claveacceso = txtContrasenia.Text;

                dtUser = usuario.iniciarSesion(entUsuario);
                if (dtUser.Rows.Count > 0)
                {
                    string encriptado = dtUser.Rows[0][4].ToString();
                    bool inicioSesion = Crypter.CheckPassword(claveacceso, encriptado);

                    if (inicioSesion)
                    {
                        Dialogo.Informar($"¡Bienvenido {entUsuario.nombreusuario.Trim()}!");
                        Dashboard dashboard = new Dashboard();
                        idusuario = Convert.ToInt16(dtUser.Rows[0][0].ToString());
                        dashboard.lblUsuario.Text = entUsuario.nombreusuario;
                        dashboard.lblrol.Text = dtUser.Rows[0][5].ToString();

                        txtNombreusuario.Clear();
                        txtContrasenia.Clear();
                        txtNombreusuario.Focus();

                        dashboard.Show();
                        this.Hide();
                    }
                    else
                    {
                        Dialogo.Error("Contraseña incorrecta");
                        txtContrasenia.SelectAll();
                        txtContrasenia.Focus();
                    }
                }
                else
                {
                    Dialogo.Error($"No existe el usuario {entUsuario.nombreusuario.Trim()}");
                    txtContrasenia.Clear();
                    txtNombreusuario.SelectAll();
                    txtNombreusuario.Focus();
                }
            }
            else
            {
                Dialogo.Error("Ingrese su nombre de usuario y contraseña");
            }
        }

        private void txtNombreusuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (
                e.KeyChar == Convert.ToChar(Keys.Enter) && 
                txtNombreusuario.Text.Trim() != String.Empty
                )
            {
                txtContrasenia.Focus();
            }
        }
        
        private void txtContrasenia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (
                e.KeyChar == Convert.ToChar(Keys.Enter) &&
                txtContrasenia.Text.Trim() != String.Empty
                )
            {
                btniniciosesion.PerformClick();
            }
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

    }
}
