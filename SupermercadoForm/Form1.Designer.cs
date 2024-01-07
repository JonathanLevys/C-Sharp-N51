namespace SupermercadoForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelPrimeiraTela = new Label();
            buttonConcatenar = new Button();
            labelNome = new Label();
            labelSobrenome = new Label();
            textBoxNome = new TextBox();
            textBoxSobrenome = new TextBox();
            labelOperação = new Label();
            labelNumero1 = new Label();
            textBoxNumeroNum01 = new TextBox();
            labelNumero2 = new Label();
            label7 = new Label();
            richTextBoxHistorico = new RichTextBox();
            buttonCalcular = new Button();
            textBoxNum02 = new TextBox();
            comboBoxOperação = new ComboBox();
            buttonLimpar = new Button();
            SuspendLayout();
            // 
            // labelPrimeiraTela
            // 
            labelPrimeiraTela.AutoSize = true;
            labelPrimeiraTela.Font = new Font("Baskerville Old Face", 18F, FontStyle.Regular, GraphicsUnit.Point);
            labelPrimeiraTela.ForeColor = Color.Red;
            labelPrimeiraTela.Location = new Point(70, 9);
            labelPrimeiraTela.Name = "labelPrimeiraTela";
            labelPrimeiraTela.Size = new Size(143, 27);
            labelPrimeiraTela.TabIndex = 0;
            labelPrimeiraTela.Text = "Primeira Tela";
            labelPrimeiraTela.Click += label1_Click;
            // 
            // buttonConcatenar
            // 
            buttonConcatenar.Location = new Point(70, 190);
            buttonConcatenar.Name = "buttonConcatenar";
            buttonConcatenar.Size = new Size(434, 129);
            buttonConcatenar.TabIndex = 1;
            buttonConcatenar.Text = "Concatenar";
            buttonConcatenar.UseVisualStyleBackColor = true;
            buttonConcatenar.Click += buttonConcatenar_Click;
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Location = new Point(70, 71);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(40, 15);
            labelNome.TabIndex = 2;
            labelNome.Text = "Nome";
            labelNome.Click += label2_Click;
            // 
            // labelSobrenome
            // 
            labelSobrenome.AutoSize = true;
            labelSobrenome.Location = new Point(70, 126);
            labelSobrenome.Name = "labelSobrenome";
            labelSobrenome.Size = new Size(68, 15);
            labelSobrenome.TabIndex = 3;
            labelSobrenome.Text = "Sobrenome";
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(70, 89);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(434, 23);
            textBoxNome.TabIndex = 4;
            // 
            // textBoxSobrenome
            // 
            textBoxSobrenome.Location = new Point(70, 144);
            textBoxSobrenome.Name = "textBoxSobrenome";
            textBoxSobrenome.Size = new Size(434, 23);
            textBoxSobrenome.TabIndex = 5;
            // 
            // labelOperação
            // 
            labelOperação.AutoSize = true;
            labelOperação.Location = new Point(560, 71);
            labelOperação.Name = "labelOperação";
            labelOperação.Size = new Size(58, 15);
            labelOperação.TabIndex = 6;
            labelOperação.Text = "Operação";
            labelOperação.Click += label4_Click;
            // 
            // labelNumero1
            // 
            labelNumero1.AutoSize = true;
            labelNumero1.Location = new Point(560, 126);
            labelNumero1.Name = "labelNumero1";
            labelNumero1.Size = new Size(66, 15);
            labelNumero1.TabIndex = 7;
            labelNumero1.Text = "Número 01";
            // 
            // textBoxNumeroNum01
            // 
            textBoxNumeroNum01.Location = new Point(560, 144);
            textBoxNumeroNum01.Name = "textBoxNumeroNum01";
            textBoxNumeroNum01.Size = new Size(139, 23);
            textBoxNumeroNum01.TabIndex = 9;
            // 
            // labelNumero2
            // 
            labelNumero2.AutoSize = true;
            labelNumero2.Location = new Point(717, 126);
            labelNumero2.Name = "labelNumero2";
            labelNumero2.Size = new Size(66, 15);
            labelNumero2.TabIndex = 10;
            labelNumero2.Text = "Número 02";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(560, 190);
            label7.Name = "label7";
            label7.Size = new Size(55, 15);
            label7.TabIndex = 11;
            label7.Text = "Historico";
            label7.Click += label7_Click;
            // 
            // richTextBoxHistorico
            // 
            richTextBoxHistorico.Location = new Point(560, 208);
            richTextBoxHistorico.Name = "richTextBoxHistorico";
            richTextBoxHistorico.Size = new Size(262, 111);
            richTextBoxHistorico.TabIndex = 12;
            richTextBoxHistorico.Text = "";
            richTextBoxHistorico.TextChanged += richTextBoxHistorico_TextChanged;
            // 
            // buttonCalcular
            // 
            buttonCalcular.Location = new Point(828, 71);
            buttonCalcular.Name = "buttonCalcular";
            buttonCalcular.Size = new Size(75, 187);
            buttonCalcular.TabIndex = 13;
            buttonCalcular.Text = "Calcular";
            buttonCalcular.UseVisualStyleBackColor = true;
            buttonCalcular.Click += buttonCalcular_Click;
            // 
            // textBoxNum02
            // 
            textBoxNum02.Location = new Point(722, 144);
            textBoxNum02.Name = "textBoxNum02";
            textBoxNum02.Size = new Size(100, 23);
            textBoxNum02.TabIndex = 14;
            // 
            // comboBoxOperação
            // 
            comboBoxOperação.FormattingEnabled = true;
            comboBoxOperação.Items.AddRange(new object[] { "Dividir", "Multiplicar", "Somar", "Subtrair" });
            comboBoxOperação.Location = new Point(560, 89);
            comboBoxOperação.Name = "comboBoxOperação";
            comboBoxOperação.Size = new Size(262, 23);
            comboBoxOperação.TabIndex = 15;
            // 
            // buttonLimpar
            // 
            buttonLimpar.Location = new Point(828, 285);
            buttonLimpar.Name = "buttonLimpar";
            buttonLimpar.Size = new Size(75, 23);
            buttonLimpar.TabIndex = 16;
            buttonLimpar.Text = "Limpar";
            buttonLimpar.UseVisualStyleBackColor = true;
            buttonLimpar.Click += buttonLimpar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1052, 450);
            Controls.Add(buttonLimpar);
            Controls.Add(comboBoxOperação);
            Controls.Add(textBoxNum02);
            Controls.Add(buttonCalcular);
            Controls.Add(richTextBoxHistorico);
            Controls.Add(label7);
            Controls.Add(labelNumero2);
            Controls.Add(textBoxNumeroNum01);
            Controls.Add(labelNumero1);
            Controls.Add(labelOperação);
            Controls.Add(textBoxSobrenome);
            Controls.Add(textBoxNome);
            Controls.Add(labelSobrenome);
            Controls.Add(labelNome);
            Controls.Add(buttonConcatenar);
            Controls.Add(labelPrimeiraTela);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelPrimeiraTela;
        private Button buttonConcatenar;
        private Label labelNome;
        private Label labelSobrenome;
        private TextBox textBoxNome;
        private TextBox textBoxSobrenome;
        private Label labelOperação;
        private Label labelNumero1;
        private TextBox textBoxNumeroNum01;
        private Label labelNumero2;
        private Label label7;
        private RichTextBox richTextBoxHistorico;
        private Button buttonCalcular;
        private TextBox textBoxNum02;
        private ComboBox comboBoxOperação;
        private Button buttonLimpar;
    }
}