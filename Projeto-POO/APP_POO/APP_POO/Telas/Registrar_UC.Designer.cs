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
            button1 = new Button();
            textBox1 = new TextBox();
            label4 = new Label();
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
            Btn_Login.Font = new Font("Montserrat SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn_Login.ForeColor = Color.WhiteSmoke;
            Btn_Login.Location = new Point(230, 643);
            Btn_Login.Name = "Btn_Login";
            Btn_Login.Size = new Size(111, 37);
            Btn_Login.TabIndex = 21;
            Btn_Login.Text = "Login";
            Btn_Login.UseVisualStyleBackColor = false;
            Btn_Login.Click += Btn_Login_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label5.AutoSize = true;
            label5.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(83, 597);
            label5.Name = "label5";
            label5.Size = new Size(411, 27);
            label5.TabIndex = 20;
            label5.Text = "Já possui uma conta? Faça o Login aqui";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.ForestGreen;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Montserrat SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.WhiteSmoke;
            button1.Location = new Point(230, 504);
            button1.Name = "button1";
            button1.Size = new Size(111, 37);
            button1.TabIndex = 19;
            button1.Text = "Registrar";
            button1.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            textBox1.BackColor = Color.FromArgb(192, 255, 192);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Montserrat", 10.8F);
            textBox1.Location = new Point(226, 452);
            textBox1.MaxLength = 15;
            textBox1.Name = "textBox1";
            textBox1.PasswordChar = '*';
            textBox1.Size = new Size(125, 22);
            textBox1.TabIndex = 18;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label4.AutoSize = true;
            label4.Font = new Font("Montserrat SemiBold", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(176, 415);
            label4.Name = "label4";
            label4.Size = new Size(225, 32);
            label4.TabIndex = 17;
            label4.Text = "Confirme a Senha";
            // 
            // TBox_Senha_Login
            // 
            TBox_Senha_Login.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            TBox_Senha_Login.BackColor = Color.FromArgb(192, 255, 192);
            TBox_Senha_Login.BorderStyle = BorderStyle.None;
            TBox_Senha_Login.Font = new Font("Montserrat", 10.8F);
            TBox_Senha_Login.Location = new Point(226, 366);
            TBox_Senha_Login.MaxLength = 15;
            TBox_Senha_Login.Name = "TBox_Senha_Login";
            TBox_Senha_Login.PasswordChar = '*';
            TBox_Senha_Login.Size = new Size(125, 22);
            TBox_Senha_Login.TabIndex = 16;
            TBox_Senha_Login.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label3.AutoSize = true;
            label3.Font = new Font("Montserrat SemiBold", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(245, 328);
            label3.Name = "label3";
            label3.Size = new Size(88, 32);
            label3.TabIndex = 15;
            label3.Text = "Senha";
            // 
            // TBox_Usuario_Login
            // 
            TBox_Usuario_Login.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            TBox_Usuario_Login.BackColor = Color.FromArgb(192, 255, 192);
            TBox_Usuario_Login.BorderStyle = BorderStyle.None;
            TBox_Usuario_Login.Font = new Font("Montserrat", 10.8F);
            TBox_Usuario_Login.Location = new Point(226, 283);
            TBox_Usuario_Login.MaxLength = 15;
            TBox_Usuario_Login.Name = "TBox_Usuario_Login";
            TBox_Usuario_Login.Size = new Size(125, 22);
            TBox_Usuario_Login.TabIndex = 14;
            TBox_Usuario_Login.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.Font = new Font("Montserrat SemiBold", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(235, 245);
            label2.Name = "label2";
            label2.Size = new Size(106, 32);
            label2.TabIndex = 13;
            label2.Text = "Usuário";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Font = new Font("Montserrat SemiBold", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(183, 92);
            label1.Name = "label1";
            label1.Size = new Size(233, 61);
            label1.TabIndex = 12;
            label1.Text = "Registrar";
            // 
            // Registrar_UC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(Btn_Login);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(TBox_Senha_Login);
            Controls.Add(label3);
            Controls.Add(TBox_Usuario_Login);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Registrar_UC";
            Size = new Size(577, 749);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Btn_Login;
        private Label label5;
        private Button button1;
        private TextBox textBox1;
        private Label label4;
        private TextBox TBox_Senha_Login;
        private Label label3;
        private TextBox TBox_Usuario_Login;
        private Label label2;
        private Label label1;
    }
}
