using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteOO
{

    class ClasseTeste
    {
        #region Construtores
        //Construtor 1
        public ClasseTeste()
        {

        }

        //Construtor 2
        public ClasseTeste(int valorVariavel, int valorPropriedadePrivada)
        {
            this.variavel = valorVariavel;
            this.PropriedadeEscritaPrivada = valorPropriedadePrivada;
        }
        #endregion

        #region Variaveis
        private int variavel;
        #endregion

        #region Propriedades
        public int Propriedade { get; set; }

        public int PropriedadeEscritaPrivada { get; private set; }

        public int PropriedadeApenasGet
        {
            get
            {
                return this.PropriedadeEscritaPrivada + 10;
            }
        }
        #endregion

        #region Métodos
        public void DarValorAPropriedadePrivada(int x)
        {
            Random rdm = new Random();
            int val = rdm.Next(0, 10);
            this.PropriedadeEscritaPrivada = val;
            //this.PropriedadeEscritaPrivada = new Random().Next(0,10);
        }

        public static void OiEuSouUmMetodoEstatico()
        {
        }

        #endregion
    }

    abstract class Arma
    {
        public string Nome { get; set; }
        public double Peso { get; set; }
        public double Preço { get; set; }
        public int QtdMaos { get; set; }
        public abstract double CalcularDano();
        public abstract double CalcularIntervalo();

    }

    abstract class ArmaFogo : Arma
    {
        public int TamanhoDoPente { get; set; }
        public double Calibre { get; set; }
        public double Recuo { get; set; }
    }
    abstract class ArmaBranca : Arma
    {
        public FormaGolpe Forma { get; set; }
    }

    enum FormaGolpe
    {
        Estocada, Pancada, Cortada
    }

    class Pexera : ArmaBranca
    {
        public Pexera()
        {
            this.Forma = FormaGolpe.Cortada;
            this.Nome = "Pexera 666";
            this.Peso = 1;
            this.Preço = -1;
            this.QtdMaos = 1;
        }


        public override double CalcularDano()
        {
            return 999999999;
        }

        public override double CalcularIntervalo()
        {
            return 2;
        }
    }

    class Ak47 : ArmaFogo
    {
        public Ak47()
        {
            this.Nome = "Ak47";
            this.Peso = 3.8;
            this.Preço = 20000;
            this.QtdMaos = 2;
            this.TamanhoDoPente = 40;
            this.Calibre = 7.62;
        }
        public override double CalcularDano()
        {
            return 30;
        }

        public override double CalcularIntervalo()
        {
            return 15;
        }
    }

    class Zweihander : ArmaBranca
    {
        public Zweihander()
        {
            this.Nome = "Zweihander";
            this.Peso = 7;
            this.Preço = 20000;
            this.QtdMaos = 2;
        }
       
        public override double CalcularDano()
        {
            return 50;
        }

        public override double CalcularIntervalo()
        {
            return 0.5;
        }
    }

    class Glock : ArmaFogo
    {
        public Glock()
        {
            this.Nome = "Glock";
            this.Peso = 0.5;
            this.Preço = 7000;
            this.QtdMaos = 2;
            this.TamanhoDoPente = 17;
            this.Calibre = 9;
        }
        public override double CalcularDano()
        {
            return 15;
        }

        public override double CalcularIntervalo()
        {
            return 15;
        }
    }

    class Personagem
    {
        public ArmaBranca ArmaBranca { get; private set; }
        public ArmaFogo ArmaFogo { get; private set; }

        public double AtacarPerto()
        {
            if (this.ArmaBranca == null)
            {
                return 0;
            }
            return this.ArmaBranca.CalcularDano();
        }

        public double AtacarLonge()
        {
            if (this.ArmaFogo == null)
            {
                return 0;
            }
            return this.ArmaFogo.CalcularDano();
        }

        public void Equipar(Arma arma)
        {
            if (arma is ArmaBranca)
            {
                this.ArmaBranca = (ArmaBranca)arma;
                if (arma.QtdMaos == 2)
                {
                    this.ArmaFogo = null;
                }
            }
            else
            {
                this.ArmaFogo = (ArmaFogo)arma;
                if (arma.QtdMaos == 2)
                {
                    this.ArmaBranca = null;
                }
            }
        }

    }

    class ClasseAvô
    {
        private string x;
        public string A { get; protected set; }

        public virtual string DefinirOrdemHierarquica()
        {
            return "Eu sou o Avô";
        }
    }

    class ClassePai : ClasseAvô
    {
        public override string DefinirOrdemHierarquica()
        {
            return "Eu sou o pai.";
        }
    }

    class ClasseFilha : ClassePai
    {
        public override string DefinirOrdemHierarquica()
        {
            return "Eu sou o filho.";
        }
    }


    class MyClass
    {
        public MyClass()
        {
            ClasseTeste.OiEuSouUmMetodoEstatico();

            ClasseTeste c1 = new ClasseTeste(100, 1000);
            ClasseTeste c = new ClasseTeste();
            //set
            c.Propriedade = 10;
            //get
            int x = c.Propriedade;
            //get e set
            c.Propriedade += 1;

            int y = c.PropriedadeEscritaPrivada;
            int w = c.PropriedadeApenasGet;

            c.DarValorAPropriedadePrivada();
        }
    }
}
