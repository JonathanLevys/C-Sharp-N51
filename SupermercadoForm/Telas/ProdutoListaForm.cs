using SupermercadoForm.Modelos;
using SupermercadoForm.Repositorios;
using SupermercadoRepositorio.Repositorios;

namespace SupermercadoForm.Telas
{
    public partial class ProdutoListaForm : Form
    {
        private IProdutoRepositorio produtoRepositorio;
        private int PosicaoPaginacao = 0;
        private int QuantidadeRegistros = 0;

        public ProdutoListaForm()
        {
            InitializeComponent();
            produtoRepositorio = new ProdutoRepositorio();
            comboBoxExibir.SelectedIndex = 0;
            comboBoxOrdenar.SelectedIndex = 0;
            comboBoxQuantidade.SelectedIndex = 0;

        }


        private void ProdutoListaForm_Load(object sender, EventArgs e)
        {
            PreencherDataGridViewComProdutos();
        }

        private void PreencherDataGridViewComProdutos()
        {
            //Remover  todas as linhas do datagridview (Para nao ficar lixo, pois iremos adicioner os registros novamente)
            dataGridViewProdutos.Rows.Clear();

            //Obter o que foi preenchido no campo de pesquisa
            var produtoFiltros = new ProdutoFiltros();

            produtoFiltros.Pesquisa = textBoxPesquisa.Text.Trim();
            produtoFiltros.Quantidade = ObterQuantidadeParaExibir();
            produtoFiltros.OrdenacaoCampo = comboBoxExibir.SelectedItem.ToString();
            produtoFiltros.OrdenacaoOrdem = comboBoxOrdenar.SelectedItem.ToString();
            produtoFiltros.Pagina = PosicaoPaginacao;


            // Obter a lista de categorias (SELECT no BD)
            var produtos = produtoRepositorio.ObterTodos(produtoFiltros);
            //percorrer cada uma das categorias obtidas na consulta (SELECT), adicionando no combobox da categoria
            for (int i = 0; i < produtos.Count; i++)
            {
                //categoria percorrida
                var produto = produtos[i];
                dataGridViewProdutos.Rows.Add(new object[]
                {
                    produto.Id,
                    produto.Nome,
                    produto.Categoria.Nome,
                    produto.PrecoUnitario
                });

            }

            DesabilitarBotaoPaginacaoNegativa();
            PreencherLabelQuantidadeTotalRegistros();
        }

        private void buttonNovo_Click(object sender, EventArgs e)
        {
            var formCadastro = new ProdutoCadastroForm();
            formCadastro.Text = "Cadastro de Produto";
            formCadastro.ShowDialog();
        }

        private void dataGridViewProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            PreencherDataGridViewComProdutos();
        }

        private void textBoxPesquisa_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            PreencherDataGridViewComProdutos();
        }

        private void comboBoxExibir_SelectedIndexChanged(object sender, EventArgs e)
        {
            PreencherDataGridViewComProdutosCasoComboEstiverPreenchidos();
        }

        private void PreencherDataGridViewComProdutosCasoComboEstiverPreenchidos()
        {
            if (comboBoxExibir.SelectedIndex != -1 &&
                comboBoxOrdenar.SelectedIndex != -1 &&
                comboBoxQuantidade.SelectedIndex != -1)
            {
                PosicaoPaginacao = 0;
                PreencherDataGridViewComProdutos();
            }
        }

        private void comboBoxOrdenar_SelectedIndexChanged(object sender, EventArgs e)
        {
            PreencherDataGridViewComProdutosCasoComboEstiverPreenchidos();
        }

        private void comboBoxQuantidade_SelectedIndexChanged(object sender, EventArgs e)
        {
            PreencherDataGridViewComProdutosCasoComboEstiverPreenchidos();
        }

        private void ButtonPaginacaoProximo_Click(object sender, EventArgs e)
        {
            int quantidadeParaExibir = ObterQuantidadeParaExibir();
            PosicaoPaginacao += quantidadeParaExibir;
            PreencherDataGridViewComProdutos();
        }

        private void ButtonPaginacaoAnterior_Click(object sender, EventArgs e)
        {
            int quantidadeParaExibir = ObterQuantidadeParaExibir();
            PosicaoPaginacao -= quantidadeParaExibir;
            PreencherDataGridViewComProdutos();
        }

        private void DesabilitarBotaoPaginacaoNegativa()
        {
            int quantidadeParaExibir = ObterQuantidadeParaExibir();
            if (PosicaoPaginacao - quantidadeParaExibir < 0)
            {
                ButtonPaginacaoAnterior.Enabled = false;
            }
            if (PosicaoPaginacao - quantidadeParaExibir >= 0)
            {
                ButtonPaginacaoAnterior.Enabled = true;
            }
            if (PosicaoPaginacao + quantidadeParaExibir >= QuantidadeRegistros)
            {
                ButtonPaginacaoProximo.Enabled = false;
            }
            if (PosicaoPaginacao + quantidadeParaExibir < QuantidadeRegistros)
            {
                ButtonPaginacaoProximo.Enabled = true;
            }


        }

        private void PreencherLabelQuantidadeTotalRegistros()
        {
            var produtoRepositorio = new ProdutoRepositorio();
            QuantidadeRegistros = produtoRepositorio.ObterQuantidadeTotalRegistros();
            labellabelQuantidadeTotalValor.Text = QuantidadeRegistros.ToString();
        }

        private int ObterQuantidadeParaExibir()
        {
            var quantidadeSelecionada = comboBoxQuantidade.SelectedItem.ToString();

            var campoQuantidade = 10;
            if (quantidadeSelecionada == "25 Itens")
                campoQuantidade = 25;
            else if (quantidadeSelecionada == "50 itens")
                campoQuantidade = 50;
            else if (quantidadeSelecionada == "100 itens")
                campoQuantidade = 100;

            return campoQuantidade;
        }

        private void buttonLimparFiltros_Click(object sender, EventArgs e)
        {
            comboBoxExibir.SelectedIndex = 0;
            comboBoxOrdenar.SelectedIndex = 0;
            comboBoxQuantidade.SelectedIndex = 0;
            textBoxPesquisa.Clear();
            PreencherDataGridViewComProdutos();
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            var linhaSelecionada = dataGridViewProdutos.SelectedRows[0];
            var id = Convert.ToInt32(linhaSelecionada.Cells[0].Value);
            var nome = linhaSelecionada.Cells[1].Value.ToString();

            var resposta = MessageBox.Show(
                $"Deseja realmente apagar o {nome}?",
                "AVISO",
                MessageBoxButtons.YesNo);
            if (resposta == DialogResult.No)
                return;

            produtoRepositorio.Apagar(id);
            PreencherDataGridViewComProdutos();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            var linhaSelecionada = dataGridViewProdutos.SelectedRows[0];
            var id = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

            var produtoSelecionado = produtoRepositorio.ObterPorId(id);

            var produtoCadastradoForm = new ProdutoCadastroForm(produtoSelecionado);
            produtoCadastradoForm.ShowDialog();
        }
    }
}
