﻿using System;
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
            DateTime fecha;
            DateTime fechaInicio;
            DateTime fechaFin;
            String mensajeError = "";
            if (radioButton1.Enabled)
            {
                if (fechatxt.Text == null || fechatxt.Text == "")
                {
                    mensajeError = mensajeError + "Fecha";
                }
                else
                {
                    fecha = Convert.ToDateTime(fechatxt.Text);
                }

            }
            if (radioButton2.Enabled)
            {

                if (fechaIniciotxt.Text == null || fechaIniciotxt.Text == "")
                {
                    mensajeError = mensajeError + "Fecha Inicio";
                }
                else
                {
                    fechaInicio = Convert.ToDateTime(fechaIniciotxt.Text);
                }

                if (fechaIniciotxt.Text == null || fechaIniciotxt.Text == "")
                {
                    mensajeError = mensajeError + "Fecha Fin";
                }
                else
                {
                    fechaFin = Convert.ToDateTime(fechaFintxt.Text);
                }
            }
            if (!radioButton1.Enabled && !radioButton2.Enabled)
            {
                mensajeError = mensajeError + "\n Elegir un modo de busqueda(este campo es obligatorio)";
            }
        }

        private void ActualizarGrid()
        {

            FormReportePersonalContratado formReportePersonalContratadoGrid = Application.OpenForms.OfType<FormReportePersonalContratado>().FirstOrDefault();

            if (formReportePersonalContratadoGrid != null)  //Si encuentra una instancia abierta
            {               
                formReportePersonalContratadoGrid.Refresh();
            }
        }

        private void fechatxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
