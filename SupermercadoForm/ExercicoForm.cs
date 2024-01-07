using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupermercadoForm
{
    public partial class ExercicoForm : Form
    {
        public ExercicoForm()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelBoletim_Click(object sender, EventArgs e)
        {

        }

        private void textBoxAluno_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDownIdade_ValueChanged(object sender, EventArgs e)
        {
        }

        private void richTextBoxResultado_TextChanged(object sender, EventArgs e)
        {
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            string Aluno = textBoxAluno.Text;

            int idade = Convert.ToInt32(numericUpDownIdade.Text);

            int nota1 = Convert.ToInt32(textBoxNota1.Text);
            int nota2 = Convert.ToInt32(textBoxNota2.Text);
            int nota3 = Convert.ToInt32(textBoxNota3.Text);


            MessageBox.Show();

        }
    }
}
