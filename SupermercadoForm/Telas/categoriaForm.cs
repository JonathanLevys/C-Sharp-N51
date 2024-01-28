using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SupermercadoForm.Telas
{
    public partial class categoriaForm : Form
    {
        public string ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\74531\\Desktop\\Supermercado.mdf;Integrated Security=True;Connect Timeout=30";
        public categoriaForm()
        {
            InitializeComponent();
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
            }
            // Instancia um objeto para abrir a conexão com o banco de dados
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = ConnectionString;

            conexao.Open();

            SqlCommand comando = conexao.CreateCommand();
            comando.CommandText = "INSERT INTO categorias (nome) Values ('" + nomeCategoria + "')";
            comando.ExecuteNonQuery();

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
            // Instanciar um objeto para abrir a conexão com o BD
            SqlConnection conexao = new SqlConnection();
            // Definir uma ConnectionString (onde o bd se encontra)
            conexao.ConnectionString = ConnectionString;
            // Abrir a 
            conexao.Open();

            SqlCommand comando = conexao.CreateCommand();

            comando.CommandText = "SELECT id, nome FROM categorias";

            DataTable tabelaEmMemoria = new DataTable();

            tabelaEmMemoria.Load(comando.ExecuteReader());

            // limpar campo que contém as categorias
            richTextBoxCategorias.Clear();

            for (int i = 0; i < tabelaEmMemoria.Rows.Count; i++)
            {
                DataRow registro = tabelaEmMemoria.Rows[i];
                int id = Convert.ToInt32(registro["id"]);
                string nome = registro["nome"].ToString();
                richTextBoxCategorias.AppendText("Cód: " + id + " => " + nome + "\n");
            }
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            ApagarCategorias();
        }
        private void ApagarCategorias()
        {
            int codigoInformado = Convert.ToInt32(textBoxApagar.Text);

            SqlConnection conexao = new SqlConnection();
            // Definir uma ConnectionString (onde o bd se encontra)
            conexao.ConnectionString = ConnectionString;

            conexao.Open();

            SqlCommand comando = conexao.CreateCommand();

            comando.CommandText = "DELETE FROM categorias WHERE id = " + codigoInformado;

            int quantitadeRegistrosApagados = comando.ExecuteNonQuery();

            if (quantitadeRegistrosApagados == 0)
            {
                MessageBox.Show("Não existe categoria com o código " + codigoInformado);
                textBoxApagar.Focus();
                return;
            }

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

            SqlConnection conexao = new SqlConnection();
            // Definir uma ConnectionString (onde o bd se encontra)
            conexao.ConnectionString = ConnectionString;
            // Abrir a conexão com o banco de dados
            conexao.Open();
            // Criar o objeto que será utilizado para defenir o comando que será executado
            SqlCommand comando = conexao.CreateCommand();
            // Defenir o comando que será executado
            comando.CommandText = "UPDATE categorias SET nome = '" + nome + "' WHERE id = " + codigoParaAlterar;
            // Defenir o comando para atualizar a categoria
            int quantidadeAlterada = comando.ExecuteNonQuery();

            // Verificar que não foi alterado a categoria
            if (quantidadeAlterada == 0)
            {
                // Apresentar feedback que nenhum registro foi atualizado
                MessageBox.Show("Não existe categoria com o código " + codigoParaAlterar);
                textBoxApagar.Focus();
                return;
            }

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
