using Microsoft.EntityFrameworkCore;
using SupermercadoForm.Modelos;
using SupermercadoRepositorio.BancoDados;
using SupermercadoRepositorio.Entidades;
using SupermercadoRepositorio.Repositorios;
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
    public class ProdutoRepositorio : IProdutoRepositorio
    {
        private readonly SupermercadoContexto _contexto;
        public ProdutoRepositorio()
        {
            _contexto = new SupermercadoContexto();
        }
        public void Cadastrar(Produto produto)
        {
            _contexto.Produtos.Add(produto);
            _contexto.SaveChanges();
        }
        public List<Produto> ObterTodos(ProdutoFiltros produtoFiltros)
        {
            return _contexto.Produtos
            .Include(x => x.Categoria)
            .ToList();
        }
        public int ObterQuantidadeTotalRegistros()
        {
            return _contexto.Produtos.Count();
        }
        public void Apagar(int id)
        {
            var produto = ObterPorId(id);
            _contexto.Produtos.Remove(produto);
            _contexto.SaveChanges();

        }

        public Produto ObterPorId(int id)
        {
            return _contexto.Produtos.Where(x => x.Id == id).FirstOrDefault();


        }
        public void Atualizar(Produto produto)
        {
            _contexto.Produtos.Update(produto);
            _contexto.SaveChanges();
        }
    }
}
