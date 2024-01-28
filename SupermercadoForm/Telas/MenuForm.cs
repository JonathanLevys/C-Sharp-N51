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
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void buttonCategorias_Click(object sender, EventArgs e)
        {
            // Instanciar um objeto
            categoriaForm form = new categoriaForm();
            // Torna o dor visivel
            form.ShowDialog();
        }

        private void buttonEstantes_Click(object sender, EventArgs e)
        {
            // Instanciar um objeto do form de estantes
            EstantesForm form = new EstantesForm();
            // Torna o dor visivel
            form.ShowDialog();
        }

        private void buttonProdutos_Click(object sender, EventArgs e)
        {
            var form = new ProdutoListaForm();
            form.ShowDialog();
        }
    }
}
