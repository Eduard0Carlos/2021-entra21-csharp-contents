using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{

    public class Brasileiro
    {
        public string CPF { get; set; }

        public virtual double Trabalhar()
        {
            return 3000;
        }
    }
}