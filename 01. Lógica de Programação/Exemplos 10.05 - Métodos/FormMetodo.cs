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
    public partial class FormMetodo : Form
    {
        public FormMetodo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int idade = PesquisarIdadePorNome(textBox1.Text);
            if (idade == 0)
            {
                MessageBox.Show("Nome não encontrado");
            }
            else
            {
                MessageBox.Show("A pessoa " + textBox1.Text + " possui " + idade + " anos.");
            }

        }

        int PesquisarIdadePorNome(string nome)
        {
            if (nome == "Carlos")
            {
                return 16;
            }
            if (nome == "Sérgio")
            {
                return 32;
            }
            if (nome == "Caio")
            {
                return 18;
            }
            return 0;
        }


    }
}
