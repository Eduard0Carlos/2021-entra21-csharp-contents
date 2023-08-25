using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao
{
    public class Goleiro : Jogador
    {
        public override double CalcularScore()
        {
            var score = this.Velocidade * 1.2 + this.Chute * 1.05 + this.Drible * 1.05 +
                        this.Força * 1.05 + this.Inteligencia * 1.05 + this.Passe * 1.05 +
                        this.Reflexo * 1.4 + this.Resistencia * 1.05;

            if (this.Altura < 1.85)
                return score - 10;

            return score + 5;
        }
    }
}
