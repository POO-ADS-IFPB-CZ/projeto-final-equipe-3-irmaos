namespace APP_POO.Telas
{
    partial class Usuario_UC
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
            groupBox1 = new GroupBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label5 = new Label();
            Btn_Recarregar = new Button();
            panel7.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel7
            // 
            panel7.Controls.Add(Btn_Voltar);
            panel7.Controls.Add(label1);
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(0, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(577, 112);
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
            label1.Location = new Point(141, 31);
            label1.Name = "label1";
            label1.Size = new Size(295, 51);
            label1.TabIndex = 12;
            label1.Text = "Configurações";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(61, 174);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(454, 184);
            groupBox1.TabIndex = 24;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informações";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Montserrat Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(33, 122);
            label4.Name = "label4";
            label4.Size = new Size(66, 21);
            label4.TabIndex = 2;
            label4.Text = "Saldo: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Montserrat Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(33, 81);
            label3.Name = "label3";
            label3.Size = new Size(167, 21);
            label3.TabIndex = 1;
            label3.Text = "Data de Cadastro: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Montserrat Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(33, 41);
            label2.Name = "label2";
            label2.Size = new Size(70, 21);
            label2.TabIndex = 0;
            label2.Text = "Nome: ";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label5.AutoSize = true;
            label5.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(47, 451);
            label5.Name = "label5";
            label5.Size = new Size(483, 27);
            label5.TabIndex = 25;
            label5.Text = "Sem crédito na conta? Faça sua recarga aqui:";
            // 
            // Btn_Recarregar
            // 
            Btn_Recarregar.Anchor = AnchorStyles.None;
            Btn_Recarregar.BackColor = Color.ForestGreen;
            Btn_Recarregar.FlatAppearance.BorderSize = 0;
            Btn_Recarregar.FlatStyle = FlatStyle.Flat;
            Btn_Recarregar.Font = new Font("Montserrat SemiBold", 9F, FontStyle.Bold);
            Btn_Recarregar.ForeColor = Color.WhiteSmoke;
            Btn_Recarregar.ImeMode = ImeMode.NoControl;
            Btn_Recarregar.Location = new Point(227, 520);
            Btn_Recarregar.Name = "Btn_Recarregar";
            Btn_Recarregar.Size = new Size(123, 51);
            Btn_Recarregar.TabIndex = 26;
            Btn_Recarregar.Text = "Recarregar";
            Btn_Recarregar.UseVisualStyleBackColor = false;
            // 
            // Usuario_UC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Btn_Recarregar);
            Controls.Add(label5);
            Controls.Add(groupBox1);
            Controls.Add(panel7);
            Name = "Usuario_UC";
            Size = new Size(577, 749);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel7;
        private Button Btn_Voltar;
        private Label label1;
        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label5;
        private Button Btn_Recarregar;
    }
}
