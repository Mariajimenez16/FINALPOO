using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalPOO
{
    public class Perfil : Usuario
    {

        public string RutaFoto { get; set; }

        public Perfil(string nombre, DateTime fechaNacimiento, string genero, string preferenciaCorrer, string nivel, List<string> ubicaciones)
            : base(nombre, fechaNacimiento, genero, preferenciaCorrer, nivel, ubicaciones)
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
