using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loginForms.Shared
{
    class loginComandos
    {
        public bool cadastrado;
        public String aviso = "";
        SqlCommand comando = new SqlCommand();
        Conexao verificaConexao = new Conexao();
        SqlDataReader lendoInformacoes;

        public bool verificaLogin(String login,String senha)
        {
            comando.CommandText = "select * from TBLogin where nome = @nome,@senha";
            comando.Parameters.AddWithValue("@nome", login);
            comando.Parameters.AddWithValue("@senha", senha);

            try
            {
                comando.Connection = verificaConexao.conectar();
                lendoInformacoes = comando.ExecuteReader();
                if (lendoInformacoes.HasRows)//procura no banco
                {
                    cadastrado = true;
                    
                }
                verificaConexao.sair();
                lendoInformacoes.Close();
            }
            catch (Exception)
            {

                this.aviso = "Algo deu errado com o banco";
            }
;            return cadastrado;
        }

        public String cadastrar(String nomeLogin,String senha,String confirmarSenha)
        {
            cadastrado=false;
            if (senha.Equals(confirmarSenha))
            {
                comando.CommandText = "insert into TBLogin values (@n,@s);";
                comando.Parameters.AddWithValue("@n", nomeLogin);
                comando.Parameters.AddWithValue("@s", senha);

                try
                {
                    comando.Connection = verificaConexao.conectar();
                    comando.ExecuteNonQuery();
                    verificaConexao.sair();
                    this.aviso = "Cadastrado com sucesso";
                    cadastrado = true;
                }
                catch (Exception)
                {

                    this.aviso = "Erro com banco de dados";
                }
            }
            else
            {
                this.aviso = "Senha nao correspondem!";
            }
            
            return aviso;
        }
    }
}
