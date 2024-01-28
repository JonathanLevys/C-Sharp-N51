using SupermercadoForm.BancoDados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermercadoForm.Repositorios
{
    // Repositório: tem a responsabilidade de
    // intermediar a camadas anteriores (tela) com o Banco de Dados, ou seja, ele é responsável 
    // por executar comandos de SQL (SELECT,INSERT,UPDATE,DELETE) 
    // CRUD => 
    // Create => INSERT
    // Read => SELECT
    // Update => UPDATE
    // Delete => DELETE
    internal class ProdutoRepositorio
        
    {
        public void Cadastrar(string nome, int idCategoria, decimal precoUnitario)
        {
            //Instanciando um objeto que realiza
            var conexao = new ConexaoBancoDados();

            var comando = conexao.Conectar();

            comando.CommandText = "INSERT INTO produtos ( nome, id_categoria, preco_unitario) VALUES (@NOME, @ID_CATEGORIA, @PRECO_UNITARIO)";

            comando.Parameters.AddWithValue("@NOME", nome);
            comando.Parameters.AddWithValue("@ID_CATEGORIA", idCategoria);
            comando.Parameters.AddWithValue("@PRECO_UNITARIO", precoUnitario);
            comando.ExecuteNonQuery();
            //Fechar a conexão com o BD.
            comando.Connection.Close();
        }
    }
}
