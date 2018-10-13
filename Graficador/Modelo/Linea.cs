using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graficador.Modelo
{
    public class Linea
    {
        private Point origen;
        private Point destino;
        private float pendiente;

        public Linea(Point origen, Point destino)
        {
            this.origen = origen;
            this.destino = destino;
            pendiente = destino.X - origen.X != 0 ? (float)(destino.Y - origen.Y) / (float)(destino.X - origen.X) : float.PositiveInfinity;
        }

        public Point Origen { get => origen; }
        public Point Destino { get => destino; }
        public float Pendiente { get => pendiente; }
    }
}
