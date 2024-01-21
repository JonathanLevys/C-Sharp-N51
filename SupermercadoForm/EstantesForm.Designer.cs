namespace SupermercadoForm
{
    partial class EstantesForm
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
            labelNome = new Label();
            labelSigla = new Label();
            textBoxNome = new TextBox();
            maskedTextBoxSigla = new MaskedTextBox();
            dataGridViewEstantes = new DataGridView();
            ColumnId = new DataGridViewTextBoxColumn();
            ColumnNome = new DataGridViewTextBoxColumn();
            ColumnSigla = new DataGridViewTextBoxColumn();
            buttonSalvar = new Button();
            labelEstantes = new Label();
            buttonApagar = new Button();
            buttonEditar = new Button();
            labelPesquisar = new Label();
            textBoxPesquisar = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEstantes).BeginInit();
            SuspendLayout();
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Location = new Point(28, 21);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(40, 15);
            labelNome.TabIndex = 0;
            labelNome.Text = "Nome";
            // 
            // labelSigla
            // 
            labelSigla.AutoSize = true;
            labelSigla.Location = new Point(28, 91);
            labelSigla.Name = "labelSigla";
            labelSigla.Size = new Size(32, 15);
            labelSigla.TabIndex = 1;
            labelSigla.Text = "Sigla";
            labelSigla.Click += label2_Click;
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(28, 39);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(239, 23);
            textBoxNome.TabIndex = 2;
            // 
            // maskedTextBoxSigla
            // 
            maskedTextBoxSigla.Location = new Point(28, 109);
            maskedTextBoxSigla.Mask = "AAA";
            maskedTextBoxSigla.Name = "maskedTextBoxSigla";
            maskedTextBoxSigla.Size = new Size(239, 23);
            maskedTextBoxSigla.TabIndex = 3;
            // 
            // dataGridViewEstantes
            // 
            dataGridViewEstantes.AllowUserToAddRows = false;
            dataGridViewEstantes.AllowUserToDeleteRows = false;
            dataGridViewEstantes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEstantes.Columns.AddRange(new DataGridViewColumn[] { ColumnId, ColumnNome, ColumnSigla });
            dataGridViewEstantes.Location = new Point(285, 39);
            dataGridViewEstantes.Name = "dataGridViewEstantes";
            dataGridViewEstantes.ReadOnly = true;
            dataGridViewEstantes.RowTemplate.Height = 25;
            dataGridViewEstantes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewEstantes.Size = new Size(390, 519);
            dataGridViewEstantes.TabIndex = 4;
            // 
            // ColumnId
            // 
            ColumnId.HeaderText = "Código";
            ColumnId.Name = "ColumnId";
            ColumnId.ReadOnly = true;
            ColumnId.Width = 50;
            // 
            // ColumnNome
            // 
            ColumnNome.HeaderText = "Nome";
            ColumnNome.Name = "ColumnNome";
            ColumnNome.ReadOnly = true;
            ColumnNome.Width = 200;
            // 
            // ColumnSigla
            // 
            ColumnSigla.HeaderText = "Sigla";
            ColumnSigla.Name = "ColumnSigla";
            ColumnSigla.ReadOnly = true;
            // 
            // buttonSalvar
            // 
            buttonSalvar.Location = new Point(192, 138);
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.Size = new Size(75, 23);
            buttonSalvar.TabIndex = 5;
            buttonSalvar.Text = "Salvar";
            buttonSalvar.UseVisualStyleBackColor = true;
            buttonSalvar.Click += buttonSalvar_Click;
            // 
            // labelEstantes
            // 
            labelEstantes.AutoSize = true;
            labelEstantes.Location = new Point(285, 21);
            labelEstantes.Name = "labelEstantes";
            labelEstantes.Size = new Size(50, 15);
            labelEstantes.TabIndex = 6;
            labelEstantes.Text = "Estantes";
            // 
            // buttonApagar
            // 
            buttonApagar.Location = new Point(690, 68);
            buttonApagar.Name = "buttonApagar";
            buttonApagar.Size = new Size(75, 23);
            buttonApagar.TabIndex = 7;
            buttonApagar.Text = "Apagar";
            buttonApagar.UseVisualStyleBackColor = true;
            buttonApagar.Click += buttonApagar_Click;
            // 
            // buttonEditar
            // 
            buttonEditar.Location = new Point(690, 39);
            buttonEditar.Name = "buttonEditar";
            buttonEditar.Size = new Size(75, 23);
            buttonEditar.TabIndex = 8;
            buttonEditar.Text = "Editar";
            buttonEditar.UseVisualStyleBackColor = true;
            buttonEditar.Click += buttonEditar_Click;
            // 
            // labelPesquisar
            // 
            labelPesquisar.AutoSize = true;
            labelPesquisar.Location = new Point(447, 21);
            labelPesquisar.Name = "labelPesquisar";
            labelPesquisar.Size = new Size(57, 15);
            labelPesquisar.TabIndex = 9;
            labelPesquisar.Text = "Pesquisar";
            // 
            // textBoxPesquisar
            // 
            textBoxPesquisar.Location = new Point(510, 15);
            textBoxPesquisar.Name = "textBoxPesquisar";
            textBoxPesquisar.Size = new Size(165, 23);
            textBoxPesquisar.TabIndex = 10;
            textBoxPesquisar.TextChanged += textBox1_TextChanged;
            textBoxPesquisar.KeyDown += textBoxPesquisar_KeyDown;
            // 
            // EstantesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(848, 705);
            Controls.Add(textBoxPesquisar);
            Controls.Add(labelPesquisar);
            Controls.Add(buttonEditar);
            Controls.Add(buttonApagar);
            Controls.Add(labelEstantes);
            Controls.Add(buttonSalvar);
            Controls.Add(dataGridViewEstantes);
            Controls.Add(maskedTextBoxSigla);
            Controls.Add(textBoxNome);
            Controls.Add(labelSigla);
            Controls.Add(labelNome);
            Name = "EstantesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Estantes";
            ((System.ComponentModel.ISupportInitialize)dataGridViewEstantes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNome;
        private Label labelSigla;
        private TextBox textBoxNome;
        private MaskedTextBox maskedTextBoxSigla;
        private DataGridView dataGridViewEstantes;
        private Button buttonSalvar;
        private Label labelEstantes;
        private Button buttonApagar;
        private Button buttonEditar;
        private Label labelPesquisar;
        private TextBox textBoxPesquisar;
        private DataGridViewTextBoxColumn ColumnId;
        private DataGridViewTextBoxColumn ColumnNome;
        private DataGridViewTextBoxColumn ColumnSigla;
    }
}