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

        protected string Nombre { get; set; }

        protected DateTime FechaNacimiento { get; set; }

        protected string Genero { get; set; }

        protected string PreferenciaCorrer { get; set; }

        protected string Nivel { get; set; }

        protected List<string> Ubicaciones { get; set; }

        public Usuario(string nombre, DateTime fechaNacimiento, string genero, string preferenciaCorrer, string nivel, List<string> ubicaciones)

        {

            if (!SoloLetrasYEspacios(nombre))

                throw new ArgumentException("El nombre solo debe contener letras y espacios.");

            if (CalcularEdad(fechaNacimiento) < 18)

                throw new ArgumentException("Debes ser mayor de 18 años para registrarte.");

            Nombre = nombre;

            FechaNacimiento = fechaNacimiento;

            Genero = genero;

            PreferenciaCorrer = preferenciaCorrer;

            Nivel = nivel;

            Ubicaciones = ubicaciones;

        }

        public Usuario(string nombre, DateTime fechaNacimiento, string? genero, string? nivel, List<string> ubicacionesSeleccionadas)
        {
            Nombre = nombre;
            FechaNacimiento = fechaNacimiento;
            Genero = genero;
            Nivel = nivel;
            this.ubicacionesSeleccionadas = ubicacionesSeleccionadas;
        }

        public static bool SoloLetrasYEspacios(string texto)

        {

            return texto.All(c => char.IsLetter(c) || c == ' ');

        }

        public static int CalcularEdad(DateTime fechaNacimiento)

        {

            var hoy = DateTime.Today;

            int edad = hoy.Year - fechaNacimiento.Year;

            if (fechaNacimiento.Date > hoy.AddYears(-edad)) edad--;

            return edad;

        }

    }


}
