using BusinessLogicalLayer;
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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
            this.toolStripStatusLabel1.Text = SystemParameters.GetCurrentFuncionario().Nome;
        }

        private void gêneroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastroGenero frm = new FormCadastroGenero();
            this.Visible = false;
            frm.ShowDialog();
            this.Visible = true;
        }

        private void filmesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastroFilme frm = new FormCadastroFilme();
            this.Visible = false;
            frm.ShowDialog();
            this.Visible = true;
        }
    }
}
