namespace APP_POO.Telas
{
    partial class Registrar_UC
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
            Btn_Login = new Button();
            label5 = new Label();
            Btn_Registrar = new Button();
            Tx_Box_SenhaConfirmar = new TextBox();
            label4 = new Label();
            TBox_Senha_Registrar = new TextBox();
            label3 = new Label();
            TBox_Usuario_Registrar = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // Btn_Login
            // 
            Btn_Login.Anchor = AnchorStyles.None;
            Btn_Login.BackColor = Color.ForestGreen;
            Btn_Login.FlatAppearance.BorderSize = 0;
            Btn_Login.FlatStyle = FlatStyle.Flat;
            Btn_Login.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn_Login.ForeColor = Color.WhiteSmoke;
            Btn_Login.Location = new Point(201, 482);
            Btn_Login.Margin = new Padding(3, 2, 3, 2);
            Btn_Login.Name = "Btn_Login";
            Btn_Login.Size = new Size(97, 28);
            Btn_Login.TabIndex = 21;
            Btn_Login.Text = "Login";
            Btn_Login.UseVisualStyleBackColor = false;
            Btn_Login.Click += Btn_Login_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(73, 448);
            label5.Name = "label5";
            label5.Size = new Size(294, 20);
            label5.TabIndex = 20;
            label5.Text = "Já possui uma conta? Faça o Login aqui";
            // 
            // Btn_Registrar
            // 
            Btn_Registrar.Anchor = AnchorStyles.None;
            Btn_Registrar.BackColor = Color.ForestGreen;
            Btn_Registrar.FlatAppearance.BorderSize = 0;
            Btn_Registrar.FlatStyle = FlatStyle.Flat;
            Btn_Registrar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn_Registrar.ForeColor = Color.WhiteSmoke;
            Btn_Registrar.Location = new Point(201, 378);
            Btn_Registrar.Margin = new Padding(3, 2, 3, 2);
            Btn_Registrar.Name = "Btn_Registrar";
            Btn_Registrar.Size = new Size(97, 28);
            Btn_Registrar.TabIndex = 19;
            Btn_Registrar.Text = "Registrar";
            Btn_Registrar.UseVisualStyleBackColor = false;
            Btn_Registrar.Click += Btn_Registrar_Click;
            // 
            // Tx_Box_SenhaConfirmar
            // 
            Tx_Box_SenhaConfirmar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            Tx_Box_SenhaConfirmar.BackColor = Color.FromArgb(192, 255, 192);
            Tx_Box_SenhaConfirmar.BorderStyle = BorderStyle.None;
            Tx_Box_SenhaConfirmar.Font = new Font("Microsoft Sans Serif", 10.8F);
            Tx_Box_SenhaConfirmar.Location = new Point(198, 339);
            Tx_Box_SenhaConfirmar.Margin = new Padding(3, 2, 3, 2);
            Tx_Box_SenhaConfirmar.MaxLength = 15;
            Tx_Box_SenhaConfirmar.Name = "Tx_Box_SenhaConfirmar";
            Tx_Box_SenhaConfirmar.PasswordChar = '*';
            Tx_Box_SenhaConfirmar.Size = new Size(109, 17);
            Tx_Box_SenhaConfirmar.TabIndex = 18;
            Tx_Box_SenhaConfirmar.TextAlign = HorizontalAlignment.Center;
            Tx_Box_SenhaConfirmar.TextChanged += ComparaSenhas_TextChanged;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(154, 311);
            label4.Name = "label4";
            label4.Size = new Size(177, 24);
            label4.TabIndex = 17;
            label4.Text = "Confirme a Senha";
            // 
            // TBox_Senha_Registrar
            // 
            TBox_Senha_Registrar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            TBox_Senha_Registrar.BackColor = Color.FromArgb(192, 255, 192);
            TBox_Senha_Registrar.BorderStyle = BorderStyle.None;
            TBox_Senha_Registrar.Font = new Font("Microsoft Sans Serif", 10.8F);
            TBox_Senha_Registrar.Location = new Point(198, 274);
            TBox_Senha_Registrar.Margin = new Padding(3, 2, 3, 2);
            TBox_Senha_Registrar.MaxLength = 15;
            TBox_Senha_Registrar.Name = "TBox_Senha_Registrar";
            TBox_Senha_Registrar.PasswordChar = '*';
            TBox_Senha_Registrar.Size = new Size(109, 17);
            TBox_Senha_Registrar.TabIndex = 16;
            TBox_Senha_Registrar.TextAlign = HorizontalAlignment.Center;
            TBox_Senha_Registrar.TextChanged += ComparaSenhas_TextChanged;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(214, 246);
            label3.Name = "label3";
            label3.Size = new Size(70, 24);
            label3.TabIndex = 15;
            label3.Text = "Senha";
            // 
            // TBox_Usuario_Registrar
            // 
            TBox_Usuario_Registrar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            TBox_Usuario_Registrar.BackColor = Color.FromArgb(192, 255, 192);
            TBox_Usuario_Registrar.BorderStyle = BorderStyle.None;
            TBox_Usuario_Registrar.CharacterCasing = CharacterCasing.Upper;
            TBox_Usuario_Registrar.Font = new Font("Microsoft Sans Serif", 10.8F);
            TBox_Usuario_Registrar.Location = new Point(198, 212);
            TBox_Usuario_Registrar.Margin = new Padding(3, 2, 3, 2);
            TBox_Usuario_Registrar.MaxLength = 15;
            TBox_Usuario_Registrar.Name = "TBox_Usuario_Registrar";
            TBox_Usuario_Registrar.Size = new Size(109, 17);
            TBox_Usuario_Registrar.TabIndex = 14;
            TBox_Usuario_Registrar.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(206, 184);
            label2.Name = "label2";
            label2.Size = new Size(81, 24);
            label2.TabIndex = 13;
            label2.Text = "Usuário";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(160, 69);
            label1.Name = "label1";
            label1.Size = new Size(168, 39);
            label1.TabIndex = 12;
            label1.Text = "Registrar";
            // 
            // Registrar_UC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(Btn_Login);
            Controls.Add(label5);
            Controls.Add(Btn_Registrar);
            Controls.Add(Tx_Box_SenhaConfirmar);
            Controls.Add(label4);
            Controls.Add(TBox_Senha_Registrar);
            Controls.Add(label3);
            Controls.Add(TBox_Usuario_Registrar);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Registrar_UC";
            Size = new Size(505, 562);
            Load += Registrar_UC_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Btn_Login;
        private Label label5;
        private Button Btn_Registrar;
        private TextBox Tx_Box_SenhaConfirmar;
        private Label label4;
        private TextBox TBox_Senha_Registrar;
        private Label label3;
        private TextBox TBox_Usuario_Registrar;
        private Label label2;
        private Label label1;
    }
}
