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
    public partial class FormTemperaturaProfessor : Form
    {
        public FormTemperaturaProfessor()
        {
            InitializeComponent();
        }

        private void txtCelsius_TextChanged(object sender, EventArgs e)
        {
            if (txtCelsius.Text == "")
            { 
                return;
            }

            double temperatura = double.Parse(txtCelsius.Text);
            temperatura = temperatura * 1.8 + 32;

            txtConversaoParaFahrenheit.Text = temperatura.ToString("# °F");
        }

        private void txtFahrenheit_TextChanged(object sender, EventArgs e)
        {
            if (txtFahrenheit.Text == "")
            { 
                return;
            }

            double temperatura = double.Parse(txtFahrenheit.Text);
            temperatura = temperatura - (32 / 8);
            txtConversaoParaCelsius.Text = temperatura.ToString("# °C");
        }
    }
}
