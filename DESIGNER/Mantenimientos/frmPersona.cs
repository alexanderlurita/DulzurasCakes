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
    public partial class frmPersona : Form
    {
        Persona persona = new Persona(); // LLama a la clase
        EntPersona entPersona = new EntPersona(); // LLamamos a las entidades get y set
        int estado;         // Variable que se le mandará al método
        int filtro = 1; // Variable que nos ayuda con el buscador
        DataTable dt = new DataTable(); // Contener  los registros obtenidos desde la db
        DataView dv = new DataView(); // objeto que permite filtros asincronos

        public frmPersona()
        {
            InitializeComponent();
        }

        private void FormPersonas_Load(object sender, EventArgs e)
        {
            //Insertamos activos e inactivos al combobox
            cmbLista.Items.Insert(0, "Activos");
            cmbLista.SelectedIndex = 0;
            cmbLista.Items.Insert(1, "Eliminados");

            cargarDatos();

            //Configuramos el datagrid
            gridPersonas.Columns[0].Width = 25;  // Id
            gridPersonas.Columns[1].Width = 150; // Apellido
            gridPersonas.Columns[2].Width = 60; // Nombres
            gridPersonas.Columns[3].Width = 60; // Dni
            gridPersonas.Columns[4].Width = 150; // direccion
            gridPersonas.Columns[5].Width = 70; // telefono
            gridPersonas.Columns[6].Width = 150; // Email
            gridPersonas.Columns[7].Visible = false; // Apellido y nombres
        }

        private void cargarDatos()
        {
            dt = persona.listarPersonas(estado);
            gridPersonas.DataSource = dt;
            if (gridPersonas.SelectedRows.Count >0)
            {
                gridPersonas.SelectedRows[0].Selected = false;
            }

            gridPersonas.Refresh();
            dv = dt.DefaultView;
        }

        private void limpiarForm()
        {
            txtApellidos.Clear();
            txtNombres.Clear();
            txtDni.Clear();
            txtTelefono.Clear();
            txtDireccion.Clear();
            txtCorreo.Clear();
            btnGuardar.Text = "Guardar";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string datoApellido = txtApellidos.Text.Trim();
            string datoNombre = txtNombres.Text.Trim();
            string datoDni = txtDni.Text.Trim();
            string datoDireccion = txtDireccion.Text.Trim();
            string datoTelefono = txtTelefono.Text.Trim();
            string datocorreo = txtCorreo.Text.Trim();

            if (entPersona.idpersona == 0)
            {
                if (datoApellido == String.Empty)
                {
                    Dialogo.Informar("Complete el campo de apellidos, por favor");
                }
                else if (datoNombre == String.Empty)
                {
                    Dialogo.Informar("Complete el campo de nombres, por favor");
                }
                else if (datoDni.Length != 8)
                {
                    Dialogo.Informar("Complete el campo de dni, por favor");
                }
                else
                {
                    if (Dialogo.Preguntar("¿Está seguro de guardar?") == DialogResult.Yes)
                    {
                        entPersona.apellidos = datoApellido;
                        entPersona.nombres = datoNombre;
                        entPersona.dni =datoDni;
                        entPersona.direccion =datoDireccion;
                        entPersona.telefono = datoTelefono;
                        entPersona.email =datocorreo;

                        if (persona.registrarPersona(entPersona) > 0)
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

            if(entPersona.idpersona > 0)
            {
                if (datoApellido == String.Empty)
                {
                    Dialogo.Informar("Complete el campo de apellidos, por favor");


                }
                else if (datoNombre == String.Empty)
                {
                    Dialogo.Informar("Complete el campo de nombres, por favor");
                }
                else if (datoDni.Length != 8)
                {
                    Dialogo.Informar("Complete el campo de dni, por favor");
                }
                if (Dialogo.Preguntar("¿Está seguro de guardar?") == DialogResult.Yes)
                {
                    entPersona.idpersona = entPersona.idpersona;
                    entPersona.apellidos = datoApellido;
                    entPersona.nombres = datoNombre;
                    entPersona.dni = datoDni;
                    entPersona.direccion = datoDireccion;
                    entPersona.telefono = datoTelefono;
                    entPersona.email = datocorreo;
                    if (persona.editarPersona(entPersona) > 0)
                    {
                        cargarDatos();
                        limpiarForm();
                    }

                    Dialogo.Informar("Datos actualizados correctamente");
                }
            }
               
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            btnGuardar.Text = "Actualizar";
            entPersona.idpersona = Convert.ToInt32(gridPersonas.SelectedCells[0].Value.ToString());
            DataTable dtresultado = persona.buscarPersona(entPersona);
            if(dtresultado.Rows.Count > 0)
            {
                txtApellidos.Text = dtresultado.Rows[0][1].ToString();
                txtNombres.Text = dtresultado.Rows[0][2].ToString();
                txtDni.Text = dtresultado.Rows[0][3].ToString();
                txtDireccion.Text = dtresultado.Rows[0][4].ToString();
                txtTelefono.Text = dtresultado.Rows[0][5].ToString();
                txtCorreo.Text = dtresultado.Rows[0][6].ToString();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
           entPersona.idpersona = Convert.ToInt32(gridPersonas.SelectedCells[0].Value.ToString());
            DataTable dtResultado = persona.buscarPersona(entPersona);
            bool esActivo = Convert.ToBoolean(dtResultado.Rows[0][7].ToString());

            if (esActivo)
            {
                if (Dialogo.Preguntar("¿Está seguro de eliminar este registro?") == DialogResult.Yes)
                {
                    persona.eliminarPersona(entPersona);
                    Dialogo.Informar("Persona eliminada con éxito");
                }
            }
            else
            {
                if (Dialogo.Preguntar("¿Está seguro de activar este registro?") == DialogResult.Yes)
                {
                    persona.activarPersona(entPersona);
                    Dialogo.Informar("Persona activada con éxito");
                }
            }
            cargarDatos();

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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarForm();
        }

        private void rbApellidos_CheckedChanged(object sender, EventArgs e)
        {
            filtro = 1;
            txtBuscador.Clear();
        }

        private void rbDni_CheckedChanged(object sender, EventArgs e)
        {
            filtro = 2;
            txtBuscador.Clear();
        }

        private void txtBuscador_TextChanged(object sender, EventArgs e)
        {
            if(txtBuscador.Text.Trim() != String.Empty && filtro == 1)
            {
                dv.RowFilter = "apellidos LIKE '%" + txtBuscador.Text.Trim() + "%'";
            }
            else if(txtBuscador.Text.Trim() != String.Empty && filtro ==2)
            {
                dv.RowFilter = "dni LIKE '%" + txtBuscador.Text.Trim() + "%'";
            }
            else
            {
                gridPersonas.ClearSelection();
            }
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            txtBuscador.Clear();
            cargarDatos();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            cargarDatos();
        }
    }
}
