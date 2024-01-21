namespace SupermercadoForm
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
            SuspendLayout();
            // 
            // buttonCategorias
            // 
            buttonCategorias.ForeColor = Color.BlueViolet;
            buttonCategorias.Location = new Point(262, 142);
            buttonCategorias.Name = "buttonCategorias";
            buttonCategorias.Size = new Size(97, 75);
            buttonCategorias.TabIndex = 0;
            buttonCategorias.Text = "Categorias";
            buttonCategorias.UseVisualStyleBackColor = true;
            buttonCategorias.Click += buttonCategorias_Click;
            // 
            // buttonEstantes
            // 
            buttonEstantes.ForeColor = Color.DarkOrchid;
            buttonEstantes.Location = new Point(415, 142);
            buttonEstantes.Name = "buttonEstantes";
            buttonEstantes.Size = new Size(97, 75);
            buttonEstantes.TabIndex = 1;
            buttonEstantes.Text = "Estantes";
            buttonEstantes.UseVisualStyleBackColor = true;
            buttonEstantes.Click += buttonEstantes_Click;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}