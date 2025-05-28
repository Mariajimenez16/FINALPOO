using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoFinalPOO
{
    //Aquí hay uso de herencia ya que, se creo una clase
    //pública llamada Form4, que está dividida en partes(partial) y
    //hereda de la clase Form, lo que le permite comportarse como una ventana(formulario) en Windows.
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent(); //inicializa todos los controles visuales
                                   //del formulario: botones, textos, colores.
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
            // Al hacer clic, se envía el mensaje "¿que dia estas disponible?" al método Interactuar
            Interactuar("¿Qué día estás disponible?");
        }

        private void BtnHora_Click(object sender, EventArgs e)
        {
            Interactuar("¿A qué hora quieres correr?");
        }

        // Todos esos métodos son privados, significa que solo se puede usar dentro de esta clase (Form4).
        // 'void' indica que el método no retorna ningún valor.
        // 'Form4_Load' es el nombre del método, que se ejecuta automáticamente cuando se carga el formulario.
        // Entre paréntesis se reciben dos parámetros:
        // - 'object sender': representa el objeto que causó el evento (por ejemplo, el formulario).
        // - 'EventArgs e': contiene información adicional del evento (aunque no se use directamente).


        //Aquí si se presiona el botón volver regresa a la pantalla3 que son las opciones para hacer match
        private void BtnVolver_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Close();
        }

        // Método que recibe el mensaje del usuario, lo muestra en el chat,
        // obtiene la respuesta del "match" y la muestra también en el chat
        private void Interactuar(string mensajeUsuario)
        {
            txtChat.AppendText($"\r\nTú: {mensajeUsuario}");
            string respuesta = Responder(mensajeUsuario);
            txtChat.AppendText($"\r\nMatch: {respuesta}\r\n");
        }

        // Método que recibe un mensaje del usuario y devuelve una respuesta según el contenido del mensaje.
        // Utiliza condiciones para identificar palabras clave ("Hola", "día", "hora") y responde en consecuencia.
        // Si el mensaje no contiene ninguna palabra clave reconocida, devuelve un mensaje indicando que no entendió.
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
