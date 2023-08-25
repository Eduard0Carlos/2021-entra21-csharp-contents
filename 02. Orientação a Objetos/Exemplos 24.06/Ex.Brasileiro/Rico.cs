using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    public class Rico : Brasileiro
    {
        public double ValorPensaoEx { get; set; }
        public double NomeEmbarcacao { get; set; }

        public override double Trabalhar()
        {
            return base.Trabalhar() * 10;
        }
    }
}
