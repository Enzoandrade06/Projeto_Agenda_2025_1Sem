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

    public partial class frmLogin : Form
    {
        // Variável para armazenar o nome do usuário
        string nomeUsuario = "enzo";
        string Senha = "567";
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Fecha o aplicativo
        }

        private int tentativasRestantes = 3;

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == Senha && tbUsuario.Text == nomeUsuario)
            {
                this.Hide();
                frmSplashScreen frmSplashScreen = new frmSplashScreen();
                frmSplashScreen.Show();
            }
            else
            {
                textBox2.Clear();
                tbUsuario.Clear();

                tentativasRestantes--;

                if (tentativasRestantes > 0)
                {
                    MessageBox.Show($"Usuário ou senha incorretos. Você tem mais {tentativasRestantes} tentativa(s).", "Erro de login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Quantidade máxima de tentativas. Programa fechando", "Banido", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    Application.Exit();
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}