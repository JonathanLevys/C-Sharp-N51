using SupermercadoForm.BancoDados;
using SupermercadoForm.Entidades;
using System.Data;

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
        public List<Produto> ObterTodos()
        {
            // Instanciando um objeto que realiza a conexão com o BD
            var conexao = new ConexaoBancoDados();
            // Criado o comando utilizado a conexão
            var comando = conexao.Conectar();
            // definir o comando que sera executado para buscar as categorias ordenadas
            comando.CommandText = """
                SELECT
                    produtos.id,
                    produtos.nome,
                    produtos.id_categoria AS 'categoriaId',
                    produtos.preco_unitario,
                    categorias.nome AS 'categoriaNome'
               FROM produtos
               
               -- JOIN: consulta multi tabelas;
               INNER JOIN categorias ON (produtos.id_categoria = categorias.id);
""";

            // Instanciado uma tabela em memoria para armazenar os registros retornados do BD na consulta SELECT 
            var tabelaEmMemoria = new DataTable();
            //Executar a consulta SELECT carregando os dados na tabela em memória
            tabelaEmMemoria.Load(comando.ExecuteReader());
            //fechar conexao com o banco de dados
            comando.Connection.Close();
            // Instanciado uma lista para armazenar categorias
            var produtos = new List<Produto>();
            // Percorrer os registros armazenados na tabela em memória
            for (int i = 0; i < tabelaEmMemoria.Rows.Count; i++)
            {
                // Obter o registro percorrido
                var registro = tabelaEmMemoria.Rows[i];

                var produto = new Produto();
                produto.Id = Convert.ToInt32(registro["id"]);
                produto.Nome = registro["nome"].ToString();
                produto.PrecoUnitario = Convert.ToDecimal(registro["preco_unitario"]);

                // Instanciar um objero preenchendo os dados da categoria
                var categoria = new Categoria();
                categoria.Id = Convert.ToInt32(registro["categoriaId"]);
                categoria.Nome = registro["categoriaNome"].ToString();

                // Definir a categoria para o objeto do produto, para qie seja possivel visualizar na tela a categoria do produto.
                produto.Categoria = categoria;

                produtos.Add(produto);
            }
            return produtos;
        }
    }
}
