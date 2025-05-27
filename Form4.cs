using System;
using System.Drawing;
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
            txtChat.Text = "👟 Match encontrado. Puedes empezar a chatear con tu pareja para correr.";
        }

        private void BtnHola_Click(object sender, EventArgs e)
        {
            Interactuar("Hola");
        }

        private void BtnDia_Click(object sender, EventArgs e)
        {
            Interactuar("¿Qué día estás disponible?");
        }

        private void BtnHora_Click(object sender, EventArgs e)
        {
            Interactuar("¿A qué hora quieres correr?");
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Close();
        }

        private void Interactuar(string mensajeUsuario)
        {
            txtChat.AppendText($"\r\nTú: {mensajeUsuario}");
            string respuesta = Responder(mensajeUsuario);
            txtChat.AppendText($"\r\nMatch: {respuesta}\r\n");
        }

        private string Responder(string mensaje)
        {
            if (mensaje.Contains("Hola"))
            {
                return "¡Hola! Qué emoción poder correr contigo 🏃‍♀️💬";
            }
            else if (mensaje.Contains("día"))
            {
                return "Podría el sábado o el domingo. ¿Y tú?";
            }
            else if (mensaje.Contains("hora"))
            {
                return "Prefiero por la mañana, ¿te parece a las 7am?";
            }
            else
            {
                return "No entendí bien eso, ¿podrías repetirlo?";
            }
        }
    }
}
