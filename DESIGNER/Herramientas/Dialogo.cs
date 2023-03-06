using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DESIGNER.Herramientas
{
    public static class Dialogo
    {
        //Alertas informe simple
        public static void Informar(string mensaje)
        {
            MessageBox.Show(mensaje, "Pasteleria Versión 1.0", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Alerta tipo error
        public static void Error(string mensaje)
        {
            MessageBox.Show(mensaje, "Pasteleria Versión 1.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //Preguntar
        public static DialogResult Preguntar(string mensaje)
        {
            return MessageBox.Show(mensaje, "Pasteleria Versión 1.0", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

    }
}
