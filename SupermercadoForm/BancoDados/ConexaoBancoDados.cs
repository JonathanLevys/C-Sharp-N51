using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermercadoForm.BancoDados
{
    internal class ConexaoBancoDados
    {
        private string ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\74531\\Desktop\\SupermercadoDados.mdf;Integrated Security=True;Connect Timeout=30";

        public SqlCommand Conectar()
        {
            var conexao = new SqlConnection();
            conexao.ConnectionString = ConnectionString;
            conexao.Open();

            SqlCommand comando = conexao.CreateCommand();

            return comando;

        }
    }
}
