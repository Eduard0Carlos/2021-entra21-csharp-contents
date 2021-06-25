# Palavras chaves

> ### abstract
  
   Modificador que uma classe/método pode ter. Com este modificador, a classe NÃO pode mais ser instanciada. Geralmente, classes abstratas possuem métodos abstratos 
   e estes NÃO possuem implementação ( similar aos métodos que encontramos nas interfaces).
   
    Exemplo: public abstract class NomeClasse
   
> ### virtual

  Modificador que um método/propriedade pode ter. Com este modificador, podemos criar uma implementação de um método para determinada classe e, 
  as classes que vierem a herdar desta classe que contem o método virtual, podem sobrepor a implementação deste método.
  
    Exemplo: public virtual void Metodo()
  
> ### override

  Modificador que um método/propriedade pode ter. Com este modificador, sabemos que o método que estamso programando possuirá uma implementação diferente da classe que 
  estamos herdando. Em grande parte dos frameworks, um método override é acompanhado ao final da implementação com a chamada ao método da classe pai através da sintaxe 
  base.MetodoPai();
  
    Exemplo: public override string ToString()
    
> ### sealed

  Modificador que método/classe pode ter. Indica que este método/classe NÃO pode ser herdada.
  
    Exemplo: public sealed class NomeClasse
    
> ### protected

  Modificador que propriedades, váriaveis, métodos e construtores podem ter. Com este modificador, apenas as classes filhas tem acesso a estes métodos/váriaveis/classes.
  
    Exemplo: protected void Metodo()
    
> ### interface

  "Espécie de classe" que NÃO possui implementação e serve apenas como base par outras classes consumirem. É utilizado em LARGA escala e permite herança múltiplia.
  É utilizada em junção com conceitos de Injeção de Dependência em todos os sistemas modernos.
  
    Exemplo: public interface class NomeClasse
    
> ### base

  Semelhante ao "this", só que não aponta para a instancia local e sim para classe pai.
  
    Exemplo: base.Trabalhar() * 3;


