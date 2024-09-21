namespace APP_POO.Telas
{
    partial class Carrinho_UC
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            panel7 = new Panel();
            Btn_Voltar = new Button();
            label1 = new Label();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // panel7
            // 
            panel7.Controls.Add(Btn_Voltar);
            panel7.Controls.Add(label1);
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(0, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(429, 112);
            panel7.TabIndex = 23;
            // 
            // Btn_Voltar
            // 
            Btn_Voltar.BackColor = Color.White;
            Btn_Voltar.FlatAppearance.BorderSize = 0;
            Btn_Voltar.FlatStyle = FlatStyle.Flat;
            Btn_Voltar.ForeColor = Color.Transparent;
            Btn_Voltar.Location = new Point(0, 0);
            Btn_Voltar.Margin = new Padding(3, 4, 3, 4);
            Btn_Voltar.Name = "Btn_Voltar";
            Btn_Voltar.Size = new Size(35, 35);
            Btn_Voltar.TabIndex = 14;
            Btn_Voltar.UseVisualStyleBackColor = false;
            Btn_Voltar.Click += Btn_Voltar_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Font = new Font("Montserrat SemiBold", 21.7499962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ImeMode = ImeMode.NoControl;
            label1.Location = new Point(130, 31);
            label1.Name = "label1";
            label1.Size = new Size(188, 51);
            label1.TabIndex = 12;
            label1.Text = "Carrinho";
            // 
            // Carrinho_UC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            Controls.Add(panel7);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Carrinho_UC";
            Size = new Size(429, 824);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel7;
        private Button Btn_Voltar;
        private Label label1;
    }
}
