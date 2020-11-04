using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectosSoft.CapaPresentacion
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormRegistrarProyecto formRegistrarProyecto = new FormRegistrarProyecto();
            formRegistrarProyecto.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormReportesProyectos formReportesProyectos = new FormReportesProyectos();
            formReportesProyectos.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormRegistrarTrabajador formRegistrarTrabajador = new FormRegistrarTrabajador();
            formRegistrarTrabajador.ShowDialog();
        }
    }
}
