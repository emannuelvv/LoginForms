using loginForms.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loginForms.Forms
{
    public partial class telaCadastro : Form
    {
        public telaCadastro()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            String aviso = controle.cadastrar(txtLogin.Text, txtSenha.Text, txtSenhaConfirmada.Text);
            if (controle.cadastrado)
            {
                MessageBox.Show(aviso,"Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(controle.aviso);
            }
        }
    }
}
