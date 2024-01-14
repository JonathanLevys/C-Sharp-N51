namespace SupermercadoForm
{
    partial class categoriaForm
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
            buttonCadastrar = new Button();
            label1 = new Label();
            textBoxNome = new TextBox();
            buttonListar = new Button();
            richTextBoxCategorias = new RichTextBox();
            buttonApagar = new Button();
            labelCodigoApagar = new Label();
            textBoxApagar = new TextBox();
            textBoxAlterarCodigo = new TextBox();
            labelCodigoAlterar = new Label();
            textBoxAlterarNome = new TextBox();
            buttonAlterar = new Button();
            labelAlterar = new Label();
            SuspendLayout();
            // 
            // buttonCadastrar
            // 
            buttonCadastrar.Location = new Point(419, 34);
            buttonCadastrar.Name = "buttonCadastrar";
            buttonCadastrar.Size = new Size(75, 23);
            buttonCadastrar.TabIndex = 2;
            buttonCadastrar.Text = "Cadastrar";
            buttonCadastrar.UseVisualStyleBackColor = true;
            buttonCadastrar.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 34);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 1;
            label1.Text = "Nome";
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(75, 33);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(320, 23);
            textBoxNome.TabIndex = 1;
            textBoxNome.KeyDown += textBoxNome_KeyDown;
            // 
            // buttonListar
            // 
            buttonListar.Location = new Point(419, 115);
            buttonListar.Name = "buttonListar";
            buttonListar.Size = new Size(75, 23);
            buttonListar.TabIndex = 3;
            buttonListar.Text = "Listar";
            buttonListar.UseVisualStyleBackColor = true;
            buttonListar.Click += buttonListar_Click;
            // 
            // richTextBoxCategorias
            // 
            richTextBoxCategorias.Location = new Point(76, 67);
            richTextBoxCategorias.Name = "richTextBoxCategorias";
            richTextBoxCategorias.ReadOnly = true;
            richTextBoxCategorias.Size = new Size(319, 112);
            richTextBoxCategorias.TabIndex = 4;
            richTextBoxCategorias.TabStop = false;
            richTextBoxCategorias.Text = "";
            // 
            // buttonApagar
            // 
            buttonApagar.Location = new Point(419, 200);
            buttonApagar.Name = "buttonApagar";
            buttonApagar.Size = new Size(75, 23);
            buttonApagar.TabIndex = 5;
            buttonApagar.Text = "Apagar";
            buttonApagar.UseVisualStyleBackColor = true;
            buttonApagar.Click += buttonApagar_Click;
            // 
            // labelCodigoApagar
            // 
            labelCodigoApagar.AutoSize = true;
            labelCodigoApagar.Location = new Point(76, 182);
            labelCodigoApagar.Name = "labelCodigoApagar";
            labelCodigoApagar.Size = new Size(46, 15);
            labelCodigoApagar.TabIndex = 6;
            labelCodigoApagar.Text = "Código";
            // 
            // textBoxApagar
            // 
            textBoxApagar.Location = new Point(75, 200);
            textBoxApagar.Name = "textBoxApagar";
            textBoxApagar.Size = new Size(320, 23);
            textBoxApagar.TabIndex = 4;
            // 
            // textBoxAlterarCodigo
            // 
            textBoxAlterarCodigo.Location = new Point(75, 257);
            textBoxAlterarCodigo.Name = "textBoxAlterarCodigo";
            textBoxAlterarCodigo.Size = new Size(100, 23);
            textBoxAlterarCodigo.TabIndex = 6;
            // 
            // labelCodigoAlterar
            // 
            labelCodigoAlterar.AutoSize = true;
            labelCodigoAlterar.Location = new Point(75, 239);
            labelCodigoAlterar.Name = "labelCodigoAlterar";
            labelCodigoAlterar.Size = new Size(46, 15);
            labelCodigoAlterar.TabIndex = 9;
            labelCodigoAlterar.Text = "Código";
            // 
            // textBoxAlterarNome
            // 
            textBoxAlterarNome.Location = new Point(183, 257);
            textBoxAlterarNome.Name = "textBoxAlterarNome";
            textBoxAlterarNome.Size = new Size(212, 23);
            textBoxAlterarNome.TabIndex = 7;
            // 
            // buttonAlterar
            // 
            buttonAlterar.Location = new Point(419, 257);
            buttonAlterar.Name = "buttonAlterar";
            buttonAlterar.Size = new Size(75, 23);
            buttonAlterar.TabIndex = 8;
            buttonAlterar.Text = "Alterar";
            buttonAlterar.UseVisualStyleBackColor = true;
            buttonAlterar.Click += buttonAlterar_Click;
            // 
            // labelAlterar
            // 
            labelAlterar.AutoSize = true;
            labelAlterar.Location = new Point(183, 239);
            labelAlterar.Name = "labelAlterar";
            labelAlterar.Size = new Size(40, 15);
            labelAlterar.TabIndex = 12;
            labelAlterar.Text = "Nome";
            // 
            // categoriaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(594, 340);
            Controls.Add(labelAlterar);
            Controls.Add(buttonAlterar);
            Controls.Add(textBoxAlterarNome);
            Controls.Add(labelCodigoAlterar);
            Controls.Add(textBoxAlterarCodigo);
            Controls.Add(textBoxApagar);
            Controls.Add(labelCodigoApagar);
            Controls.Add(buttonApagar);
            Controls.Add(richTextBoxCategorias);
            Controls.Add(buttonListar);
            Controls.Add(textBoxNome);
            Controls.Add(label1);
            Controls.Add(buttonCadastrar);
            Name = "categoriaForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "categorias";
            Load += categoriaForm_Load;
            Shown += categoriaForm_Shown;
            KeyPress += categoriaForm_KeyPress;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCadastrar;
        private Label label1;
        private TextBox textBoxNome;
        private Button buttonListar;
        private RichTextBox richTextBoxCategorias;
        private Button buttonApagar;
        private Label labelCodigoApagar;
        private TextBox textBoxApagar;
        private TextBox textBoxAlterarCodigo;
        private Label labelCodigoAlterar;
        private TextBox textBoxAlterarNome;
        private Button buttonAlterar;
        private Label labelAlterar;
    }
}