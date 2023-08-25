using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeiroProjeto
{
    public partial class FormSomaMediaNumerosLista : Form
    {
        public FormSomaMediaNumerosLista()
        {
            InitializeComponent();
        }


        //Form das atividades do dia 07/05.
        //Questão 8: Crie um formulário que solicite 10 números para o usuário e armazene-os em uma lista.
        //Após este passo, imprima:
        //a)soma dos números;
        //b)a média dos números;
        //c)a quantidade de números abaixo da média
        List<double> numeros = new List<double>();

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Favor digite um número");
                return;
            }
            numeros.Add(int.Parse(textBox1.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double soma = 0;
            for (int i = 0; i < numeros.Count; i++)
            {
                soma += numeros[i];
            }
            double media = soma / numeros.Count;
            int qtdNumerosAbaixoMedia = 0;
            for (int i = 0; i < numeros.Count; i++)
            {
                if (numeros[i] < media)
                {
                    qtdNumerosAbaixoMedia++;
                }
            }
        }
    }
}
