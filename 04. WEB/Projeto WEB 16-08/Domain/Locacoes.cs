using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Locacao

    {
        public int ID { get; set; }
        public double Total { get; set; }
        public DateTime DataLocacao { get; set; }
        public DateTime PrazoDevolucao { get; set; }
        public DateTime? DataEntrega { get; set; }
        public double Multa { get; set; }


        public int ClienteID { get; set; }
        public Cliente Cliente { get; set; }

        public List<Filme> Filmes { get; set; }


    }
}
