using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wFigurasGeometricas
{
    public class Linea : Figura
    {
        public Point Fin { get; set; }
        public Linea(Color color, Point posicion, Point fin) : base(color, posicion)
        {
            Fin = fin;
        }
        public override void Dibujar(Graphics g)
        {
            Pen blackpen = new Pen(Color, 3);
            g.DrawLine(blackpen, Posicion, Fin);
        }
    }
}
