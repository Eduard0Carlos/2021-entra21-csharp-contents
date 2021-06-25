using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteOO
{
    class OperacaoBancaria
    {
        public TipoOperacao Tipo { get; set; }
        public double Quantia { get; set; }
        public DateTime Data { get; set; }
        public double SaldoPosOperacao { get; set; }

        public OperacaoBancaria()
        {
            this.Data = DateTime.Now;
        }

        public override string ToString()
        {
            return "Tipo:" + this.Tipo + "\r\n" +
                   "Quantia: " + this.Quantia.ToString("C2") + "\r\n" +
                   "Data: " + this.Data.ToString("dd/MM/yyyy - HH:mm") + "\r\n" +
                   "Saldo: " + this.SaldoPosOperacao.ToString("C2") + "\r\n";
        }

    }

    enum TipoOperacao
    {
        Saque, Deposito
    }
}
