using BusinessLogicalLayer;
using Entities;
using Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsPresentationLayer
{
    public partial class FormCadastroGenero : Form
    {
        private GeneroBLL generoBLL = new GeneroBLL();
       

        public FormCadastroGenero()
        {
            InitializeComponent();
            this.Load += FormCadastroGenero_Load;
            this.dgvGeneros.CellDoubleClick += DgvGeneros_CellDoubleClick;
        }

        private void DgvGeneros_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Genero g = (Genero)this.dgvGeneros.Rows[e.RowIndex].DataBoundItem;
            FormEditDeleteGenero frm = new FormEditDeleteGenero(g);
            frm.ShowDialog();

            //Esta linha só executa quando o FormEditDeleteGenero for fechado!
            this.AtualizarGrid();
            
            //string nome = Convert.ToString(this.dgvGeneros.Rows[e.RowIndex].Cells[1].Value);
            //this.txtGenero.Text = nome;
        }

        private void FormCadastroGenero_Load(object sender, EventArgs e)
        {
            AtualizarGrid();
        }

        private void AtualizarGrid()
        {
            DataResponse<Genero> response = generoBLL.GetAll();
            if (response.Success)
            {
                this.dgvGeneros.DataSource = response.Data;
            }
            else
            {
                MessageBox.Show(response.Message);
            }
        }


        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Genero g = new Genero();
            g.Nome = txtGenero.Text;
            Response response = generoBLL.Insert(g);
            MessageBox.Show(response.Message);
            AtualizarGrid();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            AtualizarGrid();

        }
    }
}
