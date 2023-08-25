using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteOO
{
    struct Humano
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
    }

    class SilvioSantosCurse
    {
        public void Enfeiticar1(int idade)
        {
            idade = 783;
        }

        //humano = caio
        public void Enfeiticar2(Humano humano)
        {
            humano.Idade = 783;
        }

    }
}
