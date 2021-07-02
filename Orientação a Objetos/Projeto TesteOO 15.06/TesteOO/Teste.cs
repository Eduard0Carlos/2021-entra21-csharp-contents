using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteOO
{
    class Teste
    {
        public Teste(string oie)
        {

        }

        private string variavel;
        public string ProprieadadeTodaPublica { get; set; }
        public string ProprieadadeEscritaPrivada { get;private set; }
        public string PropriedadeSomenteLeitura
        {
            get
            {
                return "oieeeeee";
            }
        }
        public void Metodo1() { }


    }
}
