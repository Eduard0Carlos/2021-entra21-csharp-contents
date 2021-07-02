using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao
{
    public class Centroavante : Jogador
    {
        public override double CalcularScore()
        {
            return this.Velocidade * 1.4 + this.Chute * 1.4 + this.Drible * 1.3 +
                   this.Força * 1.3 + this.Inteligencia * 1.3 + this.Passe * 1.1 +
                   this.Reflexo * 1.05 + this.Resistencia * 1.05;
        }
    }
}
