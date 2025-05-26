using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ProyectoFinalPOO;

namespace ProyectoFinalPOO
{
    public partial class Form3 : Form
    {
        private GestorCoincidencias gestorCoincidencias;

        public Form3()
        {
            InitializeComponent();
            gestorCoincidencias = new GestorCoincidencias();

            // Eventos
            this.Load += Form3_Load;
            buttonMatch.Click += ButtonMatch_Click;
            buttonSiguiente.Click += ButtonSiguiente_Click;
            comboBoxFiltroGenero.SelectedIndexChanged += ComboBoxFiltroGenero_SelectedIndexChanged;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // Inicializar ComboBox de filtro
            comboBoxFiltroGenero.Items.AddRange(new string[] { "Todos", "Hombres", "Mujeres" });
            comboBoxFiltroGenero.SelectedIndex = 0; // Por defecto: Todos

            // Inicializar lista completa
            
            MostrarPersona();
        }


        private void ComboBoxFiltroGenero_SelectedIndexChanged(object sender, EventArgs e)
        {
            gestorCoincidencias.AplicarFiltro(comboBoxFiltroGenero.SelectedItem?.ToString() ?? "Todos");
            MostrarPersona();

        }

        private void MostrarPersona()
        {
            Persona p = gestorCoincidencias.ObtenerPersonaActual();
            if (p != null)
            {
                labelNombre.Text = p.Nombre;
                labelEdad.Text = "Edad: " + p.Edad;
                labelUbicacion.Text = "Ubicación: " + p.Ubicacion;
                pictureBoxFoto.Image = p.Foto;
                pictureBoxFoto.SizeMode = PictureBoxSizeMode.StretchImage;
                buttonSiguiente.Enabled = true;
            }
            else
            {
                MessageBox.Show("No hay más personas disponibles.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                buttonSiguiente.Enabled = false;
            }
        }

        private void ButtonSiguiente_Click(object sender, EventArgs e)
        {
            gestorCoincidencias.AvanzarPersona();
            MostrarPersona();

        }

        private void ButtonMatch_Click(object sender, EventArgs e)
        {
            Form4 chat = new Form4();
            chat.Show();
            this.Hide();
        }

        private void pictureBoxFoto_Click(object sender, EventArgs e)
        {
        }

        private void buttonSiguiente_Click_1(object sender, EventArgs e)
        {
          
        }
    }

}

