using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao
{
    public class Time
    {
        private Jogador[] _jogadores = new Jogador[11];
    
        public void Escalar(params Jogador[] jogadores)
        {
            for (int i = 0; i < jogadores.Length; i++)
            {
                _jogadores[i] = jogadores[i];
            }
        }
    }
}
