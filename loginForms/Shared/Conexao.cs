using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loginForms.Shared
{
    public class Conexao
    {
        SqlConnection verificaConexao = new SqlConnection();
        public Conexao()
        {
            verificaConexao.ConnectionString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = TestesDeProjetos; Integrated Security = True";
        }

        public SqlConnection conectar()
        {
            if (verificaConexao.State == System.Data.ConnectionState.Closed)

            {
                verificaConexao.Open();
            }
            return verificaConexao;
        }

        public void sair()
        {
            if (verificaConexao.State == System.Data.ConnectionState.Open)
            {
                verificaConexao.Close();
            }

        }
    }
}
