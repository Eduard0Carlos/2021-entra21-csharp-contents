using System;
using System.Collections.Generic;

namespace Domain
{
    public class Genero
    {
        public int ID { get; set; }
        public string Nome { get; set; }

        public ICollection<Filme> Filmes { get; set; } // o mesmo genero pode estar em varios filmes, mas um filme so pode conter um genero

    }
}
