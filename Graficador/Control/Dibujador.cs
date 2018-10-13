using Graficador.Modelo;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graficador.Control
{
    public class Dibujador
    {
        private Size tamano;
        private Point origen;
        private Pen lapiz;
        private Pen lapizLineas;
        private SolidBrush fondo;        
        private int unidadesX = 20;
        private int unidadesY = 20;
        private int saltoX;
        private int saltoY;
        private Font fuente;
        private Dictionary<int, Linea> lineas;
        private List<int> mostrar;

        public int UnidadesX { get => unidadesX; set => unidadesX = value; }
        public int UnidadesY { get => unidadesY; set => unidadesY = value; }
        public Color ColorLapiz { get => lapiz.Color; set => lapiz.Color = value; }
        public Color ColorLineas { get => lapizLineas.Color; set => lapizLineas.Color = value; }
        public Color ColorFondo { get => fondo.Color; set => fondo.Color = value; }
        public Font Fuente { get => fuente; set => fuente = value; }
        

        public Dibujador()
        {
            lineas = new Dictionary<int, Linea>();
            mostrar = new List<int>();
            lapiz = new Pen(Color.Black);
            lapizLineas = new Pen(Color.Blue, 3);
            fondo = new SolidBrush(Color.White);
            fuente = new Font("Arial", 5);
        }

        public float CrearLinea(int id, Point origen, Point destino)
        {
            lineas.Add(id, new Linea(origen, destino));
            mostrar.Add(id);
            return lineas[id].Pendiente;
        }

        public void BorrarLinea(int id)
        {
            mostrar.Remove(id);
            lineas.Remove(id);
        }

        public void MostrarLinea(int id)
        {
            if (!mostrar.Contains(id))
            {
                mostrar.Add(id);
            }
        }

        public void OcultarLinea(int id)
        {
            if (mostrar.Contains(id))
            {
                mostrar.Remove(id);
            }
        }

        public void dibujar(Graphics g, Size tamano)
        {
            this.origen = new Point(tamano.Width / 2, tamano.Height / 2);
            this.tamano = new Size(origen);
            g.FillRectangle(fondo, 0, 0, tamano.Width, tamano.Height);
            saltoX = this.tamano.Width / (unidadesX + 1);
            saltoY = this.tamano.Height / (unidadesY + 1);
            dibujarCuadricula(g);
            dibujarLineas(g);
        }

        private void dibujarCuadricula(Graphics g)
        {
            g.DrawString("I", fuente, lapiz.Brush, origen.X + tamano.Width - 10, origen.Y - tamano.Height + 10);
            g.DrawString("II", fuente, lapiz.Brush, origen.X - tamano.Width + 10, origen.Y - tamano.Height + 10);
            g.DrawString("III", fuente, lapiz.Brush, origen.X - tamano.Width + 10, origen.Y + tamano.Height - 10);
            g.DrawString("IV", fuente, lapiz.Brush, origen.X + tamano.Width - 10, origen.Y + tamano.Height - 10);
            Point p1 = new Point(origen.X, origen.Y - tamano.Height),
                p2 = new Point(origen.X, origen.Y + tamano.Height),
                p3 = new Point(origen.X - tamano.Width, origen.Y),
                p4 = new Point(origen.X + tamano.Width, origen.Y);
            g.DrawLine(lapiz, p1, p2);
            g.DrawLine(lapiz, p3, p4);
            Point p5, p6, p7, p8;
            p5 = new Point(origen.X, origen.Y - 3);
            p6 = new Point(origen.X, origen.Y + 3);
            p7 = new Point(origen.X, origen.Y - 3);
            p8 = new Point(origen.X, origen.Y + 3);            
            for (int i = 0; i <= unidadesX; i += 1)
            {
                g.DrawLine(lapiz, p5, p6);
                g.DrawLine(lapiz, p7, p8);
                p5.X += saltoX;
                p6.X += saltoX;
                p7.X -= saltoX;
                p8.X -= saltoX;
                g.DrawString((i + 1).ToString(), fuente, lapiz.Brush, p6);
                g.DrawString((-i - 1).ToString(), fuente, lapiz.Brush, p8);
            }
            p5 = new Point(origen.X - 3, origen.Y);
            p6 = new Point(origen.X + 3, origen.Y);
            p7 = new Point(origen.X - 3, origen.Y);
            p8 = new Point(origen.X + 3, origen.Y);
            for (int i = 0; i <= unidadesY; i += 1)
            {
                g.DrawLine(lapiz, p5, p6);
                g.DrawLine(lapiz, p7, p8);
                p5.Y += saltoY;
                p6.Y += saltoY;
                p7.Y -= saltoY;
                p8.Y -= saltoY;
                g.DrawString((- i - 1).ToString(), fuente, lapiz.Brush, p6);
                g.DrawString((i + 1).ToString(), fuente, lapiz.Brush, p8);
            }
        }

        private void dibujarLineas(Graphics g)
        {
            Point p1, p2;
            p1 = p2 = new Point();
            foreach (int indice in mostrar)
            {
                Linea l = lineas[indice];
                p1.X = origen.X + l.Origen.X * saltoX;
                p1.Y = origen.Y - l.Origen.Y * saltoY;
                p2.X = origen.X + l.Destino.X * saltoX;
                p2.Y = origen.Y - l.Destino.Y * saltoY;
                g.DrawLine(lapizLineas, p1, p2);
            }
        }
    }
}
