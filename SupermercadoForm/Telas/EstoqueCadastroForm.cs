using SupermercadoForm.Modelos;
using SupermercadoForm.Repositorios;

namespace SupermercadoForm.Telas
{
    public partial class EstoqueCadastroForm : Form
    {
        public EstoqueCadastroForm()
        {
            InitializeComponent();
            PreencherDadosEstoques();
        }

        private void PreencherDadosEstoques()
        {
            var produtoRepositorio = new ProdutoRepositorio();

            var produtoFiltros = new ProdutoFiltros();
            produtoFiltros.Quantidade = 10000;
            produtoFiltros.Pagina = 0;

            var produtos = produtoRepositorio.ObterTodos(produtoFiltros);

            for (int i = 0; i < produtos.Count; i++)
            {
                var produto = produtos[i];
                comboBoxEstoque.Items.Add(produto);
            }
        }

    }
}
