using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace wFigurasGeometricas
{
    public abstract class Figura
    {
        public Color Color { get; set; }
        public Point Posicion { get; set; }

        public Figura(Color color, Point posicion)
        {
            Color = color;
            Posicion = posicion;
        }
        public abstract void Dibujar(Graphics g);
    }
}
