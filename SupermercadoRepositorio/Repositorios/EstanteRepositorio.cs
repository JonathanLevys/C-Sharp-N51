using SupermercadoRepositorio.BancoDados;
using SupermercadoRepositorio.Entidades;
using System.Data;

namespace SupermercadoForm.Repositorios
{
    public class EstanteRepositorio : IEstanteRepositorio
    {
        private readonly SupermercadoContexto _contexto;
        // Construtor tem como objetivo defini/construir tudo que é necessario que a classe funcione correntamente
        // Encapsulamento + NomeClasseAtual()
        public EstanteRepositorio()
        {
            //Instanciando um objeto da classe ConexaoBancoDados, para que se possível abrir a conexao com BD.
            _contexto = new SupermercadoContexto();
        }
        public void Apagar(int id)
        {
            var estante = ObterPorId(id);
            _contexto.Estantes.Remove(estante);
        }

        public void Atualizar(Estante estante)
        {
            _contexto.Estantes.Update(estante);
            _contexto.SaveChanges();
        }

        public void Cadastrar(Estante estante)
        {
            _contexto.Estantes.Add(estante);
            _contexto.SaveChanges();
        }

        public Estante ObterPorId(int id)
        {
            return _contexto.Estantes.Where(x => x.Id == id).FirstOrDefault();
        }

        public List<Estante> ObterTodos(string pesquisa)
        {
            return _contexto.Estantes.Where(x => x.Nome.Contains(pesquisa)).ToList();
        }
    }
}
