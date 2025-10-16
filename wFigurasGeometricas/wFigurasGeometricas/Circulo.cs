using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wFigurasGeometricas
{
    public  class Circulo : Figura
    {
        public int Radio { get; set; }
        public Circulo(Color color, Point posicion, int radio) : base(color, posicion)
        {
            Radio = radio;
        }
        public override void Dibujar(Graphics g)
        {

            SolidBrush blueBrush = new SolidBrush(Color);

            g.FillEllipse(blueBrush, Posicion.X + Radio, Posicion.Y, Radio * 2, Radio * 2);

        }

    }
}
