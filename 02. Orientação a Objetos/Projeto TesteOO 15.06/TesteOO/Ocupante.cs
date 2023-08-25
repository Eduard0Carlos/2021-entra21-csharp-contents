using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteOO
{
    class Ocupante
    {
        public Ocupante()
        {
            this.HoraEntrada = DateTime.Now;
        }
        public string Nome { get; set; }
        public TipoVaga Tipo { get; set; }
        public string Placa { get; set; }
        public DateTime HoraEntrada { get; set; }
    }
}
