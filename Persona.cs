using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.Logging;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ProyectoFinalPOO
{
    public class Persona
    {
        //atributos publicos para que se puedan acceder desde fuera de la clase
        public string Nombre;
        public int Edad;
        public string Ubicacion;
        public string Genero;
        public Image Foto;

        public Persona(string nombre, int edad, string ubicacion, string genero, Image foto)
        {
            //este constructor recibe los datos y los asigna a los campos de la clase con estas líneas:
            Nombre = nombre;
            Edad = edad;
            Ubicacion = ubicacion;
            Genero = genero;
            Foto = foto;
            //Así, los valores que recibe el constructor se guardan dentro del objeto que se está creando.
        }
    }
}
