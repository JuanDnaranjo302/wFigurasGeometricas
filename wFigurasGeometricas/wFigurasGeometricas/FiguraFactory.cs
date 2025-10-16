using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wFigurasGeometricas
{
    public static class FiguraFactory
    {
        public static Figura CrearFigura(string tipo, Color color, Point posicion)
        {
            switch (tipo)
            {
                case "Rectangulo":
                    return new Rectangulo(color, posicion, 100, 200);
                case "Circulo":
                    return new Circulo(color, posicion, 50);
                case "Triangulo":
                    return new Triangulo(color, posicion, 100, 200);
                case "Linea":
                    return new Linea(color, posicion, new Point(posicion.X + 100, posicion.Y));
                default:
                    throw new ArgumentException("tipo de figura no valida");
            }
        }
    }
}
