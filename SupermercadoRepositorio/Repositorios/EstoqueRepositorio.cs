using SupermercadoRepositorio.BancoDados;

namespace SupermercadoForm.Repositorios
{
    public class EstoqueRepositorio
    {
        public void Cadastrar(int  id_produto, int quantidade) 
        {
            //Instanciando um objeto que realiza
            var conexao = new ConexaoBancoDados();

            var comando = conexao.Conectar();

            comando.CommandText = "INSERT INTO estoques (quantidade, id_produto) VALUES (@QUANTIDADE, @ID_PRODUTO)";

            comando.Parameters.AddWithValue("@QUANTIDADE", quantidade);
            comando.Parameters.AddWithValue("@ID_PRODUTO", id_produto);
            comando.ExecuteNonQuery();

            comando.Connection.Close();


        }
        //public List<Estoque> ObterTodos()
        //{
        //    // Instanciando um objeto que realiza a conexão com o BD
        //    var conexao = new ConexaoBancoDados();
        //    // Criado o comando utilizado a conexão
        //    var comando = conexao.Conectar();
        //    // definir o comando que sera executado para buscar as categorias ordenadas
        //    comando.CommandText = "SELECT id, produto FROM estoques ORDER BY produto ASC";
        //    // Instanciado uma tabela em memoria para armazenar os registros retornados do BD na consulta SELECT 
        //    var tabelaEmMemoria = new DataTable();
        //    //Executar a consulta SELECT carregando os dados na tabela em memória
        //    tabelaEmMemoria.Load(comando.ExecuteReader());
        //    //fechar conexao com o banco de dados
        //    comando.Connection.Close();
        //    // Instanciado uma lista para armazenar categorias
        //    var estoques = new List<Estoque>();
        //    // Percorrer cada um dos registros da consulta SELECT
        //    for (var i = 0; i < tabelaEmMemoria.Rows.Count; i++)
        //    {
        //        //Obter o registro percorrido
        //        var registro = tabelaEmMemoria.Rows[i];
        //        var id = Convert.ToInt32(registro["id"]);
        //        var produto = registro["produto"].ToString();

        //        // Instanciado um objeto de categoria para que seja possivel adicionar a lista de categoria.
        //        var estoque = new Estoque();
        //        estoque.Id = id;
        //        estoque.Produto = produto;

        //        //Adicionar a categorias na lista de categorias
        //        estoques.Add(estoque);

        //    }
        //    //Retornar a lista de categorias obtidas na consulta SELEXT
        //    return estoques;


        //}
    }
}
