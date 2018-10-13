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
    public partial class ObtenerNumero : Form
    {
        public int Numero { get => Int32.Parse(txtNumero.Text.Trim()); }

        public ObtenerNumero(String label)
        {
            InitializeComponent();
            label1.Text = label;
        }

        private void txtNumero_Validating(object sender, CancelEventArgs e)
        {
            int temp;
            if (!(Int32.TryParse(txtNumero.Text.Trim(), out temp) && temp > 0))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNumero, "Numero invalido");
            }
            else
            {
                errorProvider1.SetError(txtNumero, "");
            }
        }

        private void butCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void butAceptar_Click(object sender, EventArgs e)
        {
            if (Validate())
            {
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
