using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalPOO
{
    public class GestorCoincidencias
    {
        private List<Persona> todasLasPersonas;
        private List<Persona> personasFiltradas;
        private int indiceActual = 0;

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
            personasFiltradas = new List<Persona>(todasLasPersonas);
            indiceActual = 0;
        }

        public void AplicarFiltro(string filtro)
        {
            // Asegura que la colección no sea null
            if (todasLasPersonas == null)
            {
                return;
            }

            //Aplicacion de LINQ - Programacion funcional

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

        public void AvanzarPersona()
        {
            if (indiceActual < personasFiltradas.Count)
                indiceActual++;
        }

    }
}
