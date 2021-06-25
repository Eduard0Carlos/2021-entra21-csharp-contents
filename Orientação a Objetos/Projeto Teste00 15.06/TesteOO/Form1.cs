using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesteOO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Estacionamento estacionamento = new Estacionamento(100, 20);

            Ocupante o = new Ocupante();
            o.Nome = "Rodrigo";
            o.Placa = "ABC-123";
            o.Tipo = TipoVaga.Moto;

            Vaga v = new Vaga();
            v.EhCoberta = true;

            estacionamento.Reservar(o, v);
            double preco = estacionamento.DarSaida("ABC-123");


            ContaBancaria contaGui = new ContaBancaria("1234", "12345678", "90090090090");
            RespostaOperacaoBancaria resposta = contaGui.Depositar(2000);

            ContaBancaria contaCelo = new ContaBancaria("4567", "32165498", "90090090090");
            double valor = 1000;

            contaGui.Transferir(valor, contaCelo);



            MessageBox.Show(resposta.Mensagem);




            Humano sergio = new Humano();
            sergio.Nome = "Sérgio";
            sergio.Idade = 32;

            Humano caio = new Humano();
            caio.Nome = "Caio";
            caio.Idade = 18;
            


            SilvioSantosCurse imortal = new SilvioSantosCurse();
            imortal.Enfeiticar1(sergio.Idade);
            imortal.Enfeiticar2(caio);

           







            try
            {
                Triangulo T = new Triangulo(20, 20, 30);
                MessageBox.Show(T.Perimetro.ToString());
                MessageBox.Show(T.Tipo.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }




            Carro fiesta = new Carro(temABS: false,
                                      modelo: "Fiest 1.0",
                                      marca: "Ford",
                                      motor: new Motor(63, false));

            Carro golf = new Carro(temABS: true,
                                   modelo: "GOLF GTI",
                                   marca: "VW",
                                   motor: new Motor(221, true));

            for (int i = 0; i < 10; i++)
            {
                fiesta.Acelerar();
                golf.Acelerar();
            }

            for (int i = 0; i < 10; i++)
            {
                fiesta.Frear();
                golf.Frear();
            }


            //Profissional p = new Profissional();
            //double valor = p.CalcularPrecoHoraServico();
            //Profissional isadora = new Profissional();
            //isadora.Altura = 1.58;
            //isadora.CorDosOlhos = CorOlhos.Castanho;
            //isadora.DataNascimento = new DateTime(2002, 10, 17);
            //isadora.EhV = true;
            //isadora.Etnia = Etnia.Europeia;
            //isadora.Genero = Genero.Feminino;
            //isadora.InformacoesCabelo = new Cabelo();
            //isadora.InformacoesCabelo.CorDoCabelo = CorCabelo.Moreno;
            //isadora.InformacoesCabelo.TamanhoDoCabelo = Tamanho.Grande;
            //isadora.InformacoesCabelo.TipoDoCabelo = TipoCabelo.Liso;
            //isadora.NomeGuerra = "Gretchen";
            //isadora.Peso = 49;
            //isadora.SemCapacete = true;
            //isadora.Tamanho = Tamanho.Pequeno;
            //isadora.TemLiberdade = true;
            //isadora.TemS = true;
            //isadora.TemT = true;

            //Profissional guilherme = new Profissional();
            //guilherme.Altura = 1.76;
            //guilherme.CorDosOlhos = CorOlhos.Preto;
            //guilherme.DataNascimento = new DateTime(1990, 11, 27);
            //guilherme.EhV = false;
            //guilherme.Etnia = Etnia.Indiana;
            //guilherme.Genero = Genero.Masculino;

            //guilherme.InformacoesCabelo = new Cabelo();
            //guilherme.InformacoesCabelo.CorDoCabelo = CorCabelo.Moreno;
            //guilherme.InformacoesCabelo.TipoDoCabelo = TipoCabelo.Liso;
            //guilherme.InformacoesCabelo.TamanhoDoCabelo = Tamanho.Medio;

            //guilherme.NomeGuerra = "Helicóptero de Combate";
            //guilherme.Peso = 75;
            //guilherme.SemCapacete = false;
            //guilherme.Tamanho = Tamanho.Grande;
            //guilherme.TemLiberdade = false;
            //guilherme.TemS = false;
            //guilherme.TemT = false;

            //try
            //{
            //    double precoIsadora = isadora.CalcularPrecoHoraServico();
            //    precoIsadora = isadora.CalcularPrecoHoraServico();
            //    double precoGuilherme = guilherme.CalcularPrecoHoraServico();

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }
    }
}
