using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace wFigurasGeometricas
{
    public class Rectangulo : Figura
    {
        public int Alto { get; set; }
        public int Ancho { get; set; }

        public Rectangulo(Color color, Point posicion, int alto, int ancho) : base(color, posicion)
        {
            Alto = alto;
            Ancho = ancho;
        }
        public override void Dibujar(Graphics g)
        {

            using (SolidBrush brush = new SolidBrush(Color))
            {

                g.FillRectangle(brush, Posicion.X, Posicion.Y, Ancho, Alto);

            }
        }
    }
}
