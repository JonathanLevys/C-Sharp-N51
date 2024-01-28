namespace SupermercadoForm.Telas
{
    partial class ProdutoCadastroForm
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
            labelCategoria = new Label();
            labelPreçoUnitario = new Label();
            buttonSalvar = new Button();
            textBoxNome = new TextBox();
            textBoxPreçoUnitario = new TextBox();
            comboBoxCategoria = new ComboBox();
            SuspendLayout();
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Location = new Point(33, 25);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(40, 15);
            labelNome.TabIndex = 0;
            labelNome.Text = "Nome";
            // 
            // labelCategoria
            // 
            labelCategoria.AutoSize = true;
            labelCategoria.Location = new Point(33, 69);
            labelCategoria.Name = "labelCategoria";
            labelCategoria.Size = new Size(58, 15);
            labelCategoria.TabIndex = 1;
            labelCategoria.Text = "Categoria";
            // 
            // labelPreçoUnitario
            // 
            labelPreçoUnitario.AutoSize = true;
            labelPreçoUnitario.Location = new Point(33, 115);
            labelPreçoUnitario.Name = "labelPreçoUnitario";
            labelPreçoUnitario.Size = new Size(82, 15);
            labelPreçoUnitario.TabIndex = 2;
            labelPreçoUnitario.Text = "Preço Unitario";
            // 
            // buttonSalvar
            // 
            buttonSalvar.Location = new Point(191, 162);
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.Size = new Size(75, 23);
            buttonSalvar.TabIndex = 3;
            buttonSalvar.Text = "Salvar";
            buttonSalvar.UseVisualStyleBackColor = true;
            buttonSalvar.Click += buttonSalvar_Click;
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(33, 43);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(233, 23);
            textBoxNome.TabIndex = 4;
            // 
            // textBoxPreçoUnitario
            // 
            textBoxPreçoUnitario.Location = new Point(33, 133);
            textBoxPreçoUnitario.Name = "textBoxPreçoUnitario";
            textBoxPreçoUnitario.Size = new Size(233, 23);
            textBoxPreçoUnitario.TabIndex = 5;
            // 
            // comboBoxCategoria
            // 
            comboBoxCategoria.FormattingEnabled = true;
            comboBoxCategoria.Location = new Point(33, 89);
            comboBoxCategoria.Name = "comboBoxCategoria";
            comboBoxCategoria.Size = new Size(233, 23);
            comboBoxCategoria.TabIndex = 6;
            // 
            // ProdutoCadastroForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(320, 255);
            Controls.Add(comboBoxCategoria);
            Controls.Add(textBoxPreçoUnitario);
            Controls.Add(textBoxNome);
            Controls.Add(buttonSalvar);
            Controls.Add(labelPreçoUnitario);
            Controls.Add(labelCategoria);
            Controls.Add(labelNome);
            Name = "ProdutoCadastroForm";
            Text = "ProdutoCadastroForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNome;
        private Label labelCategoria;
        private Label labelPreçoUnitario;
        private Button buttonSalvar;
        private TextBox textBoxNome;
        private TextBox textBoxPreçoUnitario;
        private ComboBox comboBoxCategoria;
    }
}