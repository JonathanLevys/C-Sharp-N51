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

            var produtos = produtoRepositorio.ObterTodos();

            for (int i = 0; i < produtos.Count; i++)
            {
                var produto = produtos[i];
                comboBoxEstoque.Items.Add(produto);
            }
        }

    }
}
