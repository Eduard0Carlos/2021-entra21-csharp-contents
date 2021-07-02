using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao
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
            this.Filho = f;
            this.PaiDoFilho = pai;
            pai.Filho = f;
            pai.MaeDoFilho = this;

            if (pai is ICuzao)
                (pai as ICuzao).NegarPaternidade();

            return f;
        }
    }

    class Filho
    {
        public string Nome { get; set; }
        public Mae Mae { get; set; }
        public Pai Pai { get; set; }
    }

    class Pai
    {
        public string Nome { get; set; }
        public Mae MaeDoFilho { get; set; }
        public Filho Filho { get; set; }
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
