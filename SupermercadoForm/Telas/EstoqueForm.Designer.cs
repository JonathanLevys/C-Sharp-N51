namespace SupermercadoForm.Telas
{
    partial class EstoqueForm
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
            labelCategoriaEstoque = new Label();
            buttonNovoEstoque = new Button();
            textBoxCategoriaEstoque = new TextBox();
            labelQuantidadeEstoque = new Label();
            dataGridViewEstoque = new DataGridView();
            Produto = new DataGridViewTextBoxColumn();
            Quantidade = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEstoque).BeginInit();
            SuspendLayout();
            // 
            // labelCategoriaEstoque
            // 
            labelCategoriaEstoque.AutoSize = true;
            labelCategoriaEstoque.Location = new Point(10, 12);
            labelCategoriaEstoque.Name = "labelCategoriaEstoque";
            labelCategoriaEstoque.Size = new Size(58, 15);
            labelCategoriaEstoque.TabIndex = 0;
            labelCategoriaEstoque.Text = "Categoria";
            // 
            // buttonNovoEstoque
            // 
            buttonNovoEstoque.Location = new Point(537, 33);
            buttonNovoEstoque.Name = "buttonNovoEstoque";
            buttonNovoEstoque.Size = new Size(75, 23);
            buttonNovoEstoque.TabIndex = 1;
            buttonNovoEstoque.Text = "Novo";
            buttonNovoEstoque.UseVisualStyleBackColor = true;
            buttonNovoEstoque.Click += buttonNovoEstoque_Click;
            // 
            // textBoxCategoriaEstoque
            // 
            textBoxCategoriaEstoque.Location = new Point(10, 33);
            textBoxCategoriaEstoque.Name = "textBoxCategoriaEstoque";
            textBoxCategoriaEstoque.Size = new Size(100, 23);
            textBoxCategoriaEstoque.TabIndex = 2;
            // 
            // labelQuantidadeEstoque
            // 
            labelQuantidadeEstoque.AutoSize = true;
            labelQuantidadeEstoque.Location = new Point(187, 12);
            labelQuantidadeEstoque.Name = "labelQuantidadeEstoque";
            labelQuantidadeEstoque.Size = new Size(69, 15);
            labelQuantidadeEstoque.TabIndex = 3;
            labelQuantidadeEstoque.Text = "Quantidade";
            // 
            // dataGridViewEstoque
            // 
            dataGridViewEstoque.AllowUserToAddRows = false;
            dataGridViewEstoque.BackgroundColor = SystemColors.ControlLight;
            dataGridViewEstoque.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEstoque.Columns.AddRange(new DataGridViewColumn[] { Produto, Quantidade });
            dataGridViewEstoque.Location = new Point(10, 84);
            dataGridViewEstoque.Name = "dataGridViewEstoque";
            dataGridViewEstoque.ReadOnly = true;
            dataGridViewEstoque.Size = new Size(505, 278);
            dataGridViewEstoque.TabIndex = 4;
            // 
            // Produto
            // 
            Produto.HeaderText = "Produto";
            Produto.Name = "Produto";
            Produto.ReadOnly = true;
            // 
            // Quantidade
            // 
            Quantidade.HeaderText = "Quantidade";
            Quantidade.Name = "Quantidade";
            Quantidade.ReadOnly = true;
            // 
            // EstoqueForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridViewEstoque);
            Controls.Add(labelQuantidadeEstoque);
            Controls.Add(textBoxCategoriaEstoque);
            Controls.Add(buttonNovoEstoque);
            Controls.Add(labelCategoriaEstoque);
            Name = "EstoqueForm";
            Text = "Estoque";
            ((System.ComponentModel.ISupportInitialize)dataGridViewEstoque).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelCategoriaEstoque;
        private Button buttonNovoEstoque;
        private TextBox textBoxCategoriaEstoque;
        private Label labelQuantidadeEstoque;
        private DataGridView dataGridViewEstoque;
        private DataGridViewTextBoxColumn Produto;
        private DataGridViewTextBoxColumn Quantidade;
    }
}