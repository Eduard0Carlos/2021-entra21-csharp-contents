using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace primeiro
{
    public partial class FormCalculoSalarioProfessor : Form
    {
        public FormCalculoSalarioProfessor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double salarioBase = 1400;
            double comissao = double.Parse(textBox1.Text) * 0.03;
            double salario = salarioBase + comissao;

            if (comissao > 10000)
            {
                salario = salario * 0.94;
            }

            MessageBox.Show(salario.ToString("C2"));
        }
    }
}
