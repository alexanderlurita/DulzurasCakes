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
    public partial class frmTipoPago : Form
    {
        TipoPago tipoPago = new TipoPago();
        EntTipoPago entTipoPago = new EntTipoPago();
        DataTable tabla = new DataTable();
        public frmTipoPago()
        {
            InitializeComponent();
        }

        

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (txtId.Text != "")
                {
                    entTipoPago.idTipopago = Convert.ToInt32(txtId.Text);
                    tabla = tipoPago.buscarTipoPago(entTipoPago);

                    if (tabla.Rows.Count > 0)
                    {
                        txttipopago.Text = tabla.Rows[0][1].ToString();
                    }
                }

            }
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            if (txtId.Text.Trim() == String.Empty)
            {
                Dialogo.Informar("ingrese ID");
            }
            else
            {
                if (Dialogo.Preguntar("¿Editar tipo de pago?") == DialogResult.Yes)
                {
                    entTipoPago.idTipopago = Convert.ToInt32(txtId.Text);
                    entTipoPago.tipoPago = txttipopago.Text;
                }
                if (tipoPago.editarTipoPago(entTipoPago) > 0)
                {
                    
                    txtId.Clear();
                    txttipopago.Clear();
                }
                else
                {
                    Dialogo.Error("Error al editar tipo de pago");
                }
            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (txttipopago.Text.Trim() == String.Empty)
            {
                Dialogo.Informar("Complete informacion");
            }
            else
            {
                if (Dialogo.Preguntar("¿Registrar tipo de pago?") == DialogResult.Yes)
                {
                    entTipoPago.tipoPago = txttipopago.Text.Trim();
                    if (tipoPago.registrarTipoPago(entTipoPago) > 0)
                    {
                        
                        txttipopago.Clear();
                    }
                    else
                    {
                        Dialogo.Error("Error al guardar");
                    }
                }
            }
        }
    }
}
