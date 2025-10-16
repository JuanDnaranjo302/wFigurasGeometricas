using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wFigurasGeometricas
{
    public class Triangulo : Figura
    {
        public int Lado { get; set; }
        public int Base { get; set; }
        public Triangulo(Color color, Point posicion, int lado, int bas) : base(color, posicion)
        {
            Lado = lado;
            Base = bas;
        }
        public override void Dibujar(Graphics g)
        {
            Point[] Points =
                {
                   new Point(Posicion.X, Posicion.Y + Lado ),
                   new Point(Posicion.X + Base / 2, Posicion.Y ),
                   new Point(Posicion.X + Base , Posicion.Y + Lado)
                };
            SolidBrush blueBrush = new SolidBrush(Color);

            g.FillPolygon(blueBrush, Points);
        }
    }
}
