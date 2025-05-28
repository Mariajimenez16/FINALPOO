using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalPOO
{
    // Clase que gestiona las rutas disponibles según la ubicación. Usa una relacion de composición con la Clase Ruta.
    public class GestorRutas
    {
        //Atributo tipo Diccionario que almacena las ubicaciones y sus respectivas listas de rutas
        public Dictionary<string, List<Ruta>> rutasPorUbicacion = new Dictionary<string, List<Ruta>>();

        public GestorRutas()  // Constructor que inicializa las rutas disponibles
        {
            // Se agregan las ubicaciones junto con sus rutas correspondientes
            rutasPorUbicacion.Add("Aeroparque Juan Pablo II (Medellín)", new List<Ruta>
            {
                new Ruta("Sugerencia #1", Properties.Resources.JPII_Ruta1),
                new Ruta("Sugerencia #2", Properties.Resources.JPII_Ruta2),
            });

            rutasPorUbicacion.Add("Avenida Las Vegas (Envigado)", new List<Ruta>
            {
                new Ruta("Sugerencia #1", Properties.Resources.LaVegas_Ruta1),
            });

            rutasPorUbicacion.Add("Unidad Deportiva de Belén (Medellín)", new List<Ruta>
            {
                new Ruta("Sugerencia #1", Properties.Resources.UnidadBelen_ruta1),
            });

            rutasPorUbicacion.Add("Cerro El Volador (Medellín)", new List<Ruta>
            {
                new Ruta("Sugerencia #1", Properties.Resources.CVolador_Ruta1),
                new Ruta("Sugerencia #2", Properties.Resources.CVolador_Ruta2),
            });

            rutasPorUbicacion.Add("Cerro Tres Cruces (Medellín)", new List<Ruta>
            {
                 new Ruta("Sugerencia #1", Properties.Resources.TresC_Ruta1),
                 new Ruta("Sugerencia #2", Properties.Resources.TresC_Ruta2),

            });

            rutasPorUbicacion.Add("Ciclovía Manila - Poblado", new List<Ruta>
            {
                 new Ruta("Sugerencia #1", Properties.Resources.Manila_ruta1),
            });

            rutasPorUbicacion.Add("Parque Tulio Ospina (Bello)", new List<Ruta>
            {
                 new Ruta("Sugerencia #1", Properties.Resources.Tospina_Ruta1),
                 new Ruta("Sugerencia #2", Properties.Resources.Tospina_Ruta2_png),
            });

            rutasPorUbicacion.Add("Unidad Deportiva Atanasio Girardot (Medellín)", new List<Ruta>
            {
                 new Ruta("Sugerencia #1", Properties.Resources.Atanasio_Ruta1),
                 new Ruta("Sugerencia #2", Properties.Resources.Atanasio_Ruta2),
            });

        }

        // Método que recibe una lista de ubicaciones seleccionadas en el registro (Form1) y devuelve sus rutas correspondientes
        public List<Ruta> ObtenerRutasPorUbicaciones(List<string> ubicacionesSeleccionadas)
        {
            List<Ruta> rutasFiltradas = new List<Ruta>();   // Lista donde se guardarán las rutas encontradas

            foreach (var ubicacion in ubicacionesSeleccionadas) // Recorre las ubicaciones seleccionadas por el usuario
            {
                if (rutasPorUbicacion.ContainsKey(ubicacion)) // Verifica si la ubicación existe en el diccionario
                {
                    rutasFiltradas.AddRange(rutasPorUbicacion[ubicacion]); // Agrega las rutas de esa ubicación a la lista
                }
            }

            return rutasFiltradas; // Devuelve la lista de rutas filtradas
        }

    }

}

