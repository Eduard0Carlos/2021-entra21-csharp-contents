using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    public class Corinthiano : Pobre, ILadrao
    {
        public decimal PassagensPelaPolicia { get; set; }
        public string NomeGangue { get; set; }
        public double ValorRoubado { get; set; }

        public override double Trabalhar()
        {
            throw new Exception("Corinthiano não trabalha.");
        }

        public void Roubar(Brasileiro b)
        {
            if (b is Corinthiano)
                return;

            this.ValorRoubado += b.Trabalhar();

            if (b is Rico)
                b = null;
        }
    }
}
