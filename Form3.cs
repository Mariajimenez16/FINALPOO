using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoFinalPOO
{
    public partial class Form3 : Form
    {
        private List<Persona> personas;
        private int indiceActual = 0;

        public Form3()
        {
            InitializeComponent();

            // ✅ Conectar eventos al formulario y botones
            this.Load += Form3_Load;
            buttonMatch.Click += ButtonMatch_Click;
            buttonSiguiente.Click += ButtonSiguiente_Click;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // ✅ Crear la lista de personas
            personas = new List<Persona>
            {
                new Persona("Manuel Vélez",   28, "Medellín",    Properties.Resources.matchman),
                new Persona("Sofía Torres",   25, "Envigado",    Properties.Resources.matchwoman),
                new Persona("Carlos Mejía",   30, "Sabaneta",    Properties.Resources.matchman2),
                new Persona("Laura Restrepo", 26, "Bello",       Properties.Resources.matchwoman2),
                new Persona("David Ríos",     32, "Itagüí",      Properties.Resources.matchman3),
                new Persona("Camila Mora",    27, "La Estrella", Properties.Resources.matchwoman3)
            };

            // Mostrar la primera persona
            MostrarPersona();
        }

        private void MostrarPersona()
        {
            if (indiceActual < personas.Count)
            {
                Persona p = personas[indiceActual];

                labelNombre.Text = p.Nombre;
                labelEdad.Text = "Edad: " + p.Edad;
                labelUbicacion.Text = "Ubicación: " + p.Ubicacion;

                pictureBoxFoto.Image = p.Foto;
                pictureBoxFoto.SizeMode = PictureBoxSizeMode.StretchImage;
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
    }

    // ✅ Clase Persona al final
    public class Persona
    {
        public string Nombre;
        public int Edad;
        public string Ubicacion;
        public Image Foto;

        public Persona(string nombre, int edad, string ubicacion, Image foto)
        {
            Nombre = nombre;
            Edad = edad;
            Ubicacion = ubicacion;
            Foto = foto;
        }
    }
}
