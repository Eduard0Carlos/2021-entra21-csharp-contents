using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteOO
{
    class VagaFactory
    {
        public static List<Vaga> CreateVagas(int vagas, int vagasPorAndar)
        {
            List<Vaga> listaVagas = new List<Vaga>();
            for (int i = 0; i < vagas / vagasPorAndar; i++)
            {
                for (int j = 0; j < vagasPorAndar; j++)
                {
                    Vaga v = new Vaga();
                    v.Tipo = TipoVaga.Carro;

                    char letra =(char)(65 + i);
                    v.Localizacao = letra.ToString() + j;
                    listaVagas.Add(v);
                }
            }
            return listaVagas;
        }
    }
}
