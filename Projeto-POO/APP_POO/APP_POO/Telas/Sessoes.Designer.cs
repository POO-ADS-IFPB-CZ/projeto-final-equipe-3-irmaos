namespace APP_POO.Telas
{
    partial class Sessoes
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
            panel1 = new Panel();
            GB_Frutas = new GroupBox();
            label2 = new Label();
            Btn_Fruta = new Button();
            panel2 = new Panel();
            GB_Verduras = new GroupBox();
            label4 = new Label();
            Btn_Verduras = new Button();
            panel3 = new Panel();
            BG_Legumes = new GroupBox();
            label3 = new Label();
            Btn_Legumes = new Button();
            label1 = new Label();
            Btn_Carrinho = new Button();
            panel1.SuspendLayout();
            GB_Frutas.SuspendLayout();
            panel2.SuspendLayout();
            GB_Verduras.SuspendLayout();
            panel3.SuspendLayout();
            BG_Legumes.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(192, 255, 192);
            panel1.Controls.Add(GB_Frutas);
            panel1.Controls.Add(Btn_Fruta);
            panel1.Location = new Point(0, 91);
            panel1.Name = "panel1";
            panel1.Size = new Size(505, 92);
            panel1.TabIndex = 0;
            // 
            // GB_Frutas
            // 
            GB_Frutas.Controls.Add(label2);
            GB_Frutas.Font = new Font("Montserrat SemiBold", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GB_Frutas.Location = new Point(19, 20);
            GB_Frutas.Name = "GB_Frutas";
            GB_Frutas.Size = new Size(280, 57);
            GB_Frutas.TabIndex = 1;
            GB_Frutas.TabStop = false;
            GB_Frutas.Text = "Descrição";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Montserrat", 8.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(6, 21);
            label2.Name = "label2";
            label2.Size = new Size(211, 15);
            label2.TabIndex = 0;
            label2.Text = "Frutas: Maçã, Uva, Pêra, Morango, etc...";
            // 
            // Btn_Fruta
            // 
            Btn_Fruta.Anchor = AnchorStyles.Right;
            Btn_Fruta.BackColor = Color.FromArgb(64, 200, 87);
            Btn_Fruta.FlatAppearance.BorderSize = 0;
            Btn_Fruta.FlatStyle = FlatStyle.Flat;
            Btn_Fruta.Location = new Point(434, 20);
            Btn_Fruta.Name = "Btn_Fruta";
            Btn_Fruta.Size = new Size(57, 57);
            Btn_Fruta.TabIndex = 0;
            Btn_Fruta.UseVisualStyleBackColor = false;
            Btn_Fruta.Click += Btn_Fruta_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(192, 255, 192);
            panel2.Controls.Add(GB_Verduras);
            panel2.Controls.Add(Btn_Verduras);
            panel2.Location = new Point(0, 377);
            panel2.Name = "panel2";
            panel2.Size = new Size(505, 92);
            panel2.TabIndex = 2;
            // 
            // GB_Verduras
            // 
            GB_Verduras.Controls.Add(label4);
            GB_Verduras.Font = new Font("Montserrat SemiBold", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GB_Verduras.Location = new Point(19, 20);
            GB_Verduras.Name = "GB_Verduras";
            GB_Verduras.Size = new Size(280, 57);
            GB_Verduras.TabIndex = 1;
            GB_Verduras.TabStop = false;
            GB_Verduras.Text = "Descrição";
            // 
            // label4
            // 
            label4.Font = new Font("Montserrat", 8.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(6, 21);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.No;
            label4.Size = new Size(254, 33);
            label4.TabIndex = 2;
            label4.Text = "Verduras: Alface, Couve, Agrião, Espinafre, etc...";
            // 
            // Btn_Verduras
            // 
            Btn_Verduras.Anchor = AnchorStyles.Right;
            Btn_Verduras.BackColor = Color.FromArgb(64, 200, 87);
            Btn_Verduras.FlatAppearance.BorderSize = 0;
            Btn_Verduras.FlatStyle = FlatStyle.Flat;
            Btn_Verduras.Location = new Point(434, 20);
            Btn_Verduras.Name = "Btn_Verduras";
            Btn_Verduras.Size = new Size(57, 57);
            Btn_Verduras.TabIndex = 0;
            Btn_Verduras.UseVisualStyleBackColor = false;
            Btn_Verduras.Click += Btn_Verduras_Click;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.FromArgb(192, 255, 192);
            panel3.Controls.Add(BG_Legumes);
            panel3.Controls.Add(Btn_Legumes);
            panel3.Location = new Point(0, 234);
            panel3.Name = "panel3";
            panel3.Size = new Size(505, 92);
            panel3.TabIndex = 3;
            // 
            // BG_Legumes
            // 
            BG_Legumes.Controls.Add(label3);
            BG_Legumes.Font = new Font("Montserrat SemiBold", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BG_Legumes.Location = new Point(207, 20);
            BG_Legumes.Name = "BG_Legumes";
            BG_Legumes.RightToLeft = RightToLeft.Yes;
            BG_Legumes.Size = new Size(280, 57);
            BG_Legumes.TabIndex = 1;
            BG_Legumes.TabStop = false;
            BG_Legumes.Text = "Descrição";
            // 
            // label3
            // 
            label3.Font = new Font("Montserrat", 8.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(19, 21);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.No;
            label3.Size = new Size(261, 33);
            label3.TabIndex = 1;
            label3.Text = "Legumes: Abóbora, Abobrinha, Beterraba, etc...";
            // 
            // Btn_Legumes
            // 
            Btn_Legumes.Anchor = AnchorStyles.Left;
            Btn_Legumes.BackColor = Color.FromArgb(64, 200, 87);
            Btn_Legumes.FlatAppearance.BorderSize = 0;
            Btn_Legumes.FlatStyle = FlatStyle.Flat;
            Btn_Legumes.Location = new Point(10, 20);
            Btn_Legumes.Name = "Btn_Legumes";
            Btn_Legumes.Size = new Size(57, 57);
            Btn_Legumes.TabIndex = 0;
            Btn_Legumes.UseVisualStyleBackColor = false;
            Btn_Legumes.Click += Btn_Legumes_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Font = new Font("Montserrat SemiBold", 21.7499962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ImeMode = ImeMode.NoControl;
            label1.Location = new Point(185, 12);
            label1.Name = "label1";
            label1.Size = new Size(135, 40);
            label1.TabIndex = 10;
            label1.Text = "Sessões";
            // 
            // Btn_Carrinho
            // 
            Btn_Carrinho.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Btn_Carrinho.BackColor = Color.White;
            Btn_Carrinho.FlatAppearance.BorderSize = 0;
            Btn_Carrinho.FlatStyle = FlatStyle.Flat;
            Btn_Carrinho.ForeColor = Color.Transparent;
            Btn_Carrinho.Location = new Point(466, 525);
            Btn_Carrinho.Margin = new Padding(0);
            Btn_Carrinho.Name = "Btn_Carrinho";
            Btn_Carrinho.Size = new Size(39, 34);
            Btn_Carrinho.TabIndex = 2;
            Btn_Carrinho.UseVisualStyleBackColor = false;
            Btn_Carrinho.Click += Btn_Carrinho_Click;
            Btn_Carrinho.DragEnter += Btn_Carrinho_DragEnter;
            // 
            // Sessoes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(Btn_Carrinho);
            Controls.Add(label1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Sessoes";
            Size = new Size(505, 562);
            panel1.ResumeLayout(false);
            GB_Frutas.ResumeLayout(false);
            GB_Frutas.PerformLayout();
            panel2.ResumeLayout(false);
            GB_Verduras.ResumeLayout(false);
            panel3.ResumeLayout(false);
            BG_Legumes.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private GroupBox GB_Frutas;
        private Button Btn_Fruta;
        private Panel panel2;
        private Panel panel3;
        private GroupBox BG_Legumes;
        private Button Btn_Legumes;
        private GroupBox GB_Verduras;
        private Button Btn_Verduras;
        private Label label1;
        private Button Btn_Carrinho;
        private Label label2;
        private Label label4;
        private Label label3;
    }
}
