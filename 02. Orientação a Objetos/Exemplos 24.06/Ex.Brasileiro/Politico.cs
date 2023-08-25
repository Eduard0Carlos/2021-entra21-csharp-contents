using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    public class Politico : Rico, ILadrao
    {
        public string Partido { get; set; }
        public double ValorDesviado { get; set; }
        public double ValorRoubado { get; set; }

        public void Roubar(Brasileiro b)
        {
            this.ValorRoubado += b.Trabalhar() * .3;
        }

        public override double Trabalhar()
        {
            return base.Trabalhar() * 2;
        }
    }
}
