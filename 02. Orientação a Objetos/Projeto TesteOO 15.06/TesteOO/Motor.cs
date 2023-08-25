using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteOO
{
    class Motor
    {
        public int CV { get; set; }
        public bool TemTurbo { get; set; }

        public Motor(int cv, bool temTurbo)
        {
            this.CV = cv;
            this.TemTurbo = temTurbo;
        }
    }
}
