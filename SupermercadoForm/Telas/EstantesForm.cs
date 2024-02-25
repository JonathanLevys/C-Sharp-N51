using SupermercadoForm.Repositorios;
using SupermercadoRepositorio.Entidades;

namespace SupermercadoForm.Telas
{
    public partial class EstantesForm : Form
    {
        private IEstanteRepositorio repositorio;
        public int IdParaEditar = -1;

        public EstantesForm()
        {
            repositorio = new EstanteRepositorio();
            InitializeComponent();
            ListarEstantes();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            // Verificar que é o modo de cadastro, pois -1 não é id valido
            if (IdParaEditar == -1)
            {
                CadastrarEstantes();
            }
            else
            {
                AtualizarEstantes();
            }
        }

        private void ListarEstantes()
        {
            // Obter o texto para pesquisa
            string pesquisa = textBoxPesquisar.Text.Trim();

            // Limpar dataGripView, para nao ter duplicidadede registros
            dataGridViewEstantes.Rows.Clear();

            var estantes = repositorio.ObterTodos(pesquisa);

            // Pecorrer casa um dos registros
            foreach (var estante in estantes)

                dataGridViewEstantes.Rows.Add(new object[]
                {
                    estante.Id, estante.Nome, estante.Sigla
                });

        }

        private void CadastrarEstantes()
        {

            string nome = textBoxNome.Text;
            string sigla = maskedTextBoxSigla.Text;

            var estante = new Estante();
            estante.Nome = nome;
            estante.Sigla = sigla;

            repositorio.Cadastrar(estante);

            ListarEstantes(); // Atualizar dataGripView(tabela) com os registros deas estantes do BD
            LimparCampos(); // Limpar os campos da tela
            MessageBox.Show("Estante cadastrada com sucesso");


        }

        private void LimparCampos()
        {
            textBoxNome.Clear();
            maskedTextBoxSigla.Clear();
            IdParaEditar = -1; // Redefinir para -1 para que seja possivel usuário fazer o cadastro novamente
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            ApagarEstantes();
        }

        private void ApagarEstantes()
        {
            // Verificar que existe linhas(registros) no DataGripView
            if (dataGridViewEstantes.Rows.Count == 0)
            {
                MessageBox.Show(
                    " nenhuma estante cadastrada",
                    "AVISO",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
                return;
            }

            //Pegar a linha que o usuario selecionou
            DataGridViewRow LinhaSelecionada = dataGridViewEstantes.SelectedRows[0];
            //Pegar o id da linha selecionada
            int id = Convert.ToInt32(LinhaSelecionada.Cells[0].Value);  // Cells [0] pq a primeira coluna do DataGripView é o id
            string nome = LinhaSelecionada.Cells[1].Value.ToString();

            // Questionar se deseja realmente apagar o registro
            DialogResult resultadoQustionamento = MessageBox.Show(
                "Deseja realmente apagar " + nome + "?",
                "AVISO",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
                );

            // Verificar se deseja manter o registro
            if (resultadoQustionamento == DialogResult.No)
            {
                return;
            }

            repositorio.Apagar(id);

            ListarEstantes(); // Atualizar dataGripView(tabela) com os registros deas estantes do BD
            MessageBox.Show("Estante apagada com sucesso");
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            EditarEstantes();
        }

        private void EditarEstantes()
        {
            // Verificar que existe linhas(registros) no DataGripView
            if (dataGridViewEstantes.Rows.Count == 0)
            {
                MessageBox.Show(
                    " nenhuma estante cadastrada",
                    "AVISO",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
                return;
            }

            //Pegar a linha que o usuario selecionou
            DataGridViewRow LinhaSelecionada = dataGridViewEstantes.SelectedRows[0];
            //Pegar o id da linha selecionada
            IdParaEditar = Convert.ToInt32(LinhaSelecionada.Cells[0].Value);  // Cells [0] pq a primeira coluna do DataGripView é o id

            var estante = repositorio.ObterPorId(IdParaEditar);

            textBoxNome.Text = estante.Nome;
            maskedTextBoxSigla.Text = estante.Sigla;

        }

        private void AtualizarEstantes()
        {
            string nome = textBoxNome.Text;
            string sigla = maskedTextBoxSigla.Text;

            var estante = repositorio.ObterPorId(IdParaEditar);
            estante.Nome = nome;
            estante.Sigla = sigla;

            repositorio.Atualizar(estante);

            ListarEstantes();
            LimparCampos();
            MessageBox.Show("estantes alterada com sucesso");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPesquisar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ListarEstantes();
            }
        }
    }
}
