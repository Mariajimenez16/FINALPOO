namespace ProyectoFinalPOO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        // Validar que todos los campos estén llenos antes de darle click al botón continuar
        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(textBoxNombre.Text) ||
                string.IsNullOrWhiteSpace(comboBoxGenero.Text) ||
                string.IsNullOrWhiteSpace(comboBoxNivel.Text) ||
                dateTimePicker2.Value == DateTime.MinValue ||
                checkedListBoxUbicacion.CheckedItems.Count == 0)
            {
                MessageBox.Show("Por favor, completa todos los campos antes de continuar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        public static List<string> ubicacionesSeleccionadas = new List<string>();

        private void buttonContinuar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarCampos()) return;

                ubicacionesSeleccionadas.Clear();

                string nombre = textBoxNombre.Text;
                DateTime fechaNacimiento = dateTimePicker2.Value;
                string genero = comboBoxGenero.SelectedItem?.ToString();
                string nivel = comboBoxNivel.SelectedItem?.ToString();

                
                foreach (var item in checkedListBoxUbicacion.CheckedItems)
                {
                    ubicacionesSeleccionadas.Add(item.ToString());
                }


                // Como ya no se usa "preferencia", puedes pasar null o eliminar ese parámetro en Usuario/Perfil si ya no se necesita
                Usuario nuevoUsuario = new Usuario(nombre, fechaNacimiento, genero, null, nivel, ubicacionesSeleccionadas);
                Perfil nuevoPerfil = new Perfil(nombre, fechaNacimiento, genero, null, nivel, ubicacionesSeleccionadas);

                Form2 pantalla2 = new Form2(nuevoPerfil);
                pantalla2.Show();
                this.Hide();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al abrir la siguiente pantalla: ESTE ES EL FRONT\n" + ex.Message);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkedListBoxUbicacion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void fileSystemWatcher1_Changed(object sender, FileSystemEventArgs e)
        {

        }

        private void comboBoxGenero_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void labelRunMatch_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

