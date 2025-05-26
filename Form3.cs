using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ProyectoFinalPOO
{
    public partial class Form3 : Form
    {
        private List<Persona> todasLasPersonas;
        private List<Persona> personasFiltradas;
        private int indiceActual = 0;

        public Form3()
        {
            InitializeComponent();

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
            todasLasPersonas = new List<Persona>
            {
                new Persona("Manuel Vélez",   28, "Medellín",    "Hombre", Properties.Resources.matchman),
                new Persona("Sofía Torres",   25, "Envigado",    "Mujer",  Properties.Resources.matchwoman),
                new Persona("Carlos Mejía",   30, "Sabaneta",    "Hombre", Properties.Resources.matchman2),
                new Persona("Laura Restrepo", 26, "Bello",       "Mujer",  Properties.Resources.matchwoman2),
                new Persona("David Ríos",     32, "Itagüí",      "Hombre", Properties.Resources.matchman3),
                new Persona("Camila Mora",    27, "La Estrella", "Mujer",  Properties.Resources.matchwoman3)
            };

            AplicarFiltro();
        }

        private void AplicarFiltro()
        {
            // Asegura que la colección no sea null
            if (todasLasPersonas == null)
            {
               
                return;
            }

            string filtro = comboBoxFiltroGenero.SelectedItem?.ToString() ?? "";

            if (filtro == "Hombres")
            {
                personasFiltradas = todasLasPersonas
                    .Where(p => p.Genero == "Hombre")
                    .ToList();
            }
            else if (filtro == "Mujeres")
            {
                personasFiltradas = todasLasPersonas
                    .Where(p => p.Genero == "Mujer")
                    .ToList();
            }
            else
            {
                personasFiltradas = new List<Persona>(todasLasPersonas); 
            }

            
        }


        private void ComboBoxFiltroGenero_SelectedIndexChanged(object sender, EventArgs e)
        {
            AplicarFiltro();
        }

        private void MostrarPersona()
        {
            if (indiceActual < personasFiltradas.Count)
            {
                Persona p = personasFiltradas[indiceActual];

                labelNombre.Text = p.Nombre;
                labelEdad.Text = "Edad: " + p.Edad;
                labelUbicacion.Text = "Ubicación: " + p.Ubicacion;

                pictureBoxFoto.Image = p.Foto;
                pictureBoxFoto.SizeMode = PictureBoxSizeMode.StretchImage;
                buttonSiguiente.Enabled = true;
            }
            else
            {
                MessageBox.Show("No hay más personas disponibles.");
                buttonSiguiente.Enabled = false;
            }
        }

        private void ButtonSiguiente_Click(object sender, EventArgs e)
        {
            indiceActual++;
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
    }

    public class Persona
    {
        public string Nombre;
        public int Edad;
        public string Ubicacion;
        public string Genero;
        public Image Foto;

        public Persona(string nombre, int edad, string ubicacion, string genero, Image foto)
        {
            Nombre = nombre;
            Edad = edad;
            Ubicacion = ubicacion;
            Genero = genero;
            Foto = foto;
        }
    }
}

