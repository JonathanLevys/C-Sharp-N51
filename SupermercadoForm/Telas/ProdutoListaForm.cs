using SupermercadoForm.Repositorios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupermercadoForm.Telas
{
    public partial class ProdutoListaForm : Form
    {
        public ProdutoListaForm()
        {
            InitializeComponent();
        }


        private void ProdutoListaForm_Load(object sender, EventArgs e)
        {
            PreencherDataGridViewComProdutos();
        }

        private void PreencherDataGridViewComProdutos()
        {
            //Instanciado um objeto do PreencherDadosCategorias, para obtermos a lista de produtos, 
            var produtoRepositorio = new ProdutoRepositorio();
            // Obter a lista de categorias (SELECT no BD)
            var produtos = produtoRepositorio.ObterTodos();
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
    }
}
