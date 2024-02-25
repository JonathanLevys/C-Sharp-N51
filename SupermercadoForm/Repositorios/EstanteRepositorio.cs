using SupermercadoForm.BancoDados;
using SupermercadoForm.Entidades;
using System.Data;

namespace SupermercadoForm.Repositorios
{
    internal class EstanteRepositorio : IEstanteRepositorio
    {
        private ConexaoBancoDados conexao;

        // Construtor tem como objetivo defini/construir tudo que é necessario que a classe funcione correntamente
        // Encapsulamento + NomeClasseAtual()
        public EstanteRepositorio()
        {
            //Instanciando um objeto da classe ConexaoBancoDados, para que se possível abrir a conexao com BD.
            conexao = new ConexaoBancoDados();
        }
        public void Apagar(int id)
        {
            var comando = conexao.Conectar();
            comando.CommandText = "DELETE FROM categorias WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", id);
            comando.ExecuteNonQuery();
            comando.Connection.Close();
        }

        public void Atualizar(Estante estante)
        {
            var comando = conexao.Conectar();
            comando.CommandText = "UPDATE  estantes SET nome = @NOME, sigla = @SIGLA WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", estante.Id);
            comando.Parameters.AddWithValue("@NOME", estante.Nome);
            comando.Parameters.AddWithValue("@SIGLA", estante.Sigla);

            comando.ExecuteNonQuery();
            comando.Connection.Close();
        }

        public void Cadastrar(Estante estante)
        {
            var comando = conexao.Conectar();
            comando.CommandText = "INSERT INTO estantes (nome, sigla) VALUES (@NOME, @SIGLA)";
            comando.Parameters.AddWithValue("@NOME", estante.Nome);
            comando.Parameters.AddWithValue("@SIGLA", estante.Sigla);

            comando.ExecuteNonQuery();
            comando.Connection.Close();
        }

        public Estante ObterPorId(int id)
        {
            var comando = conexao.Conectar();
            comando.CommandText = "SELECT id, nome, sigla FROM estantes WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", id);

            var tabelaEmMemoria = new DataTable();
            tabelaEmMemoria.Load(comando.ExecuteReader());
            
            comando.Connection.Close();

            var registro = tabelaEmMemoria.Rows[0];
            //Criar o objeto do estante com os dados da consulta
            var estante = new Estante();
            estante.Id = id;
            estante.Nome = registro["nome"].ToString();
            estante.Sigla = registro["sigla"].ToString();
            return estante;

        }

        public List<Estante> ObterTodos(string pesquisa)
        {
            pesquisa = $"%{pesquisa}%";
            //Abrir conexao com BD
            var comando = conexao.Conectar();
            //Definir o comando de obter a estante buscando por id
            comando.CommandText = "SELECT id, nome, sigla FROM estantes WHERE nome LIKE @PESQUISA";
            // Definir os paramentros da consulta
            comando.Parameters.AddWithValue("@PESQUISA", pesquisa);
            //Criar tabela em memoria para carregar os registros da consulta (SELECT) 
            var tabelaEmMemoria = new DataTable();
            //Carregar tabela em memoria
            tabelaEmMemoria.Load(comando.ExecuteReader());
            // Fechar a conexão com o BD
            comando.Connection.Close();
            //Criar lista de estanes para armazenar os registros da consulta
            var estantes = new List <Estante>();
            // Percorrer cada um dos registros
            foreach (DataRow registro in tabelaEmMemoria.Rows)
            {
                //Criar o objeto de estante com os dados da consulta
                var estante = new Estante();
                estante.Id = Convert.ToInt32(registro["id"]);
                estante.Nome = registro["nome"].ToString();
                estante.Sigla = registro["sigla"].ToString();
                estantes.Add(estante);
            }
            return estantes;
        }
    }
}
