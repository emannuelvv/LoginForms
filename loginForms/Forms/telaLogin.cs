using loginForms.Controller;
using loginForms.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loginForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNovoCadastro_Click(object sender, EventArgs e)
        {
            telaCadastro cadastro = new telaCadastro();
            cadastro.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            controle.acessar(txtLogin.Text, txtSenha.Text);

            if (controle.aviso.Equals(""))
            {
                if (controle.cadastrado)
                {
                    MessageBox.Show("Logado ", "Entrando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    telaPrincipal principal = new telaPrincipal();
                    principal.Show();
                }
                else
                {
                    MessageBox.Show("Login não encontrado,verifique seu login e senha", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(controle.aviso);
            }
        }
    }
}

