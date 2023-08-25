using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteOO
{
    class Mae
    {
        public string Nome { get; set; }
        public Pai PaiDoFilho { get; set; }
        public Filho Filho { get; set; }

        public Filho EngravidarDe(Pai pai)
        {
            Filho f = new Filho();
            f.Pai = pai;
            f.Mae = this;
            f.Nome = "Uóllace Robercléverson";

            pai.Filho = f;
            pai.MaeDoFilho = this;

            this.Filho = f;
            this.PaiDoFilho = pai;


            if (pai is ICuzao)
            {
                ICuzao cuzao = (ICuzao)pai;
                cuzao.NegarPaternidade();
            }
            return f;
        }
    }

    class Filho
    {
        public string Nome { get; set; }
        public Pai Pai { get; set; }
        public Mae Mae { get; set; }
    }

    class Pai
    {
        public string Nome { get; set; }
        public Filho Filho { get; set; }
        public Mae MaeDoFilho { get; set; }
    }

    class PaiCorinthiano : Pai, ICuzao
    {
        public void NegarPaternidade()
        {
            this.MaeDoFilho = null;
        }
    }
    class PaiFumante : Pai, ICuzao
    {
        public void NegarPaternidade()
        {
            this.Filho = null;
            this.MaeDoFilho = null;
        }
    }

    class Paizao : Pai
    {

    }

    interface ICuzao
    {
        void NegarPaternidade();
    }
}
