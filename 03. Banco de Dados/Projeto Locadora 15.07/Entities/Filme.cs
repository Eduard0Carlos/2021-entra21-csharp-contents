using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Filme
    {
        public int ID { get; set; }
        public string Titulo { get; set; }
        public Genero Genero { get; set; }

        public Filme()
        {
            this.Genero = new Genero();
        }
    }
}
