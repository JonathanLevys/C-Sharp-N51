namespace SupermercadoForm.Telas
{
    partial class ProdutoListaForm
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
            dataGridViewProdutos = new DataGridView();
            ColumnID = new DataGridViewTextBoxColumn();
            ColumnNome = new DataGridViewTextBoxColumn();
            ColumnCategoria = new DataGridViewTextBoxColumn();
            ColumnPreçoUnitário = new DataGridViewTextBoxColumn();
            buttonEditar = new Button();
            buttonApagar = new Button();
            labelQuantidadeTotal = new Label();
            labellabelQuantidadeTotalValor = new Label();
            labelQuantidade = new Label();
            comboBoxQuantidade = new ComboBox();
            labelExibir = new Label();
            comboBoxExibir = new ComboBox();
            labelPesquisa = new Label();
            textBoxPesquisa = new TextBox();
            buttonLimparFiltros = new Button();
            buttonPesquisar = new Button();
            buttonNovo = new Button();
            comboBoxOrdenar = new ComboBox();
            labelOrdenar = new Label();
            ButtonPaginacaoAnterior = new Button();
            ButtonPaginacaoProximo = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProdutos).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewProdutos
            // 
            dataGridViewProdutos.AllowUserToAddRows = false;
            dataGridViewProdutos.AllowUserToDeleteRows = false;
            dataGridViewProdutos.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProdutos.Columns.AddRange(new DataGridViewColumn[] { ColumnID, ColumnNome, ColumnCategoria, ColumnPreçoUnitário });
            dataGridViewProdutos.Location = new Point(12, 85);
            dataGridViewProdutos.Name = "dataGridViewProdutos";
            dataGridViewProdutos.ReadOnly = true;
            dataGridViewProdutos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewProdutos.Size = new Size(594, 373);
            dataGridViewProdutos.TabIndex = 0;
            dataGridViewProdutos.CellContentClick += dataGridViewProdutos_CellContentClick;
            // 
            // ColumnID
            // 
            ColumnID.HeaderText = "Código";
            ColumnID.Name = "ColumnID";
            ColumnID.ReadOnly = true;
            ColumnID.Width = 80;
            // 
            // ColumnNome
            // 
            ColumnNome.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnNome.HeaderText = "Nome";
            ColumnNome.Name = "ColumnNome";
            ColumnNome.ReadOnly = true;
            // 
            // ColumnCategoria
            // 
            ColumnCategoria.HeaderText = "Categoria";
            ColumnCategoria.Name = "ColumnCategoria";
            ColumnCategoria.ReadOnly = true;
            // 
            // ColumnPreçoUnitário
            // 
            ColumnPreçoUnitário.HeaderText = "Preço Unitário";
            ColumnPreçoUnitário.Name = "ColumnPreçoUnitário";
            ColumnPreçoUnitário.ReadOnly = true;
            // 
            // buttonEditar
            // 
            buttonEditar.Location = new Point(612, 85);
            buttonEditar.Name = "buttonEditar";
            buttonEditar.Size = new Size(75, 23);
            buttonEditar.TabIndex = 1;
            buttonEditar.Text = "Editar";
            buttonEditar.UseVisualStyleBackColor = true;
            // 
            // buttonApagar
            // 
            buttonApagar.Location = new Point(612, 114);
            buttonApagar.Name = "buttonApagar";
            buttonApagar.Size = new Size(75, 23);
            buttonApagar.TabIndex = 2;
            buttonApagar.Text = "Apagar";
            buttonApagar.UseVisualStyleBackColor = true;
            buttonApagar.Click += buttonApagar_Click;
            // 
            // labelQuantidadeTotal
            // 
            labelQuantidadeTotal.AutoSize = true;
            labelQuantidadeTotal.Location = new Point(378, 461);
            labelQuantidadeTotal.Name = "labelQuantidadeTotal";
            labelQuantidadeTotal.Size = new Size(164, 15);
            labelQuantidadeTotal.TabIndex = 4;
            labelQuantidadeTotal.Text = "Quantidade Total de Produtos";
            // 
            // labellabelQuantidadeTotalValor
            // 
            labellabelQuantidadeTotalValor.AutoSize = true;
            labellabelQuantidadeTotalValor.Location = new Point(568, 461);
            labellabelQuantidadeTotalValor.Name = "labellabelQuantidadeTotalValor";
            labellabelQuantidadeTotalValor.Size = new Size(32, 15);
            labellabelQuantidadeTotalValor.TabIndex = 5;
            labellabelQuantidadeTotalValor.Text = "Total";
            // 
            // labelQuantidade
            // 
            labelQuantidade.AutoSize = true;
            labelQuantidade.Location = new Point(12, 9);
            labelQuantidade.Name = "labelQuantidade";
            labelQuantidade.Size = new Size(69, 15);
            labelQuantidade.TabIndex = 6;
            labelQuantidade.Text = "Quantidade";
            // 
            // comboBoxQuantidade
            // 
            comboBoxQuantidade.FormattingEnabled = true;
            comboBoxQuantidade.Items.AddRange(new object[] { "10 Itens", "25 Itens", "50 Itens", "100 Itens" });
            comboBoxQuantidade.Location = new Point(13, 28);
            comboBoxQuantidade.Name = "comboBoxQuantidade";
            comboBoxQuantidade.Size = new Size(96, 23);
            comboBoxQuantidade.TabIndex = 7;
            comboBoxQuantidade.SelectedIndexChanged += comboBoxQuantidade_SelectedIndexChanged;
            // 
            // labelExibir
            // 
            labelExibir.AutoSize = true;
            labelExibir.Location = new Point(128, 9);
            labelExibir.Name = "labelExibir";
            labelExibir.Size = new Size(36, 15);
            labelExibir.TabIndex = 8;
            labelExibir.Text = "Exibir";
            // 
            // comboBoxExibir
            // 
            comboBoxExibir.FormattingEnabled = true;
            comboBoxExibir.Items.AddRange(new object[] { "Código", "Nome", "Categoria ", "Preço unitário" });
            comboBoxExibir.Location = new Point(128, 28);
            comboBoxExibir.Name = "comboBoxExibir";
            comboBoxExibir.Size = new Size(120, 23);
            comboBoxExibir.TabIndex = 9;
            comboBoxExibir.SelectedIndexChanged += comboBoxExibir_SelectedIndexChanged;
            // 
            // labelPesquisa
            // 
            labelPesquisa.AutoSize = true;
            labelPesquisa.Location = new Point(426, 9);
            labelPesquisa.Name = "labelPesquisa";
            labelPesquisa.Size = new Size(53, 15);
            labelPesquisa.TabIndex = 10;
            labelPesquisa.Text = "Pesquisa";
            // 
            // textBoxPesquisa
            // 
            textBoxPesquisa.Location = new Point(426, 27);
            textBoxPesquisa.Name = "textBoxPesquisa";
            textBoxPesquisa.Size = new Size(180, 23);
            textBoxPesquisa.TabIndex = 11;
            textBoxPesquisa.TextChanged += textBoxPesquisa_TextChanged;
            textBoxPesquisa.KeyDown += textBoxPesquisa_KeyDown;
            // 
            // buttonLimparFiltros
            // 
            buttonLimparFiltros.Location = new Point(426, 56);
            buttonLimparFiltros.Name = "buttonLimparFiltros";
            buttonLimparFiltros.Size = new Size(99, 23);
            buttonLimparFiltros.TabIndex = 12;
            buttonLimparFiltros.Text = "Limpar Filtros";
            buttonLimparFiltros.UseVisualStyleBackColor = true;
            buttonLimparFiltros.Click += buttonLimparFiltros_Click;
            // 
            // buttonPesquisar
            // 
            buttonPesquisar.Location = new Point(531, 56);
            buttonPesquisar.Name = "buttonPesquisar";
            buttonPesquisar.Size = new Size(75, 23);
            buttonPesquisar.TabIndex = 13;
            buttonPesquisar.Text = "Pesquisar";
            buttonPesquisar.UseVisualStyleBackColor = true;
            buttonPesquisar.Click += buttonPesquisar_Click;
            // 
            // buttonNovo
            // 
            buttonNovo.Location = new Point(612, 28);
            buttonNovo.Name = "buttonNovo";
            buttonNovo.Size = new Size(75, 51);
            buttonNovo.TabIndex = 14;
            buttonNovo.Text = "Novo";
            buttonNovo.UseVisualStyleBackColor = true;
            buttonNovo.Click += buttonNovo_Click;
            // 
            // comboBoxOrdenar
            // 
            comboBoxOrdenar.FormattingEnabled = true;
            comboBoxOrdenar.Items.AddRange(new object[] { "A-Z", "Z-A" });
            comboBoxOrdenar.Location = new Point(263, 28);
            comboBoxOrdenar.Name = "comboBoxOrdenar";
            comboBoxOrdenar.Size = new Size(120, 23);
            comboBoxOrdenar.TabIndex = 16;
            comboBoxOrdenar.SelectedIndexChanged += comboBoxOrdenar_SelectedIndexChanged;
            // 
            // labelOrdenar
            // 
            labelOrdenar.AutoSize = true;
            labelOrdenar.Location = new Point(263, 9);
            labelOrdenar.Name = "labelOrdenar";
            labelOrdenar.Size = new Size(50, 15);
            labelOrdenar.TabIndex = 15;
            labelOrdenar.Text = "Ordenar";
            // 
            // ButtonPaginacaoAnterior
            // 
            ButtonPaginacaoAnterior.Location = new Point(34, 464);
            ButtonPaginacaoAnterior.Name = "ButtonPaginacaoAnterior";
            ButtonPaginacaoAnterior.Size = new Size(75, 23);
            ButtonPaginacaoAnterior.TabIndex = 17;
            ButtonPaginacaoAnterior.Text = "Anterior";
            ButtonPaginacaoAnterior.UseVisualStyleBackColor = true;
            ButtonPaginacaoAnterior.Click += ButtonPaginacaoAnterior_Click;
            // 
            // ButtonPaginacaoProximo
            // 
            ButtonPaginacaoProximo.Location = new Point(128, 464);
            ButtonPaginacaoProximo.Name = "ButtonPaginacaoProximo";
            ButtonPaginacaoProximo.Size = new Size(75, 23);
            ButtonPaginacaoProximo.TabIndex = 18;
            ButtonPaginacaoProximo.Text = "Próximo";
            ButtonPaginacaoProximo.UseVisualStyleBackColor = true;
            ButtonPaginacaoProximo.Click += ButtonPaginacaoProximo_Click;
            // 
            // ProdutoListaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(706, 517);
            Controls.Add(ButtonPaginacaoProximo);
            Controls.Add(ButtonPaginacaoAnterior);
            Controls.Add(comboBoxOrdenar);
            Controls.Add(labelOrdenar);
            Controls.Add(buttonNovo);
            Controls.Add(buttonPesquisar);
            Controls.Add(buttonLimparFiltros);
            Controls.Add(textBoxPesquisa);
            Controls.Add(labelPesquisa);
            Controls.Add(comboBoxExibir);
            Controls.Add(labelExibir);
            Controls.Add(comboBoxQuantidade);
            Controls.Add(labelQuantidade);
            Controls.Add(labellabelQuantidadeTotalValor);
            Controls.Add(labelQuantidadeTotal);
            Controls.Add(buttonApagar);
            Controls.Add(buttonEditar);
            Controls.Add(dataGridViewProdutos);
            Name = "ProdutoListaForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProdutoListaForm";
            Load += ProdutoListaForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewProdutos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewProdutos;
        private Button buttonEditar;
        private Button buttonApagar;
        private Label labelQuantidadeTotal;
        private Label labellabelQuantidadeTotalValor;
        private Label labelQuantidade;
        private ComboBox comboBoxQuantidade;
        private Label labelExibir;
        private ComboBox comboBoxExibir;
        private Label labelPesquisa;
        private TextBox textBoxPesquisa;
        private Button buttonLimparFiltros;
        private Button buttonPesquisar;
        private Button buttonNovo;
        private ComboBox comboBoxOrdenar;
        private Label labelOrdenar;
        private Button ButtonPaginacaoAnterior;
        private Button ButtonPaginacaoProximo;
        private DataGridViewTextBoxColumn ColumnID;
        private DataGridViewTextBoxColumn ColumnNome;
        private DataGridViewTextBoxColumn ColumnCategoria;
        private DataGridViewTextBoxColumn ColumnPreçoUnitário;
    }
}