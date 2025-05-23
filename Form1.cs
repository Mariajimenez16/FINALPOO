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

        //validar que todos los campos esten llenos antes de darle click
        //al bot�n continuar
        private bool ValidarCampos()
        {
            // Verificar si alg�n campo est� vac�o
            if (string.IsNullOrWhiteSpace(textBoxNombre.Text) ||
                string.IsNullOrWhiteSpace(comboBoxGenero.Text) ||
                string.IsNullOrWhiteSpace(comboBoxPreferencia.Text) ||
                string.IsNullOrWhiteSpace(comboBoxNivel.Text) ||
                dateTimePicker2.Value == DateTime.MinValue ||
                checkedListBoxUbicacion.CheckedItems.Count == 0)
            {
                MessageBox.Show("Por favor, completa todos los campos antes de continuar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void buttonContinuar_Click(object sender, EventArgs e)
        {

            try
            {
                //activar la funci�n de validar campos
                if (!ValidarCampos()) return;

                string nombre = textBoxNombre.Text;
                DateTime fechaNacimiento = dateTimePicker2.Value;
                string genero = comboBoxGenero.SelectedItem?.ToString();
                string preferencia = comboBoxPreferencia.SelectedItem?.ToString();
                string nivel = comboBoxNivel.SelectedItem?.ToString();

                List<string> ubicacionesSeleccionadas = new List<string>();
                foreach (var item in checkedListBoxUbicacion.CheckedItems)
                {
                    ubicacionesSeleccionadas.Add(item.ToString());
                }

                Usuario nuevoUsuario = new Usuario(nombre, fechaNacimiento, genero, preferencia, nivel, ubicacionesSeleccionadas);

                Perfil nuevoPerfil = new Perfil(nombre, fechaNacimiento, genero, preferencia, nivel, ubicacionesSeleccionadas);

                Form2 pantalla2 = new Form2(nuevoPerfil);
                pantalla2.Show();       // Muestra la pantalla 2
                this.Hide();            // Oculta la pantalla actual (Form1)

            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error de Validaci�n", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error al abrir la siguiente pantalla: ESTE ES EL FRONT" + ex.Message);
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
    }
}
