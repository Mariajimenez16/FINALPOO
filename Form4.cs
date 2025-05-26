using System;
using System.Windows.Forms;

namespace ProyectoFinalPOO
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            txtHistorial.Text = "Bienvenido al Chat Simulado.\r\n";
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            string mensajeUsuario = txtMensaje.Text.Trim();

            if (string.IsNullOrEmpty(mensajeUsuario))
            {
                MessageBox.Show("Escribe un mensaje antes de enviarlo.");
                return;
            }

            // Mostrar el mensaje del usuario
            txtHistorial.AppendText("Tú: " + mensajeUsuario + Environment.NewLine);

            // Simular respuesta del "bot"
            string respuesta = RespuestaBot(mensajeUsuario);
            txtHistorial.AppendText("Bot: " + respuesta + Environment.NewLine);

            // Limpiar el campo de entrada
            txtMensaje.Clear();
            txtMensaje.Focus();
        }

        private string RespuestaBot(string mensaje)
        {
            mensaje = mensaje.ToLower();

            if (mensaje.Contains("hola"))
                return "¡Hola! ¿Cómo estás?";
            else if (mensaje.Contains("gracias"))
                return "Con gusto 😊";
            else if (mensaje.Contains("adios") || mensaje.Contains("chao"))
                return "¡Hasta pronto!";
            else
                return "No entendí tu mensaje. 😅";
        }
    }
}
