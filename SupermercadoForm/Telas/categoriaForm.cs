using SupermercadoRepositorio.Entidades;
using SupermercadoRepositorio.Repositorios;

namespace SupermercadoForm.Telas
{
    public partial class CategoriaForm : Form
    {
        private ICategoriaRepositorio repositorio;

        public CategoriaForm()
        {
            InitializeComponent();
            // Instanciando um objeto de classe CategoriaRepositorio
            repositorio = new CategoriaRepositorio();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //CRUD
            //Create => INSERT
            CriarCategoria();
            //Read => SELECT
            //Update
            //Delete
        }

        private void CriarCategoria()
        {
            // Obter o nome da categoria que o usuario preencheu
            string nomeCategoria = textBoxNome.Text;
            if (nomeCategoria.Length < 3)
            {
                MessageBox.Show("Nome da categoria deve conter no minimo 3 caracteres.");
                return;
            }
            var categoria = new Categoria();
            categoria.Nome = nomeCategoria;

            repositorio.Cadastrar(categoria);

            //Limpar o campo do nome
            textBoxNome.Clear();

            MessageBox.Show("Categoria criada com sucesso!");

            ListarCategorias();
        }

        private void buttonListar_Click(object sender, EventArgs e)
        {
            //CRUD
            // READ
            ListarCategorias();
        }

        private void ListarCategorias()
        {
            // limpar campo que contém as categorias
            richTextBoxCategorias.Clear();

            var categorias = repositorio.ObterTodos();

            for (int i = 0; i < categorias.Count; i++)
            {
                //Obter id e nome do registro percorrido
                var categoria = categorias[i];
                //Adicionar no campo das categorias o registro percorrido
                richTextBoxCategorias.AppendText("Cód: " + categoria.Id + " => " + categoria.Nome + "\n");
            }
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            ApagarCategorias();
        }

        private void ApagarCategorias()
        {
            int codigoInformado = Convert.ToInt32(textBoxApagar.Text);

            repositorio.Apagar(codigoInformado);

            // Verificar quue nenhum campo foi apagado
          /*  if (quantitadeRegistrosApagados == 0)
            {
                MessageBox.Show("Não existe categoria com o código " + codigoInformado);
                textBoxApagar.Focus();
                return;
            }
            */
            textBoxApagar.Clear();

            MessageBox.Show("Registro apagado com sucesso.");

            ListarCategorias();

        }
        
        private void categoriaForm_Load(object sender, EventArgs e)
        {
            // Preeencher a lista da categoria com os registro da tabela de categorias
            ListarCategorias();


        }

        private void categoriaForm_Shown(object sender, EventArgs e)
        {
            // Colocar o cursor no textbox do campo cadastrar
            textBoxNome.Focus();

        }

        private void categoriaForm_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        // 
        private void textBoxNome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CriarCategoria();
            }
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            AlterarCategoria();
        }

        private void AlterarCategoria()
        {
            int codigoParaAlterar = Convert.ToInt32(textBoxAlterarCodigo.Text);
            string nome = textBoxAlterarNome.Text;

            var categoria = new Categoria();
            categoria.Id = codigoParaAlterar;
            categoria.Nome = nome;

            repositorio.Atualizar(categoria);
            /*
            // Verificar que não foi alterado a categoria
            if (quantidadeAlterada == 0)
            {
                // Apresentar feedback que nenhum registro foi atualizado
                MessageBox.Show("Não existe categoria com o código " + codigoParaAlterar);
                textBoxApagar.Focus();
                return;
            }
            */
            // Limpar campos de atualização
            textBoxAlterarCodigo.Clear();
            textBoxAlterarNome.Clear();
            // Apresentar feedback que o registro foi atualizado
            MessageBox.Show("Categoria atualizada com sucesso.");
            // Atualizar lista de categorias
            ListarCategorias();
        }

        private void textBoxNome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
