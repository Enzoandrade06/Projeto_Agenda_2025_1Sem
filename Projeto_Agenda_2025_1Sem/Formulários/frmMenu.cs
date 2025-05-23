using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projeto_Agenda_2025_1Sem.Formulários;

namespace Projeto_Agenda_2025_1Sem
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pessoasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadtblPessoa objCadtblPessoa = new frmCadtblPessoa();
            objCadtblPessoa.MdiParent = this;
            objCadtblPessoa.Show();
        }

        private void pessoasFiltroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaPessoas objContblPessoa = new frmConsultaPessoas();
            objContblPessoa.MdiParent = this;
            objContblPessoa.Show();
        }

        private void relatóriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVisualizaRelatorioPessoas objRelPessoa = new frmVisualizaRelatorioPessoas();
            objRelPessoa.MdiParent = this;
            objRelPessoa.Show();
        }
    }
}
