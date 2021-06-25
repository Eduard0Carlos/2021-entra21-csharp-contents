using System;

namespace Heranca.ExPoligono
{
    public class Triangulo : Poligono
    {
        public Triangulo(double[] lados) : base(lados)
        {
            if (lados.Length != 3)
                throw new Exception("Triangulo só pode conter 3 lados.");
        }

        public override double CalcularArea()
        {
            return this.Lados[0] * this.Lados[1] / 2;
        }
    }
}
