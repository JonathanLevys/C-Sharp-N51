using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupermercadoForm.Telas
{
    public partial class EstantesForm : Form
    {
        public string ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\74531\\Desktop\\Supermercado.mdf;Integrated Security=True;Connect Timeout=30";
        public int IdParaEditar = -1;
        public EstantesForm()
        {
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
            string pesquisa = "%" + textBoxPesquisar.Text.Trim() + "%";

            // Conectar com o banco de dados
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = ConnectionString;
            conexao.Open();

            //definir o comando da consulta das estantes
            SqlCommand comando = conexao.CreateCommand();
            comando.CommandText = "SELECT id, nome, sigla FROM estantes WHERE nome LIKE @PESQUISA";
            comando.Parameters.AddWithValue("@PESQUISA", pesquisa);

            //CRiar tabela em memoria e carregar registros da consulta(SELECT) das estantes
            DataTable tabelaEmMemoria = new DataTable();
            tabelaEmMemoria.Load(comando.ExecuteReader());

            // Limpar dataGripView, para nao ter duplicidadede registros
            dataGridViewEstantes.Rows.Clear();

            conexao.Close();

            // Pecorrer casa um dos registros
            for (int i = 0; i < tabelaEmMemoria.Rows.Count; i++)
            {
                // Obter o registro (estantes) percorrido
                DataRow registro = tabelaEmMemoria.Rows[i];
                // Obter o id, nome e sigla da consulta realizada
                int id = Convert.ToInt32(registro["id"]);
                string nome = registro["nome"].ToString();
                string sigla = registro["sigla"].ToString();

                //Adicionar uma linha no DataGripView (componente da tabela do form)
                dataGridViewEstantes.Rows.Add(new object[]
                {
                    id, nome, sigla
                });
            }
        }
        private void CadastrarEstantes()
        {

            string nome = textBoxNome.Text;
            string sigla = maskedTextBoxSigla.Text;
            // Conectar com o banco de dados
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = ConnectionString;
            conexao.Open();

            //definir o comando da consulta das estantes
            SqlCommand comando = conexao.CreateCommand();
            comando.CommandText = "INSERT INTO estantes (nome, sigla) VALUES (@NOME, @SIGLA)";
            comando.Parameters.AddWithValue("@NOME", nome);
            comando.Parameters.AddWithValue("@SIGLA", sigla);

            // Executar o insert armazenando a quantidade de registros afetados 
            int quantidadeRegistrosAfetados = comando.ExecuteNonQuery();

            //Verificar que o registro foi persistido com sucesso
            if (quantidadeRegistrosAfetados > 0)
            {
                ListarEstantes(); // Atualizar dataGripView(tabela) com os registros deas estantes do BD
                LimparCampos(); // Limpar os campos da tela
                MessageBox.Show("Estante cadastrada com sucesso");
            }


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

            // Conectar com o banco de dados
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = ConnectionString;
            conexao.Open();

            //definir o comando da consulta das estantes
            SqlCommand comando = conexao.CreateCommand();
            comando.CommandText = "DELETE FROM estantes WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", id);

            // Executar o insert armazenando a quantidade de registros afetados 
            int quantidadeRegistrosAfetados = comando.ExecuteNonQuery();

            //Verificar que o registro foi persistido com sucesso
            if (quantidadeRegistrosAfetados > 0)
            {
                ListarEstantes(); // Atualizar dataGripView(tabela) com os registros deas estantes do BD
                MessageBox.Show("Estante apagada com sucesso");
            }
            // Fechar a conexão com BD
            conexao.Close();
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

            // Conectar com o banco de dados
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = ConnectionString;
            conexao.Open();

            //definir o comando da consulta das estantes
            SqlCommand comando = conexao.CreateCommand();
            comando.CommandText = "SELECT id, nome, sigla FROM estantes WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", IdParaEditar);

            //CRiar tabela em memoria e carregar registros da consulta(SELECT) das estantes
            DataTable tabelaEmMemoria = new DataTable();
            tabelaEmMemoria.Load(comando.ExecuteReader());

            // Obter a primeira linha da tabela pois filtramos buscando po id, retornará um unico registro
            DataRow registro = tabelaEmMemoria.Rows[0];

            // Obter o id, nome e sigla da consulta realizada
            string nome = registro["nome"].ToString();
            string sigla = registro["sigla"].ToString();

            textBoxNome.Text = nome;
            maskedTextBoxSigla.Text = sigla;

            // fechar conexão com o BD
            conexao.Close();
        }
        private void AtualizarEstantes()
        {
            string nome = textBoxNome.Text;
            string sigla = maskedTextBoxSigla.Text;

            // Conectar com o banco de dados
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = ConnectionString;
            conexao.Open();

            //definir o comando da consulta das estantes
            SqlCommand comando = conexao.CreateCommand();
            comando.CommandText = "UPDATE estantes SET nome = @NOME, sigla = @SIGLA WHERE id = @ID";
            comando.Parameters.AddWithValue("@NOME", nome);
            comando.Parameters.AddWithValue("@SIGLA", sigla);
            comando.Parameters.AddWithValue("@ID", IdParaEditar);

            //Executar o update armazenando a quantidade de registros afetados
            int quantidadeRegistroAfetados = comando.ExecuteNonQuery();

            // Verificar que o registro foi persistido com sucesso
            if (quantidadeRegistroAfetados > 0)
            {
                ListarEstantes();
                LimparCampos();
                MessageBox.Show("esntantes alterada com sucesso");
            }
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
