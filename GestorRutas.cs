using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalPOO
{
    public class GestorRutas
    {
        public Dictionary<string, List<Ruta>> rutasPorUbicacion = new Dictionary<string, List<Ruta>>();

        public GestorRutas()
        {

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

        public List<Ruta> ObtenerRutasPorUbicaciones(List<string> ubicacionesSeleccionadas)
        {
            List<Ruta> rutasFiltradas = new List<Ruta>();

            foreach (var ubicacion in ubicacionesSeleccionadas)
            {
                 if (rutasPorUbicacion.ContainsKey(ubicacion))
                 {
                    rutasFiltradas.AddRange(rutasPorUbicacion[ubicacion]);
                 }
            }

            return rutasFiltradas;
        }

    }

}

