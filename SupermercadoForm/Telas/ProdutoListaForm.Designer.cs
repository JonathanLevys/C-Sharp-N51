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
            dataGridViewProdutos.Location = new Point(14, 113);
            dataGridViewProdutos.Margin = new Padding(3, 4, 3, 4);
            dataGridViewProdutos.Name = "dataGridViewProdutos";
            dataGridViewProdutos.ReadOnly = true;
            dataGridViewProdutos.RowHeadersWidth = 51;
            dataGridViewProdutos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewProdutos.Size = new Size(679, 497);
            dataGridViewProdutos.TabIndex = 0;
            dataGridViewProdutos.CellContentClick += dataGridViewProdutos_CellContentClick;
            // 
            // ColumnID
            // 
            ColumnID.HeaderText = "Código";
            ColumnID.MinimumWidth = 6;
            ColumnID.Name = "ColumnID";
            ColumnID.ReadOnly = true;
            ColumnID.Width = 80;
            // 
            // ColumnNome
            // 
            ColumnNome.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnNome.HeaderText = "Nome";
            ColumnNome.MinimumWidth = 6;
            ColumnNome.Name = "ColumnNome";
            ColumnNome.ReadOnly = true;
            // 
            // ColumnCategoria
            // 
            ColumnCategoria.HeaderText = "Categoria";
            ColumnCategoria.MinimumWidth = 6;
            ColumnCategoria.Name = "ColumnCategoria";
            ColumnCategoria.ReadOnly = true;
            ColumnCategoria.Width = 125;
            // 
            // ColumnPreçoUnitário
            // 
            ColumnPreçoUnitário.HeaderText = "Preço Unitário";
            ColumnPreçoUnitário.MinimumWidth = 6;
            ColumnPreçoUnitário.Name = "ColumnPreçoUnitário";
            ColumnPreçoUnitário.ReadOnly = true;
            ColumnPreçoUnitário.Width = 125;
            // 
            // buttonEditar
            // 
            buttonEditar.Location = new Point(699, 113);
            buttonEditar.Margin = new Padding(3, 4, 3, 4);
            buttonEditar.Name = "buttonEditar";
            buttonEditar.Size = new Size(86, 31);
            buttonEditar.TabIndex = 1;
            buttonEditar.Text = "Editar";
            buttonEditar.UseVisualStyleBackColor = true;
            buttonEditar.Click += buttonEditar_Click;
            // 
            // buttonApagar
            // 
            buttonApagar.Location = new Point(699, 152);
            buttonApagar.Margin = new Padding(3, 4, 3, 4);
            buttonApagar.Name = "buttonApagar";
            buttonApagar.Size = new Size(86, 31);
            buttonApagar.TabIndex = 2;
            buttonApagar.Text = "Apagar";
            buttonApagar.UseVisualStyleBackColor = true;
            buttonApagar.Click += buttonApagar_Click;
            // 
            // labelQuantidadeTotal
            // 
            labelQuantidadeTotal.AutoSize = true;
            labelQuantidadeTotal.Location = new Point(432, 615);
            labelQuantidadeTotal.Name = "labelQuantidadeTotal";
            labelQuantidadeTotal.Size = new Size(208, 20);
            labelQuantidadeTotal.TabIndex = 4;
            labelQuantidadeTotal.Text = "Quantidade Total de Produtos";
            // 
            // labellabelQuantidadeTotalValor
            // 
            labellabelQuantidadeTotalValor.AutoSize = true;
            labellabelQuantidadeTotalValor.Location = new Point(649, 615);
            labellabelQuantidadeTotalValor.Name = "labellabelQuantidadeTotalValor";
            labellabelQuantidadeTotalValor.Size = new Size(42, 20);
            labellabelQuantidadeTotalValor.TabIndex = 5;
            labellabelQuantidadeTotalValor.Text = "Total";
            // 
            // labelQuantidade
            // 
            labelQuantidade.AutoSize = true;
            labelQuantidade.Location = new Point(14, 12);
            labelQuantidade.Name = "labelQuantidade";
            labelQuantidade.Size = new Size(87, 20);
            labelQuantidade.TabIndex = 6;
            labelQuantidade.Text = "Quantidade";
            // 
            // comboBoxQuantidade
            // 
            comboBoxQuantidade.FormattingEnabled = true;
            comboBoxQuantidade.Items.AddRange(new object[] { "10 Itens", "25 Itens", "50 Itens", "100 Itens" });
            comboBoxQuantidade.Location = new Point(15, 37);
            comboBoxQuantidade.Margin = new Padding(3, 4, 3, 4);
            comboBoxQuantidade.Name = "comboBoxQuantidade";
            comboBoxQuantidade.Size = new Size(109, 28);
            comboBoxQuantidade.TabIndex = 7;
            comboBoxQuantidade.SelectedIndexChanged += comboBoxQuantidade_SelectedIndexChanged;
            // 
            // labelExibir
            // 
            labelExibir.AutoSize = true;
            labelExibir.Location = new Point(146, 12);
            labelExibir.Name = "labelExibir";
            labelExibir.Size = new Size(46, 20);
            labelExibir.TabIndex = 8;
            labelExibir.Text = "Exibir";
            // 
            // comboBoxExibir
            // 
            comboBoxExibir.FormattingEnabled = true;
            comboBoxExibir.Items.AddRange(new object[] { "Código", "Nome", "Categoria ", "Preço unitário" });
            comboBoxExibir.Location = new Point(146, 37);
            comboBoxExibir.Margin = new Padding(3, 4, 3, 4);
            comboBoxExibir.Name = "comboBoxExibir";
            comboBoxExibir.Size = new Size(137, 28);
            comboBoxExibir.TabIndex = 9;
            comboBoxExibir.SelectedIndexChanged += comboBoxExibir_SelectedIndexChanged;
            // 
            // labelPesquisa
            // 
            labelPesquisa.AutoSize = true;
            labelPesquisa.Location = new Point(487, 12);
            labelPesquisa.Name = "labelPesquisa";
            labelPesquisa.Size = new Size(65, 20);
            labelPesquisa.TabIndex = 10;
            labelPesquisa.Text = "Pesquisa";
            // 
            // textBoxPesquisa
            // 
            textBoxPesquisa.Location = new Point(487, 36);
            textBoxPesquisa.Margin = new Padding(3, 4, 3, 4);
            textBoxPesquisa.Name = "textBoxPesquisa";
            textBoxPesquisa.Size = new Size(205, 27);
            textBoxPesquisa.TabIndex = 11;
            textBoxPesquisa.TextChanged += textBoxPesquisa_TextChanged;
            textBoxPesquisa.KeyDown += textBoxPesquisa_KeyDown;
            // 
            // buttonLimparFiltros
            // 
            buttonLimparFiltros.Location = new Point(487, 75);
            buttonLimparFiltros.Margin = new Padding(3, 4, 3, 4);
            buttonLimparFiltros.Name = "buttonLimparFiltros";
            buttonLimparFiltros.Size = new Size(113, 31);
            buttonLimparFiltros.TabIndex = 12;
            buttonLimparFiltros.Text = "Limpar Filtros";
            buttonLimparFiltros.UseVisualStyleBackColor = true;
            buttonLimparFiltros.Click += buttonLimparFiltros_Click;
            // 
            // buttonPesquisar
            // 
            buttonPesquisar.Location = new Point(607, 75);
            buttonPesquisar.Margin = new Padding(3, 4, 3, 4);
            buttonPesquisar.Name = "buttonPesquisar";
            buttonPesquisar.Size = new Size(86, 31);
            buttonPesquisar.TabIndex = 13;
            buttonPesquisar.Text = "Pesquisar";
            buttonPesquisar.UseVisualStyleBackColor = true;
            buttonPesquisar.Click += buttonPesquisar_Click;
            // 
            // buttonNovo
            // 
            buttonNovo.Location = new Point(699, 37);
            buttonNovo.Margin = new Padding(3, 4, 3, 4);
            buttonNovo.Name = "buttonNovo";
            buttonNovo.Size = new Size(86, 68);
            buttonNovo.TabIndex = 14;
            buttonNovo.Text = "Novo";
            buttonNovo.UseVisualStyleBackColor = true;
            buttonNovo.Click += buttonNovo_Click;
            // 
            // comboBoxOrdenar
            // 
            comboBoxOrdenar.FormattingEnabled = true;
            comboBoxOrdenar.Items.AddRange(new object[] { "A-Z", "Z-A" });
            comboBoxOrdenar.Location = new Point(301, 37);
            comboBoxOrdenar.Margin = new Padding(3, 4, 3, 4);
            comboBoxOrdenar.Name = "comboBoxOrdenar";
            comboBoxOrdenar.Size = new Size(137, 28);
            comboBoxOrdenar.TabIndex = 16;
            comboBoxOrdenar.SelectedIndexChanged += comboBoxOrdenar_SelectedIndexChanged;
            // 
            // labelOrdenar
            // 
            labelOrdenar.AutoSize = true;
            labelOrdenar.Location = new Point(301, 12);
            labelOrdenar.Name = "labelOrdenar";
            labelOrdenar.Size = new Size(63, 20);
            labelOrdenar.TabIndex = 15;
            labelOrdenar.Text = "Ordenar";
            // 
            // ButtonPaginacaoAnterior
            // 
            ButtonPaginacaoAnterior.Location = new Point(39, 619);
            ButtonPaginacaoAnterior.Margin = new Padding(3, 4, 3, 4);
            ButtonPaginacaoAnterior.Name = "ButtonPaginacaoAnterior";
            ButtonPaginacaoAnterior.Size = new Size(86, 31);
            ButtonPaginacaoAnterior.TabIndex = 17;
            ButtonPaginacaoAnterior.Text = "Anterior";
            ButtonPaginacaoAnterior.UseVisualStyleBackColor = true;
            ButtonPaginacaoAnterior.Click += ButtonPaginacaoAnterior_Click;
            // 
            // ButtonPaginacaoProximo
            // 
            ButtonPaginacaoProximo.Location = new Point(146, 619);
            ButtonPaginacaoProximo.Margin = new Padding(3, 4, 3, 4);
            ButtonPaginacaoProximo.Name = "ButtonPaginacaoProximo";
            ButtonPaginacaoProximo.Size = new Size(86, 31);
            ButtonPaginacaoProximo.TabIndex = 18;
            ButtonPaginacaoProximo.Text = "Próximo";
            ButtonPaginacaoProximo.UseVisualStyleBackColor = true;
            ButtonPaginacaoProximo.Click += ButtonPaginacaoProximo_Click;
            // 
            // ProdutoListaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(807, 689);
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
            Margin = new Padding(3, 4, 3, 4);
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