namespace SupermercadoForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Ao abrir a tela irá deixar preeenchido por padrão a operação somar
            comboBoxOperação.SelectedItem = "Somar";
        }

        private void buttonConcatenar_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Olá mundo!");
            //Obter o nome que está preenchido no textbox do nome
            string nome = textBoxNome.Text;

            if (nome.Length > 15)
            {
                MessageBox.Show("Nome deve conter no maximo 15 caracteres");
                //encerra a execução deste metodo
                return;
            }
            if (nome.Length < 2)
            {
                MessageBox.Show("Nome deve conter no minimo 2 caracteres");
                return;
            }

            //Obter o sobrenome que está preenchido no textbox do sobrenome
            string sobrenome = textBoxSobrenome.Text;
            //Validar que o nome contem de 5 ate 150 caracteres
            if (sobrenome.Length > 150)
            {
                MessageBox.Show("Nome deve conter no maximo 15 caracteres");
                //encerra a execução deste metodo
                return;
            }
            if (sobrenome.Length < 2)
            {
                MessageBox.Show("Nome deve conter no minimo 2 caracteres");
                return;
            }

            // Concatenar o nome e sobrenome
            string nomeCompleto = nome + " " + sobrenome;
            //Apresentar o nome completo do usuário
            MessageBox.Show(nomeCompleto);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            string operacaoEscolhida = comboBoxOperação.SelectedItem.ToString();
            int numero1 = 0;
            try
            {
                numero1 = Convert.ToInt32(textBoxNumeroNum01.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Número 1 dev e ser uma numeor inteiro");
                textBoxNumeroNum01.Focus();
                return;
            }
            int numero2 = 0;
            try
            {
                numero2 = Convert.ToInt32(textBoxNum02.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Número 2 dev e ser uma numeor inteiro");
                textBoxNum02.Focus();
                return;

            }
            int resultado = 0;
            char operacaoSimbolo = ' ';
            if (operacaoEscolhida == "Somar")
            {
                resultado = numero1 + numero2;
                operacaoSimbolo = '+';
            }
            else if (operacaoEscolhida == "Subtrair")
            {
                resultado = numero1 - numero2;
                operacaoSimbolo = '-';
            }
            else if (operacaoEscolhida == "Multiplicar")
            {
                resultado = numero1 * numero2;
                operacaoSimbolo = '*';
            }
            else if (operacaoEscolhida == "Dividir")
            {
                resultado = numero1 / numero2;
                operacaoSimbolo = '/';

                if (numero2 == 0)
                {
                    MessageBox.Show("Número 2 não pode ser 0");
                    textBoxNum02.Focus();
                    return;
                }
            }



            DateTime dataHoraAtual = DateTime.Now;
            string dataHoraForamatada = dataHoraAtual.ToShortDateString() + " " +
                dataHoraAtual.ToLongTimeString();
            string texto = dataHoraForamatada + " " + numero1 + " " + operacaoSimbolo + " " + numero2 + " = " + resultado + "\n";

            richTextBoxHistorico.Text += texto;

            LimparCampos();

        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();

            richTextBoxHistorico.Clear();
        }

        private void LimparCampos()
        {
            textBoxNumeroNum01.Clear();
            textBoxNum02.Clear();
            comboBoxOperação.SelectedItem = "Somar";
            textBoxNumeroNum01.Focus();

            richTextBoxHistorico.Clear();
        }

        private void richTextBoxHistorico_TextChanged(object sender, EventArgs e)
        {

        }
    }
}