using Graficador.Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graficador.UI
{
    public partial class Principal : Form
    {
        private Dibujador dibujador;

        public Principal()
        {
            InitializeComponent();
            dibujador = new Dibujador();
        }

        private void pDibujable_Paint_1(object sender, PaintEventArgs e)
        {
            dibujador.dibujar(e.Graphics, pDibujable.Size);
        }

        private void pDibujable_Resize(object sender, EventArgs e)
        {
            pDibujable.Invalidate();
        }

        private void escalaXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ObtenerNumero on = new ObtenerNumero("Escala X");
            on.ShowDialog();
            if (on.DialogResult == DialogResult.OK)
            {
                dibujador.UnidadesX = on.Numero;
                pDibujable.Invalidate();
            }
        }

        private void escalaYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ObtenerNumero on = new ObtenerNumero("Escala Y");
            on.ShowDialog();
            if (on.DialogResult == DialogResult.OK)
            {
                dibujador.UnidadesY = on.Numero;
                pDibujable.Invalidate();
            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            DialogResult dr = cd.ShowDialog();
            if (dr == DialogResult.OK)
            {
                dibujador.ColorLapiz = cd.Color;
                pDibujable.Invalidate();
            }
        }

        private void fuenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            fd.MinSize = 5;
            DialogResult dr = fd.ShowDialog();
            if (dr == DialogResult.OK)
            {
                dibujador.Fuente = fd.Font;
                pDibujable.Invalidate();
            }
        }

        private void colorFondoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            DialogResult dr = cd.ShowDialog();
            if (dr == DialogResult.OK)
            {
                dibujador.ColorFondo = cd.Color;
                pDibujable.Invalidate();
            }
        }
    }
}
