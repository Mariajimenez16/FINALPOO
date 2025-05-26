using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalPOO
{
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
