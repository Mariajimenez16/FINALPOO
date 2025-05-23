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
    public partial class Form2 : Form
    {
        private Perfil perfilUsuario;

        public Form2(Perfil perfil)
        {
            InitializeComponent();
            AgregarFoto.Click += AgregarFoto_Click;

            if (perfil == null)
            {
                MessageBox.Show("Error: No se recibió un perfil válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            perfilUsuario = perfil;

            // Cargar datos en los labels al abrir la pantalla
            NombreTexto.Text = perfilUsuario.ObtenerNombre();
            EdadTexto.Text = perfilUsuario.Edad().ToString();
            GeneroTexto.Text = perfilUsuario.ObtenerGenero();
            NivelTexto.Text = perfilUsuario.ObtenerNivel();

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void AgregarFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Archivos de imagen|*.jpg;*.png;*.jpeg",
                Title = "Seleccionar imagen de perfil"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                perfilUsuario.RutaFoto = openFileDialog.FileName;  // Guardamos la ruta de la imagen
                FotoPerfil.Image = Image.FromFile(perfilUsuario.RutaFoto);  // Cargar la imagen directamente
                FotoPerfil.Refresh();
            }


        }

        private void buttonCrearPerfil_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Perfil creado con éxito!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Abrir el siguiente Form
            Form3 coincidenciasForm = new Form3();
            coincidenciasForm.Show();
            this.Hide();

        }
    }
}

