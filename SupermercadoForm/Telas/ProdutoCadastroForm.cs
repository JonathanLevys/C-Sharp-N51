using SupermercadoForm.Repositorios;
using SupermercadoRepositorio.Entidades;
using SupermercadoRepositorio.Repositorios;
using System.Diagnostics.Eventing.Reader;

namespace SupermercadoForm.Telas
{
    public partial class ProdutoCadastroForm : Form
    {
        private int IdProdutoEditar = -1;
        public ProdutoCadastroForm()
        {
            InitializeComponent();
            PreencherDadosCategorias();
        }

        public ProdutoCadastroForm(Produto produto)
        {
            InitializeComponent();
            PreencherDadosCategorias();
            textBoxNome.Text = produto.Nome;
            textBoxPreçoUnitario.Text = produto.PrecoUnitario.ToString();

            foreach (var item in comboBoxCategoria.Items)
            {
                var categoria = (Categoria)item;
                var categoriaId = categoria.Id;
                if (categoriaId == produto.Categoria.Id)
                {
                    comboBoxCategoria.SelectedItem = categoria;
                    break;
                }

            }
        }


        private void PreencherDadosCategorias()
        {
            //Instanciado um objeto do PreencherDadosCategorias, para obtermos a lista de categorias, 
            //para permitir o usuario escolher a categoria desejada no combobox da Categoria
            var categoriaRepositorio = new CategoriaRepositorio();
            // Obter a lista de categorias (SELECT no BD)
            var categorias = categoriaRepositorio.ObterTodos();
            //percorrer cada uma das categorias obtidas na consulta (SELECT), adicionando no combobox da categoria
            for (int i = 0; i < categorias.Count; i++)
            {
                //categoria percorrida
                var categoria = categorias[i];
                //adicionar a categoria percorrida no combobox da categoria
                comboBoxCategoria.Items.Add(categoria);
            }
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            //obter a Categoria Selecionada
            var categoria = (Categoria)comboBoxCategoria.SelectedItem;

            var nome = textBoxNome.Text;
            var precoUnitario = Convert.ToDecimal(textBoxPreçoUnitario.Text);

            var repositorio = new ProdutoRepositorio();

            Produto produto;

            if (IdProdutoEditar == -1)
            {
                produto = new Produto()
                {
                    Nome = nome,
                    PrecoUnitario = precoUnitario,
                    Categoria = categoria

                };

                repositorio.Cadastrar(produto);
                MessageBox.Show("Produto cadastrado com sucesso");
                return;
            }
            produto = repositorio.ObterPorId(IdProdutoEditar);
            produto.Nome = nome;
            produto.PrecoUnitario = precoUnitario;
            produto.Categoria = categoria;

            repositorio.Atualizar(produto);
            MessageBox.Show("Produto atualizado com sucesso");
        }
    }

}

