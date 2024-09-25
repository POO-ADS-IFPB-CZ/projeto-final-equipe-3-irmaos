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
            panel6 = new Panel();
            checkBox1 = new CheckBox();
            label3 = new Label();
            label2 = new Label();
            Panel_Uva = new Panel();
            Label_UvaPreco = new Label();
            label34 = new Label();
            label35 = new Label();
            label36 = new Label();
            Label_UvaNome = new Label();
            panel1 = new Panel();
            button2 = new Button();
            button1 = new Button();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel7
            // 
            panel7.Controls.Add(Btn_Voltar);
            panel7.Controls.Add(label1);
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(0, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(613, 112);
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
            label1.Location = new Point(223, 31);
            label1.Name = "label1";
            label1.Size = new Size(188, 51);
            label1.TabIndex = 12;
            label1.Text = "Carrinho";
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(192, 255, 192);
            panel6.Controls.Add(checkBox1);
            panel6.Controls.Add(label3);
            panel6.Controls.Add(label2);
            panel6.Controls.Add(Panel_Uva);
            panel6.Controls.Add(Label_UvaPreco);
            panel6.Controls.Add(label34);
            panel6.Controls.Add(label35);
            panel6.Controls.Add(label36);
            panel6.Controls.Add(Label_UvaNome);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 112);
            panel6.Margin = new Padding(3, 4, 3, 4);
            panel6.Name = "panel6";
            panel6.Size = new Size(613, 123);
            panel6.TabIndex = 27;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(512, 53);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(18, 17);
            checkBox1.TabIndex = 17;
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(349, 46);
            label3.Name = "label3";
            label3.Size = new Size(132, 31);
            label3.TabIndex = 16;
            label3.Text = "R$ 12,50";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(360, 13);
            label2.Name = "label2";
            label2.Size = new Size(96, 18);
            label2.TabIndex = 15;
            label2.Text = "Preço Total";
            // 
            // Panel_Uva
            // 
            Panel_Uva.Location = new Point(18, 63);
            Panel_Uva.Name = "Panel_Uva";
            Panel_Uva.Size = new Size(57, 57);
            Panel_Uva.TabIndex = 14;
            // 
            // Label_UvaPreco
            // 
            Label_UvaPreco.AutoSize = true;
            Label_UvaPreco.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label_UvaPreco.Location = new Point(214, 46);
            Label_UvaPreco.Name = "Label_UvaPreco";
            Label_UvaPreco.Size = new Size(116, 31);
            Label_UvaPreco.TabIndex = 5;
            Label_UvaPreco.Text = "R$ 2,50";
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label34.Location = new Point(213, 13);
            label34.Name = "label34";
            label34.Size = new Size(117, 18);
            label34.TabIndex = 4;
            label34.Text = "Preço Unitário";
            // 
            // label35
            // 
            label35.AutoSize = true;
            label35.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label35.Location = new Point(121, 46);
            label35.Name = "label35";
            label35.Size = new Size(30, 31);
            label35.TabIndex = 3;
            label35.Text = "5";
            // 
            // label36
            // 
            label36.AutoSize = true;
            label36.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label36.Location = new Point(102, 13);
            label36.Name = "label36";
            label36.Size = new Size(93, 18);
            label36.TabIndex = 2;
            label36.Text = "Quantidade";
            // 
            // Label_UvaNome
            // 
            Label_UvaNome.AutoSize = true;
            Label_UvaNome.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label_UvaNome.Location = new Point(27, 13);
            Label_UvaNome.Name = "Label_UvaNome";
            Label_UvaNome.Size = new Size(37, 18);
            Label_UvaNome.TabIndex = 1;
            Label_UvaNome.Text = "Uva";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 255, 192);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 751);
            panel1.Name = "panel1";
            panel1.Size = new Size(613, 73);
            panel1.TabIndex = 28;
            // 
            // button2
            // 
            button2.Enabled = false;
            button2.Location = new Point(430, 13);
            button2.Name = "button2";
            button2.Size = new Size(157, 48);
            button2.TabIndex = 30;
            button2.Text = "Comprar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Enabled = false;
            button1.Location = new Point(27, 13);
            button1.Name = "button1";
            button1.Size = new Size(157, 48);
            button1.TabIndex = 29;
            button1.Text = "Remover";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Carrinho_UC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            Controls.Add(panel1);
            Controls.Add(panel6);
            Controls.Add(panel7);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Carrinho_UC";
            Size = new Size(613, 824);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel7;
        private Button Btn_Voltar;
        private Label label1;
        private Panel panel6;
        private Panel Panel_Uva;
        private Label Label_UvaPreco;
        private Label label34;
        private Label label35;
        private Label label36;
        private Label Label_UvaNome;
        private Label label3;
        private Label label2;
        private CheckBox checkBox1;
        private Panel panel1;
        private Button button2;
        private Button button1;
    }
}
