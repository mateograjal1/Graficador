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
    public partial class Linea : Form
    {
        public Point Origen { get => new Point((int)nX1.Value, (int)nY1.Value); }
        public Point Destino { get => new Point((int)nX2.Value, (int)nY2.Value); }

        public Linea()
        {
            InitializeComponent();
        }

        private void butCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void butAceptar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
