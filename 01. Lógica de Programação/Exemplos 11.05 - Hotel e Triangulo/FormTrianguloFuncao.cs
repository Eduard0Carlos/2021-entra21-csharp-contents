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
    public partial class FormTrianguloFuncao : Form
    {
        public FormTrianguloFuncao()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            int l1 = int.Parse(txtLadoA.Text);
            int l2 = int.Parse(txtLadoB.Text);
            int l3 = int.Parse(txtLadoC.Text);

            if (VerificarIntegridadeTriangulo(l1, l2, l3))
            {
                string tipo = CalcularTipoTriangulo(l1, l2, l3);
                MessageBox.Show(tipo);
            }
            else
            {
                MessageBox.Show("Os lados informados não formam um triangulo valido");
            }
        }




        public bool VerificarIntegridadeTriangulo(int lado1, int lado2, int lado3)
        {
            //return !(lado1 > lado2 + lado3 || lado2 > lado1 + lado3 || lado3 > lado1 + lado2);
            if (lado1 > lado2 + lado3 || lado2 > lado1 + lado3 || lado3 > lado1 + lado2)
            {

            }
            return true;
        }



        string CalcularTipoTriangulo(int lado1, int lado2, int lado3)
        {
            if (lado1 == lado2 && lado2 == lado3)
            {
                return "Equilátero";
            }
            if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
            {
                return "Isósceles";
            }
            return "Escaleno";
        }

    }
}
