using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao
{
    class ClasseTeste
    {

        #region Variables
        private int _variavel;
        #endregion

        #region Properties
        //A diferença de uma variável para uma propriedade é que propriedade permite denominar o protetor de acesso de leitura ou escrita
        public int Propriedade { get; set; }

        //Para se escrever em uma propriedade ou váriavel privada é necessário usar o encapsulamento.
        //As duas formas de encapsulamento são através de contrutor ou método público
        public int PropriedadeEscritaPrivada { get; private set; }

        //Propriedade somente leitura
        public int PropriedadeSomenteEscrita
        {
            get
            {
                return this.Propriedade + 10;
            }
        }
        #endregion

        #region Builders
        //Contrutor é um metodo iniciado quando o objeto é instanciado
        public ClasseTeste()
        {
        }

        //Sobrecarga é quando o método/construtor com o mesmo nome tem implementações diferentes
        public ClasseTeste(int valorVariavel, int valorPropriedadePrivada)
        {
            this._variavel = valorVariavel;
            this.PropriedadeEscritaPrivada = valorPropriedadePrivada;
        }
        #endregion

        #region Methods
        //Ex escrita em propriedade privada
        public void DarValorAPropriedadePrivada()
        {
            this.PropriedadeEscritaPrivada = new Random().Next(0, 10);
        }

        public static void MetodoEstatico()
        {
            //this - não é possível
        }
        #endregion
    }

    #region ExemploArma
    abstract class Arma
    {
        public string Nome { get; set; }
        public double Peso { get; set; }
        public double Preco { get; set; }
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

    enum FormaGolpe
    {
        Estocada, Pancada, Cortada
    }

    abstract class ArmaBranca : Arma
    {
        public FormaGolpe Forma { get; set; }
    }

    class Pexera : ArmaBranca
    {
        public Pexera()
        {
            this.Forma = FormaGolpe.Cortada;
            this.Nome = "Pexera 666";
            this.Peso = 1;
            this.Preco = -1;
            this.QtdMaos = 1;
        }

        public override double CalcularDano()
        {
            return 1.7976931348623157E+308;
        }

        public override double CalcularIntervalo()
        {
            return 2;
        }
    }

    class Zweihander : ArmaBranca
    {
        public Zweihander()
        {
            this.Forma = FormaGolpe.Pancada;
            this.Nome = "Zweihander";
            this.Peso = 3;
            this.Preco = 15000;
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
            this.Preco = 7000;
            this.Calibre = 9;
            this.QtdMaos = 1;
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

    class Ak47 : ArmaFogo
    {
        public Ak47()
        {
            this.Nome = "AK47";
            this.Peso = 3.8;
            this.Preco = 20000;
            this.Calibre = 762;
            this.QtdMaos = 2;
        }

        public override double CalcularDano()
        {
            return 10;
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

        public double? AtacarPerto()
        {
            return this.ArmaBranca?.CalcularDano();
        }

        public double? AtacarLonge()
        {
            return this.ArmaFogo?.CalcularDano();
        }

        public void Equipar(Arma arma)
        {
            if (arma is ArmaBranca)
            {
                if (arma?.QtdMaos == 2)
                {
                    this.ArmaBranca = (ArmaBranca)arma;
                    if (ArmaFogo?.QtdMaos == 2)
                        ArmaFogo = null;
                }
            }
            else
            {
                this.ArmaFogo = (ArmaFogo)arma;

                if (arma?.QtdMaos == 2)
                    this.ArmaBranca = null;
            }
        }
    }
    #endregion

    #region ExemploHeranca_Simples
    class ClasseAvo
    {
        //Ninguém consegue acessar
        private string x;
        //protected somente os filhos podem acessar
        public string A { get; protected set; }

        public virtual string DefinirOrdemHierarquica()
        {
            return "Eu sou Avô";
        }
    }

    class ClassePai : ClasseAvo
    {
        public override string DefinirOrdemHierarquica()
        {
            return "Eu sou Pai";
        }
    }

    class ClasseFilha : ClassePai
    {
        public override string DefinirOrdemHierarquica()
        {
            return "Eu sou filho";
        }
    }
    #endregion

    class MyClass
    {
        public MyClass()
        {
            var itajaiense = new Personagem();

            itajaiense.Equipar(new Glock());
            itajaiense.Equipar(new Pexera());

            //Objeto ou instancia
            var c = new ClasseTeste();

            //set
            c.Propriedade = 10;

            //get
            var x = c.Propriedade;

            //get e set
            c.Propriedade++;

            c.DarValorAPropriedadePrivada();
        }
    }
}
