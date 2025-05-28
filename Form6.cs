using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalPOO
{
    public partial class Form6 : Form
    {
        private List<string> ubicacionesSeleccionadas;
        private GestorRutas gestorRutas = new GestorRutas();

        public Form6()
        {
            InitializeComponent();
            CargarUbicacionesEnComboBox();

        }

        private void CargarUbicacionesEnComboBox()
        {
            cmbUbicaciones.Items.Clear();

            if (Form1.ubicacionesSeleccionadas != null && Form1.ubicacionesSeleccionadas.Count > 0)
            {
                foreach (string ubicacion in Form1.ubicacionesSeleccionadas)
                {
                    cmbUbicaciones.Items.Add(ubicacion);
                }

                cmbUbicaciones.SelectedIndex = 0; // Seleccionar primera opción
            }
            else
            {
                MessageBox.Show("No hay ubicaciones seleccionadas.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cmbUbicaciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ubicacionSeleccionada = cmbUbicaciones.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(ubicacionSeleccionada))
            {
                List<Ruta> rutas = gestorRutas.ObtenerRutasPorUbicaciones(new List<string> { ubicacionSeleccionada });

                if (rutas.Count > 0)
                {
                    pictureBoxRuta1.Image = rutas[0].Imagen;
                    label4.Text = rutas[0].Nombre;

                    if (rutas.Count > 1)
                    {
                        pictureBoxRuta2.Image = rutas[1].Imagen;
                        label2.Text = rutas[1].Nombre;
                        pictureBoxRuta2.Visible = true;
                        label2.Visible = true;
                    }
                    else
                    {
                        pictureBoxRuta2.Image = null;
                        label2.Text = "";
                        pictureBoxRuta2.Visible = false;
                        label2.Visible = false;
                    }
                }
                else
                {
                    pictureBoxRuta1.Image = null;
                    label4.Text = "";
                    pictureBoxRuta2.Image = null;
                    label2.Text = "";
                    pictureBoxRuta2.Visible = false;
                    label2.Visible = false;
                    MessageBox.Show("No hay rutas disponibles para esta ubicación.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        

        private void pictureBoxRuta1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
