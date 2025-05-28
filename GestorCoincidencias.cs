using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalPOO
{
    // Clase que gestiona las personas disponibles y aplica filtros para mostrar coincidencias.
    public class GestorCoincidencias
    {
        // Lista que contiene todas las personas disponibles.
        private List<Persona> todasLasPersonas;
        // Lista con las personas filtradas según género u otros criterios.
        private List<Persona> personasFiltradas;
        //Índice que indica cuál persona se está mostrando actualmente.
        private int indiceActual = 0;


        // Constructor: se ejecuta automáticamente al crear un objeto GestorCoincidencias.
        // Aquí se inicializa la lista de personas con datos de ejemplo.
        public GestorCoincidencias()
        {
            todasLasPersonas = new List<Persona>
            {
                new Persona("Manuel Vélez",   28, "Medellín",    "Hombre", Properties.Resources.matchman),
                new Persona("Sofía Torres",   25, "Envigado",    "Mujer",  Properties.Resources.matchwoman),
                new Persona("Carlos Mejía",   30, "Sabaneta",    "Hombre", Properties.Resources.matchman2),
                new Persona("Laura Restrepo", 26, "Bello",       "Mujer",  Properties.Resources.matchwoman2),
                new Persona("David Ríos",     32, "Itagüí",      "Hombre", Properties.Resources.matchman3),
                new Persona("Camila Mora",    27, "La Estrella", "Mujer",  Properties.Resources.matchwoman3)
            };
            // Al principio, las personas filtradas son todas las personas disponibles.
            personasFiltradas = new List<Persona>(todasLasPersonas);
            // Se inicia mostrando la primera persona.
            indiceActual = 0;
        }

        // Método que aplica un filtro por género: "Hombres", "Mujeres" o todos.
        public void AplicarFiltro(string filtro)
        {
            // Asegura que la colección no sea null
            if (todasLasPersonas == null)
            {
                return;
            }

            //Aplicacion de LINQ - Programacion funcional
            // Si el filtro es "Hombres", se seleccionan solo personas cuyo género es Hombre.
            if (filtro == "Hombres")
                personasFiltradas = todasLasPersonas.Where(p => p.Genero == "Hombre").ToList();
            else if (filtro == "Mujeres")
                personasFiltradas = todasLasPersonas.Where(p => p.Genero == "Mujer").ToList();
            else
                personasFiltradas = new List<Persona>(todasLasPersonas);
        }

        public Persona ObtenerPersonaActual()
        {
            return indiceActual < personasFiltradas.Count ? personasFiltradas[indiceActual] : null;
        }

        // Avanza al siguiente elemento de la lista filtrada si aún no se ha llegado al final.
        public void AvanzarPersona()
        {
            if (indiceActual < personasFiltradas.Count)
                indiceActual++;
        }

    }
}
