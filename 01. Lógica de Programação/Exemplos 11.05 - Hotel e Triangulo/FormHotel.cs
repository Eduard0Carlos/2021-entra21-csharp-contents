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
    public partial class FormHotel : Form
    {
        public FormHotel()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double NumeroPessoas = double.Parse(txtQtdPessoas.Text);
            double NumeroDias = double.Parse(txtQtdDias.Text);
            string quarto= "";

            if (rdStandart.Checked)
            {
                quarto = "Standart";
            }
            else if (rdLuxo.Checked)
            {
                quarto = "Luxo";
            }
            else
            {
                quarto = "SuperLuxo";
            }
            double PrecoFinal = CalcularPrecoPessoasDias(NumeroPessoas, NumeroDias, quarto);
            lblTotal.Text = PrecoFinal.ToString("C2");

        }


        private double CalcularPrecoPessoasDias(double QtdPessoas, double QtdDias, string quarto)
        {
            double temp = QtdDias * QtdPessoas;
            
            if (quarto == "Standart")
            {
                temp = temp * 100;
                return temp;
            }
            if (quarto == "Luxo")
            {
                temp = temp * 200;
                return temp;
            }
            if (quarto == "SuperLuxo")
            {
                temp = temp * 400;
                return temp;
            }
            return 0;
        }

    }
}
