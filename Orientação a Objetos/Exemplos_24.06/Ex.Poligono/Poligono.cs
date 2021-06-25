using System.Linq;

namespace Heranca.ExPoligono
{
    public abstract class Poligono
    {
        /*
        * abstract -> Modificador que uma classe/método pode ter. Com este modificador, a classe
        * Não pode mais ser instanciada. Geralmente, classes abstratas possuem métodos abstratos
        * e estes NÃO possuem implementação ( similar aos métodos que encontramos nas interfaces).
        *
        * virtual -> Modificador que um método/propriedade pode ter. Com este modificador, podemos
        * criar uma implementação de um método para determinada classe e, as classes que vierem a
        * herdar desta classe que contem o método virtual, podem sobrepor a implementação deste
        * método.
        *
        * override -> Modificador que um método/propriedade pode ter. Com este modificador, sabemos
        * que o método que estamso programando possuirá uma implementação diferente da classe que
        * estamos herdando. Em grande parte dos frameworks, um método override é acompanhado ao final
        * da implementação com a chamada ao método da classe pai através da sintaxe base.MetodoPai();
        * - Exemplo: base.Trabalhar() * 3;
        *
        * sealed -> Modificador que método/classe pode ter. Indica que este método/classe NÃO pode ser
        * herdada.
        *
        * protected -> Modificador que propriedades, váriaveis, métodos e construtores podem ter. Com
        * este modificador, apenas as classes filhas tem acesso a estes métodos/váriaveis/classes.
        *
        * interface -> "Espécie de classe" que NÃO possui implementação e serve apenas como base para
        * outras classes consumirem. É utilizado em LARGA escala e permite herança múltiplia.
        * É utilizada em junção com conceitos de Injeção de Dependência em todos os sistemas modernos.
        * 
        * base -> Semelhante ao "this", só que não aponta para a instÇancia local e sim para classe pai.
        */

        protected double[] Lados;

        public Poligono(double[] lados)
        {
            this.Lados = lados;
        }

        public abstract double CalcularArea();

        public double CalcularPerimetro()
        {
            return this.Lados.Sum();
        }
    }
}
