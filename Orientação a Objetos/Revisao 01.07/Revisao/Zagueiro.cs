using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao
{
    public class Zagueiro : Jogador
    {
        public override double CalcularScore()
        {
            var score = this.Velocidade * 1.4 + this.Chute * 1.05 + this.Drible * 1.05 +
                        this.Força * 1.4 + this.Inteligencia * 1.2 + this.Passe * 1.2 +
                        this.Reflexo * 1.4 + this.Resistencia * 1.3;

            if (this.Altura < 1.75)
                score -= 10;
            else if (this.Altura >= 1.85)
                score += 5;

            return score;
        }
    }
}
