using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteOO
{
    class Vaga
    {
        public string Localizacao { get; set; }
        public bool EhSegurada { get; set; }
        public bool EhCoberta { get; set; }
        public bool TemRecharge { get; set; }
        public TipoVaga Tipo { get; set; }
        public Ocupante Cliente{ get; set; }

        public double Preco
        {
            get
            {
                double preco = 0;
                switch (this.Tipo)
                {
                    case TipoVaga.Moto:
                        preco = 3;
                        break;
                    case TipoVaga.Carro:
                        preco = 5;
                        break;
                    case TipoVaga.Camioneta:
                        preco = 7;
                        break;
                    case TipoVaga.Caminhao:
                        preco = 10;
                        break;
                    case TipoVaga.Bicicleta:
                        preco = 2;
                        break;
                    case TipoVaga.Barco:
                        preco = 200;
                        break;
                    case TipoVaga.Helicoptero:
                        preco = 200;
                        break;
                }

                if (EhCoberta)
                {
                    preco = preco * 1.3;
                }
                if (EhSegurada)
                {
                    preco = preco * 1.2;
                }
                if (this.TemRecharge)
                {
                    preco += 10;
                }
                return preco;
            }
        }
    }
}
