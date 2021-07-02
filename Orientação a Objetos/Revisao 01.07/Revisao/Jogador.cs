using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao
{
    public abstract class Jogador
    {
        public string Nome { get; set; }
        public double Velocidade { get; set; }
        public double Passe { get; set; }
        public double Força { get; set; }
        public double Chute { get; set; }
        public double Inteligencia { get; set; }
        public double Resistencia { get; set; }
        public double Drible { get; set; }
        public double Reflexo { get; set; }
        public double Altura { get; set; }
        public Perna PernaBoa { get; set; }

        public abstract double CalcularScore();
    
    }
}
