using SupermercadoForm.BancoDados;
using SupermercadoForm.Entidades;
using System.Data;

namespace SupermercadoForm.Repositorios
{
    internal class CategoriaRepositorio
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
    }
}
