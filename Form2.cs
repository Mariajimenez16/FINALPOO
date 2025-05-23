using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalPOO
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
public class Persona
{
    public string Nombre;
    public int Edad;
    public string Ubicacion;
    public string Genero;

    public Persona(string nombre, int edad, string ubicacion, string genero)
    {
        Nombre = nombre;
        Edad = edad;
        Ubicacion = ubicacion;
        Genero = genero;
    }

    public string MostrarDatos()
    {
        return "Nombre: " + Nombre + ", Edad: " + Edad + ", Ubicación: " + Ubicacion + ", Género: " + Genero;
    }
}

