using System;

namespace Heranca.ExPoligono
{
    public class Quadrilatero : Poligono
    {
        public Quadrilatero(double[] lados) : base(lados)
        {
            if (lados.Length != 4)
                throw new Exception("Quadrilatero possui 4 lados.");
        }

        public override double CalcularArea()
        {
            return this.Lados[0] * this.Lados[1];
        }
    }
}
