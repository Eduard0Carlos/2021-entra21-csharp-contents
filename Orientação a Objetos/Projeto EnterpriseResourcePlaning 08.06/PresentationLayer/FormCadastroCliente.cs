using BusinessLogicalLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PresentationLayer
{
    public partial class FormCadastroCliente : Form
    {

        public FormCadastroCliente()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Cliente c = new Cliente();
            c.Bairro = txtBairro.Text;
            c.CEP = txtCEP.Text;
            c.Complemento = txtComplemento.Text;
            c.CPF = txtCPF.Text;
            c.DataNascimento = dtpDataDeNascimento.Value;
            c.Email = txtEmail.Text;
            c.EstadoCivil = cmbEstadoCivil.Text;
            c.Genero = cmbGenero.Text;
            c.Nome = txtNome.Text;
            c.Numero = txtNumero.Text;
            c.Rua = txtRua.Text;
            c.Telefone = txtTelefone.Text;
            c.UF = cmbUF.Text;
            c.Cidade = txtCidade.Text;

            ClienteBusinessValidator business = new ClienteBusinessValidator();
            string mensagem = business.Cadastrar(c);
            MessageBox.Show(mensagem);

            FormCleaner.ClearForm(this);

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            FormCleaner.ClearForm(this);
        }
    }

    class FormCleaner
    {
        public static void ClearForm(Control control)
        {
            foreach (Control item in control.Controls)
            {
                if (item.HasChildren)
                {
                    ClearForm(item);
                }
                if (item is TextBoxBase)
                {
                    item.Text = "";
                }
                if (item is ComboBox)
                {
                    (item as ComboBox).Text = "";
                }
            }
        }


    }
}
