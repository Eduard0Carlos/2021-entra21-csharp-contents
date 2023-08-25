using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Filme
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public int Duracao { get; set; }
        public int AnoLancamento { get; set; }
        
        public int GeneroID { get; set; }
        public Genero Genero { get; set; } // o mesmo genero pode estar em varios filmes, mas um filme so pode conter um genero

        public ICollection<Locacao> Locacao { get; set; }

        public double preco
        {
            get
            {
                int ano = DateTime.Now.Year;
                int diferencaTempo = ano - AnoLancamento;
                if (ano == 0 )
                {
                    return 10;
                }
                else if (diferencaTempo < 3)
                {
                    return 8;
                }
                else if (diferencaTempo < 5)
                {
                    return 6;
                }
                return 5;
            }
        }

    }
}
