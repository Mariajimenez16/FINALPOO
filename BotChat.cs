using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalPOO
{
    public class BotRunner
    {
        public string Responder(string mensaje)
        {
            switch (mensaje)
            {
                case "Hola":
                    return "¡Hola! Me alegra hablar contigo.";
                case "¿Qué día estás disponible?":
                    return "El domingo me va perfecto, ¿te parece?";
                case "¿A qué hora quieres correr?":
                    return "Podemos encontrarnos a las 7:00 a.m. en la ciclovía.";
                default:
                    return "No entendí eso. ¿Puedes repetir?";
            }
        }
    }
}
