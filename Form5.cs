using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoFinalPOO
{
    public partial class Form5 : Form
    {
        private List<Image> listaImagenes;
        private int indiceActual = 0;

        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            listaImagenes = new List<Image>
            {
                Properties.Resources.BRUNCHA,
                Properties.Resources.BRUNCHB,
                Properties.Resources.BRUNCHC,
                Properties.Resources.BRUNCHD,
                Properties.Resources.BRUNCHE,
                Properties.Resources.BRUNCHG
            };

            pictureBox1.Image = listaImagenes[indiceActual];
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            indiceActual++;
            if (indiceActual >= listaImagenes.Count)
                indiceActual = 0;

            pictureBox1.Image = listaImagenes[indiceActual];
        }
    }
}
