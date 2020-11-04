using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectosSoft.CapaDominio;

namespace ProyectosSoft.CapaPresentacion
{
    public partial class FormReportePersonalContratado : Form
    {
        public FormReportePersonalContratado()
        {
            InitializeComponent();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ActualizarGrid()
        {

            FormReportePersonalContratado formReportePersonalContratadoGrid = Application.OpenForms.OfType<FormReportePersonalContratado>().FirstOrDefault();

            if (formReportePersonalContratadoGrid != null)  //Si encuentra una instancia abierta
            {               
                formReportePersonalContratadoGrid.Refresh();
            }
        }
    }
}
