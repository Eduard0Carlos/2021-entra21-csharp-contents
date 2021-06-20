using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace primeiro
{
    public partial class FormPotenciaRaiz : Form
    {
        public FormPotenciaRaiz()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double valor = Convert.ToDouble(textBox1.Text);

            double raizQuadrada = Math.Sqrt(valor);
            MessageBox.Show("Raiz quadrada vale " + raizQuadrada + " e " + raizQuadrada * -1);

            double potencia = Math.Pow(valor, 2);
            MessageBox.Show("O quadrado vale " + potencia);
        }
    }
}
