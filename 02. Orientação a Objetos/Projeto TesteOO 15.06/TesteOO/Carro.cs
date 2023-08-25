using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteOO
{
    class Carro
    {
        public string Modelo { get; private set; }
        public string Marca { get; private set; }
        public double Velocidade { get; private set; }
        public Motor Motor { get; private set; }
        public bool TemABS { get; private set; }

        public Carro(string modelo, string marca, Motor motor, bool temABS)
        {
            this.Modelo = modelo;
            this.Marca = marca;
            this.Motor = motor;
            this.TemABS = temABS;
        }

        public void Acelerar()
        {
            if (this.Velocidade == 0)
            {
                if (this.Motor.CV < 80)
                {
                    this.Velocidade = 10;
                }
                else if (this.Motor.CV < 160)
                {
                    this.Velocidade = 20;
                }
                else
                {
                    this.Velocidade = 30;
                }
            }
            else
            {
                double coeficienteAceleracao = (double)this.Motor.CV / 500 + 1;
                this.Velocidade = this.Velocidade * coeficienteAceleracao;

                if (this.Motor.TemTurbo)
                {
                    this.Velocidade += 4;
                }
            }
        }

        public void Frear()
        {
            double frenagem = 20;
            if (this.TemABS)
            {
                frenagem = 50;
            }

            if (this.Velocidade - frenagem < 0)
            {
                this.Velocidade = 0;
            }
            else
            {
                this.Velocidade -= frenagem;
            }
        }
    }
}
