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
    public partial class FormReportesProyectos : Form
    {
        public FormReportesProyectos()
        {
            InitializeComponent();
        }

        private void FormReportesProyectos_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FormReportePersonalContratado formReportePersonalContratado = new FormReportePersonalContratado();
            formReportePersonalContratado.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormReportePresupuestos formReportePresupuestos = new FormReportePresupuestos();
            formReportePresupuestos.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormReporteGanancias formReporteGanancias = new FormReporteGanancias();
            formReporteGanancias.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
