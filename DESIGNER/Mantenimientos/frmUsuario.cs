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
using System.Data.SqlClient;
using DESIGNER.Herramientas;
using ENTITIES;
using CryptSharp;

namespace DESIGNER.Mantenimientos
{
    public partial class frmUsuario : Form
    {
        Usuario usuario =new Usuario();
        Persona  persona = new Persona();
        EntUsuario entUsuario = new EntUsuario();
        Rol rol = new Rol();
        int estado;         // Variable que se le mandará al método listarUsuario
        int filtro = 1; // Variable que nos ayuda con el buscador
        DataTable dt = new DataTable(); // Contener  los registros obtenidos desde la db
        DataView dv = new DataView(); // objeto que permite filtros asincronos

        public frmUsuario()
        {
            InitializeComponent();
        }

        private void FormUsuario_Load(object sender, EventArgs e)
        {
            //Insertamos activos e inactivos al combobox
            cmbLista.Items.Insert(0, "Activos");
            cmbLista.SelectedIndex = 0;
            cmbLista.Items.Insert(1, "Eliminados");

            // ComboBox Personas
            DataTable dtpersona = persona.listarPersonas(1);
            //Se crea una instancia de AutoCompleteStringCollection
            AutoCompleteStringCollection registros = new AutoCompleteStringCollection();
            //Recorremos las filas del DataTable para posteriormente añadir a los registros en forma de array
            foreach (DataRow row in dtpersona.Rows)
            {
                registros.Add(Convert.ToString(row["nombrecompleto"]));
            }
            //Se llena el combobox del DataTable y especificamos los datos a mostrar y los valores que tendrán
            cmbPersonas.DataSource = dtpersona;
            cmbPersonas.DisplayMember = "nombrecompleto";
            cmbPersonas.ValueMember = "idpersona";
            //Llenamos la propiedad de Autocomplete para que autocomplete con cada caracter que escribamos
            cmbPersonas.AutoCompleteCustomSource = registros;
            cmbPersonas.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbPersonas.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cmbPersonas.SelectedIndex = -1;

            // ComboBox Roles
            DataTable dtrol = rol.listarRoles();
            AutoCompleteStringCollection registrosRol = new AutoCompleteStringCollection();
            foreach(DataRow row in dtrol.Rows)
            {
                registrosRol.Add(Convert.ToString(row["rol"]));
            }
            cmbRoles.DataSource = dtrol;
            cmbRoles.DisplayMember = "rol";
            cmbRoles.ValueMember = "idrol";
            cmbRoles.AutoCompleteCustomSource = registrosRol;
            cmbRoles.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbRoles.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cmbRoles.SelectedIndex = -1;

            cargarDatos();
        }

        private void cargarDatos()
        {
            dt = usuario.listarUsuarios(estado);
            gridUsuario.DataSource = dt;

            gridUsuario.Columns[0].HeaderText = "ID";
            gridUsuario.Columns[1].HeaderText = "Apellidos";
            gridUsuario.Columns[2].HeaderText = "Nombres";
            gridUsuario.Columns[3].HeaderText = "Rol";
            gridUsuario.Columns[4].HeaderText = "Usuario";
            if (gridUsuario.SelectedRows.Count > 0)
            {
                gridUsuario.SelectedRows[0].Selected = false;
            }

            gridUsuario.Refresh();
            dv = dt.DefaultView;
        }

        private void limpiarForm()
        {
            cmbPersonas.SelectedValue = -1;
            cmbRoles.SelectedValue = -1;
            txtUsuario.Clear();
            txtContraseña.Clear();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int datoPersona = Convert.ToInt32(cmbPersonas.SelectedValue.ToString());  
            int datoRol = Convert.ToInt32(cmbRoles.SelectedValue.ToString());
            string datoUsuario = txtUsuario.Text.Trim();
            string claveOriginal = txtContraseña.Text.Trim();
            string claverEncriptada = Crypter.Blowfish.Crypt(claveOriginal);
            if (entUsuario.idusuario == 0)
            {
                if( datoPersona == 0  ||
                    datoRol == 0 ||
                    datoUsuario == String.Empty ||
                    claverEncriptada == String.Empty)
                {
                    Dialogo.Informar("Complete todos los campos para continuar");
                }
                else
                {
                    if (Dialogo.Preguntar("¿Está seguro de guardar?") == DialogResult.Yes)
                    {
                        entUsuario.idpersona = datoPersona;
                        entUsuario.idrol = datoRol;
                        entUsuario.nombreusuario = datoUsuario;
                        entUsuario.claveacceso = claverEncriptada;

                        if (usuario.registrarUsuario(entUsuario) > 0)
                        {

                            cargarDatos();
                            limpiarForm();
                        }
                    }
                    else
                    {
                        Dialogo.Error("Error, no se logro guardar el registro");
                    }
                }
            }
            if (entUsuario.idusuario > 0)
            {
                if (datoPersona == 0 ||
                   datoRol == 0 ||
                   datoUsuario == String.Empty ||
                   claverEncriptada == String.Empty)
                {
                    Dialogo.Informar("Complete todos los campos para continuar");
                }
                if (Dialogo.Preguntar("¿Está seguro de actualizar?") == DialogResult.Yes)
                {
                    entUsuario.idusuario = entUsuario.idusuario;
                    entUsuario.idpersona = datoPersona;
                    entUsuario.idrol = datoRol;
                    entUsuario.nombreusuario = datoUsuario;
                    entUsuario.claveacceso = claverEncriptada;

                    if (usuario.editarUsuario(entUsuario) > 0)
                    { 
                        cargarDatos();
                        limpiarForm();
                    }

                    Dialogo.Informar("Datos actualizados correctamente");
                }
            }
        }

        private void cmbLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLista.SelectedIndex == 0)
            {
                estado = 1;
                btnEliminar.Text = "Eliminar";
            }
            else
            {
                estado = 0;
                btnEliminar.Text = "Activar";
            }
            cargarDatos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            entUsuario.idusuario = Convert.ToInt32(gridUsuario.SelectedCells[0].Value.ToString());
            DataTable dtResultado = usuario.buscarUsuario(entUsuario);
            bool esActivo = Convert.ToBoolean(dtResultado.Rows[0][7].ToString());

            if (esActivo)
            {
                if (Dialogo.Preguntar("¿Está seguro de eliminar el registro?") == DialogResult.Yes)
                {
                    usuario.eliminarUsuario (entUsuario);
                    Dialogo.Informar("Usuario eliminado con éxito");
                }
            }
            else
            {
                if (Dialogo.Preguntar("¿Está seguro de activar el registro?") == DialogResult.Yes)
                {
                    usuario.activarUsuario(entUsuario);
                    Dialogo.Informar("Usuario activado con éxito");
                }
            }
            cargarDatos();
        }

        private void rbApellidos_CheckedChanged(object sender, EventArgs e)
        {
            filtro = 1;
            txtBuscador.Clear();
        }

        private void rbNombres_CheckedChanged(object sender, EventArgs e)
        {
            filtro = 2;
            txtBuscador.Clear();
        }

        private void rbRol_CheckedChanged(object sender, EventArgs e)
        {
            filtro = 3;
            txtBuscador.Clear();
        }

        private void rbUsuario_CheckedChanged(object sender, EventArgs e)
        {
            filtro = 4;
            txtBuscador.Clear();
        }

        private void txtBuscador_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscador.Text.Trim() != String.Empty && filtro == 1)
            {
                dv.RowFilter = "apellidos LIKE '%" + txtBuscador.Text.Trim() + "%'";
            }
            else if (txtBuscador.Text.Trim() != String.Empty && filtro == 2)
            {
                dv.RowFilter = "nombres LIKE '%" + txtBuscador.Text.Trim() + "%'";
            }
            else if (txtBuscador.Text.Trim() != String.Empty && filtro == 3)
            {
                dv.RowFilter = "rol LIKE '%" + txtBuscador.Text.Trim() + "%'";
            }
            else if (txtBuscador.Text.Trim() != String.Empty && filtro == 4)
            {
                dv.RowFilter = "nombreusuario LIKE '%" + txtBuscador.Text.Trim() + "%'";
            }
            else
            {
                gridUsuario.ClearSelection();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            cargarDatos();
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            txtBuscador.Clear();
            cargarDatos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            btnGuardar.Text = "Actualizar";
            entUsuario.idusuario= Convert.ToInt32(gridUsuario.SelectedCells[0].Value.ToString());
            DataTable dtresultado = usuario.buscarUsuario(entUsuario);
            if (dtresultado.Rows.Count > 0)
            {
                cmbPersonas.SelectedValue = dtresultado.Rows[0][1].ToString();
                cmbRoles.SelectedValue = dtresultado.Rows[0][2].ToString();
                txtUsuario.Text= dtresultado.Rows[0][3].ToString();
                txtContraseña.Text = dtresultado.Rows[0][4].ToString();

            }
        }

        
    }
}
    