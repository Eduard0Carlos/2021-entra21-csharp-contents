using BusinessLogicalLayer;
using Entities;
using Entities.Interfaces;
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
    public partial class FormEditDeleteGenero : Form
    {
        private GeneroBLL generoBLL = new GeneroBLL();

        public FormEditDeleteGenero(Genero genero)
        {
            InitializeComponent();

            this.txtID.Text = genero.ID.ToString();
            this.txtGenero.Text = genero.Nome;
        }


        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Response r = generoBLL.Delete(int.Parse(txtID.Text));
            MessageBox.Show(r.Message);
            if (r.Success)
            {
                this.Close();
            }

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Response r = generoBLL.Update(new Genero()
            {
                ID = int.Parse(txtID.Text),
                Nome = txtGenero.Text
            });
            MessageBox.Show(r.Message);
            if (r.Success)
            {
                this.Close();
            }

        }
    }
}
