using BOL;
using DESIGNER.Herramientas;
using ENTITIES;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DESIGNER.Mantenimientos
{
    public partial class fmrventa : Form
    {
        TipoPago tipoPago = new TipoPago();
        Persona persona = new Persona();
        Empresa empresa = new Empresa();
        Producto producto = new Producto();

        EntPersona entPersona = new EntPersona();
        EntEmpresa entEmpresa = new EntEmpresa();
        EntTipoPago entTipoPago = new EntTipoPago();
        EntProducto entProducto = new EntProducto();


        DataTable resultado = new DataTable();

        public fmrventa()
        {
            InitializeComponent();
        }

        private void frmVenta_Load(object sender, EventArgs e)
        {

            // ComboBox Medio Pago
            DataTable dtTipoPAgo = tipoPago.listarTipoPagos();
            //Se crea una instancia de AutoCompleteStringCollection
            AutoCompleteStringCollection registros = new AutoCompleteStringCollection();
            //Recorremos las filas del DataTable para posteriormente añadir a los registros en forma de array
            foreach (DataRow row in dtTipoPAgo.Rows)
            {
                registros.Add(Convert.ToString(row["tipopago"]));
            }
            //Se llena el combobox del DataTable y especificamos los datos a mostrar y los valores que tendrán
            cmbMedioPago.DataSource = dtTipoPAgo;
            cmbMedioPago.DisplayMember = "tipopago";
            cmbMedioPago.ValueMember = "idtipopago";
            //Llenamos la propiedad de Autocomplete para que autocomplete con cada caracter que escribamos
            cmbMedioPago.AutoCompleteCustomSource = registros;
            cmbMedioPago.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbMedioPago.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cmbMedioPago.SelectedIndex = -1;


            // ComboBox Producto
            DataTable dtProducto = producto.listarActivos();
            AutoCompleteStringCollection registros1 = new AutoCompleteStringCollection();
            foreach (DataRow row in dtProducto.Rows)
            {
                registros1.Add(Convert.ToString(row["nombreproducto"]));
            }
            cmbProducto.DataSource = dtProducto;
            cmbProducto.DisplayMember = "nombreproducto";
            cmbProducto.ValueMember = "idproducto";
            cmbProducto.AutoCompleteCustomSource = registros;
            cmbProducto.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbProducto.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cmbProducto.SelectedIndex = -1;

        }

        private void limpiarForm()
        {
            txtDni.Clear();
            txtCliente.Clear();
            txtFactura.Clear();
            cmbMedioPago.SelectedValue = -1;
        }


        private void limpiarFormProducto()
        {
            txtCantidad.Clear();
            txtStock.Clear();
            txtPrecio.Clear();
            cmbProducto.SelectedValue = -1;
            txtDescripcion.Clear();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarForm();
        }

        

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (txtDni.Text != "")
                {
                    entPersona.dni = txtDni.Text;
                    resultado = persona.buscarPersonaDni(entPersona);
                    if (resultado.Rows.Count > 0)
                    {
                        txtCliente.Text = resultado.Rows[0][1].ToString();
                    }
                }
            }
        }

        private void rbFactura_CheckedChanged_1(object sender, EventArgs e)
        {
            txtFactura.Visible = true;
            txtDni.Visible = false;
            lblDni.Text = "RUC: ";
            lblCliente.Text = "Empresa";
        }

        private void rbBoleta_CheckedChanged_1(object sender, EventArgs e)
        {
            txtFactura.Visible = false;
            txtDni.Visible = true;
            lblDni.Text = "DNI: ";
            lblCliente.Text = "Cliente: ";
        }

        private void txtFactura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (txtFactura.Text != "")
                {
                    entEmpresa.ruc = txtFactura.Text;
                    resultado = empresa.buscarEmpresa(entEmpresa);
                    if (resultado.Rows.Count > 0)
                    {
                        txtCliente.Text = resultado.Rows[0][1].ToString();
                    }
                }
            }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            limpiarForm();
        }

        private void cmbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
           
                entProducto.idproducto= Convert.ToInt32(cmbProducto.SelectedIndex);
                DataTable dtProducto = producto.buscar(entProducto);
                if (dtProducto.Rows.Count > 0)
                {
                    txtDescripcion.Text = dtProducto.Rows[0][3].ToString();
                    txtPrecio.Text = dtProducto.Rows[0][5].ToString();
                    txtStock.Text = dtProducto.Rows[0][6].ToString();

            }
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cmbProducto.SelectedValue.ToString() != String.Empty || txtCantidad.Text.ToString() != String.Empty)
            {
                entProducto.precio = (float)Convert.ToDecimal( txtPrecio.Text);
                float cantidad = (float)Convert.ToDecimal(txtCantidad.Text);
                entProducto.descripcion = txtDescripcion.Text;
                float importe =cantidad * entProducto.precio;
                gridDetalle.Rows.Add(cantidad, entProducto.descripcion, entProducto.precio, importe);
                Dialogo.Informar("Agregado...");
            }
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            limpiarFormProducto();
        }

        private void txtNeto_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
