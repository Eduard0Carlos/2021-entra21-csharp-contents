using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteOO
{
    public class Triangulo
    {
        public int LadoA { get; private set; }
        public int LadoB { get; private set; }
        public int LadoC { get; private set; }
        public TipoTriangulo Tipo
        {
            get
            {
                if (this.LadoA == this.LadoB && this.LadoB == this.LadoC)
                {
                    return TipoTriangulo.Equilátero;
                }
                if (this.LadoA == this.LadoB || this.LadoB == this.LadoC || this.LadoA == this.LadoC)
                {
                    return TipoTriangulo.Isósceles;
                }
                return TipoTriangulo.Escaleno;
            }
        }

        public int Perimetro
        {
            get
            {
                return this.LadoA + this.LadoB + this.LadoC;
            }
        }

        public Triangulo(int ladoA, int ladoB, int ladoC)
        {
            if (ladoA >= ladoB + ladoC || ladoB >= ladoA + ladoC || ladoC >= ladoA + ladoB)
            {
                throw new Exception("Um lado não pode ser maior que a soma dos outros dois em um triângulo.");
            }
            this.LadoA = ladoA;
            this.LadoB = ladoB;
            this.LadoC = ladoC;
        }

    }
}
