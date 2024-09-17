namespace APP_POO.Telas
{
    partial class Login_UC
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
            Btn_Registrar = new Button();
            label5 = new Label();
            TBox_Senha_Login = new TextBox();
            label3 = new Label();
            TBox_Usuario_Login = new TextBox();
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
            Btn_Login.Font = new Font("Montserrat SemiBold", 9F, FontStyle.Bold);
            Btn_Login.ForeColor = Color.WhiteSmoke;
            Btn_Login.ImeMode = ImeMode.NoControl;
            Btn_Login.Location = new Point(234, 435);
            Btn_Login.Name = "Btn_Login";
            Btn_Login.Size = new Size(111, 37);
            Btn_Login.TabIndex = 16;
            Btn_Login.Text = "Login";
            Btn_Login.UseVisualStyleBackColor = false;
            Btn_Login.Click += Btn_Login_Click;
            // 
            // Btn_Registrar
            // 
            Btn_Registrar.Anchor = AnchorStyles.None;
            Btn_Registrar.BackColor = Color.ForestGreen;
            Btn_Registrar.FlatAppearance.BorderSize = 0;
            Btn_Registrar.FlatStyle = FlatStyle.Flat;
            Btn_Registrar.Font = new Font("Montserrat SemiBold", 9F, FontStyle.Bold);
            Btn_Registrar.ForeColor = Color.WhiteSmoke;
            Btn_Registrar.ImeMode = ImeMode.NoControl;
            Btn_Registrar.Location = new Point(234, 600);
            Btn_Registrar.Name = "Btn_Registrar";
            Btn_Registrar.Size = new Size(111, 37);
            Btn_Registrar.TabIndex = 15;
            Btn_Registrar.Text = "Registrar";
            Btn_Registrar.UseVisualStyleBackColor = false;
            Btn_Registrar.Click += Btn_Registrar_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label5.AutoSize = true;
            label5.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ImeMode = ImeMode.NoControl;
            label5.Location = new Point(81, 549);
            label5.Name = "label5";
            label5.Size = new Size(414, 27);
            label5.TabIndex = 14;
            label5.Text = "Não possui uma conta? Registre-se aqui\r\n";
            // 
            // TBox_Senha_Login
            // 
            TBox_Senha_Login.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            TBox_Senha_Login.BackColor = Color.FromArgb(192, 255, 192);
            TBox_Senha_Login.BorderStyle = BorderStyle.None;
            TBox_Senha_Login.Font = new Font("Montserrat", 10.8F);
            TBox_Senha_Login.Location = new Point(227, 383);
            TBox_Senha_Login.MaxLength = 15;
            TBox_Senha_Login.Name = "TBox_Senha_Login";
            TBox_Senha_Login.PasswordChar = '*';
            TBox_Senha_Login.Size = new Size(125, 22);
            TBox_Senha_Login.TabIndex = 13;
            TBox_Senha_Login.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label3.AutoSize = true;
            label3.Font = new Font("Montserrat SemiBold", 13.7999992F, FontStyle.Bold);
            label3.ImeMode = ImeMode.NoControl;
            label3.Location = new Point(246, 345);
            label3.Name = "label3";
            label3.Size = new Size(88, 32);
            label3.TabIndex = 12;
            label3.Text = "Senha";
            // 
            // TBox_Usuario_Login
            // 
            TBox_Usuario_Login.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            TBox_Usuario_Login.BackColor = Color.FromArgb(192, 255, 192);
            TBox_Usuario_Login.BorderStyle = BorderStyle.None;
            TBox_Usuario_Login.Font = new Font("Montserrat", 10.8F);
            TBox_Usuario_Login.Location = new Point(227, 283);
            TBox_Usuario_Login.MaxLength = 15;
            TBox_Usuario_Login.Name = "TBox_Usuario_Login";
            TBox_Usuario_Login.Size = new Size(125, 22);
            TBox_Usuario_Login.TabIndex = 11;
            TBox_Usuario_Login.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.Font = new Font("Montserrat SemiBold", 13.7999992F, FontStyle.Bold);
            label2.ImeMode = ImeMode.NoControl;
            label2.Location = new Point(240, 245);
            label2.Name = "label2";
            label2.Size = new Size(106, 32);
            label2.TabIndex = 10;
            label2.Text = "Usuário";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Font = new Font("Montserrat SemiBold", 25.8000011F, FontStyle.Bold);
            label1.ImeMode = ImeMode.NoControl;
            label1.Location = new Point(216, 92);
            label1.Name = "label1";
            label1.Size = new Size(155, 61);
            label1.TabIndex = 9;
            label1.Text = "Login";
            // 
            // Login_UC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(Btn_Login);
            Controls.Add(Btn_Registrar);
            Controls.Add(label5);
            Controls.Add(TBox_Senha_Login);
            Controls.Add(label3);
            Controls.Add(TBox_Usuario_Login);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Login_UC";
            Size = new Size(577, 749);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Btn_Login;
        private Button Btn_Registrar;
        private Label label5;
        private TextBox TBox_Senha_Login;
        private Label label3;
        private TextBox TBox_Usuario_Login;
        private Label label2;
        private Label label1;
    }
}
