using SupermercadoRepositorio.BancoDados;
using System.Data;
using SupermercadoRepositorio.Entidades;

namespace SupermercadoRepositorio.Repositorios
{
    public class CategoriaRepositorio
    {
        public List<Categoria> ObterTodos()
        {
            // Instanciando um objeto que realiza a conexão com o BD
            var conexao = new ConexaoBancoDados();
            // Criado o comando utilizado a conexão
            var comando = conexao.Conectar();
            // definir o comando que sera executado para buscar as categorias ordenadas
            comando.CommandText = "SELECT id, nome FROM categorias ORDER BY nome ASC";
            // Instanciado uma tabela em memoria para armazenar os registros retornados do BD na consulta SELECT 
            var tabelaEmMemoria = new DataTable();
            //Executar a consulta SELECT carregando os dados na tabela em memória
            tabelaEmMemoria.Load(comando.ExecuteReader());
            //fechar conexao com o banco de dados
            comando.Connection.Close();
            // Instanciado uma lista para armazenar categorias
            var categorias = new List<Categoria>();
            // Percorrer cada um dos registros da consulta SELECT
            for (var i = 0; i < tabelaEmMemoria.Rows.Count; i++)
            {
                //Obter o registro percorrido
                var registro = tabelaEmMemoria.Rows[i];
                var id = Convert.ToInt32(registro["id"]);
                var nome = registro["nome"].ToString();

                // Instanciado um objeto de categoria para que seja possivel adicionar a lista de categoria.
                var categoria = new Categoria();
                categoria.Id = id;
                categoria.Nome = nome;

                //Adicionar a categorias na lista de categorias
                categorias.Add(categoria);

            }
            //Retornar a lista de categorias obtidas na consulta SELEXT
            return categorias;
        }
        public void Cadastrar(Categoria categoria)
        {
            // Instanciando um objeto que realiza a conexão com o BD
            var conexao = new ConexaoBancoDados();
            // Criado o comando utilizado a conexão
            var comando = conexao.Conectar();
            // definir o comando de INSERT
            comando.CommandText = "INSERT INTO categorias (nome) VALUES (@NOME)";
            // Definir todos os parametros do insert.
            comando.Parameters.AddWithValue("@NOME", categoria.Nome);
            comando.Parameters.AddWithValue("@ID", categoria.Id);
            // Executa o comando de update
            comando.ExecuteNonQuery();
            // Fecha a conexao com BD
            comando.Connection.Close();

        }
        public void Atualizar(Categoria categoria)
        {
            // Instanciando um objeto que realiza a conexão com o BD
            var conexao = new ConexaoBancoDados();
            // Criado o comando utilizado a conexão
            var comando = conexao.Conectar();
            // definir o comando de Update.
            comando.CommandText = "UPDATE categorias SET nome = @NOME WHERE id = @ID";
            // Definir todos os parametros do insert.
            comando.Parameters.AddWithValue("@NOME", categoria.Nome);
            comando.Parameters.AddWithValue("@ID", categoria.Id);
            // Executa o comando de update
            comando.ExecuteNonQuery();
            // Fecha a conexao com BD
            comando.Connection.Close();

        }
        public void Apagar(int id)
        {
            // Instanciando um objeto que realiza a conexão com o BD
            var conexao = new ConexaoBancoDados();
            // Criado o comando utilizado a conexão
            var comando = conexao.Conectar();
            // definir o comando de delete.
            comando.CommandText = "DELETE FROM categorias WHERE id = @ID";
            // Definir todos os parametros do delete.
            comando.Parameters.AddWithValue("@ID", id);
            // Executa o comando de delete
            comando.ExecuteNonQuery();
            // Fecha a conexao com BD
            comando.Connection.Close();

        }
        public Categoria ObterPorID(int id)
        {
            // Instanciando um objeto que realiza a conexão com o BD
            var conexao = new ConexaoBancoDados();
            // Criado o comando utilizado a conexão
            var comando = conexao.Conectar();
            // definir o comando que sera executado para buscar as categorias ordenadas
            comando.CommandText = "SELECT id, nome FROM categorias WHERE id = @ID";
            // Definir todos os parametros do select.
            comando.Parameters.AddWithValue("@ID", id);
            // Executa o comando de update
            comando.ExecuteNonQuery();
            // Fecha a conexao com BD
            comando.Connection.Close();
            // Instanciado uma tabela em memoria para armazenar os registros retornados do BD na consulta SELECT 
            var tabelaEmMemoria = new DataTable();
            //Executar a consulta SELECT carregando os dados na tabela em memória
            tabelaEmMemoria.Load(comando.ExecuteReader());
            //fechar conexao com o banco de dados
            comando.Connection.Close();

            var registro = tabelaEmMemoria.Rows[0];
            var nome = registro["nome"].ToString();

            // Instanciado um objeto de categoria para que seja possivel adicionar a lista de categoria.
            var categoria = new Categoria();
            categoria.Id = id;
            categoria.Nome = nome;

            return categoria;

        }
    }
}
