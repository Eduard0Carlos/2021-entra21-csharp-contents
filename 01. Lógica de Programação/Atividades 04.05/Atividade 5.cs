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
    public partial class FormOrdemCrescenteProfessor : Form
    {
        public FormOrdemCrescenteProfessor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double n1 = double.Parse(textBox1.Text);
            double n2 = double.Parse(textBox2.Text);
            double n3 = double.Parse(textBox3.Text);

            if (n1 == n2 || n2 == n3 || n1 == n3)
            {
                MessageBox.Show("Não repita");
                return;
            }

            if (n1 > n2 && n2 > n3)
            {
                MessageBox.Show(n1 + "," + n2 + "," + n3 );
            }
            else if (n1 > n3 && n2 < n3)
            {
                MessageBox.Show(n1 + "," + n3 + "," + n2);
            }
            else if (n2 > n1 && n1 > n3)
            {
                MessageBox.Show(n2 + "," + n1 + "," + n3);
            }
            else if (n2 > n1 && n3 > n1)
            {
                MessageBox.Show(n2 + "," + n3 + "," + n1);
            }
            else if (n3 > n2 && n2 > n1)
            {
                MessageBox.Show(n3 + "," + n2 + "," + n1);
            }
            else
            {
                MessageBox.Show(n2 + "," + n3 + "," + n1);
            }

            double media = (n1 + n2 + n3) / 3;
            MessageBox.Show(media.ToString("N2"));
        }
    }
}
