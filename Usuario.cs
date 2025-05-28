using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalPOO
{
    public class Usuario
    {
        private List<string> ubicacionesSeleccionadas;

        //Uso de encapsulamiento para proteger los atributos y controlar el acceso desde otras clases.
        protected string Nombre { get; set; }

        protected DateTime FechaNacimiento { get; set; }

        protected string Genero { get; set; }

        protected string PreferenciaCorrer { get; set; }

        protected string Nivel { get; set; }

        protected List<string> Ubicaciones { get; set; }

        //Constructor de la clase usuario
        public Usuario(string nombre, DateTime fechaNacimiento, string genero, string preferenciaCorrer, string nivel, List<string> ubicaciones)

        {

            if (!SoloLetrasYEspacios(nombre))

                throw new ArgumentException("El nombre solo debe contener letras y espacios.");

            if (CalcularEdad(fechaNacimiento) < 18)

                throw new ArgumentException("Debes ser mayor de 18 años para registrarte.");

            // Estas líneas asignan los valores recibidos por el constructor (los parámetros)
            // a las propiedades internas de la clase. Es decir, guardan los datos que se pasan
            // al crear un nuevo objeto Usuario, para que queden almacenados dentro del objeto.
            Nombre = nombre;

            FechaNacimiento = fechaNacimiento;

            Genero = genero;

            PreferenciaCorrer = preferenciaCorrer;

            Nivel = nivel;

            Ubicaciones = ubicaciones;

        }

        public Usuario(string nombre, DateTime fechaNacimiento, string genero, string nivel, List<string> ubicacionesSeleccionadas)
        {
            Nombre = nombre;
            FechaNacimiento = fechaNacimiento;
            Genero = genero;
            Nivel = nivel;
            this.ubicacionesSeleccionadas = ubicacionesSeleccionadas;
        }

        public static bool SoloLetrasYEspacios(string texto)

        {
            //uso de la expresión lambda:Para cada carácter c, devuelve verdadero si es una letra o un espacio
            return texto.All(c => char.IsLetter(c) || c == ' ');

        }

        //método estático que calcula la edad 
        public static int CalcularEdad(DateTime fechaNacimiento)

        {

            var hoy = DateTime.Today;

            int edad = hoy.Year - fechaNacimiento.Year;

            if (fechaNacimiento.Date > hoy.AddYears(-edad)) edad--;

            return edad;

        }

    }


}
