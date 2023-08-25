using BusinessLogicalLayer;
using Entities;
using Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsPresentationLayer
{
    public partial class FormCadastroFilme : Form
    {
        private GeneroBLL generoBLL = new GeneroBLL();

        public FormCadastroFilme()
        {
            InitializeComponent();
        }

        private void FormCadastroFilme_Load(object sender, EventArgs e)
        {
            DataResponse<Genero> response = generoBLL.GetAll();
            if (response.Success)
            {
                cmbGenero.DataSource = response.Data;
                cmbGenero.ValueMember = "ID";
                cmbGenero.DisplayMember = "Nome";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idGeneroSelecionado = (int)cmbGenero.SelectedValue;


        }
    }
}
