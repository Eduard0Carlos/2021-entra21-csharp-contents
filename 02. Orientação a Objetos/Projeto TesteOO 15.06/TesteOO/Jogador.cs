using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace TesteOO
{
    abstract class Jogador
    {

        public override string ToString()
        {
            return this.Nome + " - " + this.CalcularScore().ToString("N2");
        }
        public string Nome { get; set; }
        public double Velocidade { get; set; }
        public double Passe { get; set; }
        public double Força { get; set; }
        public double Chute { get; set; }
        public double Inteligencia { get; set; }
        public double Resistencia { get; set; }
        public double Drible { get; set; }
        public double Reflexo { get; set; }
        public double Altura { get; set; }
        public Perna Perna { get; set; }

        public abstract double CalcularScore();
    }

    class Zagueiro : Jogador
    {
        public override double CalcularScore()
        {
            double score =
                this.Velocidade * 1.4 + this.Chute * 1.05 + this.Drible * 1.05 +
                   this.Força * 1.4 + this.Inteligencia * 1.2 + this.Passe * 1.2 +
                   this.Reflexo * 1.4 + this.Resistencia * 1.3;

            if (this.Altura <= 1.75)
            {
                score -= 10;
            }
            else if (this.Altura >= 1.85)
            {
                score += 5;
            }
            return score;
        }
    }

    abstract class MeioCampo : Jogador
    {

    }

    class Volante : MeioCampo
    {
        public override double CalcularScore()
        {
            double score =
              this.Velocidade * 1.2 + this.Chute * 1.05 + this.Drible * 1.05 +
                 this.Força * 1.4 + this.Inteligencia * 1.4 + this.Passe * 1.4 +
                 this.Reflexo * 1.3 + this.Resistencia * 1.4;
            return score / 100;
        }
    }

    class Meia : MeioCampo
    {
        public override double CalcularScore()
        {
            double score =
              this.Velocidade * 1.4 + this.Chute * 1.2 + this.Drible * 1.4 +
                 this.Força * 1.05 + this.Inteligencia * 1.4 + this.Passe * 1.4 +
                 this.Reflexo * 1.05 + this.Resistencia * 1.2;
            return score / 100;
        }
    }

    class Centroavante : Jogador
    {
        public override double CalcularScore()
        {
            double score =
              this.Velocidade * 1.4 + this.Chute * 1.4 + this.Drible * 1.3 +
                 this.Força * 1.3 + this.Inteligencia * 1.3 + this.Passe * 1.1 +
                 this.Reflexo * 1.05 + this.Resistencia * 1.05;
            return score/100;
        }
    }

    class Goleiro : Jogador
    {
        public override double CalcularScore()
        {
            double score =
            this.Velocidade * 1.2 + this.Chute * 1.05 + this.Drible * 1.05 +
               this.Força * 1.05 + this.Inteligencia * 1.2 + this.Passe * 1.05 +
               this.Reflexo * 2 + this.Resistencia * 1.2;

            if (this.Altura < 1.85)
            {
                return (score - 10) / 100;
            }
            return (score + 5) / 100;
        }
    }

    class Time
    {
        public string Nome { get; set; }
        private Jogador[] jogadores = new Jogador[11];

        public void Escalar(Goleiro goleiro)
        {
            this.jogadores[0] = goleiro;
        }

        public void Escalar(params Zagueiro[] zagueiros)
        {
            for (int i = 1; i < 4; i++)
            {
                this.jogadores[i] = zagueiros[i - 1];
            }
        }

        public void Escalar(params Volante[] meioCampistas)
        {
            int j = 0;
            for (int i = 4; i < 7; i++)
            {
                this.jogadores[i] = meioCampistas[j++];
            }
        }

        public void Escalar(params Meia[] meioCampistas)
        {
            int j = 0;
            for (int i = 7; i < 9; i++)
            {
                this.jogadores[i] = meioCampistas[j++];
            }
        }
        public void Escalar(params Centroavante[] atacantes)
        {
            for (int i = 9; i < 11; i++)
            {
                this.jogadores[i] = atacantes[i - 9];
            }
        }

        public double ScoreDefesa
        {
            get
            {
                double somaScoreDefesa = 0;
                for (int i = 0; i < 4; i++)
                {
                    somaScoreDefesa += this.jogadores[i].CalcularScore();
                }
                return somaScoreDefesa / 4;
            }
        }

        public double ScoreMeioCampo
        {
            get
            {
                double scoreMeioCampo = 0;
                for (int i = 4; i < 9; i++)
                {
                    scoreMeioCampo += this.jogadores[i].CalcularScore();
                }
                return scoreMeioCampo / 5;
            }
        }

        public double ScoreAtaque
        {
            get
            {
                double scoreAtaque = 0;
                for (int i = 9; i < 11; i++)
                {
                    scoreAtaque += this.jogadores[i].CalcularScore();
                }
                return scoreAtaque / 2;
            }
        }

        public double Score
        {
            get { return (this.ScoreAtaque + this.ScoreDefesa + this.ScoreMeioCampo) / 3; }
        }

    }

    class ResultadoPartida
    {
        public Time Time1 { get; set; }
        public Time Time2 { get; set; }
        public string Resultado { get; set; }
        public Time Vencedor { get; set; }
        public bool Empatou { get; set; }
    }

    class Partida
    {
        Timer timer = new Timer();
        private Time t1;
        private Time t2;

        public Partida()
        {
            timer.Interval = 1000;
            timer.Elapsed += Timer_Elapsed;
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {

        }

        //public ResultadoPartida Jogar(Time t1, Time t2)
        //{
        //    this.t1 = t1;
        //    this.t2 = t2;
        //    timer.Start();
        //}
    }


}
