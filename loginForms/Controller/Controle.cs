using loginForms.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loginForms.Controller
{
    public class Controle
    {
        public bool cadastrado;
        public String aviso = "";
        public bool acessar(string login,String senha)
        {
            loginComandos loginForms = new loginComandos();
            loginForms.verificaLogin(login, senha);

            if (!loginForms.aviso.Equals(""))
            {
                this.aviso = loginForms.aviso;
            }

            return cadastrado;
        }

        public String cadastrar(String nomeLogin,String senha,String confirmarSenha)
        {
            loginComandos loginForms = new loginComandos();
            this.aviso = loginForms.cadastrar(nomeLogin, senha, confirmarSenha);

            if (loginForms.cadastrado)
            {
                this.cadastrado = true;
            }
            return aviso;
        }
    }
}
