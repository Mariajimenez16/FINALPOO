using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalPOO
{
    //Aquí la clase Perfil que hereda de clase Usuario
    public class Perfil : Usuario
    {
        //el atributo es lista privada que guarda las ubicaciones
        //seleccionadas por el usuario. Al ser private, solo puede usarse dentro de la clase Perfil.
        private List<string> ubicacionesSeleccionadas;

        public string RutaFoto { get; set; }

        public Perfil(string nombre, DateTime fechaNacimiento, string genero, string preferenciaCorrer, string nivel, List<string> ubicaciones)
            : base(nombre, fechaNacimiento, genero, preferenciaCorrer, nivel, ubicaciones)
        {
            RutaFoto = null;
        }

        public Perfil(string nombre, DateTime fechaNacimiento, string genero, string nivel, List<string> ubicaciones)
    : base(nombre, fechaNacimiento, genero, nivel, ubicaciones)
        {
            RutaFoto = null;
        }


        // Método para obtener la imagen de la foto de perfil (o null si no hay)
        public Image ObtenerImagen()
        {
            if (!string.IsNullOrEmpty(RutaFoto) && File.Exists(RutaFoto))
            {
                return Image.FromFile(RutaFoto);
            }
            return null;
        }

        // Método para obtener la edad usando el método estático de Usuario
        public int Edad()
        {
            return CalcularEdad(FechaNacimiento);
        }

        // Métodos para acceder a las propiedades protegidas 
        public string ObtenerNombre()
        {
            return Nombre;
        }

        public string ObtenerGenero()
        {
            return Genero;
        }

        public string ObtenerNivel()
        {
            return Nivel;
        }

    }
}
