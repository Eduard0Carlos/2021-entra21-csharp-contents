using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteOO
{
    class Profissional
    {
        public string NomeGuerra { get; set; }
        public double Altura { get; set; }
        public double Peso { get; set; }
        public Cabelo InformacoesCabelo { get; set; }
        public Genero Genero { get; set; }
        public DateTime DataNascimento { get; set; }
        public bool TemS { get; set; }
        public bool EhV { get; set; }
        public Tamanho Tamanho { get; set; }
        public bool TemT { get; set; }
        public Etnia Etnia { get; set; }
        public CorOlhos CorDosOlhos { get; set; }
        public bool SemCapacete { get; set; }
        public bool TemLiberdade { get; set; }


        public int Idade
        {
            get
            {
                DateTime birthdate = this.DataNascimento;
                DateTime today = DateTime.Now;
                int age = today.Year - birthdate.Year;
                //Necessário para ver se a pessoa já fez aniversário esse ano!
                if (birthdate > today.AddYears(-age))
                {
                    age--;
                }
                return age;
            }
        }

        public double IMC
        {
            get
            {
                return this.Peso / Math.Pow(this.Altura, 2);
            }
        }

        public double CalcularPrecoHoraServico()
        {
            double precoBase = 200;

            if (this.Idade < 18)
            {
                throw new Exception("Não é permitido menor de idade.");
            }

            if (this.Idade <= 23)
            {
                precoBase += 200;
            }
            else if(this.Idade <= 30)
            {
                precoBase += 150;
            }
            else if(this.Idade <= 38)
            {
                precoBase += 100;
            }
            else if (this.Idade <= 45)
            {
                precoBase += 50;
            }
            else
            {
                precoBase -= 50;
            }
            if (this.EhV)
            {
                precoBase += 10000;
                this.EhV = false;
            }
            if (this.Genero == Genero.Feminino && this.TemS)
            {
                precoBase += 200;
            }
            if (this.SemCapacete)
            {
                precoBase += 200;
            }
            if (this.TemLiberdade)
            {
                precoBase += 200;
            }
            return precoBase;
        }
    }
}
