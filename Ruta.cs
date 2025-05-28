using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalPOO
{
    //Representación de las rutas por ubicacion dentro del sistema. Usa una relacion de composición con la clase GestorRutas
    //pues una Ruta no existe si no está en esta clase antes. 

    public class Ruta
    {
        //Propiedades de solo lectura para almacenar el nombre de cada ruta y su imagen correpondiente. 
        public string Nombre { get; }
        public Image Imagen { get; }

        //Constructor para poder instanciar la ruta
        public Ruta(string nombre, Image imagen)
        {
            Nombre = nombre;
            Imagen = imagen;
        }
    }

}
