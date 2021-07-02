using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao
{
    class Meia : MeioCampo
    {
        public override double CalcularScore()
        {
            return this.Velocidade * 1.4 + this.Chute * 1.2 + this.Drible * 1.4 +
            this.Força * 1.05 + this.Inteligencia * 1.4 + this.Passe * 1.4 +
            this.Reflexo * 1.05 + this.Resistencia * 1.2;
        }
    }
}
