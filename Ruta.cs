using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalPOO
{
    public class Ruta
    {
        public string Nombre { get; }
        public Image Imagen { get; }

        public Ruta(string nombre, Image imagen)
        {
            Nombre = nombre;
            Imagen = imagen;
        }
    }

}
