namespace SupermercadoForm.Telas
{
    partial class MenuForm
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
            buttonCategorias = new Button();
            buttonEstantes = new Button();
            buttonProdutos = new Button();
            SuspendLayout();
            // 
            // buttonCategorias
            // 
            buttonCategorias.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCategorias.ForeColor = Color.BlueViolet;
            buttonCategorias.Location = new Point(146, 142);
            buttonCategorias.Name = "buttonCategorias";
            buttonCategorias.Size = new Size(130, 119);
            buttonCategorias.TabIndex = 0;
            buttonCategorias.Text = "Categorias";
            buttonCategorias.UseVisualStyleBackColor = true;
            buttonCategorias.Click += buttonCategorias_Click;
            // 
            // buttonEstantes
            // 
            buttonEstantes.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonEstantes.ForeColor = Color.DarkOrchid;
            buttonEstantes.Location = new Point(297, 142);
            buttonEstantes.Name = "buttonEstantes";
            buttonEstantes.Size = new Size(126, 119);
            buttonEstantes.TabIndex = 1;
            buttonEstantes.Text = "Estantes";
            buttonEstantes.UseVisualStyleBackColor = true;
            buttonEstantes.Click += buttonEstantes_Click;
            // 
            // buttonProdutos
            // 
            buttonProdutos.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonProdutos.ForeColor = Color.DarkOrchid;
            buttonProdutos.Location = new Point(449, 142);
            buttonProdutos.Name = "buttonProdutos";
            buttonProdutos.Size = new Size(119, 119);
            buttonProdutos.TabIndex = 2;
            buttonProdutos.Text = "Produtos";
            buttonProdutos.UseVisualStyleBackColor = true;
            buttonProdutos.Click += buttonProdutos_Click;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(693, 450);
            Controls.Add(buttonProdutos);
            Controls.Add(buttonEstantes);
            Controls.Add(buttonCategorias);
            Name = "MenuForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema do Supermacado";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonCategorias;
        private Button buttonEstantes;
        private Button buttonProdutos;
    }
}