using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao
{
    public class Volante : MeioCampo
    {
        public override double CalcularScore()
        {
            return this.Velocidade * 1.2 + this.Chute * 1.05 + this.Drible * 1.05 +
            this.Força * 1.4 + this.Inteligencia * 1.4 + this.Passe * 1.4 +
            this.Reflexo * 1.3 + this.Resistencia * 1.4;
        }
    }
}
