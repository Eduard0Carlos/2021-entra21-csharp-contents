using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteOO
{
    class Estacionamento
    {
        private List<Vaga> vagas;

        public Estacionamento(int totalVagas, int vagasPorAndar)
        {
            this.vagas = VagaFactory.CreateVagas(totalVagas, vagasPorAndar);
        }

        public Vaga Reservar(Ocupante ocupante, Vaga vaga)
        {
            if (ocupante.Tipo != vaga.Tipo)
            {
                throw new Exception("Seu veículo não bate com a vaga selecionada.");
            }

            foreach (Vaga v in this.vagas)
            {
                if (v.EhCoberta == vaga.EhCoberta && v.EhSegurada == vaga.EhSegurada && v.TemRecharge == vaga.TemRecharge && vaga.Cliente == null)
                {
                    v.Cliente = ocupante;
                    return v;
                }
            }
            throw new Exception("Seu veículo não bate com a vaga selecionada.");
        }


        public double DarSaida(string placa)
        {
            foreach (Vaga v in this.vagas)
            {
                //v.Cliente !=null && v.Cliente.Placa == placa
                if (v.Cliente?.Placa == placa)
                {
                    DateTime horaEntrada = v.Cliente.HoraEntrada;
                    DateTime horaSaida = DateTime.Now;
                    TimeSpan ts = horaSaida.Subtract(horaEntrada);
                    int horas = (int)ts.TotalHours;
                    if (horas == 0)
                    {
                        horas++;
                    }
                    return horas * v.Preco;
                }
            }
            throw new Exception("Veículo não encontrado.");
        }



    }
}
