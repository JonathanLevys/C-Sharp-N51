﻿using System.Data.SqlClient;

namespace SupermercadoRepositorio.BancoDados
{
    public class ConexaoBancoDados
    {
        private string ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\74531\\Documents\\SupermercadoBancoDado.mdf;Integrated Security=True;Connect Timeout=30";

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
