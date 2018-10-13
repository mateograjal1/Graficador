using Graficador.Control;
using Graficador.Modelo;
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
        private static int INDICE = 0;
        

        public Principal()
        {
            InitializeComponent();
            this.Hide();
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

        private void colorLineasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            DialogResult dr = cd.ShowDialog();
            if (dr == DialogResult.OK)
            {
                dibujador.ColorLineas = cd.Color;
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

        private void agregarNuevaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            int indice = dgvLineas.Rows.Add();
            Linea l = new Linea();
            DialogResult dr = l.ShowDialog();
            if (dr == DialogResult.OK)
            {
                float pendiente = dibujador.CrearLinea(++INDICE, l.Origen, l.Destino);
                dgvLineas.Rows[indice].Cells[0].Value = INDICE;
                dgvLineas.Rows[indice].Cells[1].Value = l.Origen.X;
                dgvLineas.Rows[indice].Cells[2].Value = l.Origen.Y;
                dgvLineas.Rows[indice].Cells[3].Value = l.Destino.X;
                dgvLineas.Rows[indice].Cells[4].Value = l.Destino.Y;
                dgvLineas.Rows[indice].Cells[5].Value = pendiente;
                DataGridViewCheckBoxCell cb = (DataGridViewCheckBoxCell)dgvLineas.Rows[indice].Cells[6];
                cb.Value = true;
                pDibujable.Invalidate();
            }
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            dgvLineas.Columns[1].ValueType = typeof(Int32);
            dgvLineas.Columns[2].ValueType = typeof(Int32);
            dgvLineas.Columns[3].ValueType = typeof(Int32);
            dgvLineas.Columns[4].ValueType = typeof(Int32);
            dgvLineas.Columns[0].ReadOnly = true;
            dgvLineas.Columns[1].ReadOnly = true;
            dgvLineas.Columns[2].ReadOnly = true;
            dgvLineas.Columns[3].ReadOnly = true;
            dgvLineas.Columns[4].ReadOnly = true;
            dgvLineas.Columns[5].ReadOnly = true;
            dgvLineas.Columns[6].ReadOnly = false;
        }

        private void dgvLineas_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvLineas.IsCurrentCellDirty)
            {
                dgvLineas.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void dgvLineas_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 6)
            {
                DataGridViewCheckBoxCell cb = (DataGridViewCheckBoxCell)dgvLineas.Rows[e.RowIndex].Cells[6];
                if ((bool)cb.Value)
                {
                    dibujador.MostrarLinea((int)dgvLineas.Rows[e.RowIndex].Cells[0].Value);
                } else
                {
                    dibujador.OcultarLinea((int)dgvLineas.Rows[e.RowIndex].Cells[0].Value);
                }
                pDibujable.Invalidate();
            }
        }

        private void borrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvLineas.SelectedRows.Count > 0)
            {
                dibujador.BorrarLinea((int)dgvLineas.SelectedRows[0].Cells[0].Value);
                dgvLineas.Rows.RemoveAt(dgvLineas.SelectedRows[0].Index);
            }
        }
    }
}
