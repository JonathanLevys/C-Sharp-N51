namespace SupermercadoForm.Telas
{
    public partial class EstoqueForm : Form
    {
        public EstoqueForm()
        {
            InitializeComponent();
        }

        public int id { get; internal set; }

        private void buttonNovoEstoque_Click(object sender, EventArgs e)
        {
            new EstoqueCadastroForm().ShowDialog();
        }
    }
}
