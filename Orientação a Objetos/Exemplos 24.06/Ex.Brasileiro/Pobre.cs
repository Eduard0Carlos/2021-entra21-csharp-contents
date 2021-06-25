using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    public class Pobre : Brasileiro
    {
        public int NDoencas { get; set; }
        public double ValorAluguel { get; set; }
        public double ValorFinanciamento { get; set; }

        public override double Trabalhar()
        {
            return base.Trabalhar() / 3;
        }
    }
}
