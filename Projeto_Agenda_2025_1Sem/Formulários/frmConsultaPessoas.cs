using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Agenda_2025_1Sem.Formulários
{
    public partial class frmConsultaPessoas : Form
    {
        public frmConsultaPessoas()
        {
            InitializeComponent();
        }

        private void frmConsultaPessoas_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dataSet_Agenda.tblPessoa'. Você pode movê-la ou removê-la conforme necessário.
            this.tblPessoaTableAdapter.Fill(this.dataSet_Agenda.tblPessoa);

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            tblPessoaBindingSource.Filter = "Nome like '%" + txtPesquisa.Text + "%'";
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
