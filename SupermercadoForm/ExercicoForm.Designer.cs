namespace SupermercadoForm
{
    partial class ExercicoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExercicoForm));
            labelAluno = new Label();
            buttonCalcular = new Button();
            textBoxAluno = new TextBox();
            labelBoletim = new Label();
            labelIdade = new Label();
            labelCSahrp = new Label();
            numericUpDownIdade = new NumericUpDown();
            labelNota1 = new Label();
            labelNota2 = new Label();
            labelNota3 = new Label();
            textBoxNota1 = new TextBox();
            textBoxNota2 = new TextBox();
            textBoxNota3 = new TextBox();
            richTextBoxResultado = new RichTextBox();
            labelResultado = new Label();
            pictureBoxProfessor = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDownIdade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProfessor).BeginInit();
            SuspendLayout();
            // 
            // labelAluno
            // 
            labelAluno.AutoSize = true;
            labelAluno.Location = new Point(29, 121);
            labelAluno.Name = "labelAluno";
            labelAluno.Size = new Size(39, 15);
            labelAluno.TabIndex = 0;
            labelAluno.Text = "Aluno";
            // 
            // buttonCalcular
            // 
            buttonCalcular.Location = new Point(265, 297);
            buttonCalcular.Name = "buttonCalcular";
            buttonCalcular.Size = new Size(75, 23);
            buttonCalcular.TabIndex = 1;
            buttonCalcular.Text = "Calcular";
            buttonCalcular.UseVisualStyleBackColor = true;
            buttonCalcular.Click += buttonCalcular_Click;
            // 
            // textBoxAluno
            // 
            textBoxAluno.Location = new Point(29, 142);
            textBoxAluno.Name = "textBoxAluno";
            textBoxAluno.Size = new Size(199, 23);
            textBoxAluno.TabIndex = 2;
            textBoxAluno.TextChanged += textBoxAluno_TextChanged;
            // 
            // labelBoletim
            // 
            labelBoletim.AutoSize = true;
            labelBoletim.Font = new Font("Elephant", 23.9999962F, FontStyle.Bold, GraphicsUnit.Point);
            labelBoletim.ForeColor = Color.Blue;
            labelBoletim.Location = new Point(143, 34);
            labelBoletim.Name = "labelBoletim";
            labelBoletim.Size = new Size(280, 41);
            labelBoletim.TabIndex = 3;
            labelBoletim.Text = "Boletim Digital";
            labelBoletim.Click += labelBoletim_Click;
            // 
            // labelIdade
            // 
            labelIdade.AutoSize = true;
            labelIdade.Location = new Point(29, 168);
            labelIdade.Name = "labelIdade";
            labelIdade.Size = new Size(36, 15);
            labelIdade.TabIndex = 4;
            labelIdade.Text = "Idade";
            // 
            // labelCSahrp
            // 
            labelCSahrp.AutoSize = true;
            labelCSahrp.Location = new Point(265, 121);
            labelCSahrp.Name = "labelCSahrp";
            labelCSahrp.Size = new Size(50, 15);
            labelCSahrp.TabIndex = 5;
            labelCSahrp.Text = "C_Sharp";
            // 
            // numericUpDownIdade
            // 
            numericUpDownIdade.Location = new Point(29, 186);
            numericUpDownIdade.Name = "numericUpDownIdade";
            numericUpDownIdade.Size = new Size(120, 23);
            numericUpDownIdade.TabIndex = 6;
            numericUpDownIdade.ValueChanged += numericUpDownIdade_ValueChanged;
            // 
            // labelNota1
            // 
            labelNota1.AutoSize = true;
            labelNota1.Location = new Point(265, 142);
            labelNota1.Name = "labelNota1";
            labelNota1.Size = new Size(39, 15);
            labelNota1.TabIndex = 7;
            labelNota1.Text = "Nota1";
            // 
            // labelNota2
            // 
            labelNota2.AutoSize = true;
            labelNota2.Location = new Point(265, 200);
            labelNota2.Name = "labelNota2";
            labelNota2.Size = new Size(39, 15);
            labelNota2.TabIndex = 8;
            labelNota2.Text = "Nota2";
            // 
            // labelNota3
            // 
            labelNota3.AutoSize = true;
            labelNota3.Location = new Point(265, 250);
            labelNota3.Name = "labelNota3";
            labelNota3.Size = new Size(39, 15);
            labelNota3.TabIndex = 9;
            labelNota3.Text = "Nota3";
            // 
            // textBoxNota1
            // 
            textBoxNota1.Location = new Point(265, 160);
            textBoxNota1.Name = "textBoxNota1";
            textBoxNota1.Size = new Size(100, 23);
            textBoxNota1.TabIndex = 10;
            // 
            // textBoxNota2
            // 
            textBoxNota2.Location = new Point(265, 219);
            textBoxNota2.Name = "textBoxNota2";
            textBoxNota2.Size = new Size(100, 23);
            textBoxNota2.TabIndex = 11;
            // 
            // textBoxNota3
            // 
            textBoxNota3.Location = new Point(265, 268);
            textBoxNota3.Name = "textBoxNota3";
            textBoxNota3.Size = new Size(100, 23);
            textBoxNota3.TabIndex = 12;
            textBoxNota3.TextChanged += textBox3_TextChanged;
            // 
            // richTextBoxResultado
            // 
            richTextBoxResultado.Location = new Point(508, 178);
            richTextBoxResultado.Name = "richTextBoxResultado";
            richTextBoxResultado.Size = new Size(230, 129);
            richTextBoxResultado.TabIndex = 13;
            richTextBoxResultado.Text = "";
            richTextBoxResultado.TextChanged += richTextBoxResultado_TextChanged;
            // 
            // labelResultado
            // 
            labelResultado.AutoSize = true;
            labelResultado.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelResultado.Location = new Point(570, 150);
            labelResultado.Name = "labelResultado";
            labelResultado.Size = new Size(100, 25);
            labelResultado.TabIndex = 14;
            labelResultado.Text = "Resultado";
            // 
            // pictureBoxProfessor
            // 
            pictureBoxProfessor.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxProfessor.ErrorImage = null;
            pictureBoxProfessor.Image = (Image)resources.GetObject("pictureBoxProfessor.Image");
            pictureBoxProfessor.Location = new Point(29, 12);
            pictureBoxProfessor.Name = "pictureBoxProfessor";
            pictureBoxProfessor.Size = new Size(108, 82);
            pictureBoxProfessor.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxProfessor.TabIndex = 15;
            pictureBoxProfessor.TabStop = false;
            // 
            // ExercicoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBoxProfessor);
            Controls.Add(labelResultado);
            Controls.Add(richTextBoxResultado);
            Controls.Add(textBoxNota3);
            Controls.Add(textBoxNota2);
            Controls.Add(textBoxNota1);
            Controls.Add(labelNota3);
            Controls.Add(labelNota2);
            Controls.Add(labelNota1);
            Controls.Add(numericUpDownIdade);
            Controls.Add(labelCSahrp);
            Controls.Add(labelIdade);
            Controls.Add(labelBoletim);
            Controls.Add(textBoxAluno);
            Controls.Add(buttonCalcular);
            Controls.Add(labelAluno);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ExercicoForm";
            Text = "ExercicoForm";
            ((System.ComponentModel.ISupportInitialize)numericUpDownIdade).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProfessor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelAluno;
        private Button buttonCalcular;
        private TextBox textBoxAluno;
        private Label labelBoletim;
        private Label labelIdade;
        private Label labelCSahrp;
        private NumericUpDown numericUpDownIdade;
        private Label labelNota1;
        private Label labelNota2;
        private Label labelNota3;
        private TextBox textBoxNota1;
        private TextBox textBoxNota2;
        private TextBox textBoxNota3;
        private RichTextBox richTextBoxResultado;
        private Label labelResultado;
        private PictureBox pictureBoxProfessor;
    }
}