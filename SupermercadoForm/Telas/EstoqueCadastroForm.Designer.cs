namespace SupermercadoForm.Telas
{
    partial class EstoqueCadastroForm
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
            labelEstoqueProduto = new Label();
            labelQntdadeEstoque = new Label();
            comboBoxEstoque = new ComboBox();
            textBox1 = new TextBox();
            buttonCadastrarEstoque = new Button();
            SuspendLayout();
            // 
            // labelEstoqueProduto
            // 
            labelEstoqueProduto.AutoSize = true;
            labelEstoqueProduto.Location = new Point(50, 30);
            labelEstoqueProduto.Name = "labelEstoqueProduto";
            labelEstoqueProduto.Size = new Size(50, 15);
            labelEstoqueProduto.TabIndex = 0;
            labelEstoqueProduto.Text = "Produto";
            // 
            // labelQntdadeEstoque
            // 
            labelQntdadeEstoque.AutoSize = true;
            labelQntdadeEstoque.Location = new Point(50, 86);
            labelQntdadeEstoque.Name = "labelQntdadeEstoque";
            labelQntdadeEstoque.Size = new Size(69, 15);
            labelQntdadeEstoque.TabIndex = 1;
            labelQntdadeEstoque.Text = "Quantidade";
            // 
            // comboBoxEstoque
            // 
            comboBoxEstoque.DisplayMember = "Nome";
            comboBoxEstoque.FormattingEnabled = true;
            comboBoxEstoque.Location = new Point(50, 48);
            comboBoxEstoque.Name = "comboBoxEstoque";
            comboBoxEstoque.Size = new Size(121, 23);
            comboBoxEstoque.TabIndex = 2;
            comboBoxEstoque.ValueMember = "Nome";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(50, 104);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(121, 23);
            textBox1.TabIndex = 3;
            // 
            // buttonCadastrarEstoque
            // 
            buttonCadastrarEstoque.Location = new Point(201, 48);
            buttonCadastrarEstoque.Name = "buttonCadastrarEstoque";
            buttonCadastrarEstoque.Size = new Size(75, 23);
            buttonCadastrarEstoque.TabIndex = 4;
            buttonCadastrarEstoque.Text = "Cadastrar";
            buttonCadastrarEstoque.UseVisualStyleBackColor = true;
            // 
            // EstoqueCadastroForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonCadastrarEstoque);
            Controls.Add(textBox1);
            Controls.Add(comboBoxEstoque);
            Controls.Add(labelQntdadeEstoque);
            Controls.Add(labelEstoqueProduto);
            Name = "EstoqueCadastroForm";
            Text = "EstoqueCadastroForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelEstoqueProduto;
        private Label labelQntdadeEstoque;
        private ComboBox comboBoxEstoque;
        private TextBox textBox1;
        private Button buttonCadastrarEstoque;
    }
}