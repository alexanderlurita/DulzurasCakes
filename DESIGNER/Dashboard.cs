using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DESIGNER
{
    public partial class Dashboard : Form
    {
        DateTime fechaactual;
        public Dashboard()
        {
            InitializeComponent();
        }
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            fechaactual = DateTime.Now;
            FECHA.Text = fechaactual.ToLongDateString();
            HORA.Text = fechaactual.ToShortTimeString();
        }

        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

    }
}
