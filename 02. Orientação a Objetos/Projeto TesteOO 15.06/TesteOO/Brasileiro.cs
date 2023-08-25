using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesteOO.Heranca
{
    //abstract virtual override sealed protected interface base
    //Abstract -> Modificador que uma classe/método pode ter. Com este modificador, a classe
    //não pode mais ser instanciada. Geralmente, classes abstratas possuem métodos abstratos
    //e estes NÃO possuem implementação (similar aos métodos que encontramos nas interfaces).

    //Virtual -> Modificador que um método/propriedade pode ter. Com este modificador, podemos criar
    //uma implementação de um método para determinada classe e, as classes que vierem 
    //a herdar desta classe que contem o método virtual, podem sobrepor a implementação
    //deste método.

    //Override -> Modificador que um método/propriedade pode ter. Com este modificador, sabemos 
    //que o método que estamos programando possuirá uma implementação diferente da classe que 
    //estamos herdando. Em grande parte dos frameworks, um método override é acompanhado no final
    //da implementação com a chamada ao método da classe pai através da sintaxe base.MetodoPai();
    //por ex: base.Trabalhar() / 3;

    //sealed -> Modificador que um método/classe pode ter. Indica que este método/classe
    //NÃO pode ser herdado.

    //protected -> Modificador que variáveis, propriedades, métodos e construtores podem ter. Com este modificador,
    //apenas as classes filhas tem acesso a estes métodos/propriedades/variáveis/construtores.

    //interface -> "Espécie de classe" que NÃO possui implementação e serve apenas como base para 
    //outras classes consumirem. É utilizado em LARGA escala e permite herança múltipla.
    //É utilizada em junção com conceitos de Injeção de Dependência em todos os sistemas modernos.

    //base -> Semelhante ao "this", só que não aponta para a instância local e sim para classe pai.

    abstract class X
    {
    }

    abstract class Poligono
    {
        protected double[] lados;

        public Poligono(double[] ladinhos)
        {
            this.lados = ladinhos;
        }

        public abstract double CalcularArea();

        public double CalcularPerimetro()
        {
            return this.lados.Sum();
        }
    }

    class Quadrilatero : Poligono
    {
        public Quadrilatero(double[] lados):base(lados)
        {
            if (lados.Length != 4)
            {
                throw new Exception("Quadrilátero só pode conter 4 lados.");
            }
        }

        public override double CalcularArea()
        {
            return this.lados[0] * this.lados[1];
        }
    }

    class Triangulo : Poligono
    {
        public Triangulo(double[] lados):base(lados)
        {
            if (lados.Length != 3)
            {
                throw new Exception("Triangulo só pode conter 3 lados.");
            }
        }

        public override double CalcularArea()
        {
            return lados[0] * lados[1] / 2;
        }

    }


    class Brasileiro : object
    {
        public string CPF { get; set; }

        public virtual double Trabalhar()
        {
            return 3000;
        }

    }

    class Rico : Brasileiro
    {
        public double ValorPensaoEx { get; set; }
        public double NomeEmbarcacao { get; set; }
        public override double Trabalhar()
        {
            return base.Trabalhar() * 10;
        }
    }

    class Pobre : Brasileiro
    {
        public int NDoencas { get; set; }
        public double ValorAluguel { get; set; }
        public double ValorFinanciamento { get; set; }

        public override double Trabalhar()
        {
            return base.Trabalhar() / 3;
        }
    }

    class Politico : Rico, ILadrao
    {
        public string Partido { get; set; }
        public double ValorDesviado { get; set; }

        public override double Trabalhar()
        {
            return base.Trabalhar() * 2;
        }

        public void Roubar(Brasileiro b)
        {
            this.ValorRoubado += b.Trabalhar() * 0.3;
        }

        public double ValorRoubado { get; set; }
    }

    class Corinthiano : Pobre, ILadrao
    {
        public decimal PassagensPelaPolicia { get; set; }
        public string NomeGangue { get; set; }

        public override sealed double Trabalhar()
        {
            throw new Exception("Corinthiano não trabalha.");
        }

        public void Roubar(Brasileiro b)
        {
            if (b is Corinthiano)
            {
                return;
            }

            //Brasileiro, Pobre, Rico, Politico

            //b.Trabalhar() => Polimorfismo
            this.ValorRoubado += b.Trabalhar();
            if (b is Rico)
            {
                b = null;
            }

        }

        public double ValorRoubado { get; set; }
    }

    interface ILadrao
    {
        void Roubar(Brasileiro b);
        double ValorRoubado { get; set; }
    }

    class PresidioDosSonhos
    {
        public void Prender(ILadrao ladrao)
        {


        }
    }

    class Kamer
    {
        public void Casar(Rico r)
        {

        }
    }

    class Isadora
    {
        public void Casar(Corinthiano c)
        {

        }
    }



    class MyClass
    {
        public MyClass()
        {
            Brasileiro b = new Brasileiro();
            Rico r = new Rico();
            Pobre p = new Pobre();
            Politico pp = new Politico();
            Corinthiano cc = new Corinthiano();

            cc.Roubar(r);

            Triangulo t = new Triangulo(new double[] { 10, 10, 15 });

            t.CalcularPerimetro();
               

        }
    }

}
